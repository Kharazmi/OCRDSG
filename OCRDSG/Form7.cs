using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCRDSG
{
    public partial class Form7 : OCRDSG.FormChild
    {
        public Form7()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Program.dataset.output = LabelPath.Text;
            if (Program.dataset.text == "")
                Program.dataset.imageCount = (int)UpDownCount.Value;
            else
                Program.dataset.imageCount = 1;
            Program.dataset.prefix = DateTime.Now.Year + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0') + DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0') + DateTime.Now.Second.ToString().PadLeft(2, '0');
            Next(new Form8());
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogOutput.ShowDialog();
            if (result == DialogResult.OK)
            {
                LabelPath.ForeColor = SystemColors.ControlText;
                LabelPath.Text = DialogOutput.SelectedPath;
                ButtonStart.Enabled = true;
            }
        }

        private void Form7_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                if (Program.dataset.text=="")
                {
                    PanelCount.Visible = true;
                }
                else
                {
                    PanelCount.Visible = false;
                }
            }
        }
    }
}
