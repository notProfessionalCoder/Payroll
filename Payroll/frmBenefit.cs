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
    public partial class frmBenefit : Form
    {
        string id;
        string connectionString;
        SqlConnection connection;
        public frmBenefit(string empid)
        {
            id = empid;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["payrollSystem"].ConnectionString;
        }

        private void Benefit_Load(object sender, EventArgs e)
        {
            string jobStatus;
            string con = "SELECT * FROM Current_Employees WHERE [Employee ID] = '" + id + "'";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                this.lblHealthres.Text = dt.Rows[0]["Insurance"].ToString();
                this.lblPackageres.Text = dt.Rows[0]["Package"].ToString();
                this.lblDisabilityres.Text = dt.Rows[0]["Disability"].ToString();
                this.lblDentalres.Text = dt.Rows[0]["Dental"].ToString();
                this.lblDependentsres.Text = dt.Rows[0]["Dependents"].ToString();
                this.lblFourkres.Text = dt.Rows[0]["401K"].ToString();
                jobStatus = dt.Rows[0]["Job Status"].ToString();

            }

            if (jobStatus == "Full Time")
            {
                lblVacationres.Text = "80.00 Hours";
                lblSickres.Text = "40.00 Hours";
                lblHolidayres.Text = "7 Days";
                lblFholidayres.Text = "2 Days";
            }
            else
            {
                lblVacationres.Text = "TBD";
                lblSickres.Text = "TBD";
                lblHolidayres.Text = "TBD";
                lblFholidayres.Text = "TBD";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // https://www.dol.gov/whd/forms/wh347instr.htm - something i was looking at for benefits
            System.Diagnostics.Process.Start("http://www.google.com");
        }
    }
}
