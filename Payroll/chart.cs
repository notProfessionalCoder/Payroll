using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Data.SqlClient;
using System.Configuration;
namespace Payroll
{
    public partial class chart : Form
    {
        string connectionString;
        SqlConnection connection;
        Socket socket;
        bool isConnect = false;
        string id;
        public chart(string eid)
        {
            id = eid;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["payrollSystem"].ConnectionString;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//建立socket
            IPAddress ipAdd = IPAddress.Parse("47.252.76.117");
            IPEndPoint ipAndPo = new IPEndPoint(ipAdd, 140);
            try
            {
                socket.Connect(ipAndPo);
                this.textBox1.AppendText("Connecting to the server....\r\n");
                isConnect = true;
            }
            catch (Exception)
            {
                this.textBox1.AppendText("The connection failed. Server is down.");
                isConnect = false;
            }
            this.textBox1.AppendText("You are now connected to the server!\r\n");
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(ReceiveMessage);
            t.Start();
        }
        public void ReceiveMessage()
        {
            while (isConnect)
            {
                byte[] brr = new byte[1024 * 100];
                try
                {
                    int num = socket.Receive(brr);
                    string str = Encoding.Default.GetString(brr, 0, num);
                    this.textBox1.AppendText(str);
                    this.textBox1.SelectionStart = this.textBox1.Text.Length;
                    this.textBox1.ScrollToCaret();

                }
                catch (Exception)
                {
                    Thread.CurrentThread.Abort();
                    MessageBox.Show("Server is disconnected.", "Disconnection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name;
            string con = "SELECT * FROM Current_Employees WHERE [Employee ID] = '" + id + "'";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                name = dt.Rows[0]["Name"].ToString();
            }
            if (!String.IsNullOrWhiteSpace(this.textBox2.Text))
            {
                if (isConnect)
                {
                    string str = name+'('+id+")  " + DateTime.Now.ToLongTimeString().ToString() + "\r\n" + this.textBox2.Text + "\r\n";
                    this.textBox2.Clear();
                    try
                    {
                        byte[] brr = Encoding.Default.GetBytes(str);
                        socket.Send(brr);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed connecting to the server.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Cannot send a blank text message!", "Blank Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            // the user can press send or enter to send the message
            if (e.KeyChar == (char)Keys.Enter)
            {
                    e.Handled = true;
                    button1.PerformClick();
            }

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.textBox2.AppendText("\r\n");
            }
        }
    }
}
