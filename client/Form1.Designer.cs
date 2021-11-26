namespace client
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
            this.txthost = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.Label();
            this.connectbtn = new System.Windows.Forms.Button();
            this.textport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txthost
            // 
            this.txthost.Location = new System.Drawing.Point(63, 25);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(100, 20);
            this.txthost.TabIndex = 11;
            this.txthost.Text = "127.0.0.1";
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.Location = new System.Drawing.Point(353, 27);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(25, 13);
            this.port.TabIndex = 10;
            this.port.Text = "port";
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(595, 25);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(84, 23);
            this.connectbtn.TabIndex = 9;
            this.connectbtn.Text = "Connessione";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // textport
            // 
            this.textport.Location = new System.Drawing.Point(399, 25);
            this.textport.Name = "textport";
            this.textport.Size = new System.Drawing.Size(100, 20);
            this.textport.TabIndex = 8;
            this.textport.Text = "8910";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "host";
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(20, 79);
            this.txtstatus.Multiline = true;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(650, 114);
            this.txtstatus.TabIndex = 12;
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(692, 215);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 23);
            this.sendbtn.TabIndex = 13;
            this.sendbtn.Text = "send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(29, 266);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(641, 181);
            this.txtmsg.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtmsg);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txthost);
            this.Controls.Add(this.port);
            this.Controls.Add(this.connectbtn);
            this.Controls.Add(this.textport);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.TextBox textport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.TextBox txtmsg;
    }
}

