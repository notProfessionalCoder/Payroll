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
    public partial class frmPaymentInfo : Form
    {
        string id;
        string connectionString;
        SqlConnection connection;
        public frmPaymentInfo(string empid)
        {
            id = empid;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["payrollSystem"].ConnectionString;
        }

        private void frmPaymentInfo_Load(object sender, EventArgs e)
        {
            int Hour, Min;
            decimal money, payrate;
            string con = "SELECT TOP 1 * FROM Paycheck WHERE [Employee ID] = '"+id+"' ORDER BY submitDate desc";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                DataTable dt = new DataTable();
                int n = adapter.Fill(dt);
                if (n > 0)
                {
                    this.lblPaychangecur.Text = '$' + dt.Rows[0]["Pay Rate"].ToString();
                    Hour = int.Parse(dt.Rows[0]["Paid Hours in s"].ToString());
                    Hour /= 3600;
                    Min = int.Parse(dt.Rows[0]["Paid Hours in s"].ToString());
                    Min = (Min / 60) - (Hour * 60);
                    payrate = decimal.Parse(dt.Rows[0]["Pay Rate"].ToString());
                    money = (Hour * payrate) + (Min * payrate / 60);
                    this.lblHourschangecur.Text = Hour.ToString() + '.' + Min.ToString();
                    this.lblEarnedchangecur.Text = '$' + money.ToString();
                }
                else
                {
                    string con2 = "SELECT * FROM Current_Employees WHERE [Employee ID] = '" + id + "'";
                    using (connection = new SqlConnection(connectionString))
                    using (SqlDataAdapter adapter2 = new SqlDataAdapter(con2, connection))
                    {
                        DataTable dt2 = new DataTable();
                        adapter2.Fill(dt2);
                        this.lblPaychangecur.Text = '$' + dt2.Rows[0]["Hourly Rate"].ToString();
                    }
                    MessageBox.Show("You currently do not have any paychecks.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string con = "SELECT * FROM Paycheck WHERE submitDate = '" + this.dateTimePicker1.Value.ToString() + "' and [Employee ID]" +
                " = '" + id + "'";
            int Hour, Min;
            decimal money,payrate;
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                DataTable dt = new DataTable();
                int n = adapter.Fill(dt);
                if (n > 0)
                {
                    Hour = int.Parse(dt.Rows[0]["Paid Hours in s"].ToString());
                    Hour /= 3600;
                    Min = int.Parse(dt.Rows[0]["Paid Hours in s"].ToString());
                    Min = (Min / 60) - (Hour * 60);
                    payrate = decimal.Parse(dt.Rows[0]["Pay Rate"].ToString());
                    money = (Hour * payrate) + (Min * payrate / 60);
                    this.lblHourschangepas.Text = Hour.ToString() + '.' + Min.ToString();
                    this.lblEarnedchangepas.Text = '$' + money.ToString();
                    this.lblDatechangepas.Text = dt.Rows[0]["submitDate"].ToString();
                    this.lblPaychangepas.Text = dt.Rows[0]["Pay Rate"].ToString();
                }
                else
                    MessageBox.Show("You did not submit a paycheck on " + this.dateTimePicker1.Value.Date.ToLongDateString() + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
