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
            this.pageHethong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pageNhaplieu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pageThi = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pageBaocao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btnGv = new System.Windows.Forms.Button();
            this.btnSv = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageHethong,
            this.pageNhaplieu,
            this.pageThi,
            this.pageBaocao});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1229, 143);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // pageHethong
            // 
            this.pageHethong.Name = "pageHethong";
            this.pageHethong.Text = "Hệ thống";
            // 
            // pageNhaplieu
            // 
            this.pageNhaplieu.Name = "pageNhaplieu";
            this.pageNhaplieu.Text = "Nhập liệu";
            // 
            // pageThi
            // 
            this.pageThi.Name = "pageThi";
            this.pageThi.Text = "Kỳ thi";
            // 
            // pageBaocao
            // 
            this.pageBaocao.Name = "pageBaocao";
            this.pageBaocao.Text = "Báo cáo";
            // 
            // btnGv
            // 
            this.btnGv.Location = new System.Drawing.Point(64, 53);
            this.btnGv.Name = "btnGv";
            this.btnGv.Size = new System.Drawing.Size(103, 23);
            this.btnGv.TabIndex = 1;
            this.btnGv.Text = "giảng viên";
            this.btnGv.UseVisualStyleBackColor = true;
            this.btnGv.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSv
            // 
            this.btnSv.Location = new System.Drawing.Point(64, 82);
            this.btnSv.Name = "btnSv";
            this.btnSv.Size = new System.Drawing.Size(103, 23);
            this.btnSv.TabIndex = 2;
            this.btnSv.Text = "Sinh viên";
            this.btnSv.UseVisualStyleBackColor = true;
            this.btnSv.Click += new System.EventHandler(this.btnSv_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1229, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Location = new System.Drawing.Point(64, 111);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(103, 23);
            this.btnDangxuat.TabIndex = 5;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.UseVisualStyleBackColor = true;
            this.btnDangxuat.Click += new System.EventHandler(this.button1_Click_1);
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
            // frmmain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 555);
            this.Controls.Add(this.btnDangxuat);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSv);
            this.Controls.Add(this.btnGv);
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
        private System.Windows.Forms.Button btnGv;
        private System.Windows.Forms.Button btnSv;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnDangxuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageNhaplieu;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageThi;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageBaocao;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
    }
}

