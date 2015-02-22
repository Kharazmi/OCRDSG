using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OCRDSG
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
            EditParent();
            LabelTitle.Text = Program.title;
            LabelVersion.Left = LabelTitle.Left + LabelTitle.Width - 9;
            LabelVersion.Text = Program.version;
            for (int index = 0; index < Program.steps.Length; index++)
                Controls["PanelCover"].Controls["PanelPage"].Controls["PanelSteps"].Controls["LabelStep" + (index + 1)].Text = Program.steps[index];
        }

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", ExactSpelling = true)]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_CLIENTEDGE = 0x200;
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOZORDER = 0x0004;
        private const uint SWP_NOREDRAW = 0x0008;
        private const uint SWP_NOACTIVATE = 0x0010;
        private const uint SWP_FRAMECHANGED = 0x0020;
        private const uint SWP_SHOWWINDOW = 0x0040;
        private const uint SWP_HIDEWINDOW = 0x0080;
        private const uint SWP_NOCOPYBITS = 0x0100;
        private const uint SWP_NOOWNERZORDER = 0x0200;
        private const uint SWP_NOSENDCHANGING = 0x0400;

        private void EditParent()
        {
            foreach (Control c in this.Controls)
            {
                MdiClient client = c as MdiClient;
                if (client != null)
                {
                    int windowLong = GetWindowLong(c.Handle, GWL_EXSTYLE);
                    windowLong &= ~WS_EX_CLIENTEDGE;
                    SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong);
                    SetWindowPos(client.Handle, IntPtr.Zero, 0, 0, 0, 0,
                        SWP_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER |
                        SWP_NOOWNERZORDER | SWP_FRAMECHANGED);
                    client.BackColor = this.BackColor;
                }
            }
        }

        private void FormParent_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.MdiParent = this;
            form.Show();
            activePage = 0;
            PanelCover.Visible = false;
        }

        public static int activePage;
        public static bool forward;

        private void FormParent_MdiChildActivate(object sender, EventArgs e)
        {
            try
            {
                if (Program.dataset.paper)
                    ActiveMdiChild.Controls["PanelPage"].Controls["PanelSteps"].Controls["LabelStep4"].Visible = true;
                else
                    ActiveMdiChild.Controls["PanelPage"].Controls["PanelSteps"].Controls["LabelStep4"].Visible = false;
            }
            catch { }
        }
    }
}
