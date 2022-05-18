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
    public partial class frm_add_QA : DevExpress.XtraEditors.XtraForm
    {
        bool check_add = false;
        string notifi;
        public frm_add_QA()
        {
            InitializeComponent();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {

            if (check_add == true)
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

        private void frm_add_QA_Load(object sender, EventArgs e)
        {

        }
    }
}