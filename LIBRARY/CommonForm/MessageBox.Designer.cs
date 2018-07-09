﻿namespace LIBRARY
{
    partial class MessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBox));
            this.InfoBg = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBg)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoBg
            // 
            this.InfoBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.InfoBg.Location = new System.Drawing.Point(0, 30);
            this.InfoBg.Name = "InfoBg";
            this.InfoBg.Size = new System.Drawing.Size(250, 120);
            this.InfoBg.TabIndex = 0;
            this.InfoBg.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("黑体", 12F);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(6, 7);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(104, 16);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "图书管理系统";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseMove);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ConfirmButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ConfirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Location = new System.Drawing.Point(88, 108);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(73, 23);
            this.ConfirmButton.TabIndex = 6;
            this.ConfirmButton.TabStop = false;
            this.ConfirmButton.Text = "确定";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.TextBox.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.TextBox.Location = new System.Drawing.Point(0, 58);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(250, 23);
            this.TextBox.TabIndex = 7;
            this.TextBox.Text = "label1";
            this.TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageBox
            // 
            this.AcceptButton = this.ConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.InfoBg);
            this.DM_howBorder = false;
            this.DM_ShadowWidth = 6;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "提示";
            this.Load += new System.EventHandler(this.InfoBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InfoBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox InfoBg;
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label TextBox;
    }
}