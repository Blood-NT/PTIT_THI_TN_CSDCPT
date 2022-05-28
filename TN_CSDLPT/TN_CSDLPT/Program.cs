using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using TN_CSDLPT.form;
using System.Data;

namespace TN_CSDLPT
{
    static class Program
    {


        public static bool sinhvien = false;
        public static bool giangvien = false;
        public static frmmain frmmain;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            frmmain = new frmmain();
            Application.Run(frmmain);
        }
    }
    }
