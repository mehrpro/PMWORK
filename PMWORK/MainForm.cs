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
        private void ShowForms(object obj)
        {
            foreach (Form x in this.MdiChildren)
            {
                x.Close();
            }

            Form frm = (Form)obj;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }


        private void itmCompany_Click(object sender, EventArgs e)
        {
            ShowForms(new CompaniesForm());

        }
    }
}
