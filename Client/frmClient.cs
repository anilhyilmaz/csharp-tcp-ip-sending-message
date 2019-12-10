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
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=sorular;Uid=root;Pwd='p3rd3_y4t4k_11';" +
            "AllowUserVariables=True;UseCompression=True");
        public frmClient()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false; //disable button
            tcpClient = new SimpleTCP.SimpleTcpClient().Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
            btnSend.Enabled = true; //enable send

            Random r = new Random();
            int number = r.Next(1, 2);
            string sqlsoru = "SELECT questions FROM `sorular`.`questions`";
            MySqlCommand komut = new MySqlCommand(sqlsoru, mysqlbaglan);
            mysqlbaglan.Open();
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string soru = dr["questions"].ToString();
                txtclientsorugoster.Text = dr["questions"].ToString();
            }
            else
            {
                txtclientsorugoster.Text = "veri cekilemedi";
            }
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
            string cevap = Convert.ToString(txtMessage.Text);
            string correct_answer = "ankara";
            int sonuc = string.Compare(cevap, correct_answer);
            if (sonuc==1)
            {
                tcpClient.Disconnect();
                txtStatus.Text += "Yanlış bildiniz, butonlar kapatılıyor!";
                btnSend.Enabled = false;
                txtsorugoster.Enabled = false;
            }
            else
            {
                txtStatus.Text += "Dogru bildiniz!";
            }
        }
    }
}
