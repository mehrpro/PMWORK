using DevExpress.XtraGrid.Views.Grid;
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
    public partial class CompaniesForm : DevExpress.XtraEditors.XtraForm
    {
        private AppDbContext db;
        public CompaniesForm()
        {
            InitializeComponent();
            db = new AppDbContext();
          
            UpdateList();
        }

        public  void UpdateList()
        {
            var result = new List<CompanyViewModel>();
            var qry =  db.Companies.ToList();
            if (qry.Count > 0)
            {
                foreach (var item in qry)
                {
                    result.Add(new CompanyViewModel()
                    {
                        ID = item.ID,
                        CompnayIndex = item.CompnayIndex,
                        CompanyTiltle = item.CompanyTiltle,
                        Description = item.Description
                    });                    
                }
                dgvCompany.DataSource = result;
                dgvCompany.Refresh();
            }
            
            //gridView1.Columns["ID"].Visible = false;

            
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            var obj = new Entities.Company();
            obj.CompnayIndex = Convert.ToByte( txtCompanyIndex.EditValue);
            obj.CompanyTiltle = txtCompanyTitle.EditValue.ToString().Trim();
            obj.Description = txtDescription.Text.ToString().Trim();       
            db.Companies.Add(obj);
            var result = db.SaveChanges();
            UpdateList();

        }

        private void gvCompany_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var re = e.RowHandle;
        }

        private void gvCompany_RowClick(object sender, RowClickEventArgs e)
        {
            var ef = e.RowHandle.ToString();
           
        }

        private void dgvCompany_Click(object sender, EventArgs e)
        {

        }
    }
}
