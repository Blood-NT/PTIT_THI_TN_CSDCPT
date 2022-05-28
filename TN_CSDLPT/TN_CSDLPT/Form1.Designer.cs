namespace TN_CSDLPT
{
  
    partial class frmmain
    {
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_QL_GV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QL_Khoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QL_LOP = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_GV_dangky_thi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sv_cho = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SV_Login = new DevExpress.XtraBars.BarButtonItem();
            this.btn_GV_Login = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.add_thi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QL_MH = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QL_SV = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.pageHethong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.gropu_he_thong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageGV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.group_GV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageThi = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.group_gv_dk_thi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.group_sv_thi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.group_Add_Thi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_QL_GV,
            this.btn_QL_Khoa,
            this.btn_QL_LOP,
            this.barButtonItem11,
            this.btn_GV_dangky_thi,
            this.btn_sv_cho,
            this.btn_SV_Login,
            this.btn_GV_Login,
            this.barButtonItem3,
            this.add_thi,
            this.barButtonItem1,
            this.btn_QL_MH,
            this.btn_QL_SV});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 41;
            this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageHethong,
            this.pageGV,
            this.pageThi});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1229, 143);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btn_QL_GV
            // 
            this.btn_QL_GV.Caption = "Quản Lý Giáo Viên";
            this.btn_QL_GV.Id = 15;
            this.btn_QL_GV.Name = "btn_QL_GV";
            this.btn_QL_GV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QL_GV_ItemClick);
            // 
            // btn_QL_Khoa
            // 
            this.btn_QL_Khoa.Caption = "Quản Lý Khoa";
            this.btn_QL_Khoa.Id = 16;
            this.btn_QL_Khoa.Name = "btn_QL_Khoa";
            this.btn_QL_Khoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QL_Khoa_ItemClick_1);
            // 
            // btn_QL_LOP
            // 
            this.btn_QL_LOP.Caption = "Quản Lý Lớp";
            this.btn_QL_LOP.Id = 17;
            this.btn_QL_LOP.Name = "btn_QL_LOP";
            this.btn_QL_LOP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QL_LOP_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Phục Hồi Giáo Viên";
            this.barButtonItem11.Id = 18;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // btn_GV_dangky_thi
            // 
            this.btn_GV_dangky_thi.Caption = "Giáo Viên Đăng Ký Thi";
            this.btn_GV_dangky_thi.Id = 27;
            this.btn_GV_dangky_thi.Name = "btn_GV_dangky_thi";
            this.btn_GV_dangky_thi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_GV_dangky_thi_ItemClick);
            // 
            // btn_sv_cho
            // 
            this.btn_sv_cho.Caption = "Sinh Viên Vào Phòng Chờ";
            this.btn_sv_cho.Id = 28;
            this.btn_sv_cho.Name = "btn_sv_cho";
            // 
            // btn_SV_Login
            // 
            this.btn_SV_Login.Caption = "Sinh Viên Login";
            this.btn_SV_Login.Id = 34;
            this.btn_SV_Login.Name = "btn_SV_Login";
            this.btn_SV_Login.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_SV_Login_ItemClick);
            // 
            // btn_GV_Login
            // 
            this.btn_GV_Login.Caption = "Giao Viên Login";
            this.btn_GV_Login.Id = 35;
            this.btn_GV_Login.Name = "btn_GV_Login";
            this.btn_GV_Login.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_GV_Login_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 36;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // add_thi
            // 
            this.add_thi.Caption = "Thêm Câu Hỏi Vào Bộ Đề";
            this.add_thi.Id = 37;
            this.add_thi.Name = "add_thi";
            this.add_thi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.add_thi_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 38;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btn_QL_MH
            // 
            this.btn_QL_MH.Caption = "Quản Lý Môn Học";
            this.btn_QL_MH.Id = 39;
            this.btn_QL_MH.Name = "btn_QL_MH";
            this.btn_QL_MH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QL_MH_ItemClick);
            // 
            // btn_QL_SV
            // 
            this.btn_QL_SV.Caption = "Quản Lý Sinh Viên";
            this.btn_QL_SV.Id = 40;
            this.btn_QL_SV.Name = "btn_QL_SV";
            this.btn_QL_SV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QL_SV_ItemClick);
            // 
            // pageHethong
            // 
            this.pageHethong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.gropu_he_thong});
            this.pageHethong.Name = "pageHethong";
            this.pageHethong.Text = "Hệ thống";
            // 
            // gropu_he_thong
            // 
            this.gropu_he_thong.ItemLinks.Add(this.btn_SV_Login, true);
            this.gropu_he_thong.ItemLinks.Add(this.btn_GV_Login, true);
            this.gropu_he_thong.ItemLinks.Add(this.barButtonItem3, true);
            this.gropu_he_thong.Name = "gropu_he_thong";
            this.gropu_he_thong.ShowCaptionButton = false;
            // 
            // pageGV
            // 
            this.pageGV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.group_GV});
            this.pageGV.Name = "pageGV";
            this.pageGV.Text = "Giáo Viên";
            // 
            // group_GV
            // 
            this.group_GV.ItemLinks.Add(this.btn_QL_GV, true);
            this.group_GV.ItemLinks.Add(this.btn_QL_SV, true);
            this.group_GV.ItemLinks.Add(this.btn_QL_Khoa, true);
            this.group_GV.ItemLinks.Add(this.btn_QL_LOP, true);
            this.group_GV.ItemLinks.Add(this.btn_QL_MH, true);
            this.group_GV.ItemLinks.Add(this.barButtonItem11, true);
            this.group_GV.Name = "group_GV";
            this.group_GV.ShowCaptionButton = false;
            this.group_GV.Text = " ";
            // 
            // pageThi
            // 
            this.pageThi.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.group_gv_dk_thi,
            this.group_sv_thi,
            this.group_Add_Thi});
            this.pageThi.Name = "pageThi";
            this.pageThi.Text = "THI";
            // 
            // group_gv_dk_thi
            // 
            this.group_gv_dk_thi.ItemLinks.Add(this.btn_GV_dangky_thi, true);
            this.group_gv_dk_thi.Name = "group_gv_dk_thi";
            this.group_gv_dk_thi.ShowCaptionButton = false;
            this.group_gv_dk_thi.Text = " ";
            // 
            // group_sv_thi
            // 
            this.group_sv_thi.ItemLinks.Add(this.btn_sv_cho, true);
            this.group_sv_thi.Name = "group_sv_thi";
            this.group_sv_thi.ShowCaptionButton = false;
            // 
            // group_Add_Thi
            // 
            this.group_Add_Thi.ItemLinks.Add(this.add_thi, true);
            this.group_Add_Thi.Name = "group_Add_Thi";
            this.group_Add_Thi.ShowCaptionButton = false;
            this.group_Add_Thi.Text = " ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1229, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // frmmain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 555);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmmain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "TN_CSDLPT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageHethong;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageGV;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageThi;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup group_GV;
        private DevExpress.XtraBars.BarButtonItem btn_QL_GV;
        private DevExpress.XtraBars.BarButtonItem btn_QL_Khoa;
        private DevExpress.XtraBars.BarButtonItem btn_QL_LOP;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem btn_GV_dangky_thi;
        private DevExpress.XtraBars.BarButtonItem btn_sv_cho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup gropu_he_thong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup group_gv_dk_thi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_SV_Login;
        private DevExpress.XtraBars.BarButtonItem btn_GV_Login;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup group_sv_thi;
        private DevExpress.XtraBars.BarButtonItem add_thi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup group_Add_Thi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_QL_MH;
        private DevExpress.XtraBars.BarButtonItem btn_QL_SV;
    }
}

