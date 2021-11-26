using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)

        {

            server = new SimpleTcpServer();

            server.Delimiter = 0x13;

            server.StringEncoder = Encoding.UTF8;

            server.DataReceived += Datareceived;

        }

        private void Datareceived(object sender, SimpleTCP.Message e)

        {

            txtstatus.Invoke((MethodInvoker)delegate ()

            {

                txtstatus.Text += e.MessageString;

                txtstatus.AppendText(Environment.NewLine);

                e.ReplyLine(string.Format("Il Server ha ricevuto il seguente messaggio: ", e.MessageString));
            
            });

        }

        private void srtbtn_Click(object sender, EventArgs e)

        {

            txtstatus.Text += "Server Starting to comunicate";

            txtstatus.AppendText(Environment.NewLine);

            IPAddress ip = IPAddress.Parse(txthost.Text);

            server.Start(ip, Convert.ToInt32(textport.Text));

        }

        private void stopbtn_Click(object sender, EventArgs e)

        {

            if (server.IsStarted)

            {

                server.Stop();

                txtstatus.Text = "Server Stopped";

               txtstatus.AppendText(Environment.NewLine);

            };
        }

    }
}
