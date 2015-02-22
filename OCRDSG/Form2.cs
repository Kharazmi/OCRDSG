using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCRDSG
{
    public partial class Form2 : OCRDSG.FormChild
    {

        bool lexiconStatus = false, textStatus = false;

        public Form2()
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
            Program.dataset.paper = RadioPaper.Checked;
            if (RadioText.Checked)
                Program.dataset.text = TextText.Text;
            else
                Program.dataset.text = "";
            Program.dataset.input = DialogDictionary.FileName;
            Program.dataset.dpi = (int)UpDownDPI.Value;
            Next(new Form3());
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            DialogDictionary.ShowDialog();
        }

        private void OpenDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (DialogDictionary.FileName == "")
            {
                LabelPath.ForeColor = Color.Red;
                LabelPath.Text = "No lexicon file selected";
                lexiconStatus = false;
                ButtonNext.Enabled = false;
            }
            else if (!OCRDataset.CheckInput(DialogDictionary.FileName))
            {
                LabelPath.ForeColor = Color.Red;
                LabelPath.Text = "Incorrect lexicon file selected";
                lexiconStatus = false;
                ButtonNext.Enabled = false;
            }
            else
            {
                LabelPath.ForeColor = SystemColors.ControlText;
                LabelPath.Text = DialogDictionary.FileName;
                lexiconStatus = true;
                ButtonNext.Enabled = true;
            }
        }

        private void RadioPaper_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioPaper.Checked)
            {
                Program.dataset.paper = true;
                ButtonNext.Enabled = lexiconStatus;
                LabelStep4.Visible = true;
                MdiParent.Controls["PanelCover"].Controls["PanelPage"].Controls["PanelSteps"].Controls["LabelStep4"].Visible = true;
                PanelLexicon.Visible = true;
                TextText.Visible = false;
                LabelTextError.Visible = false;
            }
        }

        private void RadioWord_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioWord.Checked)
            {
                Program.dataset.paper = false;
                ButtonNext.Enabled = lexiconStatus;
                LabelStep4.Visible = false;
                MdiParent.Controls["PanelCover"].Controls["PanelPage"].Controls["PanelSteps"].Controls["LabelStep4"].Visible = false;
                PanelLexicon.Visible = true;
                TextText.Visible = false;
                LabelTextError.Visible = false;
            }
        }

        private void RadioText_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioText.Checked)
            {
                Program.dataset.paper = false;
                ButtonNext.Enabled = textStatus;
                LabelStep4.Visible = false;
                MdiParent.Controls["PanelCover"].Controls["PanelPage"].Controls["PanelSteps"].Controls["LabelStep4"].Visible = false;
                PanelLexicon.Visible = false;
                TextText.Visible = true;
                LabelTextError.Visible = !textStatus;
            }
        }

        private void TextText_TextChanged(object sender, EventArgs e)
        {
            if (TextText.Text == "")
            {
                textStatus = false;
                ButtonNext.Enabled = false;
                LabelTextError.Visible = true;
            }
            else
            {
                textStatus = true;
                ButtonNext.Enabled = true;
                LabelTextError.Visible = false;
            }
        }
    }
}
