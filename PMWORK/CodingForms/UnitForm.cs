using PMWORK.CodingForms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMWORK.CodingForms
{
    public partial class UnitForm :DevExpress.XtraEditors.XtraForm
    {
        private AppDbContext db;
        public UnitForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            UpdateList();
        }

        public void UpdateList()
        {
            var qry = db.UnitOfMeasurements.ToList();
            var list = new List<UnitViewModel>();
            if (qry.Count > 0)
            {
                foreach (var item in qry)
                {
                    list.Add(new UnitViewModel()
                    {
                        ID = item.ID,
                        Unit = item.Unit,
                        Description = item.Description
                    });
                }

                dgvUnit.DataSource = list;
                dgvUnit.Refresh();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var obj = new Entities.UnitOfMeasurement()
            {
                Unit = txtUnitTitle.Text.Trim(),
                Description = txtDescription.Text.Trim()
            };
            try
            {
                db.UnitOfMeasurements.Add(obj);
                db.SaveChanges();
                UpdateList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
