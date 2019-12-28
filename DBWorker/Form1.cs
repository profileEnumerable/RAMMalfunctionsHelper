using DBWorker.DAL.Entities;
using DBWorker.DAL.EntityFramework;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DBWorker
{
    public partial class Form1 : Form
    {
        private bool isFormLoaded;

        private readonly RamMalfunctionsContext context;
        public virtual DbSet<Ram> ram { get; set; }

        private readonly DataGridViewRow currentRow;

        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;

            context = new RamMalfunctionsContext();
            context.RAMs.Load();

            ramCrud.DataSource = context.RAMs.Local.ToBindingList();
            ramCrud.Refresh();
            // InitializeEmptyRamRecords();

        }

        private void ramCrud_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ram = context.RAMs;

            if (e.RowIndex < ram.Count() && e.RowIndex >= 0 && isFormLoaded)
            {
                var bitmap = new Bitmap($"Images/image{e.RowIndex + 1}.jpg");

                var form = new Form()
                {
                    Width = bitmap.Width,
                    Height = bitmap.Height + 25
                };

                form.Controls.Add(new PictureBox()
                {
                    Image = bitmap,
                    Dock = DockStyle.Fill
                });

                form.Show();
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            isFormLoaded = true;
        }
    }
}
