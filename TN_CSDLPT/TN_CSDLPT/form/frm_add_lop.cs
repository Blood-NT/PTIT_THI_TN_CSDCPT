using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TN_CSDLPT.form
{
    public partial class frm_add_lop : DevExpress.XtraEditors.XtraForm
    {
        bool check_add_lop = false;
        string notifi;
        public frm_add_lop()
        {
            InitializeComponent();
        }

   

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check_add_lop = !check_add_lop;
            if (check_add_lop == true)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "check", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Thêm Câu Hỏi Thành Công", "noteeeeeeeeeee");

                }
            }
            else
            {
                notifi = "Bạn chưa nhập gì hết nè ";
                MessageBox.Show(notifi, "noteeeeeeeeeee");

            }
        }
    }
}