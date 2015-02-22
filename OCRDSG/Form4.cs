using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCRDSG
{
    public partial class Form4 : OCRDSG.FormChild
    {
        public Form4()
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
            if (RadioA4.Checked)
            {
                Program.dataset.width = 8.27F;
                Program.dataset.height = 11.69F;
            }
            else if (RadioLetter.Checked)
            {
                Program.dataset.width = 8.5F;
                Program.dataset.height = 11F;
            }
            else
            {
                Program.dataset.width = (float)UpDownWidth.Value;
                Program.dataset.height = (float)UpDownHeight.Value;
            }
            if (RadioPortrait.Checked)
                Program.dataset.portrait = true;
            else
                Program.dataset.portrait = false;
            if (RadioLTR.Checked)
                Program.dataset.rtl = false;
            else
                Program.dataset.rtl = true;
            Next(new Form5());
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PanelSizeCustom.Visible = RadioCustom.Checked;
        }

        private void Form4_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                if (!Program.dataset.paper)
                {
                    if (FormParent.forward)
                        Next(new Form5());
                    else
                        Back();
                }

            }
        }

        private void RadioA4_CheckedChanged(object sender, EventArgs e)
        {
            UpDownWidth.Value = 8.27M;
            UpDownHeight.Value = 11.69M;
        }

        private void RadioLetter_CheckedChanged(object sender, EventArgs e)
        {
            UpDownWidth.Value = 8.5M;
            UpDownHeight.Value = 11M;
        }
    }
}
