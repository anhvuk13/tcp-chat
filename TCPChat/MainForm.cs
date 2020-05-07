using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Drawing;

namespace TCPChat
{
    public partial class MainForm : Form
    {
        public static void btnMouseHover(Button btn)
        {
            btn.BackColor = Color.Navy;
            btn.ForeColor = Color.White;
        }

        public static void btnMouseLeave(Button btn)
        {
            btn.BackColor = Color.Black;
            btn.ForeColor = Color.DeepSkyBlue;
        }

        public static void btnMouseDown(Button btn)
        {
            btn.BackColor = Color.LightSkyBlue;
            btn.ForeColor = Color.Black;
        }

        private readonly object _lock = new object();
        private readonly Dictionary<string, TcpClient> clientsList = new Dictionary<string, TcpClient>();
        private Thread thread = null;
        private uint clientsCount = 0;
        private TcpListener serverSocket;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serverSocket != null) serverSocket.Stop();
            if (thread != null) thread.Abort();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //  server section
        private void btnServer_Click(object sender, EventArgs e)
        {
            btnServer.Enabled = false;
            thread = new Thread(serverThread);
            thread.Start();
        }

        private void serverThread()
        {
            int port;
            try
            {
                port = Int32.Parse(hostPort.Text);
                serverSocket = new TcpListener(IPAddress.Any, port);
                serverSocket.Start();
            }
            catch
            {
                btnServer.Invoke(new MethodInvoker(delegate ()
                {
                    btnServer.Enabled = true;
                }));
                MessageBox.Show("The port is invalid or in use.", "Error");
                return;
            }

            MessageBox.Show($"Successfully host a conversation at port {port}.", "Success");
           
            while (Thread.CurrentThread.IsAlive)
            {
                clientsCount++;
                TcpClient client = null;
                try
                {
                    client = serverSocket.AcceptTcpClient();
                }
                catch (SocketException e)
                {
                    if ((e.SocketErrorCode == SocketError.Interrupted)) break;
                }

                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesCount = stream.Read(buffer, 0, buffer.Length);
                string username = Encoding.UTF8.GetString(buffer, 0, bytesCount);
                if (username == " ") username = $"User {clientsCount}";
                if (clientsList.ContainsKey(username))
                {
                    clientsCount--;
                    buffer = Encoding.UTF8.GetBytes(" ");
                    stream.Write(buffer, 0, buffer.Length);
                    continue;
                }
                buffer = Encoding.UTF8.GetBytes(username);
                stream.Write(buffer, 0, buffer.Length);
                broadcast($">>> {username} has joined the conversation.");

                lock (_lock) clientsList.Add(username, client);

                Thread handlingThread = new Thread(o => clientsHandling((string)o));
                handlingThread.Start(username);
            }

            btnServer.Invoke(new MethodInvoker(delegate ()
            {
                btnServer.Enabled = true;
                btnServer.ResetText();
            }));
        }

        public void clientsHandling(string username)
        {
            TcpClient client;
            lock (_lock) client = clientsList[username];
            while (true)
            {
                int bytesCount = 0;
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                try
                {
                    bytesCount = stream.Read(buffer, 0, buffer.Length);
                } catch { }
                if (bytesCount == 0) break;
                
                string data = Encoding.UTF8.GetString(buffer, 0, bytesCount);
                broadcast($"{username}: {data}");
            }
            broadcast($">>> {username} has left the conversation.");

            lock (_lock) clientsList.Remove(username);
            client.Client.Shutdown(SocketShutdown.Both);
            client.Close();
            clientsList.Remove(username);
        }

        public void broadcast(string data)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(data + Environment.NewLine);
            lock (_lock)
            {
                foreach (TcpClient c in clientsList.Values)
                {
                    NetworkStream stream = c.GetStream();
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }

        //  client section
        private void btnClient_Click(object sender, EventArgs e)
        {
            (new ClientForm(joinUsername.Text, joinIP.Text, joinPort.Text)).Show();
        }

        // Effect
        private void btnServer_MouseHover(object sender, EventArgs e)
        {
            btnMouseHover(btnServer);
        }

        private void btnServer_MouseLeave(object sender, EventArgs e)
        {
            btnMouseLeave(btnServer);
        }

        private void btnServer_MouseDown(object sender, MouseEventArgs e)
        {
            btnMouseDown(btnServer);
        }

        private void btnClient_MouseHover(object sender, EventArgs e)
        {
            btnMouseHover(btnClient);
        }

        private void btnClient_MouseLeave(object sender, EventArgs e)
        {
            btnMouseLeave(btnClient);
        }

        private void btnClient_MouseDown(object sender, MouseEventArgs e)
        {
            btnMouseDown(btnClient);
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnMouseHover(btnExit);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnMouseLeave(btnExit);
        }

        private void btnExit_MouseDown(object sender, MouseEventArgs e)
        {
            btnMouseDown(btnExit);
        }
    }
}