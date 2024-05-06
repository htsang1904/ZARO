using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zaro.Classes;
using System.Text.RegularExpressions;
using System.Web.UI.Design;

namespace zaro
{
    public partial class Register : Form
    {
        bool isPasswordVisible = false;
        bool isPasswordConfirmVisible = false;
        IFirebaseClient client;
        public Register()
        {
            InitializeComponent();
            client = FbClient.Client;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Hide();
            login login = new login();
            login.ShowDialog();
            Close();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtRegPhone.Text) || string.IsNullOrEmpty(txtRegMail.Text) || string.IsNullOrEmpty(txtRegPass.Text) || string.IsNullOrEmpty(txtRegPassConfirm.Text)) 
            {
                guna2MessageDialog1.Text = "Vui lòng điền đầy đủ thông tin";
                guna2MessageDialog1.Caption = "Lỗi";
                guna2MessageDialog1.Show();
                return;
            }

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string emailAddress = txtRegMail.Text.Trim();

            if (!string.IsNullOrEmpty(emailAddress) && !Regex.IsMatch(emailAddress, emailPattern))
            {
                guna2MessageDialog1.Text = "Vui lòng nhập đúng định dạng mail";
                guna2MessageDialog1.Caption = "Lỗi";
                guna2MessageDialog1.Show();
                return;
            }
            var register = new registerInfo()
            {
                email = txtRegMail.Text,
                phoneNumber = txtRegPhone.Text,
                password = txtRegPass.Text,
            };
            SetResponse response = await client.SetAsync("users/" + txtRegPhone.Text, register);
            registerInfo res = response.ResultAs<registerInfo>();
            if (res != null)
            {
                guna2MessageDialog1.Text = "Chúc mừng bạn đã đăng ký thành công!";
                guna2MessageDialog1.Caption = "Thông báo";
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
                guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
                guna2MessageDialog1.Show();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            showPassBtn.Image = isPasswordVisible ? Properties.Resources.eyes_open_icon : Properties.Resources.eyes_close_icon;
            txtRegPass.PasswordChar = isPasswordVisible ? '\0' : '*';
        }

        private void showPassBtn1_Click(object sender, EventArgs e)
        {
            isPasswordConfirmVisible = !isPasswordConfirmVisible;
            showPassBtn1.Image = isPasswordConfirmVisible ? Properties.Resources.eyes_open_icon : Properties.Resources.eyes_close_icon;
            txtRegPassConfirm.PasswordChar = isPasswordConfirmVisible ? '\0' : '*';
        }
    }
}
