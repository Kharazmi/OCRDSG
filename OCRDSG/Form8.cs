using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace OCRDSG
{
    public partial class Form8 : OCRDSG.FormChild
    {
        public Form8()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Program.dataset.output + "\\" + Program.dataset.prefix);
            }
            catch
            {
                ButtonView.Enabled = false;
            }
        }

    }
}
