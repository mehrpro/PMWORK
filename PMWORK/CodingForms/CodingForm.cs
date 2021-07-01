using DevExpress.XtraEditors;
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
    public partial class CodingForm : XtraForm
    {
        private AppDbContext db;
        private ComboBoxBaseClass _selectCompany;
        private ComboBoxBaseClass _selectGroup;
        private ComboBoxBaseClass _selectSubGroup;
        private ComboBoxBaseClass _selectUnit;
        private Coding Row { get; set; }


        public CodingForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";

            cbxGroup.Properties.DisplayMember = "Title";
            cbxGroup.Properties.ValueMember = "ID";

            cbxSubGroup.Properties.DisplayMember = "Title";
            cbxSubGroup.Properties.ValueMember = "ID";

            cbxUnit.Properties.DisplayMember = "Title";
            cbxUnit.Properties.ValueMember = "ID";

            cbxCompany.Properties.DataSource = db.Companies
                .Select(s => new ComboBoxBaseClass()
                { ID = s.ID, Title = s.CompanyTiltle, Tag = s.CompnayIndex.ToString() }).ToList();

            cbxUnit.Properties.DataSource = db.UnitOfMeasurements
                .Select(s => new ComboBoxBaseClass()
                { ID = s.ID, Title = s.Unit, Tag = null }).ToList();

        }

        public void cbxGroupList(int id)
        {
            cbxGroup.Properties.DataSource = db.Groups.Where(g => g.CompanyID_FK == id)
                .Select(s => new ComboBoxBaseClass()
                {
                    ID = s.ID,
                    Title = s.GroupTitle,
                    Tag = s.GroupIndex.ToString()
                }).ToList();
        }

        public void cbxSubGroupList(int cid,int gid)
        {
            cbxSubGroup.Properties.DataSource = db.SubGroups.Where(g => g.CompanyID_FK == cid && g.GroupID_FK ==gid)
                .Select(s => new ComboBoxBaseClass()
                {
                    ID = s.ID,
                    Title = s.SubGroupTitle,
                    Tag = s.SubGroupIndex.ToString()
                }).ToList();
        }

        private void CodeBox()
        {
            if(_selectCompany.ID > 0 && _selectCompany != null)
            {

            }
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
        }

        private void cbxGroup_EditValueChanged(object sender, EventArgs e)
        {
            _selectGroup = (ComboBoxBaseClass)cbxGroup.GetSelectedDataRow();
            if (_selectGroup == null)
            {
                cbxSubGroup.EditValue = null;
                cbxSubGroup.Properties.DataSource = null;
                return;
            }
            cbxSubGroupList(_selectCompany.ID,_selectGroup.ID);
        }

        private void cbxSubGroup_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
