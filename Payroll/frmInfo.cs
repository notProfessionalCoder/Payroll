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
    public partial class frmInfo : Form
    {
        string id;
        string connectionString;
        SqlConnection connection;
        public frmInfo(string empid)
        {
            id = empid;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["payrollSystem"].ConnectionString;
            loading();
        }
        private void loading()
        {
            string con = "Select * from Current_Employees where [Employee ID] = '" + id + "'";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                this.lblEmpres.Text = dt.Rows[0]["Name"].ToString();
                this.lblJobstatusres.Text = dt.Rows[0]["Job Status"].ToString();
                this.lblEmailres.Text = dt.Rows[0]["Email"].ToString();
                this.lblPhoneres.Text = dt.Rows[0]["Phone Number"].ToString();
                this.lblDepres.Text = dt.Rows[0]["Job Title"].ToString();
                this.lblAddressres.Text = dt.Rows[0]["Address"].ToString() + ", " + dt.Rows[0]["City"].ToString() + ", " + dt.Rows[0]["State"].ToString() + ", " + dt.Rows[0]["Zip Code"].ToString();
                this.lblAccountres.Text = dt.Rows[0]["accountNo"].ToString();
                this.lblRouteres.Text = dt.Rows[0]["routeNo"].ToString();
            }

        }

        private void frmInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
