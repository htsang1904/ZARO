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

        private FirebaseAuthConfig config = new FirebaseAuthConfig
        {
            ApiKey = "AIzaSyD65Q-h6yVWJrQ2pQ7L57U_lkpxzMPwHMo",
            AuthDomain = "zaro-b91c3.firebaseapp.com",
            Providers = new FirebaseAuthProvider[]
            {
                new GoogleProvider().AddScopes("email"),
                new EmailProvider()
            },
            UserRepository = new FileUserRepository("FirebaseSample")
        };
        private FirebaseAuthClient authClient;
        public login()
        {
            InitializeComponent();
            client = FbClient.FClient;

            authClient = new FirebaseAuthClient(config);

            AutoSignIn();
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
            try
            {
                var userCredential = await authClient.SignInWithEmailAndPasswordAsync(username, password);

                var user = userCredential.User;
                var refreshToken = user.Credential.RefreshToken;
                var token = await user.GetIdTokenAsync();
                var displayName = user.Info.DisplayName;
                var uid = user.Uid;
                MessageBox.Show($"Đăng nhập thành công!\n\nID Token: {token}\nRefresh Token: {refreshToken}\nUser ID: {uid}\nDisplay Name: {displayName}\n",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FirebaseAuthHttpException ex)
            {
                MessageBox.Show($"Lỗi xác thực Firebase: {ex.Reason}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            reset_password resetPassword = new reset_password();
            resetPassword.Show();
        }

        private async void AutoSignIn()
        {
            try
            {
                if (authClient.User != null)
                {
                    var user = authClient.User;
                    MessageBox.Show($"Chào mừng trở lại, {user.Info.Email}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
