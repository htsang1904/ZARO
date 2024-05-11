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
using Guna.UI2.WinForms;
using System.Security.Policy;
using System.Web.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Firebase.Database.Query;
using System.Net;

namespace zaro
{
    public partial class Register : Form
    {
        bool isPasswordVisible = false;
        bool isPasswordConfirmVisible = false;
        private IFirebaseClient FsharpClient;
        private Firebase.Database.FirebaseClient FClient;
        public Register()
        {
            InitializeComponent();
            FsharpClient = FbClient.FsharpClient;
            FClient = FbClient.FClient;
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
            if (string.IsNullOrEmpty(txtRegPhone.Text) || string.IsNullOrEmpty(txtRegMail.Text) || string.IsNullOrEmpty(txtRegPass.Text) || string.IsNullOrEmpty(txtRegPassConfirm.Text)) 
            {
                showMessage("Vui lòng điền đầy đủ thông tin", "Thông báo", "Properties.Resources.eyes_open_icon", "Light");
                return;
            }
            
            if (!IsValidPhoneNumber(txtRegPhone.Text))
            {
                showMessage("Số điện thoại không đúng", "Thông báo", "Error", "Light");
                return;
            }

            if (!IsValidMail(txtRegMail.Text))
            {
                showMessage("Email không đúng", "Thông báo", "Error", "Light");
                return;
            }
            if (!IsValidPassword()) return;

            if(await IsUserExist(txtRegPhone.Text.Trim()))
            {
                showMessage("Số điện thoại đã tồn tại", "Thông báo", "Error", "Light");
                return;
            }

            var register = new registerInfo()
            {
                email = txtRegMail.Text,
                phoneNumber = txtRegPhone.Text,
                password = txtRegPass.Text,
            };


            SetResponse response = FsharpClient.Set("Users/" + txtRegPhone.Text, register);
            registerInfo res = response.ResultAs<registerInfo>();
            if (res != null)
            {
                showMessage("Chúc mừng bạn đã đăng ký thành công!", "Thông báo", "None", "Light");
                resetData();
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
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"(84|0[3|5|7|8|9])+([0-9]{8})\b";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(phoneNumber);
            return match.Success;
        }
        public bool IsValidMail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            Regex regex = new Regex(emailPattern);
            Match match = regex.Match(email);
            return match.Success;
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
        public bool IsValidPassword()
        {
            string password = txtRegPass.Text;
            string confirmPassword = txtRegPassConfirm.Text;

            if (password.Length >= 8 && password == confirmPassword)
            {
                return true;
            }
            else if (password.Length < 8)
            {
                showMessage("Mật khẩu phải chứa ít nhất 8 ký tự!", "Thông báo", "Error", "Light");
                txtRegPass.Focus();
                return false;
            }
            else
            {
                showMessage("Mật khẩu và xác nhận mật khẩu không khớp. Vui lòng nhập lại!", "Thông báo", "Error", "Light");
                txtRegPassConfirm.Focus();
                return false;
            }
        }

        public async Task<bool> IsUserExist(string username)
        {
            var userSnapshot = await FClient
                .Child("Users")
                .OrderBy("phoneNumber")
                .EqualTo(username)
                .OnceAsync<registerInfo>();
            var userData = userSnapshot.FirstOrDefault()?.Object;
            if(userData != null)
            {
                return true;
            }
            else 
            {
                return false;
            }
           
           
        }

        public void resetData()
        {
            txtRegPhone.Clear();
            txtRegMail.Clear();
            txtRegPass.Clear();
            txtRegPassConfirm.Clear();
        }
    }
}
