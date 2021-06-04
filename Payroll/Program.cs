using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\")
            || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName + "\\App_Data";
                AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            /*frmLogin form1 = new frmLogin();
            form1.ShowDialog();
            if(form1.DialogResult == DialogResult.OK)
            {
                form1.Dispose();
                Application.Run(new frmEmployee());
            }
            else if(form1.DialogResult == DialogResult.Yes)
            {
                form1.Dispose();
                Application.Run(new Human_Resource());
            }*/
        }
    }
}
