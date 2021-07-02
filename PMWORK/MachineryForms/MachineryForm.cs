using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMWORK.Machinery
{
    public partial class MachineryForm : XtraForm
    {

        AppDbContext db;
        
        public MachineryForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            cbxCodingList();
        }


        void cbxCodingList()
        {
            cbxCoding.Properties.DisplayMember = "Code";
            cbxCoding.Properties.ValueMember = "ID";
            var qry = db.Codings.Select(x=> new ComboBoxCoding()
            {
                ID = x.ID,
                Code = x.Code,
                Title = x.CodeTitle,
                Company = $"{x.Company.CompanyTiltle}-{x.Group.GroupTitle}-{x.SubGroup.SubGroupTitle}"
            }).ToList();
            cbxCoding.Properties.DataSource = qry;
        }


        internal void MachineryList()
        {
            dgvMachineryList.DataSource = db.Machineries.ToList();
        }
    }



}
