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
using System.Diagnostics;

namespace Payroll
{
    public partial class frmEmployee: Form
    {
        string connectionString;
        SqlConnection connection;
        string employeeId;
        public frmEmployee(string empid)
        {
            employeeId = empid;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["payrollSystem"].ConnectionString;
            loading();
            loadBenefits();
            loadPaymentInfo();
            loadPersonInfo();
            loadSearch();
            loadClock();
            loadDispute();
            loadChart();
        }
        private Point mPoint;
        private void loading()
        {
            string con = "SELECT * FROM Current_Employees WHERE [Employee ID] = '" + employeeId + "'";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                this.lblEmp.Text = dt.Rows[0]["Name"].ToString();
            }
            this.Times.Text = DateTime.Now.ToString("d");
        }
        //loadallform
        #region 
        private void loadChart()
        {
            this.panel2.Controls.Clear();
            chart c = new chart(employeeId);
            c.TopLevel = false;
            c.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(c);
            c.Show();
        }
        private void loadBenefits()
        {
            this.pnlBenefits.Controls.Clear();
            frmBenefit benefit = new frmBenefit(employeeId);
            benefit.TopLevel = false;
            benefit.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlBenefits.Controls.Add(benefit);
            benefit.Show();
        }
        private void loadPaymentInfo()
        {
            this.pnlPaymentInfo.Controls.Clear();
            frmPaymentInfo paymentinfo = new frmPaymentInfo(employeeId);
            paymentinfo.TopLevel = false;
            paymentinfo.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlPaymentInfo.Controls.Add(paymentinfo);
            paymentinfo.Show();
        }
        private void loadPersonInfo()
        {
            this.pnlPersonInfo.Controls.Clear();
            frmInfo information = new frmInfo(employeeId);
            information.TopLevel = false;
            information.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlPersonInfo.Controls.Add(information);
            information.Show();
        }
        private void loadSearch()
        {
            this.pnlSearch.Controls.Clear();
            frmSearchOthers SH = new frmSearchOthers();
            SH.TopLevel = false;
            SH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlSearch.Controls.Add(SH);
            SH.Show();
        }
        private void loadClock()
        {
            this.pnlClock.Controls.Clear();
            frmClockInOut clockinout = new frmClockInOut(employeeId);
            clockinout.TopLevel = false;
            clockinout.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlClock.Controls.Add(clockinout);
            clockinout.Show();
        }
        private void loadDispute()
        {
            this.pnlDispute.Controls.Clear();
            frmSubDispute subdispute = new frmSubDispute(employeeId);
            subdispute.TopLevel = false;
            subdispute.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlDispute.Controls.Add(subdispute);
            subdispute.Show();
        }
        #endregion

        private void btnBenefits_Click(object sender, EventArgs e)
        {
            this.pnlClock.Visible = false;
            this.pnlDispute.Visible = false;
            this.pnlPaymentInfo.Visible = false;
            this.pnlPersonInfo.Visible = false;
            this.pnlSearch.Visible = false;
            this.pnlBackground.Visible = false;
            this.pnlBenefits.Visible = true;
            this.pnlBenefits.BringToFront();
        }
        #region
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }
        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (var process in Process.GetProcessesByName("Payroll"))
                {
                    process.Kill();
                }
                Application.ExitThread();
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                // don't need code here
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void pnlBackground_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
        private void btnPersInfo_Click(object sender, EventArgs e)
        {
            this.pnlBackground.Visible = false;
            this.pnlBenefits.Visible = false;
            this.pnlClock.Visible = false;
            this.pnlDispute.Visible = false;
            this.pnlPaymentInfo.Visible = false;
            this.pnlPersonInfo.Visible = true;
            this.pnlSearch.Visible = false;
            this.panel2.Visible = false;
            this.pnlPersonInfo.BringToFront();
        }
        private void btnSearchOthr_Click_1(object sender, EventArgs e)
        {
            this.pnlBackground.Visible = false;
            this.pnlBenefits.Visible = false;
            this.pnlClock.Visible = false;
            this.pnlDispute.Visible = false;
            this.pnlPaymentInfo.Visible = false;
            this.pnlPersonInfo.Visible = false;
            this.pnlSearch.Visible = true;
            this.panel2.Visible = false;
            this.pnlSearch.BringToFront();
        }

        private void btnExitTop_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("Payroll"))
            {
                process.Kill();
            }
            Application.ExitThread();
            Application.Exit();
        }

        private void btnPayInfo_Click(object sender, EventArgs e)
        {
            this.pnlBackground.Visible = false;
            this.pnlBenefits.Visible = false;
            this.pnlClock.Visible = false;
            this.pnlDispute.Visible = false;
            this.pnlPaymentInfo.Visible = true;
            this.pnlPersonInfo.Visible = false;
            this.pnlSearch.Visible = false;
            this.panel2.Visible = false;
            this.pnlPaymentInfo.BringToFront();
        }

        private void btnClockio_Click(object sender, EventArgs e)
        {
            this.pnlBackground.Visible = false;
            this.pnlBenefits.Visible = false;
            this.pnlClock.Visible = true;
            this.pnlDispute.Visible = false;
            this.pnlPaymentInfo.Visible = false;
            this.pnlPersonInfo.Visible = false;
            this.pnlSearch.Visible = false;
            this.panel2.Visible = false;
            this.pnlClock.BringToFront();
        }

        private void btnSubDispute_Click(object sender, EventArgs e)
        {
            this.pnlBackground.Visible = false;
            this.pnlBenefits.Visible = false;
            this.pnlClock.Visible = false;
            this.pnlDispute.Visible = true;
            this.pnlPaymentInfo.Visible = false;
            this.pnlPersonInfo.Visible = false;
            this.pnlSearch.Visible = false;
            this.panel2.Visible = false;
            this.pnlDispute.BringToFront();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin Login = new frmLogin();
            Login.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.pnlBackground.Visible = false;
            this.pnlBenefits.Visible = false;
            this.pnlClock.Visible = false;
            this.pnlDispute.Visible = false;
            this.pnlPaymentInfo.Visible = false;
            this.pnlPersonInfo.Visible = false;
            this.pnlSearch.Visible = false;
            this.panel2.Visible = true;
            this.panel2.BringToFront();
        }
    }
}
