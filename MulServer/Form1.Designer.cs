namespace MulServer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.btn_SendAll = new System.Windows.Forms.Button();
            this.btn_SendSelectClient = new System.Windows.Forms.Button();
            this.lst_Message = new System.Windows.Forms.ListBox();
            this.lst_ClientList = new System.Windows.Forms.ListBox();
            this.lbl_Clients = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Start);
            this.panel1.Controls.Add(this.txt_Port);
            this.panel1.Controls.Add(this.txt_IP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(663, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 265);
            this.panel1.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(76, 165);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(93, 48);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(76, 111);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(93, 48);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(41, 58);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(162, 20);
            this.txt_Port.TabIndex = 1;
            this.txt_Port.Text = "5050";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(41, 22);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(162, 20);
            this.txt_IP.TabIndex = 0;
            this.txt_IP.Text = "172.20.3.173";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP :";
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(12, 12);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(379, 32);
            this.txt_Message.TabIndex = 0;
            this.txt_Message.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Message_KeyPress);
            // 
            // btn_SendAll
            // 
            this.btn_SendAll.Location = new System.Drawing.Point(397, 12);
            this.btn_SendAll.Name = "btn_SendAll";
            this.btn_SendAll.Size = new System.Drawing.Size(116, 32);
            this.btn_SendAll.TabIndex = 1;
            this.btn_SendAll.Text = "Send To All";
            this.btn_SendAll.UseVisualStyleBackColor = true;
            this.btn_SendAll.Click += new System.EventHandler(this.btn_SendAll_Click);
            // 
            // btn_SendSelectClient
            // 
            this.btn_SendSelectClient.Location = new System.Drawing.Point(397, 50);
            this.btn_SendSelectClient.Name = "btn_SendSelectClient";
            this.btn_SendSelectClient.Size = new System.Drawing.Size(116, 32);
            this.btn_SendSelectClient.TabIndex = 3;
            this.btn_SendSelectClient.Text = "Send Select Client";
            this.btn_SendSelectClient.UseVisualStyleBackColor = true;
            this.btn_SendSelectClient.Click += new System.EventHandler(this.btn_SendSelectClient_Click);
            // 
            // lst_Message
            // 
            this.lst_Message.FormattingEnabled = true;
            this.lst_Message.Location = new System.Drawing.Point(12, 50);
            this.lst_Message.Name = "lst_Message";
            this.lst_Message.Size = new System.Drawing.Size(379, 225);
            this.lst_Message.TabIndex = 4;
            // 
            // lst_ClientList
            // 
            this.lst_ClientList.FormattingEnabled = true;
            this.lst_ClientList.Location = new System.Drawing.Point(12, 333);
            this.lst_ClientList.Name = "lst_ClientList";
            this.lst_ClientList.Size = new System.Drawing.Size(379, 199);
            this.lst_ClientList.TabIndex = 5;
            // 
            // lbl_Clients
            // 
            this.lbl_Clients.AutoSize = true;
            this.lbl_Clients.Location = new System.Drawing.Point(12, 299);
            this.lbl_Clients.Name = "lbl_Clients";
            this.lbl_Clients.Size = new System.Drawing.Size(48, 13);
            this.lbl_Clients.TabIndex = 6;
            this.lbl_Clients.Text = "Client list";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(959, 540);
            this.Controls.Add(this.lbl_Clients);
            this.Controls.Add(this.lst_ClientList);
            this.Controls.Add(this.lst_Message);
            this.Controls.Add(this.btn_SendSelectClient);
            this.Controls.Add(this.btn_SendAll);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MulServer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Button btn_SendAll;
        private System.Windows.Forms.Button btn_SendSelectClient;
        private System.Windows.Forms.ListBox lst_Message;
        private System.Windows.Forms.ListBox lst_ClientList;
        private System.Windows.Forms.Label lbl_Clients;
        private System.Windows.Forms.Button btn_Exit;
    }
}

