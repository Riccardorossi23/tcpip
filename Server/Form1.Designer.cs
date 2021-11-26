namespace Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textport = new System.Windows.Forms.TextBox();
            this.txthost = new System.Windows.Forms.TextBox();
            this.txtsrt = new System.Windows.Forms.Button();
            this.txtstop = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "port";
            // 
            // textport
            // 
            this.textport.Location = new System.Drawing.Point(348, 40);
            this.textport.Name = "textport";
            this.textport.Size = new System.Drawing.Size(100, 20);
            this.textport.TabIndex = 2;
            this.textport.Text = "8910";
            // 
            // txthost
            // 
            this.txthost.Location = new System.Drawing.Point(104, 40);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(100, 20);
            this.txthost.TabIndex = 3;
            this.txthost.Text = "127.0.0.1";
            // 
            // txtsrt
            // 
            this.txtsrt.Location = new System.Drawing.Point(513, 43);
            this.txtsrt.Name = "txtsrt";
            this.txtsrt.Size = new System.Drawing.Size(75, 23);
            this.txtsrt.TabIndex = 4;
            this.txtsrt.Text = "Start";
            this.txtsrt.UseVisualStyleBackColor = true;
            this.txtsrt.Click += new System.EventHandler(this.srtbtn_Click);
            // 
            // txtstop
            // 
            this.txtstop.Location = new System.Drawing.Point(640, 43);
            this.txtstop.Name = "txtstop";
            this.txtstop.Size = new System.Drawing.Size(75, 23);
            this.txtstop.TabIndex = 5;
            this.txtstop.Text = "stop";
            this.txtstop.UseVisualStyleBackColor = true;
            this.txtstop.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(52, 85);
            this.txtstatus.Multiline = true;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(671, 302);
            this.txtstatus.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtstop);
            this.Controls.Add(this.txtsrt);
            this.Controls.Add(this.txthost);
            this.Controls.Add(this.textport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textport;
        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.Button txtsrt;
        private System.Windows.Forms.Button txtstop;
        private System.Windows.Forms.TextBox txtstatus;
    }
}

