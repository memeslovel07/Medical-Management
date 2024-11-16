using Medical_Management.Reports.DatewiseReports;
using Medical_Management.Reports.IdWiseReports;
using Medical_Management.Reports.NamewiseReports;
using Medical_Management.Reports.VoucherNumberWise;
using Medical_Management.Starting_Page;
using Medical_Management.Transaction_Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Management
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
            Application.Run(new Start());
        }
    }
}
    