using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseGenerator.View;

namespace LicenseGenerator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //new ClientForm().Show();
            if (DateTime.Now > new DateTime(2026,12,1))
            {
                return;
            }
            Application.Run(new GeneratorForm());
        }
    }
}
