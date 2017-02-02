namespace JEMS.MyForm
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btn_logout = new DevExpress.XtraBars.BarButtonItem();
            this.btn_exit = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btn_zoomimage = new DevExpress.XtraBars.BarSubItem();
            this.btn_qyanlybatch = new DevExpress.XtraBars.BarButtonItem();
            this.btn_quanlyuser = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_nangsuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_tiendo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xuatexcel = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.btn_logout,
            this.btn_exit,
            this.barSubItem2,
            this.btn_zoomimage,
            this.btn_qyanlybatch,
            this.btn_quanlyuser,
            this.barButtonItem5,
            this.barSubItem4,
            this.barButtonItem6,
            this.btn_nangsuat,
            this.btn_tiendo,
            this.btn_xuatexcel});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 13;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1300, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 645);
            this.barDockControlBottom.Size = new System.Drawing.Size(1300, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 623);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1300, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 623);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_zoomimage)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "&Menu";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_logout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_exit)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btn_logout
            // 
            this.btn_logout.Caption = "&Logout";
            this.btn_logout.Id = 1;
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_logout_ItemClick);
            // 
            // btn_exit
            // 
            this.btn_exit.Caption = "&Exit";
            this.btn_exit.Id = 2;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_exit_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "&Quản Lý";
            this.barSubItem2.Id = 3;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_qyanlybatch),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_quanlyuser),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_nangsuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_tiendo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_xuatexcel)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // btn_zoomimage
            // 
            this.btn_zoomimage.Caption = "&Zoom Image";
            this.btn_zoomimage.Id = 4;
            this.btn_zoomimage.Name = "btn_zoomimage";
            // 
            // btn_qyanlybatch
            // 
            this.btn_qyanlybatch.Caption = "Quản lý &Batch";
            this.btn_qyanlybatch.Id = 5;
            this.btn_qyanlybatch.Name = "btn_qyanlybatch";
            // 
            // btn_quanlyuser
            // 
            this.btn_quanlyuser.Caption = "Quản lý &User";
            this.btn_quanlyuser.Id = 6;
            this.btn_quanlyuser.Name = "btn_quanlyuser";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Check";
            this.barButtonItem5.Id = 7;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "&Check";
            this.barSubItem4.Id = 8;
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Id = 9;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // btn_nangsuat
            // 
            this.btn_nangsuat.Caption = "&Năng suất";
            this.btn_nangsuat.Id = 10;
            this.btn_nangsuat.Name = "btn_nangsuat";
            // 
            // btn_tiendo
            // 
            this.btn_tiendo.Caption = "&Tiến độ";
            this.btn_tiendo.Id = 11;
            this.btn_tiendo.Name = "btn_tiendo";
            // 
            // btn_xuatexcel
            // 
            this.btn_xuatexcel.Caption = "Xuất &Excel";
            this.btn_xuatexcel.Id = 12;
            this.btn_xuatexcel.Name = "btn_xuatexcel";
            // 
            // frm_Main
            // 
            this.ClientSize = new System.Drawing.Size(1300, 645);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JEMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btn_logout;
        private DevExpress.XtraBars.BarButtonItem btn_exit;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem btn_zoomimage;
        private DevExpress.XtraBars.BarButtonItem btn_qyanlybatch;
        private DevExpress.XtraBars.BarButtonItem btn_quanlyuser;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarButtonItem btn_nangsuat;
        private DevExpress.XtraBars.BarButtonItem btn_tiendo;
        private DevExpress.XtraBars.BarButtonItem btn_xuatexcel;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
    }
}

