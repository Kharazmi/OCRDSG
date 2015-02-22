using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OCRDSG
{
    public partial class FormChild : Form
    {
        public FormChild()
        {
            InitializeComponent();
        }

        protected void Exit()
        {
            Application.Exit();
        }

        protected void Back()
        {
            FormParent.forward = false;
            Form parent = MdiParent;
            parent.Controls["PanelCover"].Visible = true;
            if (Name != "Form8")
                Hide();
            else
                Close();
            parent.Refresh();
            parent.MdiChildren[--FormParent.activePage].Show();
            parent.Controls["PanelCover"].Visible = false;
        }

        protected void Next(Form form)
        {
            FormParent.forward = true;
            MdiParent.Controls["PanelCover"].Visible = true;
            Hide();
            MdiParent.Refresh();
            try
            {
                MdiParent.MdiChildren[++FormParent.activePage].Show();
            }
            catch
            {
                form.MdiParent = MdiParent;
                form.Show();
            }
            MdiParent.Controls["PanelCover"].Visible = false;
            form.Refresh();
            if (form.Name == "Form8")
            {
                Program.dataset.Start(form);
                Control progress = form.Controls["PanelPage"].Controls["PanelContent"].Controls["PanelProgressBackground"];
                progress.Controls["PanelProgress"].Width = progress.Width;
                form.Controls["PanelPage"].Controls["PanelContent"].Controls["LabelProgress"].Text = "Dataset generated successfully";
                form.Controls["PanelPage"].Controls["PanelContent"].Controls["ButtonView"].Enabled = true;
                form.Controls["PanelPage"].Controls["PanelButtons"].Controls["ButtonBack"].Enabled = true;
                form.Controls["PanelPage"].Controls["PanelButtons"].Controls["ButtonExit"].Enabled = true;
            }
        }

        protected void ShowInfo()
        {
            Label labelTitle = (Label)Controls["PanelPage"].Controls["PanelTitle"].Controls["LabelTitle"];
            labelTitle.Text = Program.title;
            Controls["PanelPage"].Controls["PanelTitle"].Controls["LabelVersion"].Left = labelTitle.Left + labelTitle.Width - 9;
            Controls["PanelPage"].Controls["PanelTitle"].Controls["LabelVersion"].Text = Program.version;
            for (int index = 0; index < Program.steps.Length; index++)
                Controls["PanelPage"].Controls["PanelSteps"].Controls["LabelStep" + (index + 1)].Text = Program.steps[index];
        }
    }
}