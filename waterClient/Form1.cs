using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace waterClient
{
    public partial class Form1 : Form
    {

        private Socket sock;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconn_Click(object sender, EventArgs e)
        {
            try
            {
                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(tbxIP.Text);
                IPEndPoint myport = new IPEndPoint(ip, Convert.ToInt32(tbxPort.Text));
                sock.Connect(myport);
                ShowMsg("连接成功");
                Thread th = new Thread(Receive);
                th.IsBackground = true;
                th.Start(sock);
            }
            catch (Exception)
            {
                ShowMsg("连接服务器  失败。。。请仔细检查服务器是否开启");
            }
          
        }
        void Receive(object o)
        {
            Socket ClientRecieve = o as Socket;
            ShowMsg("开始接收服务端信息");
            while (true)
            {
                try
                {

                    byte[] buffer = new byte[1024 * 1024 * 3];
                    int i = ClientRecieve.Receive(buffer);
                    if (i == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, i);
                    ShowMsg(ClientRecieve.RemoteEndPoint + ":" + str);

                }
                catch(Exception)
                {
                    ShowMsg("服务端接收异常");
                }
            }
        }
      
        public void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            sock.Close();
            btnconn.Enabled = true ;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string str = tbxMessage.Text.Trim();
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
            sock.Send(buffer);
            tbxMessage.Clear();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        }
        }


