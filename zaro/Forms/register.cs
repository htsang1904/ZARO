using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class register : Form
    {
        bool isPasswordVisible = false;
        bool isPasswordConfirmVisible = false;
        IFirebaseClient client = connectDatabase.client;
        public register()
        {
            InitializeComponent();
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
            }
            var register = new register();
            FirebaseResponse response = client.Set("users", register);
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
