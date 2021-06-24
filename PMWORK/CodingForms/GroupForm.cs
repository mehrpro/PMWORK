using DevExpress.XtraEditors;
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
    public partial class GroupForm : XtraForm
    {

        private AppDbContext db;
        private ComboBoxBaseClass _selectCompany ;
        public GroupForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";
            cbxCompany.Properties.DataSource = db.Companies
                .Select(s=> new ComboBoxBaseClass()
                {ID = s.ID,Title = s.CompanyTiltle , Tag=s.CompnayIndex.ToString()}).ToList();            
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateList(int id)
        {
            dgvGroupList.DataSource = db.Groups.Where(s => s.CompanyID_FK == id).ToList();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var obj = new Entities.Group()
            {
                CompanyID_FK = _selectCompany.ID,
                GroupIndex = Convert.ToByte(numGroup.EditValue),
                GroupTitle = txtGroupTitle.Text.Trim(),
                Description = txtDescription.Text.Trim()
            };

            try
            {
                db.Groups.Add(obj);
                db.SaveChanges();
                UpdateList(_selectCompany.ID);

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            _selectCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (_selectCompany ==  null) return;     
            txtCompanyIndex.Text = _selectCompany.Tag.ToString();
            UpdateList(_selectCompany.ID);

        }
    }
}
