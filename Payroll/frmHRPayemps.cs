using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Payroll
{
    public partial class frmHRPayemps : Form
    {
        string id;
        string connectionString;
        SqlConnection connection;
        public frmHRPayemps(string hrid)
        {
            id = hrid;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["payrollSystem"].ConnectionString;
        }
        private void btnPayemp_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form F in Application.OpenForms)
            {
                if (F.Name == "PrintPage")
                {
                    isOpen = true;
                    F.BringToFront();
                }
            }

            if (isOpen == false)
            {
                string payid = this.textBox1.Text;
                string checkno = this.textBox2.Text;
                PrintPage pg = new PrintPage(payid,checkno);
                pg.Show();
            }

            /*PrinterHelper pt = new PrinterHelper();
            string con = "SELECT [Employee ID],[Pay Rate],[Paid Hours],[Gross Pay],[Net Pay] FROM Paycheck";
            DataTable dt = new DataTable();
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                adapter.Fill(dt);
            }
            pt.PrintPriview(dt, "test");
            //pt.Print(dt, "test");*/

        }

        private void FrmHRPayemps_Load(object sender, EventArgs e)
        {
           
        }
    }
}
