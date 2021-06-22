using DevExpress.XtraEditors;
using PMWORK.CodingForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMWORK
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void itmCompany_Click(object sender, EventArgs e)
        {
            var frm = new CompanyPartial();
        }
    }
}
