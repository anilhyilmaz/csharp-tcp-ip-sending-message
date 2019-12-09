using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Client
{
    public partial class frmClient : Form
    {
        SimpleTCP.SimpleTcpClient tcpClient; //create reference to client
        public frmClient()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false; //disable button
            tcpClient = new SimpleTCP.SimpleTcpClient().Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
            btnSend.Enabled = true; //enable send
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string myMessage;
            myMessage = tcpClient.WriteLineAndGetReply(txtMessage.Text, TimeSpan.FromSeconds(3)).MessageString;
            myMessage = myMessage.Substring(0, myMessage.Length - 1);
            txtStatus.Text += myMessage + Environment.NewLine;
        }

        private void txtsorugoster_Click(object sender, EventArgs e)
        {
        }
    }
}
