﻿namespace JEMS.MyForm
{
    partial class frm_ManagerBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ManagerBatch));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tbn_Xoa_Nhieu_Batch = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TaoBatch = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDBatch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fBatchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fdatecreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fusercreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fPathPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fLoaiPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fSoLuongAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tbn_Xoa_Nhieu_Batch);
            this.panelControl1.Controls.Add(this.btn_TaoBatch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 502);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(856, 42);
            this.panelControl1.TabIndex = 0;
            // 
            // tbn_Xoa_Nhieu_Batch
            // 
            this.tbn_Xoa_Nhieu_Batch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbn_Xoa_Nhieu_Batch.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tbn_Xoa_Nhieu_Batch.Appearance.Options.UseFont = true;
            this.tbn_Xoa_Nhieu_Batch.Location = new System.Drawing.Point(578, 7);
            this.tbn_Xoa_Nhieu_Batch.Name = "tbn_Xoa_Nhieu_Batch";
            this.tbn_Xoa_Nhieu_Batch.Size = new System.Drawing.Size(120, 29);
            this.tbn_Xoa_Nhieu_Batch.TabIndex = 0;
            this.tbn_Xoa_Nhieu_Batch.Text = "Xóa Batch";
            this.tbn_Xoa_Nhieu_Batch.Click += new System.EventHandler(this.tbn_Xoa_Nhieu_Batch_Click);
            // 
            // btn_TaoBatch
            // 
            this.btn_TaoBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TaoBatch.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_TaoBatch.Appearance.Options.UseFont = true;
            this.btn_TaoBatch.Location = new System.Drawing.Point(705, 7);
            this.btn_TaoBatch.Name = "btn_TaoBatch";
            this.btn_TaoBatch.Size = new System.Drawing.Size(120, 29);
            this.btn_TaoBatch.TabIndex = 0;
            this.btn_TaoBatch.Text = "Tạo Batch";
            this.btn_TaoBatch.Click += new System.EventHandler(this.btn_TaoBatch_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit2});
            this.gridControl1.Size = new System.Drawing.Size(856, 502);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FloralWhite;
            this.gridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.FloralWhite;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDBatch,
            this.fBatchName,
            this.fdatecreated,
            this.fusercreate,
            this.fPathPicture,
            this.fLocation,
            this.fLoaiPhieu,
            this.fSoLuongAnh,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // IDBatch
            // 
            this.IDBatch.AppearanceHeader.Options.UseTextOptions = true;
            this.IDBatch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IDBatch.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.IDBatch.Caption = "IDBatch";
            this.IDBatch.FieldName = "IDBatch";
            this.IDBatch.Name = "IDBatch";
            this.IDBatch.OptionsColumn.ReadOnly = true;
            this.IDBatch.Visible = true;
            this.IDBatch.VisibleIndex = 1;
            this.IDBatch.Width = 67;
            // 
            // fBatchName
            // 
            this.fBatchName.AppearanceHeader.Options.UseTextOptions = true;
            this.fBatchName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fBatchName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fBatchName.Caption = "Tên Batch";
            this.fBatchName.FieldName = "fBatchName";
            this.fBatchName.Name = "fBatchName";
            this.fBatchName.OptionsColumn.ReadOnly = true;
            this.fBatchName.Visible = true;
            this.fBatchName.VisibleIndex = 2;
            this.fBatchName.Width = 90;
            // 
            // fdatecreated
            // 
            this.fdatecreated.AppearanceHeader.Options.UseTextOptions = true;
            this.fdatecreated.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fdatecreated.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fdatecreated.Caption = "Ngày tạo Batch";
            this.fdatecreated.FieldName = "fDateCreated";
            this.fdatecreated.Name = "fdatecreated";
            this.fdatecreated.OptionsColumn.ReadOnly = true;
            this.fdatecreated.Visible = true;
            this.fdatecreated.VisibleIndex = 3;
            this.fdatecreated.Width = 90;
            // 
            // fusercreate
            // 
            this.fusercreate.AppearanceHeader.Options.UseTextOptions = true;
            this.fusercreate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fusercreate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fusercreate.Caption = "User tạo Batch";
            this.fusercreate.FieldName = "fUserCreate";
            this.fusercreate.Name = "fusercreate";
            this.fusercreate.OptionsColumn.ReadOnly = true;
            this.fusercreate.Visible = true;
            this.fusercreate.VisibleIndex = 4;
            this.fusercreate.Width = 90;
            // 
            // fPathPicture
            // 
            this.fPathPicture.AppearanceHeader.Options.UseTextOptions = true;
            this.fPathPicture.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fPathPicture.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fPathPicture.Caption = "Đường dẫn up batch";
            this.fPathPicture.FieldName = "fPathPicture";
            this.fPathPicture.Name = "fPathPicture";
            this.fPathPicture.OptionsColumn.ReadOnly = true;
            this.fPathPicture.Visible = true;
            this.fPathPicture.VisibleIndex = 5;
            this.fPathPicture.Width = 90;
            // 
            // fLocation
            // 
            this.fLocation.AppearanceHeader.Options.UseTextOptions = true;
            this.fLocation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fLocation.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fLocation.Caption = "Path xuất trong excel";
            this.fLocation.FieldName = "fLocation";
            this.fLocation.Name = "fLocation";
            this.fLocation.OptionsColumn.ReadOnly = true;
            this.fLocation.Visible = true;
            this.fLocation.VisibleIndex = 6;
            this.fLocation.Width = 98;
            // 
            // fLoaiPhieu
            // 
            this.fLoaiPhieu.Caption = "Loại phiếu";
            this.fLoaiPhieu.FieldName = "fLoaiPhieu";
            this.fLoaiPhieu.Name = "fLoaiPhieu";
            this.fLoaiPhieu.OptionsColumn.ReadOnly = true;
            this.fLoaiPhieu.Visible = true;
            this.fLoaiPhieu.VisibleIndex = 7;
            this.fLoaiPhieu.Width = 87;
            // 
            // fSoLuongAnh
            // 
            this.fSoLuongAnh.AppearanceHeader.Options.UseTextOptions = true;
            this.fSoLuongAnh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fSoLuongAnh.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fSoLuongAnh.Caption = "Số lượng ảnh";
            this.fSoLuongAnh.FieldName = "fSoLuongAnh";
            this.fSoLuongAnh.Name = "fSoLuongAnh";
            this.fSoLuongAnh.OptionsColumn.ReadOnly = true;
            this.fSoLuongAnh.Visible = true;
            this.fSoLuongAnh.VisibleIndex = 8;
            this.fSoLuongAnh.Width = 87;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "Xoá Batch";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEdit2;
            this.gridColumn1.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            this.gridColumn1.Width = 65;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit2.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.ReadOnly = true;
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit2_ButtonClick);
            // 
            // frm_ManagerBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 544);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ManagerBatch";
            this.Text = "Quản lý Batch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ManagerBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_TaoBatch;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IDBatch;
        private DevExpress.XtraGrid.Columns.GridColumn fBatchName;
        private DevExpress.XtraGrid.Columns.GridColumn fdatecreated;
        private DevExpress.XtraGrid.Columns.GridColumn fusercreate;
        private DevExpress.XtraGrid.Columns.GridColumn fPathPicture;
        private DevExpress.XtraGrid.Columns.GridColumn fLocation;
        private DevExpress.XtraGrid.Columns.GridColumn fSoLuongAnh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn fLoaiPhieu;
        private DevExpress.XtraEditors.SimpleButton tbn_Xoa_Nhieu_Batch;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
    }
}