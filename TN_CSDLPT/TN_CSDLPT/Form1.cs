using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TN_CSDLPT
{
   
    public partial class frmmain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool sinhvien = false;
        bool giangvien = false;


        void OpenForm(Type typeForm)
        {
            foreach (Form frm in MdiChildren)
            {
                if(frm.GetType()==typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }
        public frmmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sinhvien = false;
            giangvien = true;
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(form.frm_svlogin))
                {
                    frm.Close();
                }
            }
            OpenForm(typeof(form.frmDangnhap));

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnSv_Click(object sender, EventArgs e)
        {
            sinhvien = true;
            giangvien = false;
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(form.frmDangnhap))
                {
                    frm.Close();
                }
            }
            OpenForm(typeof(form.frm_svlogin));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }
    }
}
