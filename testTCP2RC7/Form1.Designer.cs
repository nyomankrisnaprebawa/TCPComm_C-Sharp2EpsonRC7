namespace testTCP2RC7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TB_SEND = new TextBox();
            TB_RECEIVED = new TextBox();
            label2 = new Label();
            BTN_CONNECT = new Button();
            label3 = new Label();
            label1 = new Label();
            TB_IP = new TextBox();
            TB_PORT = new TextBox();
            label4 = new Label();
            BTN_SEND = new Button();
            TB_DATA1 = new TextBox();
            TB_DATA2 = new TextBox();
            TB_DATA3 = new TextBox();
            SuspendLayout();
            // 
            // TB_SEND
            // 
            TB_SEND.Location = new Point(12, 111);
            TB_SEND.Multiline = true;
            TB_SEND.Name = "TB_SEND";
            TB_SEND.Size = new Size(615, 145);
            TB_SEND.TabIndex = 1;
            // 
            // TB_RECEIVED
            // 
            TB_RECEIVED.Location = new Point(12, 297);
            TB_RECEIVED.Multiline = true;
            TB_RECEIVED.Name = "TB_RECEIVED";
            TB_RECEIVED.Size = new Size(615, 145);
            TB_RECEIVED.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 279);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Received";
            // 
            // BTN_CONNECT
            // 
            BTN_CONNECT.Location = new Point(230, 8);
            BTN_CONNECT.Name = "BTN_CONNECT";
            BTN_CONNECT.Size = new Size(75, 65);
            BTN_CONNECT.TabIndex = 7;
            BTN_CONNECT.Text = "connect";
            BTN_CONNECT.Click += BTN_CONNECT_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Send";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 8;
            label1.Text = "IP";
            label1.Click += label1_Click;
            // 
            // TB_IP
            // 
            TB_IP.Location = new Point(62, 9);
            TB_IP.Name = "TB_IP";
            TB_IP.Size = new Size(141, 23);
            TB_IP.TabIndex = 9;
            // 
            // TB_PORT
            // 
            TB_PORT.Location = new Point(62, 50);
            TB_PORT.Name = "TB_PORT";
            TB_PORT.Size = new Size(141, 23);
            TB_PORT.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 53);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 10;
            label4.Text = "PORT";
            // 
            // BTN_SEND
            // 
            BTN_SEND.Location = new Point(633, 111);
            BTN_SEND.Name = "BTN_SEND";
            BTN_SEND.Size = new Size(75, 145);
            BTN_SEND.TabIndex = 12;
            BTN_SEND.Text = "SEND";
            BTN_SEND.Click += BTN_SEND_Click;
            // 
            // TB_DATA1
            // 
            TB_DATA1.Location = new Point(633, 297);
            TB_DATA1.Name = "TB_DATA1";
            TB_DATA1.Size = new Size(100, 23);
            TB_DATA1.TabIndex = 13;
            // 
            // TB_DATA2
            // 
            TB_DATA2.Location = new Point(633, 357);
            TB_DATA2.Name = "TB_DATA2";
            TB_DATA2.Size = new Size(100, 23);
            TB_DATA2.TabIndex = 14;
            // 
            // TB_DATA3
            // 
            TB_DATA3.Location = new Point(633, 415);
            TB_DATA3.Name = "TB_DATA3";
            TB_DATA3.Size = new Size(100, 23);
            TB_DATA3.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TB_DATA3);
            Controls.Add(TB_DATA2);
            Controls.Add(TB_DATA1);
            Controls.Add(BTN_SEND);
            Controls.Add(TB_PORT);
            Controls.Add(label4);
            Controls.Add(TB_IP);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(BTN_CONNECT);
            Controls.Add(TB_RECEIVED);
            Controls.Add(label2);
            Controls.Add(TB_SEND);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TB_SEND;
        private TextBox TB_RECEIVED;
        private Label label2;
        private Button BTN_CONNECT;
        private Label label3;
        private Label label1;
        private TextBox TB_IP;
        private TextBox TB_PORT;
        private Label label4;
        private Button BTN_SEND;
        private TextBox TB_DATA1;
        private TextBox TB_DATA2;
        private TextBox TB_DATA3;
    }
}