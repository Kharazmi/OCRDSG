using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;
using System.Xml;

namespace OCRDSG
{
    class OCRDataset
    {

        double LAST_WORD_POSSIBILITY = 0.01;
        Color TEXT_COLOR = Color.FromArgb(60, 60, 60);
        int RANDOM_FONT_SIZE_MIN = 14;
        int RANDOM_FONT_SIZE_MAX = 48;
        float MARGIN_COEFFICIENT = 0.1F;
        float MARGIN_COEFFICIENT_WORD = 0.02F;
        float ROTATION_COEFFICIENT = 0.5F;
        float ROTATION_COEFFICIENT_WORD = 1.5F;
        float SKEW_COEFFICIENT = 0.05F;
        float SKEW_COEFFICIENT_WORD = 0.02F;
        float WORD_SPACE_COEFFICIENT = 0.15F;
        float LINE_SPACE_COEFFICIENT = 0.15F;
        int SCAN_NOISE_COEFFICIENT = 1;
        float SALT_PEPPER_NOISE_COEFFICIENT = 0.001F;
        int BACKGROUND_NOISE_COEFFICIENT = 2;
        int LINE_NOISE_COEFFICIENT = 10;
        float LINE_NOISE_SPACE = 0.2F;
        float MARGINAL_NOISE_COEFFICIENT = 0.04F;
        float CLUTTER_NOISE_COEFFICIENT = 0.03F;
        float CLUTTER_NOISE_INTERVAL = 0.4F;
        float CLUTTER_NOISE_DIAGONAL = 0.2F;

        public string text, input, output;
        public FontFamily[] fontFamily;
        public float width, height;
        public int dpi, fontSize, margin, rotation, skew, letterSpace, wordSpace, lineSpace;
        public int scanNoise, saltPepperNoise, backgroundNoise, lineNoise, marginalNoise, clutterNoise;
        public bool portrait = true, rtl = false, paper = true;
        public int imageCount;
        public string prefix;

        ArrayList lexicon = new ArrayList();
        Random random = new Random();
        Form startingForm;
        StreamReader sr;

        public void Start(Form form)
        {
            PrepareInput();
            PrepareOutput();
            startingForm = form;
            Control progress = startingForm.Controls["PanelPage"].Controls["PanelContent"].Controls["PanelProgressBackground"];
            for (int i = 0; i < imageCount; i++)
            {
                Control progressPart = new FlowLayoutPanel();
                progressPart.Margin = new Padding(0);
                progressPart.Size = new Size(0, 23);
                progressPart.BackColor = SystemColors.Highlight;
                progressPart.Name = "PanelProgress" + (i + 1);
                progress.Controls.Add(progressPart);
            }
            int threadVolume = (int)Math.Ceiling(600.0 / dpi) * (paper ? 1 : 10);
            Form.CheckForIllegalCrossThreadCalls = false;
            for (int step = 0; step < Math.Ceiling(imageCount / (double)threadVolume); step++)
            {
                for (int number = step * threadVolume + 1; number < (step + 1) * threadVolume + 1; number++)
                    if (number <= imageCount)
                        NewImageThread(number);
                lock (Program.activeWorkersLock)
                    while (Program.activeWorkersCount > 0)
                        Monitor.Wait(Program.activeWorkersLock);
            }
            Form.CheckForIllegalCrossThreadCalls = true;
        }

        private void NewImageThread(int number)
        {
            lock (Program.activeWorkersLock)
                ++Program.activeWorkersCount;
            ThreadPool.QueueUserWorkItem(new WaitCallback(NewImage), number);
        }

