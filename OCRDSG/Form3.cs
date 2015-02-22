using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace OCRDSG
{
    public partial class Form3 : OCRDSG.FormChild
    {
        public Form3()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            FontFamily[] fontFamily = new FontFamily[ListFont.CheckedItems.Count];
            for (int i = 0; i < ListFont.CheckedItems.Count; i++)
                fontFamily[i] = new FontFamily(ListFont.CheckedItems[i].ToString());
            Program.dataset.fontFamily = fontFamily;
            if (RadioRandom.Checked)
                Program.dataset.fontSize = 0;
            else
                Program.dataset.fontSize = (int)UpDownFontSize.Value;
            Next(new Form4());
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily font in fonts.Families)
                if (font.IsStyleAvailable(FontStyle.Regular))
                    ListFont.Items.Add(font.Name);
        }

        private void ListFonts_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (ListFont.CheckedIndices.Count == 1 && e.NewValue == CheckState.Unchecked)
            {
                LabelFontError.Visible = true;
                ButtonNext.Enabled = false;
            }
            else if (ListFont.CheckedIndices.Count == 0 && e.NewValue == CheckState.Checked)
            {
                LabelFontError.Visible = false;
                ButtonNext.Enabled = true;
            }
        }

        private void RadioCustom_CheckedChanged(object sender, EventArgs e)
        {
            PanelFontSizeUpDown.Visible = RadioCustom.Checked;
        }
    }
}