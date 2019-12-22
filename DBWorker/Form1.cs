using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using DBWorker.DAL.EntityFramework;
using System.Windows.Forms;
using DBWorker.DAL.Entities;

namespace DBWorker
{
    public partial class Form1 : Form
    {
        private readonly RamMalfunctionsContext context;
        public virtual DbSet<Ram> ram { get; set; }

        private DataGridViewRow currentRow;



        public Form1()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            context = new RamMalfunctionsContext();
            context.RAMs.Load();

            ramCrud.DataSource = context.RAMs.Local.ToBindingList();
        }

        private void ramCrud_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            ram = context.RAMs;

            if (e.RowIndex < ram.Count() && e.RowIndex >= 0)
            {
                var form = new Form
                {
                    Size = new Size(500,500)
                };

                

                form.Show();
                currentRow = ramCrud.Rows[e.RowIndex];
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
