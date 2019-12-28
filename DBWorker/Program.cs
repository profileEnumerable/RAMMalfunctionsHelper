using System;
using System.Linq;
using System.Windows.Forms;
using DBWorker.DAL.EntityFramework;

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
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
