﻿namespace LIBRARY
{
    partial class AdminBookHistoryInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBookHistoryInfoForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.BgImage = new System.Windows.Forms.PictureBox();
            this.CreditRecordSheet = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditRecordSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(7, 4);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(88, 25);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "书籍历史";
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
            this.ShutDownButton.Location = new System.Drawing.Point(565, 0);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(35, 35);
            this.ShutDownButton.TabIndex = 8;
            this.ShutDownButton.UseVisualStyleBackColor = false;
            this.ShutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
            // 
            // BgImage
            // 
            this.BgImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BgImage.Location = new System.Drawing.Point(0, 35);
            this.BgImage.Name = "BgImage";
            this.BgImage.Size = new System.Drawing.Size(600, 615);
            this.BgImage.TabIndex = 0;
            this.BgImage.TabStop = false;
            // 
            // CreditRecordSheet
            // 
            this.CreditRecordSheet.AllowUserToAddRows = false;
            this.CreditRecordSheet.AllowUserToDeleteRows = false;
            this.CreditRecordSheet.AllowUserToResizeColumns = false;
            this.CreditRecordSheet.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.CreditRecordSheet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CreditRecordSheet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.CreditRecordSheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreditRecordSheet.CausesValidation = false;
            this.CreditRecordSheet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CreditRecordSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CreditRecordSheet.ColumnHeadersHeight = 40;
            this.CreditRecordSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserID,
            this.BorrowDate,
            this.ReturnDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CreditRecordSheet.DefaultCellStyle = dataGridViewCellStyle3;
            this.CreditRecordSheet.Location = new System.Drawing.Point(75, 67);
            this.CreditRecordSheet.MultiSelect = false;
            this.CreditRecordSheet.Name = "CreditRecordSheet";
            this.CreditRecordSheet.ReadOnly = true;
            this.CreditRecordSheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CreditRecordSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CreditRecordSheet.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CreditRecordSheet.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CreditRecordSheet.RowTemplate.Height = 40;
            this.CreditRecordSheet.RowTemplate.ReadOnly = true;
            this.CreditRecordSheet.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CreditRecordSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CreditRecordSheet.ShowEditingIcon = false;
            this.CreditRecordSheet.Size = new System.Drawing.Size(468, 549);
            this.CreditRecordSheet.StandardTab = true;
            this.CreditRecordSheet.TabIndex = 28;
            // 
            // ID
            // 
            this.ID.HeaderText = "序号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 50;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "用户ID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserID.Width = 150;
            // 
            // BorrowDate
            // 
            this.BorrowDate.HeaderText = "借阅时间";
            this.BorrowDate.Name = "BorrowDate";
            this.BorrowDate.ReadOnly = true;
            this.BorrowDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BorrowDate.Width = 125;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "  归还时间";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            this.ReturnDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ReturnDate.Width = 125;
            // 
            // AdminBookHistoryInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(600, 650);
            this.Controls.Add(this.CreditRecordSheet);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BgImage);
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.DM_ShadowWidth = 6;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminBookHistoryInfoForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.BookHistoryInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditRecordSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BgImage;
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ShutDownButton;
        public System.Windows.Forms.DataGridView CreditRecordSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
    }
}