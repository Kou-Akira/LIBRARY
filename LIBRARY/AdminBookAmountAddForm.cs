﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
//using LibrarySystemBackEnd;

namespace LIBRARY
{
    public partial class AdminBookAmountAddForm : DMSkin.Main
    {
        public AdminBookAmountAddForm()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void ChargeForm_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 80, 80);
            OKButton.Region = new Region(myPath);            
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AmountTextBox_Enter(object sender, EventArgs e)
        {
            if (AmountTextBox.Text == "")
            {
                AmountCueText.Hide();
            }
        }

        private void AmountTextBox_Leave(object sender, EventArgs e)
        {
            if (AmountTextBox.Text == "")
            {
                AmountCueText.Show();
            }
        }

        private void AmountCueText_Click(object sender, EventArgs e)
        {
            if (AmountTextBox.Text == "")
            {
                AmountCueText.Hide();
                AmountTextBox.Focus();
            }
        }

        private void OKButton_MouseMove(object sender, MouseEventArgs e)
        {
            OKButton.BackgroundImage = OKButton.DM_HoverImage;
        }

        private void OKButton_MouseLeave(object sender, EventArgs e)
        {
            OKButton.BackgroundImage = OKButton.DM_NolImage;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                var num = Convert.ToInt32(AmountTextBox.Text);
                FileProtocol fileProtocol = new FileProtocol(RequestMode.AdminLoadABookHis, 6000);
                fileProtocol.NowBook.BookAmount = fileProtocol.NowBook.BookAmount + num;
                //fileProtocol.NowABook = new ClassABook(PublicVar.nowBook.BookIsbn + index.ToString("D4"));
                //fileProtocol.Admin = new ClassAdmin(PublicVar.logUser.UserId);
                //fileProtocol.Admin.Password = PublicVar.logUser.UserPassword;

                LoadingBox loadingBox = new LoadingBox(RequestMode.AdminLoadABookHis, "正在修改", fileProtocol);
                loadingBox.ShowDialog();
                if (PublicVar.ReturnValue == -233)
                {
                    return;
                }

                MessageBox infoBox = new MessageBox(3);
                infoBox.ShowDialog();
                infoBox.Dispose();
                Close();
            }
            catch
            {
                MessageBox infoBox = new MessageBox(13);
                infoBox.ShowDialog();
                infoBox.Dispose();
                AmountTextBox.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OKButton_Click(OKButton, new EventArgs());
        }
    }
}
