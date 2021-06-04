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
    public partial class frmHRViewables : Form
    {
        string id;
        string connectionString;
        SqlConnection connection;
        public frmHRViewables(string hrid)
        {
            id = hrid;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["payrollSystem"].ConnectionString;
        }

        private void frmHRViewables_Load(object sender, EventArgs e)
        {

        }
        private DataSet BindingEmployeeInfo()
        {
            DataSet ds = new DataSet();
            string con = "SELECT * FROM Current_Employees ";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                adapter.Fill(ds, "Current_Employees"); // was set to "Requests" before the change
            }
            return ds;

        }
        private void BtnViewemp_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BindingEmployeeInfo().Tables[0];
        }
        private DataSet BindingEmployeePayment()
        {
            DataSet ds = new DataSet();
            string con = "SELECT * FROM Paycheck ";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                adapter.Fill(ds, "Paycheck"); // was set to "Requests" before the change
            }
            return ds;

        }
        private void BtnViewpay_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BindingEmployeePayment().Tables[0];
        }

        private void btnViewinactive_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BindingInactivePayment().Tables[0];
        }

        private DataSet BindingInactivePayment()
        {
            DataSet ds = new DataSet();
            string con = "SELECT * FROM Inactive_Employees ";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                adapter.Fill(ds, "Inactive_Employees");
            }
            return ds;

        }

        private void btnViewretired_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BindingRetiredPayment().Tables[0];
        }

        private DataSet BindingRetiredPayment()
        {
            DataSet ds = new DataSet();
            string con = "SELECT * FROM Retired_Employees ";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                adapter.Fill(ds, "Retired_Employees");
            }
            return ds;

        }
    }
}
