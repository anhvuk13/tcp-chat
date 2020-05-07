namespace TCPChat
{
    partial class ClientForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.conversation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Black;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSend.Location = new System.Drawing.Point(306, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 31);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.Location = new System.Drawing.Point(306, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 31);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.Location = new System.Drawing.Point(306, 265);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.Black;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.message.Location = new System.Drawing.Point(12, 5);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(288, 29);
            this.message.TabIndex = 4;
            this.message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.message_KeyDown);
            // 
            // conversation
            // 
            this.conversation.BackColor = System.Drawing.Color.Black;
            this.conversation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversation.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.conversation.Location = new System.Drawing.Point(12, 38);
            this.conversation.Name = "conversation";
            this.conversation.ReadOnly = true;
            this.conversation.Size = new System.Drawing.Size(288, 258);
            this.conversation.TabIndex = 6;
            this.conversation.Text = "";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(382, 308);
            this.Controls.Add(this.conversation);
            this.Controls.Add(this.message);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Name = "ClientForm";
            this.Text = "Anonymous";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.RichTextBox conversation;
    }
}