﻿using System;
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
        void close_all_frm(Type typeForm)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() != typeForm)
                {
                    frm.Close();
                }
            }
        }
  

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }



        private void frmmain_Load(object sender, EventArgs e)
        {
            pageGV.Visible = false;
            pageThi.Visible = false;

        }

        private void btn_SV_Login_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pageGV.Visible = false;
            pageThi.Visible = true;


            group_sv_thi.Visible = true;
            group_gv_dk_thi.Visible = false;
            group_Add_Thi.Visible = false;

            Program.sinhvien = true;
            Program.giangvien = false;

            
            close_all_frm(typeof(form.frm_svlogin));
            OpenForm(typeof(form.frm_svlogin));
        }

        private void btn_GV_Login_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.sinhvien = false;
            Program.giangvien = true;

            pageThi.Visible = true;
            pageGV.Visible = true;

            group_sv_thi.Visible = false;
            group_gv_dk_thi.Visible = true;
            group_Add_Thi.Visible = true;

            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(form.frm_svlogin))
                {
                    frm.Close();
                }
            }
            close_all_frm(typeof(form.frmDangnhap));
            OpenForm(typeof(form.frmDangnhap));
        }

        private void add_thi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(form.frm_add_QA));

        }

        private void btn_add_khoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(form.frm_add_khoa));

        }

        private void btn_QL_KHOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(form.frm_add_khoa));

        }

        private void btn_QL_Khoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(form.frm_add_khoa));

        }

        private void btn_QL_LOP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(form.frm_add_lop));

        }

        private void btn_QL_MH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(form.frm_add_monhoc));

        }

        private void btn_QL_SV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(form.frm_add_sv));

        }

        private void btn_QL_GV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(form.frm_add_gv));

        }

        private void btn_GV_dangky_thi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(typeof(form.frm_gv_dk_thi));

        }
    }
}
