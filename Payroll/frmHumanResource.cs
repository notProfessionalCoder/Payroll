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
    public partial class Human_Resource : Form
    {
        string connectionString;
        SqlConnection connection;
        string hrTeamid;
        private Point mPoint;

        public Human_Resource(string hrid)
        {
            hrTeamid = hrid;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["payrollSystem"].ConnectionString;
            loading();
            loadDispute();
            loadEmployee();
            loadPayment();
            loadInfo();
            loadChart();
        }
        private void loading()
        {
            string con = "SELECT * FROM Current_Employees WHERE [Employee ID] = '" + hrTeamid + "'";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                this.lblHRname.Text = dt.Rows[0]["Name"].ToString();
            }
            this.Times.Text = DateTime.Now.ToString("d");
        }
        private void loadChart()
        {
            this.panel2.Controls.Clear();
            chart c = new chart(hrTeamid);
            c.TopLevel = false;
            c.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.panel2.Controls.Add(c);
            c.Show();
        }
        private void loadDispute()
        {
            this.pnlDispute.Controls.Clear();
            frmHRDispute dispute = new frmHRDispute(hrTeamid);
            dispute.TopLevel = false;
            dispute.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlDispute.Controls.Add(dispute);
            dispute.Show();
        }
        private void loadEmployee()
        {
            this.pnlEmployee.Controls.Clear();
            frmHRControls controls = new frmHRControls(hrTeamid);
            controls.TopLevel = false;
            controls.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlEmployee.Controls.Add(controls);
            controls.Show();
        }
        private void loadInfo()
        {
            this.pnlInfo.Controls.Clear();
            frmHRViewables empinfo = new frmHRViewables(hrTeamid);
            empinfo.TopLevel = false;
            empinfo.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlInfo.Controls.Add(empinfo);
            empinfo.Show();
        }
        private void loadPayment()
        {
            this.pnlPaycheck.Controls.Clear();
            frmHRPayemps empPayment = new frmHRPayemps(hrTeamid);
            empPayment.TopLevel = false;
            empPayment.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlPaycheck.Controls.Add(empPayment);
            empPayment.Show();
        }
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

        private void Human_Resource_MouseDown(object sender, MouseEventArgs e)
        {
              mPoint = new Point(e.X, e.Y);
        }
        private void Human_Resource_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

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

        private void btnX_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("Payroll"))
            {
                process.Kill();
            }
            Application.ExitThread();
            Application.Exit();
        }

        private void Human_Resource_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpcontrols_Click(object sender, EventArgs e)
        {
            loadEmployee();
            this.pnlDispute.Visible = false;
            this.pnlEmployee.Visible = true;
            this.pnlInfo.Visible = false;
            this.pnlPaycheck.Visible = false;
            this.panel2.Visible = false;
            this.pnlEmployee.BringToFront();
        }

        private void btnEmpinfo_Click(object sender, EventArgs e)
        {
            this.pnlDispute.Visible = false;
            this.pnlEmployee.Visible = false;
            this.pnlInfo.Visible = true;
            this.pnlPaycheck.Visible = false;
            this.panel2.Visible = false;
            this.pnlInfo.BringToFront();
        }

        private void btnSubpay_Click(object sender, EventArgs e)
        {
            this.pnlDispute.Visible = false;
            this.pnlEmployee.Visible = false;
            this.pnlInfo.Visible = false;
            this.pnlPaycheck.Visible = true;
            this.panel2.Visible = false;
            this.pnlPaycheck.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.pnlDispute.Visible = true;
            this.pnlEmployee.Visible = false;
            this.pnlInfo.Visible = false;
            this.pnlPaycheck.Visible = false;
            this.panel2.Visible = false;
            this.pnlDispute.BringToFront();
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

        private void Button2_Click(object sender, EventArgs e)
        {
            this.pnlDispute.Visible = false;
            this.pnlEmployee.Visible = false;
            this.pnlInfo.Visible = false;
            this.pnlPaycheck.Visible = false;
            this.panel2.Visible = true;
            this.panel2.BringToFront();
        }
    }
}
