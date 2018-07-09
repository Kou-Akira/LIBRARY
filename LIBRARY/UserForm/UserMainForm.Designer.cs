﻿namespace LIBRARY
{
    partial class UserMainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.MinButton = new System.Windows.Forms.Button();
            this.TimeWorker = new System.ComponentModel.BackgroundWorker();
            this.TimeTextBox = new System.Windows.Forms.Label();
            this.UserChangeButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.MainPanel.Location = new System.Drawing.Point(0, 45);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1000, 705);
            this.MainPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("黑体", 16F);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(61, 11);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(142, 22);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "图书管理系统";
            this.TitleLabel.DoubleClick += new System.EventHandler(this.TitleLabel_DoubleClick);
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseMove);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.BackgroundImage")));
            this.ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ReturnButton.FlatAppearance.BorderSize = 0;
            this.ReturnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(146)))), ((int)(((byte)(126)))));
            this.ReturnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(166)))), ((int)(((byte)(150)))));
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Location = new System.Drawing.Point(16, 5);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(35, 35);
            this.ReturnButton.TabIndex = 4;
            this.ReturnButton.TabStop = false;
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // ShutDownButton
            // 
            this.ShutDownButton.BackColor = System.Drawing.Color.Transparent;
            this.ShutDownButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShutDownButton.BackgroundImage")));
            this.ShutDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ShutDownButton.FlatAppearance.BorderSize = 0;
            this.ShutDownButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(42)))), ((int)(((byte)(21)))));
            this.ShutDownButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(65)))), ((int)(((byte)(39)))));
            this.ShutDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownButton.Location = new System.Drawing.Point(954, 5);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(35, 35);
            this.ShutDownButton.TabIndex = 5;
            this.ShutDownButton.TabStop = false;
            this.ShutDownButton.UseVisualStyleBackColor = false;
            this.ShutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
            // 
            // MinButton
            // 
            this.MinButton.BackColor = System.Drawing.Color.Transparent;
            this.MinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinButton.BackgroundImage")));
            this.MinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinButton.FlatAppearance.BorderSize = 0;
            this.MinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(124)))), ((int)(((byte)(194)))));
            this.MinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.Location = new System.Drawing.Point(901, 5);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(35, 35);
            this.MinButton.TabIndex = 6;
            this.MinButton.TabStop = false;
            this.MinButton.UseVisualStyleBackColor = false;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // TimeWorker
            // 
            this.TimeWorker.WorkerReportsProgress = true;
            this.TimeWorker.WorkerSupportsCancellation = true;
            this.TimeWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TimeWorker_DoWork);
            this.TimeWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.TimeWorker_ProgressChanged);
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.AutoSize = true;
            this.TimeTextBox.Font = new System.Drawing.Font("黑体", 16F);
            this.TimeTextBox.ForeColor = System.Drawing.Color.White;
            this.TimeTextBox.Location = new System.Drawing.Point(418, 13);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(164, 22);
            this.TimeTextBox.TabIndex = 8;
            this.TimeTextBox.Text = "2017年04月21日";
            this.TimeTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeTextBox_MouseDown);
            this.TimeTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TimeTextBox_MouseMove);
            // 
            // UserChangeButton
            // 
            this.UserChangeButton.BackColor = System.Drawing.Color.Transparent;
            this.UserChangeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserChangeButton.BackgroundImage")));
            this.UserChangeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UserChangeButton.FlatAppearance.BorderSize = 0;
            this.UserChangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(146)))), ((int)(((byte)(126)))));
            this.UserChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(166)))), ((int)(((byte)(150)))));
            this.UserChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserChangeButton.Location = new System.Drawing.Point(848, 5);
            this.UserChangeButton.Name = "UserChangeButton";
            this.UserChangeButton.Size = new System.Drawing.Size(35, 35);
            this.UserChangeButton.TabIndex = 19;
            this.UserChangeButton.TabStop = false;
            this.toolTip1.SetToolTip(this.UserChangeButton, "切换用户");
            this.UserChangeButton.UseVisualStyleBackColor = false;
            this.UserChangeButton.Click += new System.EventHandler(this.UserChangeButton_Click);
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.UserChangeButton);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MainPanel);
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.DM_ShadowWidth = 5;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMS 图书管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ShutDownButton;
        private System.Windows.Forms.Button MinButton;
        public System.Windows.Forms.Button ReturnButton;
        public System.Windows.Forms.Label TitleLabel;
        private System.ComponentModel.BackgroundWorker TimeWorker;
        private System.Windows.Forms.Label TimeTextBox;
		private System.Windows.Forms.Button UserChangeButton;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

