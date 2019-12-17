using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBWorker.DAL.EDM;

namespace DBWorker
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
            Application.Run(new Form1());


            using (var ramMalfunctionsModelContainer = new RamMalfunctionsModelContainer())
            {
                MessageBox.Show(ramMalfunctionsModelContainer.FixIssues.ToString());
            }
        }
    }
}
