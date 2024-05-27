using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Firebase.Auth;
using zaro.Classes;
using zaro.Forms;

namespace zaro
{
    public partial class splash_screen : Form
    {

        private FirebaseAuthClient authClient;
        public splash_screen()
        {
            InitializeComponent();

            authClient = FbAuth.authClient;
        }

        private void splash_screen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            authClient.SignOut();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            
            try
            {
                if (authClient.User != null)
                {
                    var user = authClient.User;
                    MessageBox.Show($"Chào mừng trở lại, {user.Info.Email}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    homepage homepage = new homepage();
                    homepage.Show();
                }
                else 
                {
                    login login = new login();
                    login.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
