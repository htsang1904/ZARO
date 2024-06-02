using System;
using System.Windows.Forms;

namespace zaro
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtLogPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLogUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.guna2ImageButton1);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.checkBox1);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.materialDivider2);
            this.guna2Panel2.Controls.Add(this.materialDivider1);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(354, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(284, 386);
            this.guna2Panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Chưa có tài khoản";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(31, 232);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "Ghi nhớ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Location = new System.Drawing.Point(171, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Quên mật khẩu ?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(151)))));
            this.label2.Location = new System.Drawing.Point(151, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Đăng ký";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.Black;
            this.materialDivider2.Depth = 0;
            this.materialDivider2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider2.Location = new System.Drawing.Point(167, 321);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(93, 1);
            this.materialDivider2.TabIndex = 30;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Black;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialDivider1.Location = new System.Drawing.Point(21, 321);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(93, 1);
            this.materialDivider1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Hoặc";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Empty;
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(151)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(77, 266);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(135, 37);
            this.guna2Button1.TabIndex = 25;
            this.guna2Button1.Text = "Đăng nhập";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Đăng nhập";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.guna2Button2);
            this.guna2Panel3.Controls.Add(this.txtLogPass);
            this.guna2Panel3.Controls.Add(this.txtLogUsername);
            this.guna2Panel3.Location = new System.Drawing.Point(0, 106);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(281, 122);
            this.guna2Panel3.TabIndex = 17;
            // 
            // txtLogPass
            // 
            this.txtLogPass.BorderRadius = 6;
            this.txtLogPass.BorderThickness = 0;
            this.txtLogPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogPass.DefaultText = "";
            this.txtLogPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLogPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLogPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.txtLogPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLogPass.ForeColor = System.Drawing.Color.Black;
            this.txtLogPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogPass.Location = new System.Drawing.Point(21, 69);
            this.txtLogPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLogPass.Name = "txtLogPass";
            this.txtLogPass.PasswordChar = '*';
            this.txtLogPass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtLogPass.PlaceholderText = "Mật khẩu";
            this.txtLogPass.SelectedText = "";
            this.txtLogPass.Size = new System.Drawing.Size(239, 39);
            this.txtLogPass.TabIndex = 1;
            // 
            // txtLogUsername
            // 
            this.txtLogUsername.BorderRadius = 6;
            this.txtLogUsername.BorderThickness = 0;
            this.txtLogUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogUsername.DefaultText = "";
            this.txtLogUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLogUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLogUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.txtLogUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLogUsername.ForeColor = System.Drawing.Color.Black;
            this.txtLogUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogUsername.Location = new System.Drawing.Point(21, 11);
            this.txtLogUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLogUsername.Name = "txtLogUsername";
            this.txtLogUsername.PasswordChar = '\0';
            this.txtLogUsername.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtLogUsername.PlaceholderText = "Email";
            this.txtLogUsername.SelectedText = "";
            this.txtLogUsername.Size = new System.Drawing.Size(239, 39);
            this.txtLogUsername.TabIndex = 0;
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog1.Text = null;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2ImageButton1.Image = global::zaro.Properties.Resources.cancel_icon;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(14, 14);
            this.guna2ImageButton1.Location = new System.Drawing.Point(250, 10);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(14, 14);
            this.guna2ImageButton1.Size = new System.Drawing.Size(22, 24);
            this.guna2ImageButton1.TabIndex = 37;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button2.BorderColor = System.Drawing.Color.Silver;
            this.guna2Button2.BorderRadius = 6;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.CustomImages.ImageSize = new System.Drawing.Size(15, 20);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::zaro.Properties.Resources.eyes_close_icon;
            this.guna2Button2.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2Button2.Location = new System.Drawing.Point(225, 76);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Padding = new System.Windows.Forms.Padding(3);
            this.guna2Button2.Size = new System.Drawing.Size(28, 28);
            this.guna2Button2.TabIndex = 38;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = global::zaro.Properties.Resources.ZARO_logo;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(356, 386);
            this.guna2Panel1.TabIndex = 0;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 386);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(638, 386);
            this.Name = "login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtLogPass;
        private Guna.UI2.WinForms.Guna2TextBox txtLogUsername;
        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}

