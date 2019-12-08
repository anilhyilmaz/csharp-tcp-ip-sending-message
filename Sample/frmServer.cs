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
        MySqlConnection baglanti;
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
            string bag;
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
            build.UserID = "root";
            build.Password = "p3rd3_y4t4k_11";
            build.Database = "sorular";
            build.Server = "localhost";
            build.Server = "localhost";

            bag = build.ToString();
            baglanti = new MySqlConnection(bag);

            baglanti.Open();
            MessageBox.Show("baglanti açıldı");


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
            txtStatus.Text += "Server starting...." + Environment.NewLine;
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text); //get ip
            server.Start(ip, Convert.ToInt32(txtPort.Text)); //start servert with ip and port
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM questions";
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = sql;
            command.Connection = baglanti;
            adapter.SelectCommand = command;

            //baglanti.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
