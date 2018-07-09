﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY
{
    public partial class AdminFunctionForm : DMSkin.Main
    {
        private AdminMainForm frmMain;

        public AdminFunctionForm(AdminMainForm frm)
        {
            InitializeComponent();
            frmMain = frm;
        }

        private void AdminFunctionForm_Load(object sender, EventArgs e)
        {
            #region 返回按钮动画
            Point t = new Point(16, 11);
            frmMain.ReturnButton.Hide();
            frmMain.TitleLabel.Location = t;
            #endregion


            #region 按钮触发范围设置
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 172, 172);
            UserManageButton.Region = new Region(myPath);
            BookManageButton.Region = new Region(myPath);
            SystemLogButton.Region = new Region(myPath);
            #endregion


            BookAmountText.Text = PublicVar.bookAmount.ToString();
            UserAmountText.Text = PublicVar.userAmount.ToString();
            BorrowRateText.Text = (PublicVar.borrowRate*100).ToString("P3");
        }

        #region Button Animate
        private void UserManageButton_MouseMove(object sender, MouseEventArgs e)
        {
            UserManageButton.BackgroundImage = UserManageButton.DM_HoverImage;
        }

        private void UserManageButton_MouseLeave(object sender, EventArgs e)
        {
            UserManageButton.BackgroundImage = UserManageButton.DM_NolImage;
        }

        private void BookManageButton_MouseMove(object sender, MouseEventArgs e)
        {
            BookManageButton.BackgroundImage = BookManageButton.DM_HoverImage;
        }

        private void BookManageButton_MouseLeave(object sender, EventArgs e)
        {
            BookManageButton.BackgroundImage = BookManageButton.DM_NolImage;
        }

        private void SystemLogButton_MouseMove(object sender, MouseEventArgs e)
        {
            SystemLogButton.BackgroundImage = SystemLogButton.DM_HoverImage;
        }

        private void SystemLogButton_MouseLeave(object sender, EventArgs e)
        {
            SystemLogButton.BackgroundImage = SystemLogButton.DM_NolImage;
        }
        #endregion

        private void BookManageButton_Click(object sender, EventArgs e)
        {
            frmMain.MainPanel.Controls.Clear();
            AdminBookManageForm bookManageForm = new AdminBookManageForm(frmMain,0,"");
            bookManageForm.TopLevel = false;
            bookManageForm.Dock = DockStyle.Fill;
            frmMain. MainPanel.Controls.Add(bookManageForm);
            bookManageForm.Show();
        }

        private void UserManageButton_Click(object sender, EventArgs e)
        {
            frmMain.MainPanel.Controls.Clear();
            AdminUserManageForm userManageForm = new AdminUserManageForm(frmMain);
            userManageForm.TopLevel = false;
            userManageForm.Dock = DockStyle.Fill;
            frmMain.MainPanel.Controls.Add(userManageForm);
            userManageForm.Show();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            AdminBookAddForm adminBookAddForm = new AdminBookAddForm();
            adminBookAddForm.ShowDialog();
            adminBookAddForm.Dispose();
        }
        private void AddBookButton_MouseLeave(object sender, EventArgs e)
        {
            AddBookButton.BackgroundImage = AddBookButton.DM_NolImage;
        }

        private void AddBookButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddBookButton.BackgroundImage = AddBookButton.DM_HoverImage;
        }

      
    }
}
