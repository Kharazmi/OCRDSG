using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCRDSG
{
    public partial class Form6 : OCRDSG.FormChild
    {
        public Form6()
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
            Program.dataset.scanNoise = (int)UpDownScanNoise.Value;
            Program.dataset.saltPepperNoise = (int)UpDownSaltPepperNoise.Value;
            Program.dataset.backgroundNoise = (int)UpDownBackgroundNoise.Value;
            Program.dataset.lineNoise = (int)UpDownLineNoise.Value;
            Program.dataset.marginalNoise = (int)UpDownMarginalNoise.Value;
            Program.dataset.clutterNoise = (int)UpDownClutterNoise.Value;
            Next(new Form7());
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void Form6_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                if (!Program.dataset.paper)
                {
                    PanelLineNoise.Visible = false;
                    PanelMarginalNoise.Visible = false;
                    PanelClutterNoise.Visible = false;
                }
                else
                {
                    PanelLineNoise.Visible = true;
                    PanelMarginalNoise.Visible = true;
                    PanelClutterNoise.Visible = true;
                }
            }
        }
    }
}
