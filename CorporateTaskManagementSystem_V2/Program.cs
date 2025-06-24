using CorporateTaskManagementSystem_V2.View;
using System;
using System.Windows.Forms;

namespace CorporateTaskManagementSystem_V2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new DashboardAdmin()); 
            //Application.Run(new AdminTask());
        }
    }
}
