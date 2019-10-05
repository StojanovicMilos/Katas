using System;
using System.Configuration;
using System.Windows.Forms;
using DapperDemo.DAL;

namespace WinFormApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard(new DataAccessObject(ConfigurationManager.ConnectionStrings["DapperDemoDB"].ConnectionString)));
        }
    }
}
