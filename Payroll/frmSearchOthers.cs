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
    public partial class frmSearchOthers : Form
    {
        string connectionString;
        SqlConnection connection;
        public frmSearchOthers()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["payrollSystem"].ConnectionString;
        }

        private void Search_history_Load(object sender, EventArgs e)
        {

        }
        private void BtnSearchnow_Click(object sender, EventArgs e)
        {
            string empid = tbID.Text;
            string name = tbName.Text;
            string con = "SELECT * FROM Current_Employees WHERE [Employee ID] = '" + empid + "' AND Name = '" + name + "'";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                DataTable dt = new DataTable();
                int n = adapter.Fill(dt);
                if(this.tbName.Text == string.Empty && this.tbID.Text == string.Empty)
                {
                    this.lblSearchqryres.Text = "Error!\nName and ID field \nare empty!";
                    this.lblSearchqryres.Visible = true;
                }
                else if (n > 0)
                {
                    this.lblSearchqryres.Text = "User Found!\nDisplaying\nResults below.";
                    this.lblSearchqryres.Visible = true;
                    this.lblFnameres.Text = dt.Rows[0]["Name"].ToString();
                    this.lblDepres.Text = dt.Rows[0]["Job Title"].ToString();
                    this.lblEmpidres.Text = dt.Rows[0]["Employee ID"].ToString();
                    this.lblEmailres.Text = dt.Rows[0]["Email"].ToString();
                    this.lblPhoneres.Text = dt.Rows[0]["Phone Number"].ToString();
                }
                else
                {
                    this.lblSearchqryres.Text = "User not found!";
                    this.lblSearchqryres.Visible = true;

                }

            }
        }
    }
}
