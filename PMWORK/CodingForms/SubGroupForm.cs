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
        public SubGroupForm()
        {
            InitializeComponent();
            db = new AppDbContext();
        }

        private void UpdateList(int companyid,int group)
        {
            var qry = db.SubGroups.Where(x=>x.CompanyID_FK == companyid && x.GroupID_FK == group).ToList();
            var list = new List<SubGroup>();
            if (qry.Count > 0)
            {
                foreach (var item in qry)
                {
                    list.Add(new SubGroup()
                    {
                        ID = item.ID,
                        SubGroupIndex = item.SubGroupIndex,
                        SubGroupTitle = item.SubGroupTitle,
                        Description = item.Description
                    });
                }
            }
        }
    }
}
