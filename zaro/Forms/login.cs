using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using FirebaseAdmin.Auth;
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
using zaro.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace zaro
{
    public partial class login : Form
    {
        bool isPasswordVisible = false;

        private FirebaseClient client;

        private FirebaseAuthClient authClient;
        public login()
        {
            InitializeComponent();
            client = FbClient.FClient;

            authClient = FbAuth.authClient;
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
                showMessage("Vui lòng điền đầy đủ thông tin", "Thông báo", "Error", "Light");
                return;
            }
            var username = txtLogUsername.Text.Trim();
            var password = txtLogPass.Text.Trim();
            try
            {
                var userCredential = await authClient.SignInWithEmailAndPasswordAsync(username, password);

                var user = userCredential.User;
                var refreshToken = user.Credential.RefreshToken;
                var token = await user.GetIdTokenAsync();
                var displayName = user.Info.DisplayName;
                var uid = user.Uid;
                showMessage($"Đăng nhập thành công!", "Thông báo", "Information", "Light");
            }
            catch (FirebaseAuthHttpException ex)
            {
                showMessage($"Thông tin tài khoản không chính xác!", "Thông báo", "Information", "Light");
            }
            catch (Exception ex)
            {
                showMessage($"Đã xảy ra lỗi: {ex.Message}", "Thông báo", "Error", "Light");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            reset_password resetPassword = new reset_password();
            resetPassword.Show();
        }

       
        public void showMessage(string message, string caption, string icon, string style)
        {
            guna2MessageDialog1.Text = message;
            guna2MessageDialog1.Caption = caption;

            if (Enum.TryParse(icon, out MessageDialogIcon iconEnum))
            {
                guna2MessageDialog1.Icon = iconEnum;
            }
            if (Enum.TryParse(style, out MessageDialogStyle styleEnum))
            {
                guna2MessageDialog1.Style = styleEnum;
            }
            guna2MessageDialog1.Show();
        }
    }
}
