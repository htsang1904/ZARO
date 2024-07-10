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
using zaro.Control;

namespace zaro.Forms
{
    public partial class controlPanel : Form
    {
        private FirebaseAuthClient authClient;
        public controlPanel()
        {
            InitializeComponent();
            Home uc = new Home();
            addUserControl( uc );
            authClient = FbAuth.authClient;
            var user = authClient.User;
            personalBtn.Text = user.Info.DisplayName;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FriendConnection uc = new FriendConnection();
            addUserControl(uc);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Home uc = new Home();
            addUserControl(uc);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void controlPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2ContextMenuStrip1.Show(personalBtn, new Point(0, guna2Button1.Height));
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            authClient.SignOut();
            Hide();
            login login = new login();
            login.ShowDialog();
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            guna2Button1.Checked = false;
            guna2Button2.Checked = false;
            guna2Button3.Checked = false;
            guna2Button4.Checked = false;
            Personal uc = new Personal();
            addUserControl(uc);
        }
    }
}
