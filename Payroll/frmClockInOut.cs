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
    public partial class frmClockInOut: Form
    {
        string connectionString;
        SqlConnection connection;
        string employeeId;
        long totalTime, currentTime = 0;
        double FIT, SST = 0.062, MT = 0.0145, SIT, SLT, FICA = 0.0765, FamilyLeave,F401,benefit = 0;
        public frmClockInOut(string empid)
        {
            employeeId = empid;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["payrollSystem"].ConnectionString;
        }
        private void frmClockInOut_Load(object sender, EventArgs e)
        {
            long hour, min, sec;
            string con = "SELECT * FROM Clock WHERE [Employee ID]='" + employeeId + "'";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
            {
                DataTable dt = new DataTable();
                int n = adapter.Fill(dt);
                if(n > 0)
                {
                    totalTime = long.Parse(dt.Rows[0]["Hour"].ToString());
                    hour = totalTime / 3600;
                    min = (totalTime / 60) - (hour * 60);
                    sec = totalTime % 60;
                    this.label1.Text = hour.ToString("00") + " : " + min.ToString("00") + " : " + sec.ToString("00");
                }
                else
                {
                    addClock();
                }
            }
        }
        private void addClock()
        {
            string con = "INSERT INTO Clock VALUES(@id, 0 )";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(con, connection))
            {
                command.Parameters.AddWithValue("@id", employeeId);
                connection.Open();
                //command.ExecuteNonQuery(); // NOT NEEDED TWICE!
                int result = command.ExecuteNonQuery();
                // Check Error
                if (result < 0)
                    MessageBox.Show("Error inserting data into Database!");
            }
        }

        private void btnClockout_Click(object sender, EventArgs e)
        {
            long hour, min, sec;
            timer1.Enabled = false;
            this.label2.Text = "00 : 00 : 00";
            totalTime += currentTime;
            currentTime = 0;
            string con = "UPDATE Clock SET Hour = @time WHERE [Employee ID] = @id";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(con, connection))
            {
                command.Parameters.AddWithValue("@id", employeeId);
                command.Parameters.AddWithValue("@time", totalTime);
                connection.Open();
                command.ExecuteNonQuery();
                int result = command.ExecuteNonQuery();
                // Check Error
                if (result < 0)
                    MessageBox.Show("Error inserting data into database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            hour = totalTime / 3600;
            min = (totalTime / 60) - (hour * 60);
            sec = totalTime % 60;
            this.label1.Text = hour.ToString("00") + " : " + min.ToString("00") + " : " + sec.ToString("00");

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            currentTime++;
            long hour = currentTime / 3600;
            long min = (currentTime / 60) - (hour * 60);
            long sec = currentTime % 60;
            this.label2.Text = hour.ToString("00") + " : " + min.ToString("00") + " : " + sec.ToString("00");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Work time has stopped.", "Stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double overpaycal(int hwis, double r)
        {
            if(hwis > 144000)
            {
                int overpay = hwis - 144000;
                double totalpay;
                totalpay = ((overpay * r * 1.5) / 3600) + (40 * r);
                return totalpay;
            }
            else
            {
                return (hwis * r) / 3600;
            }
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            string rNo, aNo;
            if (MessageBox.Show("Please make sure you submit each timesheet every week on Friday!", "Warning", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                double cal;
                int hour_work_insec;
                decimal salary;
                string marry, state,ins,dis,den;
                double totalpay,netpay,rate;
                double F401KP = 0;
                string con = "Select Hour FROM Clock Where [Employee ID] = '" + employeeId + "'";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(con, connection))
                {
                    connection.Open();
                    hour_work_insec = int.Parse(command.ExecuteScalar().ToString());
                }
                con = "SELECT * FROM Current_Employees Where [Employee ID] = '" + employeeId + "'";
                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(con, connection))
                {
                    DataTable dt = new DataTable();
                    int n = adapter.Fill(dt);
                    if (n > 0)
                    {
                        salary = decimal.Parse(dt.Rows[0]["Salary"].ToString());
                        marry = dt.Rows[0]["Marital Status"].ToString();
                        state = dt.Rows[0]["State"].ToString();
                        rate = double.Parse(dt.Rows[0]["Hourly Rate"].ToString());
                        ins = dt.Rows[0]["Insurance"].ToString();
                        dis = dt.Rows[0]["Disability"].ToString();
                        den = dt.Rows[0]["Dental"].ToString();
                        rNo = dt.Rows[0]["routeNo"].ToString();
                        aNo = dt.Rows[0]["accountNo"].ToString();
                        F401KP = double.Parse(dt.Rows[0]["401K Percent"].ToString());
                        tax_calculation(salary, marry, state,ins,dis,den);
                        totalpay = overpaycal(hour_work_insec, rate);
                        F401 = totalpay * F401KP;
                        cal = totalpay - F401 - benefit;
                        netpay = cal - (cal * FIT) - (cal * SST) - (cal * MT)
                            - (cal * SIT) - (cal * SLT) - (cal * FICA) - (cal * FamilyLeave);
                    }
                    else
                    {
                        MessageBox.Show("There was an error retrieving data from the database.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                }
                con = "INSERT INTO Paycheck ([Employee ID],[Pay Rate],[Paid Hours in s],[Gross Pay],[Net Pay],[Federal Income Tax],[Social Security Tax]," +
                    "[Medicare Tax],[State Income Tax],[State Local Tax],FICA,[401K Percent],[401K Saved],Benifit,submitDate,routeNo,accountNo) VALUES(@id,@pr,@ph,@gp,@np,@fit,@sst,@mt,@sit,@slt," +
                    "@fica,@F401KP,@401,@benefit,@sd,@rn,@an)";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(con, connection))
                {
                    connection.Open();
                    //command.ExecuteNonQuery(); // NOT NEEDED TWICE!
                    command.Parameters.AddWithValue("@id", employeeId);
                    command.Parameters.AddWithValue("@pr", rate);
                    command.Parameters.AddWithValue("@ph", hour_work_insec);
                    command.Parameters.AddWithValue("@gp", totalpay);
                    command.Parameters.AddWithValue("@np", netpay);
                    command.Parameters.AddWithValue("@fit", FIT);
                    command.Parameters.AddWithValue("@sst", SST);
                    command.Parameters.AddWithValue("@mt", MT);
                    command.Parameters.AddWithValue("@sit", SIT);
                    command.Parameters.AddWithValue("@slt", SLT);
                    command.Parameters.AddWithValue("@fica", FICA);
                    command.Parameters.AddWithValue("@F401KP", F401KP);
                    command.Parameters.AddWithValue("@401", F401);
                    command.Parameters.AddWithValue("@benefit", benefit);
                    command.Parameters.AddWithValue("@sd", DateTime.Now.Date.ToString());
                    command.Parameters.AddWithValue("@rn", rNo);
                    command.Parameters.AddWithValue("@an", aNo);

                    int result = command.ExecuteNonQuery();
                    // Check Error
                    if (result > 0)
                        MessageBox.Show("Submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("There was an error with the submission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con = "Delete From Clock WHERE [Employee ID] = @id";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(con, connection))
                {
                    command.Parameters.AddWithValue("@id", employeeId);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    // Check Error
                    if (!(result > 0))
                        MessageBox.Show("There was an error resetting the clock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                this.label1.Text = "00 : 00 : 00";
                benefit = 0;
            } 
        }
        private void tax_calculation(decimal salary, string marryStatus, string state, string ins, string dis, string den)
        {
            benefit = 0;
            if(marryStatus == "Single")
            {
                //benefit
                if (ins == "Aetna")
                    benefit += 25;
                else if (ins == "United Health Care")
                    benefit += (250 / 4);
                if (den == "Seledent")
                    benefit += (15 / 4);
                else if (den == "Avia")
                    benefit += 5;
                else if (den == "Delta")
                    benefit += (15 / 4);
                else if (den == "Aflac")
                    benefit += 5;
                if (dis == "Short Term")
                    benefit += ((double)salary * 0.01)/26;
                else if(dis == "Long Term")
                    benefit += ((double)salary * 0.02)/52;



                //Federal Income Tax
                if (salary >= 0 && salary <= 9700)
                {
                    FIT = 0.1;
                }
                else if (salary >= 9701 && salary <= 39475)
                {
                    FIT = 0.12;
                }
                else if (salary >= 39476 && salary <= 84200)
                {
                    FIT = 0.22;
                }
                else if (salary >= 84201 && salary <= 160725)
                {
                    FIT = 0.24;
                }
                else if (salary >= 160726 && salary <= 204100)
                {
                    FIT = 0.32;
                }
                else if (salary >= 204101 && salary <= 510300)
                {
                    FIT = 0.35;
                }
                else if (salary > 510300) 
                    FIT = 0.37;
                //State Income Tax and State local tax
                if(state == "NY")
                {
                    FamilyLeave = 0.00153;
                    if(salary >= 0 && salary < 8500)
                    {
                        SIT = 0.04;
                        SLT = 0;
                    }
                    else if(salary >= 8500 && salary < 11700)
                    {
                        SIT = 0.045;
                        SLT = 0.0018;
                    }
                    else if (salary >= 11700 && salary < 13900)
                    {
                        SIT = 0.0525;
                        SLT = 0.0097;
                    }
                    else if (salary >= 13900 && salary < 21400)
                    {
                        SIT = 0.059;
                        SLT = 0.0131;
                    }
                    else if (salary >= 21400 && salary < 80650)
                    {
                        SIT = 0.0621;
                        SLT = 0.0197;
                    }
                    else if (salary >= 80650 && salary < 215400)
                    {
                        SIT = 0.0649;
                        SLT = 0.0334;
                    }
                    else if (salary >= 215400 && salary < 1077550)
                    {
                        SIT = 0.0685;
                        SLT = 0.0367;
                    }
                    else if (salary >= 1077550)
                    {
                        SIT = 0.0882;
                        SLT = 0.0384;
                    }
                }
                else if(state == "NJ")
                {
                    FamilyLeave = 0.0008;
                    if(salary >= 0 && salary < 20000)
                    {
                        SIT = 0.014;
                    }
                    else if(salary >= 20000 && salary < 35000)
                    {
                        SIT = 0.0175;
                    }
                    else if (salary >= 35000 && salary < 40000)
                    {
                        SIT = 0.035;
                    }
                    else if (salary >= 40000 && salary < 75000)
                    {
                        SIT = 0.0553;
                    }
                    else if (salary >= 75000 && salary < 500000)
                    {
                        SIT = 0.0637;
                    }
                    else if (salary >= 500000 && salary < 5000000)
                    {
                        SIT = 0.0897;
                    }
                    else if (salary >= 5000000)
                    {
                        SIT = 0.1075;
                    }

                }
                else if(state == "PA")
                {
                    FamilyLeave = 0;
                    SIT = 0.0307;
                    SLT = 0.015;

                }
            }
            else if(marryStatus == "Married")
            {
                //benefit
                if (ins == "Aetna")
                    benefit += (150/4);
                else if (ins == "United Health Care")
                    benefit += (300 / 4);
                if (den == "Seledent")
                    benefit += (20 / 4);
                else if (den == "Avia")
                    benefit += (25/4);
                else if (den == "Delta")
                    benefit += (30 / 4);
                else if (den == "Aflac")
                    benefit += (30/4);
                if (dis == "Short Term")
                    benefit += ((double)salary * 0.02)/26;
                else if (dis == "Long Term")
                    benefit += ((double)salary * 0.03)/52;
                //Federal Income Tax
                if (salary >= 0 && salary <= 19400)
                {
                    FIT = 0.1;
                }
                else if (salary >= 19401 && salary <= 78950)
                {
                    FIT = 0.12;
                }
                else if (salary >= 78951 && salary <= 168400)
                {
                    FIT = 0.22;
                }
                else if (salary >= 168401 && salary <= 321450)
                {
                    FIT = 0.24;
                }
                else if (salary >= 321451 && salary <= 408200)
                {
                    FIT = 0.32;
                }
                else if (salary >= 408201 && salary <= 612350)
                {
                    FIT = 0.35;
                }
                else if (salary > 612350)
                    FIT = 0.37;
                //State Income Tax
                if(state == "NY")
                {
                    FamilyLeave = 0.00153;
                    if (salary >=0 && salary < 17150)
                    {
                        SIT = 0.04;
                        SLT = 0;
                    }
                    else if(salary >= 17150 && salary < 23600)
                    {
                        SIT = 0.045;
                        SLT = 0.002;
                    }
                    else if (salary >= 23600 && salary < 27900)
                    {
                        SIT = 0.0525;
                        SLT = 0.0098;
                    }
                    else if (salary >= 27900 && salary < 43000)
                    {
                        SIT = 0.059;
                        SLT = 0.0131;
                    }
                    else if (salary >= 43000 && salary < 161550)
                    {
                        SIT = 0.0621;
                        SLT = 0.0201;
                    }
                    else if (salary >= 161550 && salary < 323200)
                    {
                        SIT = 0.0649;
                        SLT = 0.0335;
                    }
                    else if (salary >= 323200 && salary < 2155350)
                    {
                        SIT = 0.0685;
                        SLT = 0.0361;
                    }
                    else if (salary >= 2155350)
                    {
                        SIT = 0.0882;
                        SLT = 0.0384;
                    }
                }
                else if(state =="NJ")
                {
                    FamilyLeave = 0.0008;
                    if(salary >= 0 && salary < 20000)
                    {
                        SIT = 0.014;
                    }
                    else if(salary >=20000 && salary < 50000)
                    {
                        SIT = 0.0175;
                    }
                    else if (salary >= 50000 && salary < 70000)
                    {
                        SIT = 0.0245;
                    }
                    else if (salary >= 70000 && salary < 80000)
                    {
                        SIT = 0.0350;
                    }
                    else if (salary >= 80000 && salary < 150000)
                    {
                        SIT = 0.0553;
                    }
                    else if (salary >= 150000 && salary < 500000)
                    {
                        SIT = 0.0637;
                    }
                    else if (salary >= 500000 && salary < 5000000)
                    {
                        SIT = 0.0897;
                    }
                    else if (salary >= 5000000)
                    {
                        SIT = 0.1075;
                    }

                }
                else if(state == "PA")
                {
                    FamilyLeave = 0;
                    SIT = 0.0307;
                    SLT = 0.015;
                }
            }

        }

        private void btnClockIn_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == true)
            {
                MessageBox.Show("You have already Clock in", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                timer1.Enabled = true;
            }
        }
    }
}
