﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY
{
    public partial class MainForm : DMSkin.Main
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //MFReturnButton.Hide();
            //login窗口载入点


            MainPanel.Controls.Clear();
            SearchForm searchForm = new SearchForm(this);
            searchForm.TopLevel = false;
            searchForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(searchForm);//添加到panel控件中
            searchForm.Show();
        }
        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            if(ReturnButton.Tag != null)//在主页，禁用返回键
            {
                MainPanel.Controls.Clear();
                SearchForm searchForm = new SearchForm(this);
                searchForm.TopLevel = false;
                searchForm.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(searchForm);//添加到panel控件中
                searchForm.Show();
                ReturnButton.Tag = true;
            }
        }
    }
}
