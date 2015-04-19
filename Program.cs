using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;

namespace InvoiceTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string cultureName = ConfigurationManager.AppSettings["SelectedCulture"] ?? "sr-Latn-RS";

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cultureName);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
