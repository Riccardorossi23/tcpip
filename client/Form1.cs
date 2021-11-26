using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();

            client.StringEncoder = Encoding.UTF8;

            client.DataReceived += Client_Datareceived;

        }

        private void Client_Datareceived(object sender,
        SimpleTCP.Message e)

        {

            txtstatus.Invoke((MethodInvoker)delegate ()

            {

                txtstatus.Text += e.MessageString;

                txtstatus.AppendText(Environment.NewLine);

            });

        }

        private void sendbtn_Click(object sender, EventArgs e)

        {

            try

            {

                client.Connect(txthost.Text, Convert.ToInt32(textport.Text));

                client.WriteLineAndGetReply(txtmsg.Text,
                TimeSpan.FromSeconds(5));

                txtstatus.Text += "Messaggio Inviato";

                txtstatus.AppendText(Environment.NewLine);

            }

            catch (Exception)

            {

                txtstatus.Text += "Errore, mancata connessione al server.";

                txtstatus.AppendText(Environment.NewLine);

            }

        }
        private void connectbtn_Click(object sender, EventArgs e)

        {

            try

            {

                connectbtn.Enabled = false;

                client.Connect(txthost.Text, Convert.ToInt32(textport.Text));

                txtstatus.Text += "Server connesso.";

                txtstatus.AppendText(Environment.NewLine);

            }

            catch (Exception)

            {

                txtstatus.Text += "Errore, mancata connessione al server.";

                txtstatus.AppendText(Environment.NewLine);

                connectbtn.Enabled = true;

            }

        }
    }
}
