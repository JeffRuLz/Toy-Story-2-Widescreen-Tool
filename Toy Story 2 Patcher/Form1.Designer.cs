namespace Toy_Story_2_Patcher
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAspectApply = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Other = new System.Windows.Forms.TabPage();
            this.btnFixApply = new System.Windows.Forms.Button();
            this.llSpeedrun = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.cb32Bit = new System.Windows.Forms.CheckBox();
            this.cbSuitableDevice = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.llGithub = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Other.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Other);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 191);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnAspectApply);
            this.tabPage1.Controls.Add(this.btnAuto);
            this.tabPage1.Controls.Add(this.tbHeight);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbWidth);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 165);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aspect Ratio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(171, 65);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAspectApply
            // 
            this.btnAspectApply.Location = new System.Drawing.Point(171, 94);
            this.btnAspectApply.Name = "btnAspectApply";
            this.btnAspectApply.Size = new System.Drawing.Size(75, 23);
            this.btnAspectApply.TabIndex = 4;
            this.btnAspectApply.Text = "Apply";
            this.btnAspectApply.UseVisualStyleBackColor = true;
            this.btnAspectApply.Click += new System.EventHandler(this.btnAspectApply_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(171, 36);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 23);
            this.btnAuto.TabIndex = 2;
            this.btnAuto.Text = "Auto Fill";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(59, 66);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(106, 20);
            this.tbHeight.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Height - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width - ";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(59, 36);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(106, 20);
            this.tbWidth.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custom aspect ratio hack.\r\nEnter your screen resolution or desired aspect ratio.";
            // 
            // Other
            // 
            this.Other.Controls.Add(this.btnFixApply);
            this.Other.Controls.Add(this.llSpeedrun);
            this.Other.Controls.Add(this.label5);
            this.Other.Controls.Add(this.cb32Bit);
            this.Other.Controls.Add(this.cbSuitableDevice);
            this.Other.Controls.Add(this.label4);
            this.Other.Location = new System.Drawing.Point(4, 22);
            this.Other.Name = "Other";
            this.Other.Padding = new System.Windows.Forms.Padding(3);
            this.Other.Size = new System.Drawing.Size(482, 165);
            this.Other.TabIndex = 1;
            this.Other.Text = "Fixes";
            this.Other.UseVisualStyleBackColor = true;
            // 
            // btnFixApply
            // 
            this.btnFixApply.Location = new System.Drawing.Point(10, 128);
            this.btnFixApply.Name = "btnFixApply";
            this.btnFixApply.Size = new System.Drawing.Size(75, 23);
            this.btnFixApply.TabIndex = 3;
            this.btnFixApply.Text = "Apply";
            this.btnFixApply.UseVisualStyleBackColor = true;
            this.btnFixApply.Click += new System.EventHandler(this.btnFixApply_Click);
            // 
            // llSpeedrun
            // 
            this.llSpeedrun.AutoSize = true;
            this.llSpeedrun.Location = new System.Drawing.Point(7, 56);
            this.llSpeedrun.Name = "llSpeedrun";
            this.llSpeedrun.Size = new System.Drawing.Size(248, 13);
            this.llSpeedrun.TabIndex = 0;
            this.llSpeedrun.TabStop = true;
            this.llSpeedrun.Text = "www.speedrun.com/toys2/thread/mh6ev/3#rk874";
            this.llSpeedrun.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "Miscellaneous patches by hdc0 of speedrun.com.\r\nThey\'re included in this program " +
    "for no particular reason.\r\nNot needed if you\'re using dgVoodoo2 or some other wr" +
    "apper.";
            // 
            // cb32Bit
            // 
            this.cb32Bit.AutoSize = true;
            this.cb32Bit.Location = new System.Drawing.Point(10, 105);
            this.cb32Bit.Name = "cb32Bit";
            this.cb32Bit.Size = new System.Drawing.Size(121, 17);
            this.cb32Bit.TabIndex = 2;
            this.cb32Bit.Text = "32 bit screen modes";
            this.cb32Bit.UseVisualStyleBackColor = true;
            // 
            // cbSuitableDevice
            // 
            this.cbSuitableDevice.AutoSize = true;
            this.cbSuitableDevice.Location = new System.Drawing.Point(10, 81);
            this.cbSuitableDevice.Name = "cbSuitableDevice";
            this.cbSuitableDevice.Size = new System.Drawing.Size(231, 17);
            this.cbSuitableDevice.TabIndex = 1;
            this.cbSuitableDevice.Text = "\"Unable to enumerate a suitable device\" fix";
            this.cbSuitableDevice.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilePath.Location = new System.Drawing.Point(16, 13);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(405, 20);
            this.tbFilePath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(427, 11);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // llGithub
            // 
            this.llGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llGithub.AutoSize = true;
            this.llGithub.Location = new System.Drawing.Point(13, 238);
            this.llGithub.Name = "llGithub";
            this.llGithub.Size = new System.Drawing.Size(249, 13);
            this.llGithub.TabIndex = 3;
            this.llGithub.TabStop = true;
            this.llGithub.Text = "github.com/JeffRuLz/Toy-Story-2-Widescreen-Tool";
            this.llGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 261);
            this.Controls.Add(this.llGithub);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(530, 300);
            this.Name = "Form1";
            this.Text = "Toy Story 2 BLTTR Patcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Other.ResumeLayout(false);
            this.Other.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Other;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAspectApply;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llSpeedrun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb32Bit;
        private System.Windows.Forms.CheckBox cbSuitableDevice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFixApply;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.LinkLabel llGithub;
    }
}

