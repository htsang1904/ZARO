using Firebase.Database;
using Firebase.Database.Query;
using Guna.UI2.WinForms;
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

namespace zaro
{
    public partial class login : Form
    {
        bool isPasswordVisible = false;

        private FirebaseClient client;

        public login()
        {
            InitializeComponent();
            client = FbClient.FClient;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
            Register register = new Register();
            register.Show();
            Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            guna2Button2.Image = isPasswordVisible ? Properties.Resources.eyes_open_icon : Properties.Resources.eyes_close_icon;
            txtLogPass.PasswordChar = isPasswordVisible ? '\0' : '*';
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogUsername.Text) || string.IsNullOrEmpty(txtLogPass.Text) )
            {
                guna2MessageDialog1.Text = "Vui lòng điền đầy đủ thông tin";
                guna2MessageDialog1.Caption = "Lỗi";
                guna2MessageDialog1.Show();
                return;
            }
            var username = txtLogUsername.Text.Trim();
            var password = txtLogPass.Text.Trim();
            var data = await client.Child("Users").OrderBy("phoneNumber").EqualTo(username).OnceAsync<registerInfo>();
            if (data.Count > 0) 
            {
                var user = data.First().Object;
                if (user.password == password)
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác");
                }
            }
            else
            {
                MessageBox.Show("Thông tin đăng kí không chính xác");
            }    
        }
    }
}
