using Firebase.Auth;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace zaro.Forms
{
    public partial class reset_password : Form
    {

        private FirebaseAuthClient authClient;

        public reset_password()
        {
            InitializeComponent();

            authClient = FbAuth.authClient;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            var email = tbEmailReset.Text.Trim();
            try
            {
               await authClient.ResetEmailPasswordAsync(email);
               MessageBox.Show("Hãy kiểm tra Mail của bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FirebaseAuthHttpException ex)
            {
                MessageBox.Show($"Mail không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
