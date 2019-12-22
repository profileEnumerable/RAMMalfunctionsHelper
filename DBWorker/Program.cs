using System;
using System.Globalization;
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
            Application.Run(new Form1());


            using (var context = new RamMalfunctionsContext())
            {
                var firstServiceLink =
                    from ram in context.RAMs
                    where ram.Id == 10
                    select ram.RAMMedias;

                foreach (var VARIABLE in firstServiceLink)
                {
                    MessageBox.Show(VARIABLE.First().Data);
                }
            }
        }
    }
}
