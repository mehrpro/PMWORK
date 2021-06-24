using PMWORK.Entities;
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
    public partial class SubGroupForm : DevExpress.XtraEditors.XtraForm
    {
        private AppDbContext db;
        private ComboBoxBaseClass _selectCompany;
        private ComboBoxBaseClass _selectGroup;

        public SubGroupForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";

            cbxGroup.Properties.DisplayMember = "Title";
            cbxGroup.Properties.ValueMember = "ID";

            cbxCompany.Properties.DataSource = db.Companies
                .Select(s => new ComboBoxBaseClass()
                { ID = s.ID, Title = s.CompanyTiltle, Tag = s.CompnayIndex.ToString() }).ToList();
  
        }

        public void cbxGroupList(int id)
        {
            cbxGroup.Properties.DataSource = db.Groups.Where(g=>g.CompanyID_FK == id)
                .Select(s => new ComboBoxBaseClass()
                { 
                    ID = s.ID,
                    Title = s.GroupTitle,
                    Tag = s.GroupIndex.ToString()
                }).ToList();
        }

        private void UpdateList(int companyid,int group)
        {
            dgvSubGroup.DataSource = db.SubGroups.Where(x=>x.CompanyID_FK == companyid && x.GroupID_FK == group).ToList();
            gvSubGroup.RefreshData();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
             _selectCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (_selectCompany == null)
            {
                cbxGroup.EditValue = null;
                cbxGroup.Properties.DataSource = null;                
                return;
            }
            cbxGroupList(_selectCompany.ID);
            txtCompanyIndex.Text = _selectCompany.Tag.ToString();

        }

        private void cbxGroup_EditValueChanged(object sender, EventArgs e)
        {
             _selectGroup = (ComboBoxBaseClass)cbxGroup.GetSelectedDataRow();
            if (_selectGroup == null)
            {
                dgvSubGroup.DataSource = null;
                dgvSubGroup.Refresh();
                return;
            }
            UpdateList(_selectCompany.ID, _selectGroup.ID);
            txtGroupIndex.Text = _selectGroup.Tag.ToString();

        }
    }
}
