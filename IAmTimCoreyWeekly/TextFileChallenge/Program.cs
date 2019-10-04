using System;
using System.Windows.Forms;

namespace TextFileChallenge
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
            Application.Run(new ChallengeForm(new CSVUserDb("StandardDataSet.csv"))); //"AdvancedDataSet.csv"
        }
    }
}
