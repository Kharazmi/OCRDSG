using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCRDSG
{
    public partial class Form5 : OCRDSG.FormChild
    {
        public Form5()
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
            Program.dataset.margin = (int)UpDownMargin.Value;
            Program.dataset.rotation = (int)UpDownRotation.Value;
            Program.dataset.skew = (int)UpDownSkew.Value;
            Program.dataset.letterSpace = (int)UpDownLetterSpace.Value;
            Program.dataset.wordSpace = (int)UpDownWordSpace.Value;
            Program.dataset.lineSpace = (int)UpDownLineSpace.Value;
            Next(new Form6());
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void Form5_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                if (!Program.dataset.paper)
                {
                    PanelWordSpace.Visible = false;
                    PanelLineSpace.Visible = false;
                }
                else
                {
                    PanelWordSpace.Visible = true;
                    PanelLineSpace.Visible = true;
                }
            }
        }
    }
}
