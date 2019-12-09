using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Sample
{
    public partial class frmServer : Form
    {
        SimpleTCP.SimpleTcpServer server; //create reference to tcp server

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=sorular;Uid=root;Pwd='p3rd3_y4t4k_11';" +
            "AllowUserVariables=True;UseCompression=True");

        public frmServer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop(); //stop server if it is running
            txtStatus.Text += "Server Stopped";
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            server = new SimpleTCP.SimpleTcpServer(); //create new instance of server
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                string myMessage = e.MessageString.Substring(0, e.MessageString.Length - 1); //get string except last character
                txtStatus.Text += myMessage + Environment.NewLine; //display message to screen
                e.ReplyLine(string.Format("You said:" + myMessage)); //communicate back to client
            });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                mysqlbaglan.Open(); //oluşturtuğumuz tanımı çalıştırarak açılmasını sağlıyoruz
                txtsorugoster.Enabled = true;
                if (mysqlbaglan.State != ConnectionState.Closed)
                {
                    MessageBox.Show("Veritabani baglantisi basariyla gerceklesti!");
                }
                else
                {
                    MessageBox.Show("Maalesef baglanti yapilamadi!");
                }
                txtStatus.Text += "Server starting...." + Environment.NewLine;
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text); //get ip
                server.Start(ip, Convert.ToInt32(txtPort.Text));
            } //start servert with ip and port
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void txtsorugoster_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int number = r.Next(1, 2);
            string sqlsoru = "SELECT questions FROM `sorular`.`questions`";
            MySqlCommand komut = new MySqlCommand(sqlsoru, mysqlbaglan);
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string soru = dr["questions"].ToString();
                txtserversorugoster.Text = dr["questions"].ToString();
            }
            else
            {
                txtserversorugoster.Text = "veri cekilemedi";
            }
        }
    }
}
