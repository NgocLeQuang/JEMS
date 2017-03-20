namespace JEMS.MyForm
{
    partial class frm_CreateBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CreateBatch));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_BatchName = new DevExpress.XtraEditors.TextEdit();
            this.txt_PathFolder = new DevExpress.XtraEditors.TextEdit();
            this.txt_Location = new DevExpress.XtraEditors.TextEdit();
            this.txt_UserCreate = new DevExpress.XtraEditors.TextEdit();
            this.txt_DateCreate = new DevExpress.XtraEditors.TextEdit();
            this.txt_ImagePath = new DevExpress.XtraEditors.TextEdit();
            this.btn_Browser = new DevExpress.XtraEditors.SimpleButton();
            this.btn_BrowserImage = new DevExpress.XtraEditors.SimpleButton();
            this.btn_CreateBatch = new DevExpress.XtraEditors.SimpleButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lb_SoLuongHinh = new DevExpress.XtraEditors.LabelControl();
            this.txt_LoaiPhieu = new System.Windows.Forms.ComboBox();
            this.dateEdit_ngaybatdau = new DevExpress.XtraEditors.DateEdit();
            this.timeEdit_ngaybatdau = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit_ngayketthuc = new DevExpress.XtraEditors.DateEdit();
            this.timeEdit_ngayketthuc = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.nud_songaylam = new System.Windows.Forms.NumericUpDown();
            this.nud_sogiolam = new System.Windows.Forms.NumericUpDown();
            this.nud_sophutlam = new System.Windows.Forms.NumericUpDown();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.nud_thoigiandeadline = new System.Windows.Forms.NumericUpDown();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.cbb_loaithoigian = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PathFolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Location.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserCreate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DateCreate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ImagePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ngaybatdau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ngaybatdau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_ngaybatdau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ngayketthuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ngayketthuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_ngayketthuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_songaylam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sogiolam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sophutlam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_thoigiandeadline)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(221, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(182, 27);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "TẠO BATCH MỚI";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên Batch (đơn):";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 99);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Folder Batch (nhiều):";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 128);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Đường dẫn:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(30, 158);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "User tạo Batch:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(30, 189);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Ngày tạo Batch:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(30, 221);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(91, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Đường dẫn Image:";
            // 
            // txt_BatchName
            // 
            this.txt_BatchName.Location = new System.Drawing.Point(137, 65);
            this.txt_BatchName.Name = "txt_BatchName";
            this.txt_BatchName.Size = new System.Drawing.Size(356, 20);
            this.txt_BatchName.TabIndex = 2;
            this.txt_BatchName.EditValueChanged += new System.EventHandler(this.txt_BatchName_EditValueChanged);
            // 
            // txt_PathFolder
            // 
            this.txt_PathFolder.Location = new System.Drawing.Point(137, 96);
            this.txt_PathFolder.Name = "txt_PathFolder";
            this.txt_PathFolder.Size = new System.Drawing.Size(356, 20);
            this.txt_PathFolder.TabIndex = 2;
            this.txt_PathFolder.EditValueChanged += new System.EventHandler(this.txt_PathFolder_EditValueChanged);
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(137, 125);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(356, 20);
            this.txt_Location.TabIndex = 2;
            // 
            // txt_UserCreate
            // 
            this.txt_UserCreate.Location = new System.Drawing.Point(137, 155);
            this.txt_UserCreate.Name = "txt_UserCreate";
            this.txt_UserCreate.Properties.ReadOnly = true;
            this.txt_UserCreate.Size = new System.Drawing.Size(174, 20);
            this.txt_UserCreate.TabIndex = 2;
            // 
            // txt_DateCreate
            // 
            this.txt_DateCreate.Location = new System.Drawing.Point(137, 186);
            this.txt_DateCreate.Name = "txt_DateCreate";
            this.txt_DateCreate.Properties.ReadOnly = true;
            this.txt_DateCreate.Size = new System.Drawing.Size(174, 20);
            this.txt_DateCreate.TabIndex = 2;
            // 
            // txt_ImagePath
            // 
            this.txt_ImagePath.Location = new System.Drawing.Point(137, 218);
            this.txt_ImagePath.Name = "txt_ImagePath";
            this.txt_ImagePath.Properties.ReadOnly = true;
            this.txt_ImagePath.Size = new System.Drawing.Size(356, 20);
            this.txt_ImagePath.TabIndex = 2;
            // 
            // btn_Browser
            // 
            this.btn_Browser.Location = new System.Drawing.Point(499, 94);
            this.btn_Browser.Name = "btn_Browser";
            this.btn_Browser.Size = new System.Drawing.Size(85, 23);
            this.btn_Browser.TabIndex = 3;
            this.btn_Browser.Text = "Browser...";
            this.btn_Browser.Click += new System.EventHandler(this.btn_Browser_Click);
            // 
            // btn_BrowserImage
            // 
            this.btn_BrowserImage.Location = new System.Drawing.Point(499, 216);
            this.btn_BrowserImage.Name = "btn_BrowserImage";
            this.btn_BrowserImage.Size = new System.Drawing.Size(85, 23);
            this.btn_BrowserImage.TabIndex = 3;
            this.btn_BrowserImage.Text = "Chọn Image...";
            this.btn_BrowserImage.Click += new System.EventHandler(this.btn_BrowserImage_Click);
            // 
            // btn_CreateBatch
            // 
            this.btn_CreateBatch.Location = new System.Drawing.Point(221, 457);
            this.btn_CreateBatch.Name = "btn_CreateBatch";
            this.btn_CreateBatch.Size = new System.Drawing.Size(164, 44);
            this.btn_CreateBatch.TabIndex = 4;
            this.btn_CreateBatch.Text = "Tạo Batch";
            this.btn_CreateBatch.Click += new System.EventHandler(this.btn_CreateBatch_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarControl1.Location = new System.Drawing.Point(0, 531);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Step = 1;
            this.progressBarControl1.Size = new System.Drawing.Size(632, 40);
            this.progressBarControl1.TabIndex = 5;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(31, 283);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(55, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Loại Phiếu :";
            // 
            // lb_SoLuongHinh
            // 
            this.lb_SoLuongHinh.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lb_SoLuongHinh.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_SoLuongHinh.Appearance.Options.UseFont = true;
            this.lb_SoLuongHinh.Appearance.Options.UseForeColor = true;
            this.lb_SoLuongHinh.Location = new System.Drawing.Point(137, 248);
            this.lb_SoLuongHinh.Name = "lb_SoLuongHinh";
            this.lb_SoLuongHinh.Size = new System.Drawing.Size(0, 19);
            this.lb_SoLuongHinh.TabIndex = 6;
            // 
            // txt_LoaiPhieu
            // 
            this.txt_LoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_LoaiPhieu.FormattingEnabled = true;
            this.txt_LoaiPhieu.Location = new System.Drawing.Point(137, 278);
            this.txt_LoaiPhieu.Name = "txt_LoaiPhieu";
            this.txt_LoaiPhieu.Size = new System.Drawing.Size(174, 21);
            this.txt_LoaiPhieu.TabIndex = 7;
            // 
            // dateEdit_ngaybatdau
            // 
            this.dateEdit_ngaybatdau.EditValue = null;
            this.dateEdit_ngaybatdau.Location = new System.Drawing.Point(137, 314);
            this.dateEdit_ngaybatdau.Name = "dateEdit_ngaybatdau";
            this.dateEdit_ngaybatdau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_ngaybatdau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_ngaybatdau.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEdit_ngaybatdau.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEdit_ngaybatdau.Size = new System.Drawing.Size(100, 20);
            this.dateEdit_ngaybatdau.TabIndex = 8;
            this.dateEdit_ngaybatdau.EditValueChanged += new System.EventHandler(this.dateEdit_ngaybatdau_EditValueChanged);
            this.dateEdit_ngaybatdau.Click += new System.EventHandler(this.dateEdit_ngaybatdau_Click);
            // 
            // timeEdit_ngaybatdau
            // 
            this.timeEdit_ngaybatdau.EditValue = new System.DateTime(2017, 3, 16, 0, 0, 0, 0);
            this.timeEdit_ngaybatdau.Location = new System.Drawing.Point(253, 314);
            this.timeEdit_ngaybatdau.Name = "timeEdit_ngaybatdau";
            this.timeEdit_ngaybatdau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit_ngaybatdau.Properties.Mask.EditMask = "HH:mm:ss";
            this.timeEdit_ngaybatdau.Size = new System.Drawing.Size(92, 20);
            this.timeEdit_ngaybatdau.TabIndex = 9;
            this.timeEdit_ngaybatdau.EditValueChanged += new System.EventHandler(this.timeEdit_ngaybatdau_EditValueChanged);
            this.timeEdit_ngaybatdau.Click += new System.EventHandler(this.timeEdit_ngaybatdau_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(30, 317);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(90, 13);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "Thời gian bắt đầu :";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(31, 348);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(69, 13);
            this.labelControl10.TabIndex = 1;
            this.labelControl10.Text = "Thời gian làm :";
            // 
            // dateEdit_ngayketthuc
            // 
            this.dateEdit_ngayketthuc.EditValue = null;
            this.dateEdit_ngayketthuc.Location = new System.Drawing.Point(137, 377);
            this.dateEdit_ngayketthuc.Name = "dateEdit_ngayketthuc";
            this.dateEdit_ngayketthuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_ngayketthuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_ngayketthuc.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEdit_ngayketthuc.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEdit_ngayketthuc.Size = new System.Drawing.Size(100, 20);
            this.dateEdit_ngayketthuc.TabIndex = 8;
            this.dateEdit_ngayketthuc.EditValueChanged += new System.EventHandler(this.dateEdit_ngayketthuc_EditValueChanged);
            this.dateEdit_ngayketthuc.Click += new System.EventHandler(this.dateEdit_ngayketthuc_Click);
            // 
            // timeEdit_ngayketthuc
            // 
            this.timeEdit_ngayketthuc.EditValue = new System.DateTime(2017, 3, 16, 0, 0, 0, 0);
            this.timeEdit_ngayketthuc.Location = new System.Drawing.Point(253, 377);
            this.timeEdit_ngayketthuc.Name = "timeEdit_ngayketthuc";
            this.timeEdit_ngayketthuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit_ngayketthuc.Properties.Mask.EditMask = "HH:mm:ss";
            this.timeEdit_ngayketthuc.Size = new System.Drawing.Size(92, 20);
            this.timeEdit_ngayketthuc.TabIndex = 9;
            this.timeEdit_ngayketthuc.EditValueChanged += new System.EventHandler(this.timeEdit_ngayketthuc_EditValueChanged);
            this.timeEdit_ngayketthuc.Click += new System.EventHandler(this.timeEdit_ngayketthuc_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(30, 380);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(92, 13);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "Thời gian kết thúc :";
            // 
            // nud_songaylam
            // 
            this.nud_songaylam.Location = new System.Drawing.Point(137, 344);
            this.nud_songaylam.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_songaylam.Name = "nud_songaylam";
            this.nud_songaylam.Size = new System.Drawing.Size(59, 21);
            this.nud_songaylam.TabIndex = 10;
            this.nud_songaylam.ValueChanged += new System.EventHandler(this.nud_songaylam_ValueChanged);
            this.nud_songaylam.Click += new System.EventHandler(this.nud_songaylam_Click);
            // 
            // nud_sogiolam
            // 
            this.nud_sogiolam.Location = new System.Drawing.Point(242, 344);
            this.nud_sogiolam.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_sogiolam.Name = "nud_sogiolam";
            this.nud_sogiolam.Size = new System.Drawing.Size(59, 21);
            this.nud_sogiolam.TabIndex = 10;
            this.nud_sogiolam.ValueChanged += new System.EventHandler(this.nud_sogiolam_ValueChanged);
            this.nud_sogiolam.Click += new System.EventHandler(this.nud_sogiolam_Click);
            // 
            // nud_sophutlam
            // 
            this.nud_sophutlam.Location = new System.Drawing.Point(338, 343);
            this.nud_sophutlam.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_sophutlam.Name = "nud_sophutlam";
            this.nud_sophutlam.Size = new System.Drawing.Size(59, 21);
            this.nud_sophutlam.TabIndex = 10;
            this.nud_sophutlam.ValueChanged += new System.EventHandler(this.nud_sophutlam_ValueChanged);
            this.nud_sophutlam.Click += new System.EventHandler(this.nud_sophutlam_Click);
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(201, 349);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(25, 13);
            this.labelControl12.TabIndex = 1;
            this.labelControl12.Text = "Ngày";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(305, 349);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(15, 13);
            this.labelControl13.TabIndex = 1;
            this.labelControl13.Text = "Giờ";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(400, 348);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(22, 13);
            this.labelControl14.TabIndex = 1;
            this.labelControl14.Text = "Phút";
            // 
            // nud_thoigiandeadline
            // 
            this.nud_thoigiandeadline.DecimalPlaces = 2;
            this.nud_thoigiandeadline.Location = new System.Drawing.Point(137, 409);
            this.nud_thoigiandeadline.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_thoigiandeadline.Name = "nud_thoigiandeadline";
            this.nud_thoigiandeadline.Size = new System.Drawing.Size(59, 21);
            this.nud_thoigiandeadline.TabIndex = 10;
            this.nud_thoigiandeadline.ValueChanged += new System.EventHandler(this.nud_thoigiandeadline_ValueChanged);
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(30, 413);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(99, 13);
            this.labelControl15.TabIndex = 1;
            this.labelControl15.Text = "Thông báo Deadline:";
            // 
            // cbb_loaithoigian
            // 
            this.cbb_loaithoigian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loaithoigian.FormattingEnabled = true;
            this.cbb_loaithoigian.Location = new System.Drawing.Point(204, 409);
            this.cbb_loaithoigian.Name = "cbb_loaithoigian";
            this.cbb_loaithoigian.Size = new System.Drawing.Size(93, 21);
            this.cbb_loaithoigian.TabIndex = 11;
            this.cbb_loaithoigian.SelectedIndexChanged += new System.EventHandler(this.cbb_loaithoigian_SelectedIndexChanged);
            // 
            // frm_CreateBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 571);
            this.Controls.Add(this.cbb_loaithoigian);
            this.Controls.Add(this.nud_sophutlam);
            this.Controls.Add(this.nud_sogiolam);
            this.Controls.Add(this.nud_thoigiandeadline);
            this.Controls.Add(this.nud_songaylam);
            this.Controls.Add(this.timeEdit_ngayketthuc);
            this.Controls.Add(this.timeEdit_ngaybatdau);
            this.Controls.Add(this.dateEdit_ngayketthuc);
            this.Controls.Add(this.dateEdit_ngaybatdau);
            this.Controls.Add(this.txt_LoaiPhieu);
            this.Controls.Add(this.lb_SoLuongHinh);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.btn_CreateBatch);
            this.Controls.Add(this.btn_BrowserImage);
            this.Controls.Add(this.btn_Browser);
            this.Controls.Add(this.txt_ImagePath);
            this.Controls.Add(this.txt_DateCreate);
            this.Controls.Add(this.txt_UserCreate);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.txt_PathFolder);
            this.Controls.Add(this.txt_BatchName);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_CreateBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo batch mới";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_CreateBatch_FormClosed);
            this.Load += new System.EventHandler(this.frm_CreateBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PathFolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Location.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserCreate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DateCreate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ImagePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ngaybatdau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ngaybatdau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_ngaybatdau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ngayketthuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ngayketthuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_ngayketthuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_songaylam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sogiolam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sophutlam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_thoigiandeadline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_BatchName;
        private DevExpress.XtraEditors.TextEdit txt_PathFolder;
        private DevExpress.XtraEditors.TextEdit txt_Location;
        private DevExpress.XtraEditors.TextEdit txt_UserCreate;
        private DevExpress.XtraEditors.TextEdit txt_DateCreate;
        private DevExpress.XtraEditors.TextEdit txt_ImagePath;
        private DevExpress.XtraEditors.SimpleButton btn_Browser;
        private DevExpress.XtraEditors.SimpleButton btn_BrowserImage;
        private DevExpress.XtraEditors.SimpleButton btn_CreateBatch;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl lb_SoLuongHinh;
        private System.Windows.Forms.ComboBox txt_LoaiPhieu;
        private DevExpress.XtraEditors.DateEdit dateEdit_ngaybatdau;
        private DevExpress.XtraEditors.TimeEdit timeEdit_ngaybatdau;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit dateEdit_ngayketthuc;
        private DevExpress.XtraEditors.TimeEdit timeEdit_ngayketthuc;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.NumericUpDown nud_songaylam;
        private System.Windows.Forms.NumericUpDown nud_sogiolam;
        private System.Windows.Forms.NumericUpDown nud_sophutlam;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.NumericUpDown nud_thoigiandeadline;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private System.Windows.Forms.ComboBox cbb_loaithoigian;
    }
}