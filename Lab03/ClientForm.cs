﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace Lab03
{
    public partial class ClientForm : Form
    {

        //  init section
        private TcpClient client = null;
        private Thread thread = null;
        private string joinUsername, joinIP, joinPort;
       
        public ClientForm(string joinUsername, string joinIP, string joinPort)
        {
            InitializeComponent();
            this.ActiveControl = message;
            this.joinUsername = joinUsername;
            this.joinIP = joinIP;
            this.joinPort = joinPort;
        }

        private void Lab03_Bai04_Client_Load(object sender, EventArgs e)
        {
            string username = joinUsername;
            IPAddress ip = null;
            int port = 0;
            if (username == "Username" || username == "") username = " ";
            try
            {
                ip = IPAddress.Parse(joinIP);
                port = Int32.Parse(joinPort);
            }
            catch
            {
                MessageBox.Show("The IPEndpoint is incorrect.", "Error");
                this.Close();
                return;
            }
            client = new TcpClient();
            try
            {
                client.Connect(ip, port);
            }
            catch
            {
                MessageBox.Show("Server is not running!", "Error");
                this.Close();
                return;
            }

            //  assign username
            NetworkStream stream = client.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes(username);
            stream.Write(buffer, 0, buffer.Length);

            buffer = new byte[1024];
            int bytesCount = stream.Read(buffer, 0, buffer.Length);
            string res = Encoding.UTF8.GetString(buffer, 0, bytesCount);

            if (res == " ")
            {
                MessageBox.Show($"{username} is invalid or already picked.", "Error");
                this.Close();
                return;
            }
            else MessageBox.Show($"{res} is your username.", "Success");

            thread = new Thread(o => ReceiveData((TcpClient)o));
            thread.Start(client);
         }

        //  stuff section
        private void ReceiveData(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int bytesCount;

            while (
                Thread.CurrentThread.IsAlive && 
                (bytesCount = stream.Read(receivedBytes, 0, receivedBytes.Length)) > 0
            )
                conversation.Invoke(new MethodInvoker(delegate ()
                {
                    conversation.AppendText(Encoding.UTF8.GetString(receivedBytes, 0, bytesCount));
                    conversation.ScrollToCaret();
                }));

            stream.Close();
        }

        //  events handling section
        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes(message.Text);
            stream.Write(buffer, 0, buffer.Length);
            message.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            conversation.Clear();
        }

        private void message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null)
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = Encoding.UTF8.GetBytes("I left the conversation!");
                stream.Write(buffer, 0, buffer.Length);
                thread.Abort();
            }

            if (client != null)
            {
                try
                {
                    client.Client.Shutdown(SocketShutdown.Send);
                }
                catch { }
                client.Close();
            }
        }
    }
}
