namespace TCPChat
{
    partial class MainForm
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
            this.btnClient = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.joinPort = new System.Windows.Forms.TextBox();
            this.joinIP = new System.Windows.Forms.TextBox();
            this.joinUsername = new System.Windows.Forms.TextBox();
            this.hostPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Black;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClient.Location = new System.Drawing.Point(14, 33);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(139, 49);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Join an existing conversation";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.Location = new System.Drawing.Point(332, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 32);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.Black;
            this.btnServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnServer.Location = new System.Drawing.Point(228, 83);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(139, 49);
            this.btnServer.TabIndex = 2;
            this.btnServer.Text = "Host a new conversation";
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // joinPort
            // 
            this.joinPort.BackColor = System.Drawing.Color.Black;
            this.joinPort.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.joinPort.Location = new System.Drawing.Point(108, 17);
            this.joinPort.MaxLength = 5;
            this.joinPort.Name = "joinPort";
            this.joinPort.Size = new System.Drawing.Size(45, 20);
            this.joinPort.TabIndex = 4;
            this.joinPort.Text = "Port";
            this.joinPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // joinIP
            // 
            this.joinIP.BackColor = System.Drawing.Color.Black;
            this.joinIP.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.joinIP.Location = new System.Drawing.Point(14, 17);
            this.joinIP.MaxLength = 15;
            this.joinIP.Name = "joinIP";
            this.joinIP.Size = new System.Drawing.Size(98, 20);
            this.joinIP.TabIndex = 5;
            this.joinIP.Text = "IPAddress";
            this.joinIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // joinUsername
            // 
            this.joinUsername.BackColor = System.Drawing.Color.Black;
            this.joinUsername.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.joinUsername.Location = new System.Drawing.Point(14, 78);
            this.joinUsername.MaxLength = 15;
            this.joinUsername.Name = "joinUsername";
            this.joinUsername.Size = new System.Drawing.Size(139, 20);
            this.joinUsername.TabIndex = 6;
            this.joinUsername.Text = "Username";
            this.joinUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hostPort
            // 
            this.hostPort.BackColor = System.Drawing.Color.Black;
            this.hostPort.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.hostPort.Location = new System.Drawing.Point(331, 84);
            this.hostPort.MaxLength = 5;
            this.hostPort.Name = "hostPort";
            this.hostPort.Size = new System.Drawing.Size(35, 20);
            this.hostPort.TabIndex = 7;
            this.hostPort.Text = "Port";
            this.hostPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(393, 165);
            this.Controls.Add(this.hostPort);
            this.Controls.Add(this.joinUsername);
            this.Controls.Add(this.joinIP);
            this.Controls.Add(this.joinPort);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClient);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Name = "MainForm";
            this.Text = "TCPChat_Bai04";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.TextBox joinPort;
        private System.Windows.Forms.TextBox joinIP;
        private System.Windows.Forms.TextBox joinUsername;
        private System.Windows.Forms.TextBox hostPort;
    }
}