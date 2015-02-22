namespace OCRDSG
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DialogDictionary = new System.Windows.Forms.OpenFileDialog();
            this.PanelPage = new System.Windows.Forms.Panel();
            this.PanelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelType = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelTypeLabel = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelType = new System.Windows.Forms.Label();
            this.PanelTypeContent = new System.Windows.Forms.FlowLayoutPanel();
            this.RadioPaper = new System.Windows.Forms.RadioButton();
            this.RadioWord = new System.Windows.Forms.RadioButton();
            this.RadioText = new System.Windows.Forms.RadioButton();
            this.LabelTextError = new System.Windows.Forms.Label();
            this.TextText = new System.Windows.Forms.TextBox();
            this.PanelLexicon = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelLexiconLabel = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelLexicon = new System.Windows.Forms.Label();
            this.PanelLexiconContent = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelPath = new System.Windows.Forms.Label();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.PanelDPI = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelDPILabel = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelDPI = new System.Windows.Forms.Label();
            this.PanelDPIContent = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelDPIUpDown = new System.Windows.Forms.FlowLayoutPanel();
            this.UpDownDPI = new System.Windows.Forms.NumericUpDown();
            this.PanelSteps = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelStep1 = new System.Windows.Forms.Label();
            this.LabelStep2 = new System.Windows.Forms.Label();
            this.LabelStep3 = new System.Windows.Forms.Label();
            this.LabelStep4 = new System.Windows.Forms.Label();
            this.LabelStep5 = new System.Windows.Forms.Label();
            this.LabelStep6 = new System.Windows.Forms.Label();
            this.LabelStep7 = new System.Windows.Forms.Label();
            this.LabelStep8 = new System.Windows.Forms.Label();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelPage.SuspendLayout();
            this.PanelContent.SuspendLayout();
            this.PanelType.SuspendLayout();
            this.PanelTypeLabel.SuspendLayout();
            this.PanelTypeContent.SuspendLayout();
            this.PanelLexicon.SuspendLayout();
            this.PanelLexiconLabel.SuspendLayout();
            this.PanelLexiconContent.SuspendLayout();
            this.PanelDPI.SuspendLayout();
            this.PanelDPILabel.SuspendLayout();
            this.PanelDPIContent.SuspendLayout();
            this.PanelDPIUpDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDPI)).BeginInit();
            this.PanelSteps.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.PanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogDictionary
            // 
            this.DialogDictionary.Filter = "Text files|*.txt|All files|*.*";
            this.DialogDictionary.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenDialog_FileOk);
            // 
            // PanelPage
            // 
            this.PanelPage.Controls.Add(this.PanelContent);
            this.PanelPage.Controls.Add(this.PanelSteps);
            this.PanelPage.Controls.Add(this.PanelTitle);
            this.PanelPage.Controls.Add(this.PanelButtons);
            this.PanelPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPage.Location = new System.Drawing.Point(0, 0);
            this.PanelPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelPage.Name = "PanelPage";
            this.PanelPage.Size = new System.Drawing.Size(800, 600);
            this.PanelPage.TabIndex = 1;
            // 
            // PanelContent
            // 
            this.PanelContent.BackColor = System.Drawing.SystemColors.Control;
            this.PanelContent.Controls.Add(this.PanelType);
            this.PanelContent.Controls.Add(this.PanelLexicon);
            this.PanelContent.Controls.Add(this.PanelDPI);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelContent.Location = new System.Drawing.Point(220, 116);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            this.PanelContent.Size = new System.Drawing.Size(580, 404);
            this.PanelContent.TabIndex = 0;
            // 
            // PanelType
            // 
            this.PanelType.AutoSize = true;
            this.PanelType.Controls.Add(this.PanelTypeLabel);
            this.PanelType.Controls.Add(this.PanelTypeContent);
            this.PanelType.Location = new System.Drawing.Point(0, 29);
            this.PanelType.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.PanelType.Name = "PanelType";
            this.PanelType.Size = new System.Drawing.Size(558, 136);
            this.PanelType.TabIndex = 0;
            // 
            // PanelTypeLabel
            // 
            this.PanelTypeLabel.Controls.Add(this.LabelType);
            this.PanelTypeLabel.Location = new System.Drawing.Point(0, 0);
            this.PanelTypeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTypeLabel.Name = "PanelTypeLabel";
            this.PanelTypeLabel.Size = new System.Drawing.Size(160, 21);
            this.PanelTypeLabel.TabIndex = 5;
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelType.Location = new System.Drawing.Point(0, 0);
            this.LabelType.Margin = new System.Windows.Forms.Padding(0);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(92, 20);
            this.LabelType.TabIndex = 3;
            this.LabelType.Text = "Dataset type";
            // 
            // PanelTypeContent
            // 
            this.PanelTypeContent.AutoSize = true;
            this.PanelTypeContent.Controls.Add(this.RadioPaper);
            this.PanelTypeContent.Controls.Add(this.RadioWord);
            this.PanelTypeContent.Controls.Add(this.RadioText);
            this.PanelTypeContent.Controls.Add(this.LabelTextError);
            this.PanelTypeContent.Controls.Add(this.TextText);
            this.PanelTypeContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelTypeContent.Location = new System.Drawing.Point(160, 0);
            this.PanelTypeContent.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTypeContent.Name = "PanelTypeContent";
            this.PanelTypeContent.Size = new System.Drawing.Size(398, 136);
            this.PanelTypeContent.TabIndex = 6;
            // 
            // RadioPaper
            // 
            this.RadioPaper.AutoSize = true;
            this.RadioPaper.Checked = true;
            this.RadioPaper.Location = new System.Drawing.Point(5, 0);
            this.RadioPaper.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.RadioPaper.Name = "RadioPaper";
            this.RadioPaper.Size = new System.Drawing.Size(168, 24);
            this.RadioPaper.TabIndex = 0;
            this.RadioPaper.TabStop = true;
            this.RadioPaper.Text = "One paper per image";
            this.RadioPaper.UseVisualStyleBackColor = true;
            this.RadioPaper.CheckedChanged += new System.EventHandler(this.RadioPaper_CheckedChanged);
            // 
            // RadioWord
            // 
            this.RadioWord.AutoSize = true;
            this.RadioWord.Location = new System.Drawing.Point(5, 24);
            this.RadioWord.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.RadioWord.Name = "RadioWord";
            this.RadioWord.Size = new System.Drawing.Size(162, 24);
            this.RadioWord.TabIndex = 1;
            this.RadioWord.Text = "One word per image";
            this.RadioWord.UseVisualStyleBackColor = true;
            this.RadioWord.CheckedChanged += new System.EventHandler(this.RadioWord_CheckedChanged);
            // 
            // RadioText
            // 
            this.RadioText.AutoSize = true;
            this.RadioText.Location = new System.Drawing.Point(5, 48);
            this.RadioText.Margin = new System.Windows.Forms.Padding(5, 0, 0, 8);
            this.RadioText.Name = "RadioText";
            this.RadioText.Size = new System.Drawing.Size(106, 24);
            this.RadioText.TabIndex = 2;
            this.RadioText.Text = "Custom text";
            this.RadioText.UseVisualStyleBackColor = true;
            this.RadioText.CheckedChanged += new System.EventHandler(this.RadioText_CheckedChanged);
            // 
            // LabelTextError
            // 
            this.LabelTextError.AutoEllipsis = true;
            this.LabelTextError.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTextError.ForeColor = System.Drawing.Color.Red;
            this.LabelTextError.Location = new System.Drawing.Point(0, 80);
            this.LabelTextError.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.LabelTextError.Name = "LabelTextError";
            this.LabelTextError.Size = new System.Drawing.Size(398, 20);
            this.LabelTextError.TabIndex = 7;
            this.LabelTextError.Text = "No text entered";
            this.LabelTextError.Visible = false;
            // 
            // TextText
            // 
            this.TextText.Location = new System.Drawing.Point(5, 109);
            this.TextText.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.TextText.Name = "TextText";
            this.TextText.Size = new System.Drawing.Size(393, 27);
            this.TextText.TabIndex = 3;
            this.TextText.Visible = false;
            this.TextText.TextChanged += new System.EventHandler(this.TextText_TextChanged);
            // 
            // PanelLexicon
            // 
            this.PanelLexicon.AutoSize = true;
            this.PanelLexicon.Controls.Add(this.PanelLexiconLabel);
            this.PanelLexicon.Controls.Add(this.PanelLexiconContent);
            this.PanelLexicon.Location = new System.Drawing.Point(0, 185);
            this.PanelLexicon.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.PanelLexicon.Name = "PanelLexicon";
            this.PanelLexicon.Size = new System.Drawing.Size(558, 67);
            this.PanelLexicon.TabIndex = 1;
            // 
            // PanelLexiconLabel
            // 
            this.PanelLexiconLabel.Controls.Add(this.LabelLexicon);
            this.PanelLexiconLabel.Location = new System.Drawing.Point(0, 0);
            this.PanelLexiconLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PanelLexiconLabel.Name = "PanelLexiconLabel";
            this.PanelLexiconLabel.Size = new System.Drawing.Size(160, 21);
            this.PanelLexiconLabel.TabIndex = 5;
            // 
            // LabelLexicon
            // 
            this.LabelLexicon.AutoSize = true;
            this.LabelLexicon.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLexicon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LabelLexicon.Location = new System.Drawing.Point(0, 0);
            this.LabelLexicon.Margin = new System.Windows.Forms.Padding(0);
            this.LabelLexicon.Name = "LabelLexicon";
            this.LabelLexicon.Size = new System.Drawing.Size(58, 20);
            this.LabelLexicon.TabIndex = 3;
            this.LabelLexicon.Text = "Lexicon";
            // 
            // PanelLexiconContent
            // 
            this.PanelLexiconContent.AutoSize = true;
            this.PanelLexiconContent.Controls.Add(this.LabelPath);
            this.PanelLexiconContent.Controls.Add(this.ButtonBrowse);
            this.PanelLexiconContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelLexiconContent.Location = new System.Drawing.Point(160, 0);
            this.PanelLexiconContent.Margin = new System.Windows.Forms.Padding(0);
            this.PanelLexiconContent.Name = "PanelLexiconContent";
            this.PanelLexiconContent.Size = new System.Drawing.Size(398, 67);
            this.PanelLexiconContent.TabIndex = 6;
            // 
            // LabelPath
            // 
            this.LabelPath.AutoEllipsis = true;
            this.LabelPath.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPath.ForeColor = System.Drawing.Color.Red;
            this.LabelPath.Location = new System.Drawing.Point(0, 0);
            this.LabelPath.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.LabelPath.Name = "LabelPath";
            this.LabelPath.Size = new System.Drawing.Size(398, 20);
            this.LabelPath.TabIndex = 6;
            this.LabelPath.Text = "No lexicon file selected";
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBrowse.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBrowse.Location = new System.Drawing.Point(5, 29);
            this.ButtonBrowse.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(90, 38);
            this.ButtonBrowse.TabIndex = 0;
            this.ButtonBrowse.Text = "Browse";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // PanelDPI
            // 
            this.PanelDPI.AutoSize = true;
            this.PanelDPI.Controls.Add(this.PanelDPILabel);
            this.PanelDPI.Controls.Add(this.PanelDPIContent);
            this.PanelDPI.Location = new System.Drawing.Point(0, 272);
            this.PanelDPI.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.PanelDPI.Name = "PanelDPI";
            this.PanelDPI.Size = new System.Drawing.Size(257, 26);
            this.PanelDPI.TabIndex = 2;
            // 
            // PanelDPILabel
            // 
            this.PanelDPILabel.Controls.Add(this.LabelDPI);
            this.PanelDPILabel.Location = new System.Drawing.Point(0, 0);
            this.PanelDPILabel.Margin = new System.Windows.Forms.Padding(0);
            this.PanelDPILabel.Name = "PanelDPILabel";
            this.PanelDPILabel.Size = new System.Drawing.Size(160, 21);
            this.PanelDPILabel.TabIndex = 5;
            // 
            // LabelDPI
            // 
            this.LabelDPI.AutoSize = true;
            this.LabelDPI.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDPI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelDPI.Location = new System.Drawing.Point(0, 0);
            this.LabelDPI.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDPI.Name = "LabelDPI";
            this.LabelDPI.Size = new System.Drawing.Size(31, 20);
            this.LabelDPI.TabIndex = 3;
            this.LabelDPI.Text = "DPI";
            // 
            // PanelDPIContent
            // 
            this.PanelDPIContent.AutoSize = true;
            this.PanelDPIContent.Controls.Add(this.PanelDPIUpDown);
            this.PanelDPIContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelDPIContent.Location = new System.Drawing.Point(160, 0);
            this.PanelDPIContent.Margin = new System.Windows.Forms.Padding(0);
            this.PanelDPIContent.Name = "PanelDPIContent";
            this.PanelDPIContent.Size = new System.Drawing.Size(97, 26);
            this.PanelDPIContent.TabIndex = 6;
            // 
            // PanelDPIUpDown
            // 
            this.PanelDPIUpDown.AutoSize = true;
            this.PanelDPIUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.PanelDPIUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDPIUpDown.Controls.Add(this.UpDownDPI);
            this.PanelDPIUpDown.Location = new System.Drawing.Point(5, 0);
            this.PanelDPIUpDown.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.PanelDPIUpDown.Name = "PanelDPIUpDown";
            this.PanelDPIUpDown.Size = new System.Drawing.Size(92, 26);
            this.PanelDPIUpDown.TabIndex = 0;
            // 
            // UpDownDPI
            // 
            this.UpDownDPI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpDownDPI.Location = new System.Drawing.Point(3, 1);
            this.UpDownDPI.Margin = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.UpDownDPI.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.UpDownDPI.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.UpDownDPI.Name = "UpDownDPI";
            this.UpDownDPI.Size = new System.Drawing.Size(87, 23);
            this.UpDownDPI.TabIndex = 0;
            this.UpDownDPI.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // PanelSteps
            // 
            this.PanelSteps.BackColor = System.Drawing.SystemColors.Control;
            this.PanelSteps.Controls.Add(this.LabelStep1);
            this.PanelSteps.Controls.Add(this.LabelStep2);
            this.PanelSteps.Controls.Add(this.LabelStep3);
            this.PanelSteps.Controls.Add(this.LabelStep4);
            this.PanelSteps.Controls.Add(this.LabelStep5);
            this.PanelSteps.Controls.Add(this.LabelStep6);
            this.PanelSteps.Controls.Add(this.LabelStep7);
            this.PanelSteps.Controls.Add(this.LabelStep8);
            this.PanelSteps.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSteps.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelSteps.Location = new System.Drawing.Point(0, 116);
            this.PanelSteps.Name = "PanelSteps";
            this.PanelSteps.Padding = new System.Windows.Forms.Padding(30, 10, 10, 10);
            this.PanelSteps.Size = new System.Drawing.Size(220, 404);
            this.PanelSteps.TabIndex = 4;
            // 
            // LabelStep1
            // 
            this.LabelStep1.AutoSize = true;
            this.LabelStep1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelStep1.Location = new System.Drawing.Point(30, 15);
            this.LabelStep1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.LabelStep1.Name = "LabelStep1";
            this.LabelStep1.Size = new System.Drawing.Size(0, 37);
            this.LabelStep1.TabIndex = 0;
            // 
            // LabelStep2
            // 
            this.LabelStep2.AutoSize = true;
            this.LabelStep2.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelStep2.Location = new System.Drawing.Point(30, 62);
            this.LabelStep2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelStep2.Name = "LabelStep2";
            this.LabelStep2.Size = new System.Drawing.Size(0, 37);
            this.LabelStep2.TabIndex = 1;
            // 
            // LabelStep3
            // 
            this.LabelStep3.AutoSize = true;
            this.LabelStep3.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep3.Location = new System.Drawing.Point(30, 109);
            this.LabelStep3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelStep3.Name = "LabelStep3";
            this.LabelStep3.Size = new System.Drawing.Size(0, 37);
            this.LabelStep3.TabIndex = 2;
            // 
            // LabelStep4
            // 
            this.LabelStep4.AutoSize = true;
            this.LabelStep4.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep4.Location = new System.Drawing.Point(30, 156);
            this.LabelStep4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelStep4.Name = "LabelStep4";
            this.LabelStep4.Size = new System.Drawing.Size(0, 37);
            this.LabelStep4.TabIndex = 3;
            // 
            // LabelStep5
            // 
            this.LabelStep5.AutoSize = true;
            this.LabelStep5.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep5.Location = new System.Drawing.Point(30, 203);
            this.LabelStep5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelStep5.Name = "LabelStep5";
            this.LabelStep5.Size = new System.Drawing.Size(0, 37);
            this.LabelStep5.TabIndex = 4;
            // 
            // LabelStep6
            // 
            this.LabelStep6.AutoSize = true;
            this.LabelStep6.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep6.Location = new System.Drawing.Point(30, 250);
            this.LabelStep6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelStep6.Name = "LabelStep6";
            this.LabelStep6.Size = new System.Drawing.Size(0, 37);
            this.LabelStep6.TabIndex = 5;
            // 
            // LabelStep7
            // 
            this.LabelStep7.AutoSize = true;
            this.LabelStep7.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep7.Location = new System.Drawing.Point(30, 297);
            this.LabelStep7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelStep7.Name = "LabelStep7";
            this.LabelStep7.Size = new System.Drawing.Size(0, 37);
            this.LabelStep7.TabIndex = 6;
            // 
            // LabelStep8
            // 
            this.LabelStep8.AutoSize = true;
            this.LabelStep8.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep8.Location = new System.Drawing.Point(30, 344);
            this.LabelStep8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelStep8.Name = "LabelStep8";
            this.LabelStep8.Size = new System.Drawing.Size(0, 37);
            this.LabelStep8.TabIndex = 7;
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelTitle.Controls.Add(this.LabelVersion);
            this.PanelTitle.Controls.Add(this.LabelTitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Padding = new System.Windows.Forms.Padding(10);
            this.PanelTitle.Size = new System.Drawing.Size(800, 116);
            this.PanelTitle.TabIndex = 3;
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVersion.Location = new System.Drawing.Point(585, 40);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(0, 37);
            this.LabelVersion.TabIndex = 2;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI Light", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(10, 10);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(0, 74);
            this.LabelTitle.TabIndex = 0;
            // 
            // PanelButtons
            // 
            this.PanelButtons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelButtons.Controls.Add(this.ButtonExit);
            this.PanelButtons.Controls.Add(this.ButtonNext);
            this.PanelButtons.Controls.Add(this.ButtonBack);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(0, 520);
            this.PanelButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Padding = new System.Windows.Forms.Padding(10);
            this.PanelButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PanelButtons.Size = new System.Drawing.Size(800, 80);
            this.PanelButtons.TabIndex = 1;
            // 
            // ButtonExit
            // 
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(23, 20);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(90, 38);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonNext.Enabled = false;
            this.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNext.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.Location = new System.Drawing.Point(688, 20);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(90, 38);
            this.ButtonNext.TabIndex = 0;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.UseVisualStyleBackColor = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.Location = new System.Drawing.Point(588, 20);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(90, 38);
            this.ButtonBack.TabIndex = 1;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.PanelPage);
            this.Name = "Form2";
            this.Text = "";
            this.PanelPage.ResumeLayout(false);
            this.PanelContent.ResumeLayout(false);
            this.PanelContent.PerformLayout();
            this.PanelType.ResumeLayout(false);
            this.PanelType.PerformLayout();
            this.PanelTypeLabel.ResumeLayout(false);
            this.PanelTypeLabel.PerformLayout();
            this.PanelTypeContent.ResumeLayout(false);
            this.PanelTypeContent.PerformLayout();
            this.PanelLexicon.ResumeLayout(false);
            this.PanelLexicon.PerformLayout();
            this.PanelLexiconLabel.ResumeLayout(false);
            this.PanelLexiconLabel.PerformLayout();
            this.PanelLexiconContent.ResumeLayout(false);
            this.PanelDPI.ResumeLayout(false);
            this.PanelDPI.PerformLayout();
            this.PanelDPILabel.ResumeLayout(false);
            this.PanelDPILabel.PerformLayout();
            this.PanelDPIContent.ResumeLayout(false);
            this.PanelDPIContent.PerformLayout();
            this.PanelDPIUpDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDPI)).EndInit();
            this.PanelSteps.ResumeLayout(false);
            this.PanelSteps.PerformLayout();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.PanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelStep1;
        private System.Windows.Forms.Panel PanelPage;
        private System.Windows.Forms.FlowLayoutPanel PanelSteps;
        private System.Windows.Forms.Label LabelStep2;
        private System.Windows.Forms.Label LabelStep3;
        private System.Windows.Forms.Label LabelStep4;
        private System.Windows.Forms.Label LabelStep5;
        private System.Windows.Forms.Label LabelStep6;
        private System.Windows.Forms.Label LabelStep7;
        private System.Windows.Forms.Label LabelStep8;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.OpenFileDialog DialogDictionary;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.FlowLayoutPanel PanelContent;
        private System.Windows.Forms.FlowLayoutPanel PanelLexicon;
        private System.Windows.Forms.Label LabelLexicon;
        private System.Windows.Forms.FlowLayoutPanel PanelLexiconLabel;
        private System.Windows.Forms.FlowLayoutPanel PanelLexiconContent;
        private System.Windows.Forms.FlowLayoutPanel PanelType;
        private System.Windows.Forms.FlowLayoutPanel PanelTypeLabel;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.FlowLayoutPanel PanelTypeContent;
        private System.Windows.Forms.RadioButton RadioPaper;
        private System.Windows.Forms.RadioButton RadioWord;
        private System.Windows.Forms.FlowLayoutPanel PanelDPI;
        private System.Windows.Forms.FlowLayoutPanel PanelDPILabel;
        private System.Windows.Forms.Label LabelDPI;
        private System.Windows.Forms.FlowLayoutPanel PanelDPIContent;
        private System.Windows.Forms.FlowLayoutPanel PanelDPIUpDown;
        private System.Windows.Forms.NumericUpDown UpDownDPI;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.Label LabelPath;
        private System.Windows.Forms.RadioButton RadioText;
        private System.Windows.Forms.TextBox TextText;
        private System.Windows.Forms.Label LabelTextError;
    }
}
