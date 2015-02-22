namespace OCRDSG
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelPage = new System.Windows.Forms.Panel();
            this.PanelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelOutput = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelOutputLabel = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.PanelOutputContent = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelPath = new System.Windows.Forms.Label();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.PanelCount = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelCountLabel = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelCount = new System.Windows.Forms.Label();
            this.PanelCountContent = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelCountUpDown = new System.Windows.Forms.FlowLayoutPanel();
            this.UpDownCount = new System.Windows.Forms.NumericUpDown();
            this.PanelSteps = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelStep1 = new System.Windows.Forms.Label();
            this.LabelStep2 = new System.Windows.Forms.Label();
            this.LabelStep3 = new System.Windows.Forms.Label();
            this.LabelStep4 = new System.Windows.Forms.Label();
            this.LabelStep5 = new System.Windows.Forms.Label();
            this.LabelStep6 = new System.Windows.Forms.Label();
            this.LabelStep7 = new System.Windows.Forms.Label();
            this.LabelStep8 = new System.Windows.Forms.Label();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.DialogOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.PanelPage.SuspendLayout();
            this.PanelContent.SuspendLayout();
            this.PanelOutput.SuspendLayout();
            this.PanelOutputLabel.SuspendLayout();
            this.PanelOutputContent.SuspendLayout();
            this.PanelCount.SuspendLayout();
            this.PanelCountLabel.SuspendLayout();
            this.PanelCountContent.SuspendLayout();
            this.PanelCountUpDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCount)).BeginInit();
            this.PanelSteps.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.PanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPage
            // 
            this.PanelPage.Controls.Add(this.PanelContent);
            this.PanelPage.Controls.Add(this.PanelSteps);
            this.PanelPage.Controls.Add(this.PanelTitle);
            this.PanelPage.Controls.Add(this.PanelButtons);
            this.PanelPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPage.Location = new System.Drawing.Point(0, 0);
            this.PanelPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelPage.Name = "PanelPage";
            this.PanelPage.Size = new System.Drawing.Size(800, 600);
            this.PanelPage.TabIndex = 4;
            // 
            // PanelContent
            // 
            this.PanelContent.BackColor = System.Drawing.SystemColors.Control;
            this.PanelContent.Controls.Add(this.PanelOutput);
            this.PanelContent.Controls.Add(this.PanelCount);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelContent.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PanelContent.Location = new System.Drawing.Point(220, 116);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            this.PanelContent.Size = new System.Drawing.Size(580, 404);
            this.PanelContent.TabIndex = 0;
            // 
            // PanelOutput
            // 
            this.PanelOutput.AutoSize = true;
            this.PanelOutput.Controls.Add(this.PanelOutputLabel);
            this.PanelOutput.Controls.Add(this.PanelOutputContent);
            this.PanelOutput.Location = new System.Drawing.Point(0, 29);
            this.PanelOutput.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.PanelOutput.Name = "PanelOutput";
            this.PanelOutput.Size = new System.Drawing.Size(558, 67);
            this.PanelOutput.TabIndex = 0;
            // 
            // PanelOutputLabel
            // 
            this.PanelOutputLabel.Controls.Add(this.LabelOutput);
            this.PanelOutputLabel.Location = new System.Drawing.Point(0, 0);
            this.PanelOutputLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PanelOutputLabel.Name = "PanelOutputLabel";
            this.PanelOutputLabel.Size = new System.Drawing.Size(160, 21);
            this.PanelOutputLabel.TabIndex = 5;
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOutput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LabelOutput.Location = new System.Drawing.Point(0, 0);
            this.LabelOutput.Margin = new System.Windows.Forms.Padding(0);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(97, 20);
            this.LabelOutput.TabIndex = 3;
            this.LabelOutput.Text = "Output folder";
            // 
            // PanelOutputContent
            // 
            this.PanelOutputContent.AutoSize = true;
            this.PanelOutputContent.Controls.Add(this.LabelPath);
            this.PanelOutputContent.Controls.Add(this.ButtonBrowse);
            this.PanelOutputContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelOutputContent.Location = new System.Drawing.Point(160, 0);
            this.PanelOutputContent.Margin = new System.Windows.Forms.Padding(0);
            this.PanelOutputContent.Name = "PanelOutputContent";
            this.PanelOutputContent.Size = new System.Drawing.Size(398, 67);
            this.PanelOutputContent.TabIndex = 6;
            // 
            // LabelPath
            // 
            this.LabelPath.AutoEllipsis = true;
            this.LabelPath.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPath.ForeColor = System.Drawing.Color.Red;
            this.LabelPath.Location = new System.Drawing.Point(0, 0);
            this.LabelPath.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.LabelPath.Name = "LabelPath";
            this.LabelPath.Size = new System.Drawing.Size(398, 20);
            this.LabelPath.TabIndex = 6;
            this.LabelPath.Text = "No output folder selected";
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBrowse.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBrowse.Location = new System.Drawing.Point(5, 29);
            this.ButtonBrowse.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(90, 38);
            this.ButtonBrowse.TabIndex = 0;
            this.ButtonBrowse.Text = "Browse";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // PanelCount
            // 
            this.PanelCount.AutoSize = true;
            this.PanelCount.Controls.Add(this.PanelCountLabel);
            this.PanelCount.Controls.Add(this.PanelCountContent);
            this.PanelCount.Location = new System.Drawing.Point(0, 116);
            this.PanelCount.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.PanelCount.Name = "PanelCount";
            this.PanelCount.Size = new System.Drawing.Size(257, 26);
            this.PanelCount.TabIndex = 1;
            // 
            // PanelCountLabel
            // 
            this.PanelCountLabel.Controls.Add(this.LabelCount);
            this.PanelCountLabel.Location = new System.Drawing.Point(0, 0);
            this.PanelCountLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PanelCountLabel.Name = "PanelCountLabel";
            this.PanelCountLabel.Size = new System.Drawing.Size(160, 21);
            this.PanelCountLabel.TabIndex = 5;
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelCount.Location = new System.Drawing.Point(0, 0);
            this.LabelCount.Margin = new System.Windows.Forms.Padding(0);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(131, 20);
            this.LabelCount.TabIndex = 3;
            this.LabelCount.Text = "Number of images";
            // 
            // PanelCountContent
            // 
            this.PanelCountContent.AutoSize = true;
            this.PanelCountContent.Controls.Add(this.PanelCountUpDown);
            this.PanelCountContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelCountContent.Location = new System.Drawing.Point(160, 0);
            this.PanelCountContent.Margin = new System.Windows.Forms.Padding(0);
            this.PanelCountContent.Name = "PanelCountContent";
            this.PanelCountContent.Size = new System.Drawing.Size(97, 26);
            this.PanelCountContent.TabIndex = 6;
            // 
            // PanelCountUpDown
            // 
            this.PanelCountUpDown.AutoSize = true;
            this.PanelCountUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.PanelCountUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCountUpDown.Controls.Add(this.UpDownCount);
            this.PanelCountUpDown.Location = new System.Drawing.Point(5, 0);
            this.PanelCountUpDown.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.PanelCountUpDown.Name = "PanelCountUpDown";
            this.PanelCountUpDown.Size = new System.Drawing.Size(92, 26);
            this.PanelCountUpDown.TabIndex = 0;
            // 
            // UpDownCount
            // 
            this.UpDownCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpDownCount.Location = new System.Drawing.Point(3, 1);
            this.UpDownCount.Margin = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.UpDownCount.Maximum = new decimal(new int[] {
            33,
            0,
            0,
            0});
            this.UpDownCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownCount.Name = "UpDownCount";
            this.UpDownCount.Size = new System.Drawing.Size(87, 23);
            this.UpDownCount.TabIndex = 0;
            this.UpDownCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // PanelSteps
            // 
            this.PanelSteps.BackColor = System.Drawing.SystemColors.Control;
            this.PanelSteps.Controls.Add(this.LabelStep1);
            this.PanelSteps.Controls.Add(this.LabelStep2);
            this.PanelSteps.Controls.Add(this.LabelStep3);
            this.PanelSteps.Controls.Add(this.LabelStep4);
            this.PanelSteps.Controls.Add(this.LabelStep5);
            this.PanelSteps.Controls.Add(this.LabelStep6);
            this.PanelSteps.Controls.Add(this.LabelStep7);
            this.PanelSteps.Controls.Add(this.LabelStep8);
            this.PanelSteps.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSteps.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelSteps.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PanelSteps.Location = new System.Drawing.Point(0, 116);
            this.PanelSteps.Name = "PanelSteps";
            this.PanelSteps.Padding = new System.Windows.Forms.Padding(30, 10, 10, 10);
            this.PanelSteps.Size = new System.Drawing.Size(220, 404);
            this.PanelSteps.TabIndex = 4;
            // 
            // LabelStep1
            // 
            this.LabelStep1.AutoSize = true;
            this.LabelStep1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelStep1.Location = new System.Drawing.Point(30, 15);
            this.LabelStep1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.LabelStep1.Name = "LabelStep1";
            this.LabelStep1.Size = new System.Drawing.Size(0, 37);
            this.LabelStep1.TabIndex = 0;
            // 
            // LabelStep2
            // 
            this.LabelStep2.AutoSize = true;
            this.LabelStep2.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelStep2.Location = new System.Drawing.Point(30, 62);
            this.LabelStep2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelStep2.Name = "LabelStep2";
            this.LabelStep2.Size = new System.Drawing.Size(0, 37);
            this.LabelStep2.TabIndex = 1;
            // 
            // LabelStep3
            // 
            this.LabelStep3.AutoSize = true;
            this.LabelStep3.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep3.Location = new System.Drawing.Point(30, 109);
            this.LabelStep3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelStep3.Name = "LabelStep3";
            this.LabelStep3.Size = new System.Drawing.Size(0, 37);
            this.LabelStep3.TabIndex = 2;
            // 
            // LabelStep4
            // 
            this.LabelStep4.AutoSize = true;
            this.LabelStep4.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelStep4.Location = new System.Drawing.Point(30, 156);
            this.LabelStep4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelStep4.Name = "LabelStep4";
            this.LabelStep4.Size = new System.Drawing.Size(0, 37);
            this.LabelStep4.TabIndex = 3;
            // 
            // LabelStep5
            // 
            this.LabelStep5.AutoSize = true;
            this.LabelStep5.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelStep5.Location = new System.Drawing.Point(30, 203);
            this.LabelStep5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelStep5.Name = "LabelStep5";
            this.LabelStep5.Size = new System.Drawing.Size(0, 37);
            this.LabelStep5.TabIndex = 4;
            // 
            // LabelStep6
            // 
            this.LabelStep6.AutoSize = true;
            this.LabelStep6.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep6.Location = new System.Drawing.Point(30, 250);
            this.LabelStep6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelStep6.Name = "LabelStep6";
            this.LabelStep6.Size = new System.Drawing.Size(0, 37);
            this.LabelStep6.TabIndex = 5;
            // 
            // LabelStep7
            // 
            this.LabelStep7.AutoSize = true;
            this.LabelStep7.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelStep7.Location = new System.Drawing.Point(30, 297);
            this.LabelStep7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelStep7.Name = "LabelStep7";
            this.LabelStep7.Size = new System.Drawing.Size(0, 37);
            this.LabelStep7.TabIndex = 6;
            // 
            // LabelStep8
            // 
            this.LabelStep8.AutoSize = true;
            this.LabelStep8.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep8.Location = new System.Drawing.Point(30, 344);
            this.LabelStep8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LabelStep8.Name = "LabelStep8";
            this.LabelStep8.Size = new System.Drawing.Size(0, 37);
            this.LabelStep8.TabIndex = 7;
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelTitle.Controls.Add(this.LabelVersion);
            this.PanelTitle.Controls.Add(this.LabelTitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Padding = new System.Windows.Forms.Padding(10);
            this.PanelTitle.Size = new System.Drawing.Size(800, 116);
            this.PanelTitle.TabIndex = 3;
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVersion.Location = new System.Drawing.Point(600, 40);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(0, 37);
            this.LabelVersion.TabIndex = 2;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI Light", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(10, 10);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(0, 74);
            this.LabelTitle.TabIndex = 0;
            // 
            // PanelButtons
            // 
            this.PanelButtons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelButtons.Controls.Add(this.ButtonExit);
            this.PanelButtons.Controls.Add(this.ButtonStart);
            this.PanelButtons.Controls.Add(this.ButtonBack);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(0, 520);
            this.PanelButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Padding = new System.Windows.Forms.Padding(10);
            this.PanelButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PanelButtons.Size = new System.Drawing.Size(800, 80);
            this.PanelButtons.TabIndex = 1;
            // 
            // ButtonExit
            // 
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(23, 20);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(90, 38);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Enabled = false;
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStart.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.Location = new System.Drawing.Point(688, 20);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(90, 38);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.Location = new System.Drawing.Point(588, 20);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(90, 38);
            this.ButtonBack.TabIndex = 1;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.PanelPage);
            this.Name = "Form7";
            this.Text = "";
            this.VisibleChanged += new System.EventHandler(this.Form7_VisibleChanged);
            this.PanelPage.ResumeLayout(false);
            this.PanelContent.ResumeLayout(false);
            this.PanelContent.PerformLayout();
            this.PanelOutput.ResumeLayout(false);
            this.PanelOutput.PerformLayout();
            this.PanelOutputLabel.ResumeLayout(false);
            this.PanelOutputLabel.PerformLayout();
            this.PanelOutputContent.ResumeLayout(false);
            this.PanelCount.ResumeLayout(false);
            this.PanelCount.PerformLayout();
            this.PanelCountLabel.ResumeLayout(false);
            this.PanelCountLabel.PerformLayout();
            this.PanelCountContent.ResumeLayout(false);
            this.PanelCountContent.PerformLayout();
            this.PanelCountUpDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCount)).EndInit();
            this.PanelSteps.ResumeLayout(false);
            this.PanelSteps.PerformLayout();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.PanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label LabelStep1;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelStep2;
        private System.Windows.Forms.Label LabelStep3;
        private System.Windows.Forms.FlowLayoutPanel PanelContent;
        private System.Windows.Forms.Label LabelStep4;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.FlowLayoutPanel PanelSteps;
        private System.Windows.Forms.Label LabelStep5;
        private System.Windows.Forms.Label LabelStep6;
        private System.Windows.Forms.Label LabelStep7;
        private System.Windows.Forms.Label LabelStep8;
        private System.Windows.Forms.Panel PanelPage;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.FlowLayoutPanel PanelOutput;
        private System.Windows.Forms.FlowLayoutPanel PanelOutputLabel;
        private System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.FlowLayoutPanel PanelOutputContent;
        private System.Windows.Forms.Label LabelPath;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.FlowLayoutPanel PanelCount;
        private System.Windows.Forms.FlowLayoutPanel PanelCountLabel;
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.FlowLayoutPanel PanelCountContent;
        private System.Windows.Forms.FlowLayoutPanel PanelCountUpDown;
        private System.Windows.Forms.NumericUpDown UpDownCount;
        private System.Windows.Forms.FolderBrowserDialog DialogOutput;
    }
}