        void NewImage(object number)
        {
            try
            {

                if (paper)
                {
                    string imageNumber = number.ToString().PadLeft(2, '0');
                    int imageWidth = (int)(portrait ? width : height) * dpi;
                    int imageHeight = (int)(portrait ? height : width) * dpi;
                    Font imageFont = new Font(fontFamily[random.Next(fontFamily.Length)], fontSize == 0 ? random.Next(RANDOM_FONT_SIZE_MIN, RANDOM_FONT_SIZE_MAX) : fontSize);
                    int imageMargin = (int)(margin * MARGIN_COEFFICIENT * dpi);
                    int imageRotation = (int)(random.Next(-rotation, rotation + 1) * ROTATION_COEFFICIENT);
                    int imageSkew = (int)(random.Next(-skew, skew + 1) * SKEW_COEFFICIENT * dpi);
                    float imageWordSpace = wordSpace * WORD_SPACE_COEFFICIENT;
                    float imageLineSpace = lineSpace * LINE_SPACE_COEFFICIENT;
                    int imageScanNoise = scanNoise * SCAN_NOISE_COEFFICIENT;
                    float imageSaltPepperNoise = saltPepperNoise * SALT_PEPPER_NOISE_COEFFICIENT;
                    int imageBackgroundNoise = backgroundNoise * BACKGROUND_NOISE_COEFFICIENT;
                    int imageLineNoise = lineNoise * LINE_NOISE_COEFFICIENT;
                    int imageLineNoiseSpace = (int)(LINE_NOISE_SPACE * dpi);
                    int imageMarginalNoise = (int)(marginalNoise * MARGINAL_NOISE_COEFFICIENT * dpi);
                    int imageMarginalNoiseLeft = random.Next(imageMarginalNoise);
                    int imageMarginalNoiseRight = random.Next(imageMarginalNoise);
                    int imageMarginalNoiseTop = random.Next(imageMarginalNoise);
                    int imageMarginalNoiseBottom = random.Next(imageMarginalNoise);
                    int imageClutterNoise = (int)(clutterNoise * CLUTTER_NOISE_COEFFICIENT * dpi);
                    int imageClutterNoiseInterval = (int)(CLUTTER_NOISE_INTERVAL * dpi);
                    int imageClutterNoiseDiagonal = (int)(CLUTTER_NOISE_DIAGONAL * dpi);

                    int top, left;
                    string text = "";

                    Bitmap image = new Bitmap(imageWidth, imageHeight);
                    //image.SetResolution(dpi, dpi);
                    Graphics imageGraphics = Graphics.FromImage(image);
                    imageGraphics.FillRectangle(Brushes.White, 0, 0, imageWidth, imageHeight);

                    // line noise
                    if (imageLineNoise != 0)
                        for (top = imageMarginalNoiseTop + imageLineNoiseSpace; top <= imageHeight - imageLineNoiseSpace - imageMarginalNoiseBottom; top += imageLineNoiseSpace)
                            imageGraphics.DrawLine(new Pen(Color.FromArgb(255 - imageLineNoise, 255 - imageLineNoise, 255 - imageLineNoise), 1), 0, top, imageWidth, top);

                    // text
                    int imageSpaceWidth = (int)imageGraphics.MeasureString(" ", imageFont).Width;
                    string imageWord = lexicon[random.Next(lexicon.Count)].ToString();
                    SizeF imageWordSize = imageGraphics.MeasureString(imageWord, imageFont);
                    int imageWordWidth = (int)imageWordSize.Width;
                    int imageWordHeight = (int)imageWordSize.Height;
                    top = imageMargin + imageMarginalNoiseTop;
                    while (top + imageWordHeight + imageMargin + imageMarginalNoiseBottom < imageHeight)
                    {
                        if (!rtl)
                        {
                            left = imageMargin + imageMarginalNoiseLeft + imageClutterNoise + (imageClutterNoise == 0 ? 0 : imageClutterNoiseDiagonal);
                            while (left + imageWordWidth + imageMargin + imageMarginalNoiseRight + imageClutterNoise + (imageClutterNoise == 0 ? 0 : imageClutterNoiseDiagonal) < imageWidth)
                            {
                                text += imageWord + " ";
                                imageGraphics.DrawString(imageWord, imageFont, new SolidBrush(TEXT_COLOR), left, top);
                                left += imageWordWidth + (int)(imageWordSpace * imageSpaceWidth);
                                imageWord = lexicon[random.Next(lexicon.Count)].ToString();
                                imageWordSize = imageGraphics.MeasureString(imageWord, imageFont);
                                imageWordWidth = (int)imageWordSize.Width;
                                imageWordHeight = (int)imageWordSize.Height;
                                if (random.NextDouble() < LAST_WORD_POSSIBILITY)
                                    break;
                            }
                        }
                        else
                        {
                            left = imageWidth - imageMargin - imageMarginalNoiseRight - imageClutterNoise - (imageClutterNoise == 0 ? 0 : imageClutterNoiseDiagonal); ;
                            while (left - imageWordWidth - imageMargin - imageMarginalNoiseLeft - imageClutterNoise - (imageClutterNoise == 0 ? 0 : imageClutterNoiseDiagonal) > 0)
                            {
                                text += imageWord + " ";
                                imageGraphics.DrawString(imageWord, imageFont, new SolidBrush(TEXT_COLOR), left - imageWordWidth, top);
                                left -= imageWordWidth + (int)(imageWordSpace * imageSpaceWidth);
                                imageWord = lexicon[random.Next(lexicon.Count)].ToString();
                                imageWordSize = imageGraphics.MeasureString(imageWord, imageFont);
                                imageWordWidth = (int)imageWordSize.Width;
                                imageWordHeight = (int)imageWordSize.Height;
                                if (random.NextDouble() < LAST_WORD_POSSIBILITY)
                                    break;
                            }
                        }
                        top += imageWordHeight + (int)(imageLineSpace * imageWordHeight);
                        text += "\r\n";
                    }

                    Random randomLocal = new Random();
                    double rnd1 = randomLocal.NextDouble(), rnd2, rndStdNormal;
                    int rndNormal;
                    Control progress = startingForm.Controls["PanelPage"].Controls["PanelContent"].Controls["PanelProgressBackground"];
                    for (top = 0; top < imageWidth; top++)
                    {
                        for (left = 0; left < imageHeight; left++)
                        {

                            // salt & pepper noise
                            if (imageSaltPepperNoise > 0)
                            {
                                if (randomLocal.NextDouble() < imageSaltPepperNoise)
                                {
                                    if (randomLocal.Next(0, 2) == 0)
                                        image.SetPixel(top, left, TEXT_COLOR);
                                    else
                                        image.SetPixel(top, left, Color.White);
                                }
                            }

                            // background noise
                            if (imageBackgroundNoise > 0)
                            {
                                rnd2 = randomLocal.NextDouble();
                                rndStdNormal = Math.Sqrt(-2.0 * Math.Log(rnd1)) * Math.Sin(2.0 * Math.PI * rnd2);
                                rnd1 = rnd2;
                                rndNormal = Convert.ToInt32(imageBackgroundNoise * rndStdNormal);
                                Color color = image.GetPixel(top, left);
                                image.SetPixel(top, left, Color.FromArgb(CheckColor(color.R + rndNormal), CheckColor(color.G + rndNormal), CheckColor(color.B + rndNormal)));
                            }
                        }
                        progress.Controls["PanelProgress" + number].Width = (int)((top / (float)imageWidth) * (progress.Width / (float)imageCount));
                        progress.Refresh();
                    }

                    // marginal noise
                    imageGraphics.FillRectangle(Brushes.Black, 0, -imageHeight, imageWidth, imageHeight + imageMarginalNoiseTop);
                    imageGraphics.FillRectangle(Brushes.Black, 0, imageHeight - imageMarginalNoiseBottom, imageWidth, imageHeight);
                    imageGraphics.FillRectangle(Brushes.Black, -imageWidth, 0, imageWidth + imageMarginalNoiseLeft, imageHeight);
                    imageGraphics.FillRectangle(Brushes.Black, imageWidth - imageMarginalNoiseRight, 0, imageWidth, imageHeight);

                    // clutter noise
                    if (imageClutterNoise != 0)
                        for (top = imageMarginalNoiseTop + imageClutterNoiseDiagonal / 2; top < imageHeight - imageMarginalNoiseBottom; top += imageClutterNoiseInterval)
                        {
                            imageGraphics.FillEllipse(Brushes.Black, imageMarginalNoiseLeft + imageClutterNoise, top, imageClutterNoiseDiagonal, imageClutterNoiseDiagonal);
                            imageGraphics.FillEllipse(Brushes.Black, imageWidth - imageMarginalNoiseRight - imageClutterNoise - imageClutterNoiseDiagonal, top, imageClutterNoiseDiagonal, imageClutterNoiseDiagonal);
                        }

                    Bitmap imageFinal = new Bitmap(Convert.ToInt32(imageWidth), Convert.ToInt32(imageHeight));
                    Graphics imageFinalG = Graphics.FromImage(imageFinal);

                    // rotation
                    imageFinalG.TranslateTransform((imageWidth / 2), (imageHeight / 2));
                    imageFinalG.RotateTransform(imageRotation);
                    imageFinalG.TranslateTransform((-imageWidth / 2), (-imageHeight / 2));

                    // skew
                    Point[] points = { new Point(imageSkew, 0), new Point(Convert.ToInt32(imageWidth) + imageSkew, 0), new Point(-imageSkew, Convert.ToInt32(imageHeight)) };
                    imageFinalG.DrawImage(image, points);

                    // scan noise
                    System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                    System.Drawing.Imaging.EncoderParameters myEncoderParameters = new System.Drawing.Imaging.EncoderParameters(1);
                    System.Drawing.Imaging.EncoderParameter myEncoderParameter = new System.Drawing.Imaging.EncoderParameter(myEncoder, 100 - 9 * imageScanNoise);
                    myEncoderParameters.Param[0] = myEncoderParameter;
                    System.Drawing.Imaging.ImageCodecInfo[] encoders = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders();

                    Directory.CreateDirectory(output + "\\" + prefix);
                    string outputPath = output + "\\" + prefix + "\\" + imageNumber;
                    imageFinal.Save(outputPath + ".jpg", encoders[1], myEncoderParameters);

                    XmlWriter xw = XmlWriter.Create(outputPath + ".xml");
                    xw.WriteStartDocument();
                    xw.WriteStartElement("Image");
                    xw.WriteElementString("Paper", paper.ToString());
                    xw.WriteElementString("DPI", dpi.ToString());
                    xw.WriteElementString("FontName", imageFont.FontFamily.Name);
                    xw.WriteElementString("FintSize", imageFont.Size.ToString());
                    xw.WriteElementString("Width",imageWidth.ToString());
                    xw.WriteElementString("Height", imageHeight.ToString());
                    xw.WriteElementString("Portrait", portrait.ToString());
                    xw.WriteElementString("RTL", rtl.ToString());
                    xw.WriteElementString("Margin", margin.ToString());
                    xw.WriteElementString("Rotation", imageRotation.ToString());
                    xw.WriteElementString("Skew", imageSkew.ToString());
                    xw.WriteElementString("WordSpace", wordSpace.ToString());
                    xw.WriteElementString("LineSpace", lineSpace.ToString());
                    xw.WriteElementString("ScanNoise", scanNoise.ToString());
                    xw.WriteElementString("SaltPepperNoise", saltPepperNoise.ToString());
                    xw.WriteElementString("BackgroundNoise", backgroundNoise.ToString());
                    xw.WriteElementString("LineNoise", lineNoise.ToString());
                    xw.WriteElementString("LineNoiseSpace", imageLineNoiseSpace.ToString());
                    xw.WriteElementString("MarginalNoiseTop", imageMarginalNoiseTop.ToString());
                    xw.WriteElementString("MarginalNoiseRight", imageMarginalNoiseRight.ToString());
                    xw.WriteElementString("MarginalNoiseBottom", imageMarginalNoiseBottom.ToString());
                    xw.WriteElementString("MarginalNoiseLeft", imageMarginalNoiseLeft.ToString());
                    xw.WriteElementString("ClutterNoise", clutterNoise.ToString());
                    xw.WriteElementString("ClutterNoiseSpace", imageClutterNoiseInterval.ToString());
                    xw.WriteElementString("ClutterNoiseDiagonal", imageClutterNoiseDiagonal.ToString());
                    xw.WriteEndElement();
                    xw.WriteEndDocument();
                    xw.Close();

                    StreamWriter sw = new StreamWriter(outputPath + ".txt");
                    sw.Write(text);
                    sw.Close();
                }
                else
                {

                    string imageNumber = number.ToString().PadLeft(2, '0');
                    Font imageFont = new Font(fontFamily[random.Next(fontFamily.Length)], fontSize == 0 ? random.Next(RANDOM_FONT_SIZE_MIN, RANDOM_FONT_SIZE_MAX) : fontSize);
                    int imageMargin = (int)(margin * MARGIN_COEFFICIENT_WORD * dpi);
                    int imageRotation = (int)(random.Next(-rotation, rotation + 1) * ROTATION_COEFFICIENT_WORD);
                    int imageSkew = (int)(random.Next(-skew, skew + 1) * SKEW_COEFFICIENT_WORD * dpi);
                    int imageScanNoise = scanNoise * SCAN_NOISE_COEFFICIENT;
                    float imageSaltPepperNoise = saltPepperNoise * SALT_PEPPER_NOISE_COEFFICIENT;
                    int imageBackgroundNoise = backgroundNoise * BACKGROUND_NOISE_COEFFICIENT;

                    // text
                    Bitmap image = new Bitmap(1, 1);
                    Graphics imageGraphics = Graphics.FromImage(image);
                    string imageWord;
                    if (text == "")
                        imageWord = lexicon[random.Next(lexicon.Count)].ToString();
                    else
                        imageWord = text;
                    //image.SetResolution(dpi, dpi);
                    SizeF imageWordSize = imageGraphics.MeasureString(imageWord, imageFont);
                    int imageWidth = (int)(imageWordSize.Width + 2 * imageMargin);
                    int imageHeight = (int)(imageWordSize.Height + 2 * imageMargin);
                    image = new Bitmap(imageWidth, imageHeight);
                    imageGraphics = Graphics.FromImage(image);
                    imageGraphics.FillRectangle(Brushes.White, 0, 0, imageWidth, imageHeight);
                    imageGraphics.DrawString(imageWord, imageFont, new SolidBrush(TEXT_COLOR), imageMargin, imageMargin);

                    Bitmap imageFinal = new Bitmap(Convert.ToInt32(imageWidth), Convert.ToInt32(imageHeight));
                    Graphics imageFinalG = Graphics.FromImage(imageFinal);
                    imageFinalG.FillRectangle(Brushes.White, 0, 0, imageWidth, imageHeight);

                    // rotation
                    imageFinalG.TranslateTransform((imageWidth / 2), (imageHeight / 2));
                    imageFinalG.RotateTransform(imageRotation);
                    imageFinalG.TranslateTransform((-imageWidth / 2), (-imageHeight / 2));

                    // skew
                    Point[] points = { new Point(imageSkew, 0), new Point(Convert.ToInt32(imageWidth) + imageSkew, 0), new Point(-imageSkew, Convert.ToInt32(imageHeight)) };
                    imageFinalG.DrawImage(image, points);


                    int top, left;

                    Random randomLocal = new Random();
                    double rnd1 = randomLocal.NextDouble(), rnd2, rndStdNormal;
                    int rndNormal;
                    Control progress = startingForm.Controls["PanelPage"].Controls["PanelContent"].Controls["PanelProgressBackground"];
                    for (top = 0; top < imageWidth; top++)
                    {
                        for (left = 0; left < imageHeight; left++)
                        {

                            // salt & pepper noise
                            if (imageSaltPepperNoise > 0)
                            {
                                if (randomLocal.NextDouble() < imageSaltPepperNoise)
                                {
                                    if (randomLocal.Next(0, 2) == 0)
                                        imageFinal.SetPixel(top, left, TEXT_COLOR);
                                    else
                                        imageFinal.SetPixel(top, left, Color.White);
                                }
                            }

                            // background noise
                            if (imageBackgroundNoise > 0)
                            {
                                rnd2 = randomLocal.NextDouble();
                                rndStdNormal = Math.Sqrt(-2.0 * Math.Log(rnd1)) * Math.Sin(2.0 * Math.PI * rnd2);
                                rnd1 = rnd2;
                                rndNormal = Convert.ToInt32(imageBackgroundNoise * rndStdNormal);
                                Color color = imageFinal.GetPixel(top, left);
                                imageFinal.SetPixel(top, left, Color.FromArgb(CheckColor(color.R + rndNormal), CheckColor(color.G + rndNormal), CheckColor(color.B + rndNormal)));
                            }
                        }
                        progress.Controls["PanelProgress" + number].Width = (int)((top / (float)imageWidth) * (progress.Width / (float)imageCount));
                        progress.Refresh();
                    }

                    // scan noise
                    System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                    System.Drawing.Imaging.EncoderParameters myEncoderParameters = new System.Drawing.Imaging.EncoderParameters(1);
                    System.Drawing.Imaging.EncoderParameter myEncoderParameter = new System.Drawing.Imaging.EncoderParameter(myEncoder, 100 - 9 * imageScanNoise);
                    myEncoderParameters.Param[0] = myEncoderParameter;
                    System.Drawing.Imaging.ImageCodecInfo[] encoders = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders();

                    Directory.CreateDirectory(output + "\\" + prefix);
                    string outputPath = output + "\\" + prefix + "\\" + imageNumber;
                    imageFinal.Save(outputPath + ".jpg", encoders[1], myEncoderParameters);

                    XmlWriter xw = XmlWriter.Create(outputPath + ".xml");
                    xw.WriteStartDocument();
                    xw.WriteStartElement("Image");
                    xw.WriteElementString("Paper", paper.ToString());
                    xw.WriteElementString("DPI", dpi.ToString());
                    xw.WriteElementString("FontName", imageFont.FontFamily.Name);
                    xw.WriteElementString("FintSize", imageFont.Size.ToString());
                    xw.WriteElementString("Width", imageWidth.ToString());
                    xw.WriteElementString("Height", imageHeight.ToString());
                    xw.WriteElementString("Margin", margin.ToString());
                    xw.WriteElementString("Rotation", imageRotation.ToString());
                    xw.WriteElementString("Skew", imageSkew.ToString());
                    xw.WriteElementString("ScanNoise", scanNoise.ToString());
                    xw.WriteElementString("SaltPepperNoise", saltPepperNoise.ToString());
                    xw.WriteElementString("BackgroundNoise", backgroundNoise.ToString());
                    xw.WriteEndElement();
                    xw.WriteEndDocument();
                    xw.Close();

                    StreamWriter sw = new StreamWriter(outputPath + ".txt");
                    sw.Write(imageWord);
                    sw.Close();

                }

            }
            finally
            {
                lock (Program.activeWorkersLock)
                {
                    --Program.activeWorkersCount;
                    Monitor.PulseAll(Program.activeWorkersLock);
                }
            }
        }

        private void PrepareInput()
        {
            lexicon.Clear();
            if (text == "")
            {
                sr = new StreamReader(input);
                while (!sr.EndOfStream)
                    lexicon.Add(sr.ReadLine());
                sr.Close();
            }
        }

        private void PrepareOutput()
        {
            if (!Directory.Exists(output))
                Directory.CreateDirectory(output);
        }


        public static bool CheckInput(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                int length = sr.ReadToEnd().Length;
                sr.Close();
                if (length > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        private int CheckColor(int color)
        {
            if (color < 0) return 0;
            else if (color > 255) return 255;
            else return color;
        }
    }
}
