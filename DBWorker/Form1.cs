using System;
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
        private bool _isFormLoaded;
        private DataGridViewRow currentRow;
        private readonly RamMalfunctionsContext _context;
        private DbSet<Ram> Ram { get; set; }

        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;

            _context = new RamMalfunctionsContext();

            //explicit loading
            _context.RAMs.Load();
            _context.FixIssues.Load();
            _context.Malfunctions.Load();
            _context.UserServiceLinks.Load();

            ramCrud.DataSource = _context.RAMs.Local.ToBindingList();
            mufunctionCrud.DataSource = _context.Malfunctions.Local.ToBindingList();
            serviceLinkCrud.DataSource = _context.UserServiceLinks.Local.ToBindingList();
            fixIssueCrud.DataSource = _context.FixIssues.Local.ToBindingList();
        }

        private void ramCrud_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Ram = _context.RAMs;

            if (e.RowIndex < Ram.Count() && e.RowIndex >= 0 && _isFormLoaded)
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

        private void common_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var control in crudControl.SelectedTab.Controls)
            {
                if (control is DataGridView view && view.Rows[e.RowIndex].Cells["Id"].Value != null)
                {
                    currentRow = view.Rows[e.RowIndex];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) => _isFormLoaded = true;

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (currentRow.Cells[0].Value == null)
            {
                return;
            }

            try
            {
                switch (crudControl.SelectedTab.TabIndex)
                {
                    case 0:
                        {
                            var item = _context.RAMs.Find(currentRow?.Cells["Id"].Value);

                            _context.Entry(item).State = EntityState.Deleted;
                            _context.RAMs.Remove(item);

                            ramCrud.Refresh();
                            break;
                        }
                    case 1:
                        {
                            var item = _context.Malfunctions.Find(currentRow?.Cells["Id"].Value);

                            _context.Entry(item).State = EntityState.Deleted;
                            _context.Malfunctions.Remove(item);

                            mufunctionCrud.Refresh();
                            break;
                        }
                    case 2:
                        {
                            var item = _context.UserServiceLinks.Find(currentRow?.Cells["Id"].Value);

                            _context.Entry(item).State = EntityState.Deleted;
                            _context.UserServiceLinks.Remove(item);

                            serviceLinkCrud.Refresh();
                            break;
                        }
                    case 3:
                        {
                            var item = _context.FixIssues.Find(currentRow?.Cells["Id"].Value);

                            _context.Entry(item).State = EntityState.Deleted;
                            _context.FixIssues.Remove(item);

                            fixIssueCrud.Refresh();
                            break;
                        }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

    }
}