using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Linq;

namespace PMWORK.MachineryForms
{
    public partial class MachineryForm : XtraForm
    {

        private AppDbContext db;
        
        public MachineryForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            cbxCodingList();
        }


        void cbxCodingList()
        {
            cbxCoding.Properties.DisplayMember = "Cod";
            cbxCoding.Properties.ValueMember = "ID";
            var qry = db.Codings.ToList();
            var list = new List<ComboBoxCoding>();
            foreach (var x in qry)
            {
                var item = new ComboBoxCoding();

                item.ID = x.ID;
                item.Cod = x.Code;
                item.Title = x.CodeTitle;
                item.Des = x.SubGroup.SubGroupTitle;
                //}-{x.Group.GroupTitle}-{x.SubGroup.SubGroupTitle}"

                list.Add(item);
              
            }

            cbxCoding.Properties.DataSource = list;
        }


        internal void MachineryList()
        {
            dgvMachineryList.DataSource = db.Machineries.ToList();
        }
    }



}
