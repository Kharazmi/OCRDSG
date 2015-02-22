using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCRDSG
{
    public partial class Form1 : OCRDSG.FormChild
    {
        public Form1()
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
            if (Program.dataset == null)
                Program.dataset = new OCRDataset();
            Next(new Form2());
        }
    }
}
