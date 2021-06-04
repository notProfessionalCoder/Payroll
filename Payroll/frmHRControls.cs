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
    public partial class frmHRControls : Form
    {

        string connectionString;
        SqlConnection connection;
        public frmHRControls(string hrid)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["payrollSystem"].ConnectionString;
        }
        private void frmHRControls_Load(object sender, EventArgs e)
        {

        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddemp_Click(object sender, EventArgs e)
        {
            this.pnlADD.Visible = true;
            this.pnlDelete.Visible = false;
            this.pnlMod.Visible = false;
            this.pnlADD.BringToFront();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string eid = "101" + this.tbID.Text;
            string name = this.tbNAME.Text;
            string email = this.tbEMAIL.Text;
            int age = int.Parse(DateTime.Now.Year.ToString()) - int.Parse(dateTimePicker1.Value.Year.ToString());
            if (DateTime.Now.Month < dateTimePicker1.Value.Month
                || DateTime.Now.Month == dateTimePicker1.Value.Month && DateTime.Now.Day < dateTimePicker1.Value.Day)
            {
                age--;
            }
            string PN = this.tbPN.Text;
            string Add = this.tbADDRESS.Text;
            string st = this.cbState.Text;
            string city2 = this.tbCityTwo.Text;
            string zip2 = this.tbZipTwo.Text;
            string gd = this.cbGENDER.Text;
            string ins = this.cbINSURANCE.Text;
            string dis = this.cbDISABILITY.Text;
            string jobstatustwo = this.cbJobstatustwo.Text;
            string dent = this.cbDENTAL.Text;
            string marry = this.cbMARRY.Text;
            string route2 = this.tbRoutetwo.Text;
            string account2 = this.tbAccounttwo.Text;
            string package2 = this.cbPackagetwo.Text;
            string fourk = this.cb401kres.Text;
            bool fourkconv;
            string fourkper = this.cb401kpres.Text;
            decimal fourkperrate;

            if (fourk == "Yes")
                fourkconv = true;
            else if (fourk == "No")
                fourkconv = false;
            else
                fourkconv = false;

            if (fourkper == "0%")
                fourkperrate = 0.00M;
            else if (fourkper == "1%")
                fourkperrate = 0.01M;
            else if (fourkper == "2%")
                fourkperrate = 0.02M;
            else if (fourkper == "3%")
                fourkperrate = 0.03M;
            else
                fourkperrate = 0.00M;

            int dep;
            int.TryParse(tbDEPEND.Text, out dep); // without this command, an exception gets thrown
            //int dep = int.Parse(this.tbDEPEND.Text);
            string job = this.cbJOB.Text;
            decimal hrate;
            if (job == "Manager")
                hrate = 48.00M; // pay rate can be edited here
            else if (job == "Laborer")
                hrate = 21.00M; // pay rate can be edited here
            else if (job == "Secretary")
                hrate = 27.00M; // pay rate can be edited here
            else if (job == "Janitor")
                hrate = 19.00M; // pay rate can be edited here
            else
                hrate = 0M;

                string con = "INSERT INTO Current_Employees VALUES('" + eid + "','123','" + name + "','" + email + "','" + dateTimePicker1.Value.ToString() +
                "','" + age + "','" + PN + "','" + Add + "','" + city2 + "','" + st + "','" + zip2 + "','" + gd + "','" + ins + "','" + package2 + "','" + dis + "','" + dent + "','" + marry + "','" + dep + "','" + jobstatustwo + "','" + job +
                "','" + hrate + "','','','','" + fourkconv + "','" + fourkperrate + "','0','" + route2 + "','" + account2 + "')"; 

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(con, connection))
            {
                bool userExist = false; // needed so we can't add an employee ID that exist
                int success = 1; // to display the results

                if (eid == "101")
                {
                    MessageBox.Show("The employee ID field must be filled out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (eid.Length != 9)
                {
                    MessageBox.Show("The employee ID field must contain a total of 9 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex) // this is needed to make sure so we don't get the unhandled error exception
                    {
                        Console.WriteLine(ex.Message); // <- What's actually got wrong with it
                        userExist = true;
                        success = 0;
                        MessageBox.Show("This employee ID already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (userExist == false)
                    {
                        if (success > 0)
                        {
                            MessageBox.Show("User successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Error with input data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            string id = this.textBox2.Text;
            string con = "Select * from Current_Employees where [Employee ID] = '" + id + "'";
            string retID = "Select [Employee ID] from Current_Employees where [Employee ID] = '" + id + "'"; // for name compare

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                DataTable dt = new DataTable();
                int n = adapter.Fill(dt);
                if (id == "")
                {
                    MessageBox.Show("The ID field was left blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (n > 0)
                {
                    DataTable dt2 = new DataTable(); // maybe not needed
                    adapter.Fill(dt2); // maybe not needed
                    DateTime dtime = new DateTime();
                    System.Globalization.DateTimeFormatInfo dtFormat = new System.Globalization.DateTimeFormatInfo();
                    dtFormat.ShortDatePattern = "yyyy/MM/dd";
                    dtime = Convert.ToDateTime(dt.Rows[0]["Date of Birth"].ToString(), dtFormat);
                    this.tbmName.Text = dt.Rows[0]["Name"].ToString();
                    this.tbmPASSWORD.Text = dt.Rows[0]["Password"].ToString();
                    this.tbmEMAIL.Text = dt.Rows[0]["Email"].ToString();
                    this.dateTimePicker2.Value = dtime;
                    this.tbmPN.Text = dt.Rows[0]["Phone Number"].ToString();
                    this.tbmADDRESS.Text = dt.Rows[0]["Address"].ToString();
                    this.cbmSTATE.Text = dt.Rows[0]["State"].ToString();
                    this.tbCity.Text = dt.Rows[0]["City"].ToString();
                    this.tbZip.Text = dt.Rows[0]["Zip Code"].ToString();
                    this.cbmGENDER.Text = dt.Rows[0]["Gender"].ToString();
                    this.cbmINSURANCE.Text = dt.Rows[0]["Insurance"].ToString();
                    this.cbPackage.Text = dt.Rows[0]["Package"].ToString();
                    this.cbmDISABILITY.Text = dt.Rows[0]["Disability"].ToString();
                    this.cbmDENTAL.Text = dt.Rows[0]["Dental"].ToString();
                    this.cbmMARRY.Text = dt.Rows[0]["Marital Status"].ToString();
                    this.cbJobstatus.Text = dt.Rows[0]["Job Status"].ToString();
                    this.tbmDEPENDENT.Text = dt.Rows[0]["Dependents"].ToString();
                    this.tbRoute.Text = dt.Rows[0]["routeNo"].ToString();
                    this.tbAccount.Text = dt.Rows[0]["accountNo"].ToString();
                    this.cbmJOB.Text = dt.Rows[0]["Job Title"].ToString();

                    if (dt.Rows[0]["401K"].ToString() == "True")
                        this.cb401krestwo.Text = "Yes";
                    else
                        this.cb401krestwo.Text = "False";

                    this.cb401kprestwo.Text = dt.Rows[0]["401K Percent"].ToString();
                }
                else
                {
                    MessageBox.Show("The user was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (tbmDEPENDENT.Text == "") // this code is needed to fix the unexpected handling error for the empty textbox on dependents
            {
                tbmDEPENDENT.Text = "0";
            }

            string con = "UPDATE Current_Employees SET Password = @pass , Name = @name , Email = @email , " +
                "[Date of Birth] = @birth , Age = @age , [Phone Number] = @PNumber , Address = @address , City = @city, [Zip Code] = @zip , " +
                "State = @state , Gender = @gender , Insurance = @insurance , Package = @package , Disability = @disability , [Job Status] = @jobstatus , " +
                "Dental = @dental , [Marital Status] = @marry , Dependents = @depend , [Job Title] = @job , [401K] = @401k , [401K Percent] = @401KP , accountNo = @account , routeNo = @route , "  +
                "[Hourly Rate] = @HourR WHERE [Employee ID] = @id";
            string id = this.textBox2.Text;
            string name = this.tbmName.Text;
            string email = this.tbmEMAIL.Text;
            int age = int.Parse(DateTime.Now.Year.ToString()) - int.Parse(dateTimePicker2.Value.Year.ToString());
            if (DateTime.Now.Month < dateTimePicker1.Value.Month
                || DateTime.Now.Month == dateTimePicker1.Value.Month && DateTime.Now.Day < dateTimePicker1.Value.Day)
            {
                age--;
            }
            string PN = this.tbmPN.Text;
            string Add = this.tbmADDRESS.Text;
            string st = this.cbmSTATE.Text;
            string city = this.lblCity.Text;
            string zip = this.lblZip.Text;
            string gd = this.cbmGENDER.Text;
            string ins = this.cbmINSURANCE.Text;
            string package = this.cbPackage.Text;
            string dis = this.cbmDISABILITY.Text;
            string dent = this.cbmDENTAL.Text;
            string marry = this.cbmMARRY.Text;
            string jobstatus = this.cbJobstatus.Text;
            int dep = int.Parse(this.tbmDEPENDENT.Text);
            string account = this.tbAccount.Text;
            string route = this.tbRoute.Text;
            string job = this.cbmJOB.Text;
            string fourkrestwo = this.cb401krestwo.Text;
            string fourkperrestwo = this.cb401kprestwo.Text;
            bool fourktwo;

            if (fourkrestwo == "Yes")
                fourktwo = true;
            else if (fourkrestwo == "No")
                fourktwo = false;
            else
                fourktwo = false;

            decimal hrate;
            if (job == "Manager")
                hrate = 48.00M;
            else if (job == "Laborer")
                hrate = 21.00M;
            else if (job == "Secretary")
                hrate = 27.00M;
            else if (job == "Janitor")
                hrate = 19.00M;
            else
                hrate = 0M;

            decimal fourkper;
            if (cb401kprestwo.Text == "0%")
                fourkper = 0.00M;
            else if (cb401kprestwo.Text == "1%")
                fourkper = 0.01M;
            else if (cb401kprestwo.Text == "2%")
                fourkper = 0.02M;
            else if (cb401kprestwo.Text == "3%")
                fourkper = 0.03M;
            else
                fourkper = 0.00M;

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(con, connection))
            {
                command.Parameters.AddWithValue("@pass", this.tbmPASSWORD.Text);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@birth", dateTimePicker1.Value.Date);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@PNumber", PN);
                command.Parameters.AddWithValue("@address", Add);
                command.Parameters.AddWithValue("@state", st);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@zip", zip);
                command.Parameters.AddWithValue("@gender", gd);
                command.Parameters.AddWithValue("@insurance", ins);
                command.Parameters.AddWithValue("@package", package);
                command.Parameters.AddWithValue("@disability", dis);
                command.Parameters.AddWithValue("@dental", dent);
                command.Parameters.AddWithValue("@marry", marry);
                command.Parameters.AddWithValue("@jobstatus", jobstatus);
                command.Parameters.AddWithValue("@depend", dep);
                command.Parameters.AddWithValue("@account", account);
                command.Parameters.AddWithValue("@route", route);
                command.Parameters.AddWithValue("@job", job);
                command.Parameters.AddWithValue("@HourR", hrate);
                command.Parameters.AddWithValue("@401K", fourktwo);
                command.Parameters.AddWithValue("@401KP", fourkper);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Information successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error updating user information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                string con = "INSERT INTO Inactive_Employees([Employee ID], [Name], [Password], [Email], [Date of Birth], [Age], [Phone Number], [Address], [State], [City], [Zip Code], [Gender], [Insurance], [Package], [Disability], [Dental], [Marital Status], [Hourly Rate], [Salary], [Dependents], [Job Status], [Job Title]," +
                    "[Net Income], [Gross Income], [401K], [401K Percent], [401K Saved], [routeNo], [accountNo]) SELECT [Employee ID], [Name], [Password], [Email], [Date of Birth], [Age], [Phone Number], [Address], [State], [City], [Zip Code], [Gender], [Insurance], [Package], [Disability], [Dental], [Marital Status], [Hourly Rate], [Salary], [Dependents], [Job Status], [Job Title]," +
                    "[Net Income], [Gross Income], [401K], [401K Percent], [401K Saved], [routeNo], [accountNo] FROM Current_Employees WHERE [Employee ID] = '" + this.textBox12.Text + "'";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(con, connection))
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("User was successfully moved to the Inactive database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error moving the user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con = "DELETE FROM Current_Employees WHERE [Employee ID] = @id";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(con, connection))
                {
                    command.Parameters.AddWithValue("@id", this.textBox12.Text);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("User was successfully removed from active employees.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error deleting user from active database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (this.radioButton2.Checked)
            {
                string con = "INSERT INTO Retired_Employees([Employee ID], [Name], [Password], [Email], [Date of Birth], [Age], [Phone Number], [Address], [State], [City], [Zip Code], [Gender], [Insurance], [Package], [Disability], [Dental], [Marital Status], [Hourly Rate], [Salary], [Dependents], [Job Status], [Job Title]," +
                    "[Net Income], [Gross Income], [401K], [401K Percent], [401K Saved], [routeNo], [accountNo]) SELECT [Employee ID], [Name], [Password], [Email], [Date of Birth], [Age], [Phone Number], [Address], [State], [City], [Zip Code], [Gender], [Insurance], [Package], [Disability], [Dental], [Marital Status], [Hourly Rate], [Salary], [Dependents], [Job Status], [Job Title]," +
                    "[Net Income], [Gross Income], [401K], [401K Percent], [401K Saved], [routeNo], [accountNo] FROM Current_Employees WHERE [Employee ID] = '" + this.textBox12.Text + "'";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(con, connection))
                {
                    //if ()
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("User was successfully moved to the retired database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error moving the user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con = "DELETE FROM Current_Employees WHERE [Employee ID] = @id";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(con, connection))
                {
                    command.Parameters.AddWithValue("@id", this.textBox12.Text);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("User was successfully removed from active employees.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("There was an error deleting the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (this.radioButton3.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string con = "DELETE FROM Current_Employees WHERE [Employee ID] = @id";
                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(con, connection))
                    {
                        command.Parameters.AddWithValue("@id", this.textBox12.Text);
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("User was successfully deleted from active employees!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("There was an error deleting the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    // don't need code here
                }
            }
            else
                MessageBox.Show("Please select an option.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        } 

        private void BtnModemp_Click(object sender, EventArgs e)
        {
            this.pnlADD.Visible = false;
            this.pnlDelete.Visible = false;
            this.pnlMod.Visible = true;
            this.pnlMod.BringToFront();
        }

        private void BtmpDelemp_Click(object sender, EventArgs e)
        {
            this.pnlADD.Visible = false;
            this.pnlDelete.Visible = true;
            this.pnlMod.Visible = false;
            this.pnlDelete.BringToFront();
        }

        private void tbmDEPENDENT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbDEPEND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbRoutetwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbAccounttwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
