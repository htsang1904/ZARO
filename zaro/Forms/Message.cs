using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zaro.Classes;

namespace zaro.Forms
{
    public partial class ZaroMessage : Form
    {
        public ZaroMessage()
        {
            InitializeComponent();
        }

        private void Message_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("aaa");
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void label34_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
        /*TcpClient tcpClient = new TcpClient();
        NetworkStream ns = tcpClient.GetStream();

        void Connect()
        {
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 268);
            Socket client = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.IP);
            client.Connect(IP);
        }
        void Close()
        {
            client.Close();
        }
        void Send()
        {
            if (MessageTxb.Text != string.Empty)
                client.Send(Serialize(MessageTxb.Text));
        }
        void Receive()
        {
            try
            {
                while(true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);
                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }
            
        }
        void AddMessage()
        {}
        byte[] Serialize(object obj)
        {

        }
        object Deserialize(byte[] data))
        {
        }
        */
    }
}
