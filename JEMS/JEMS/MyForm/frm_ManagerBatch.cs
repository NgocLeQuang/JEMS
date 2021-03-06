﻿using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace JEMS.MyForm
{
    public partial class frm_ManagerBatch : DevExpress.XtraEditors.XtraForm
    {
        public frm_ManagerBatch()
        {
            InitializeComponent();
        }

        private void frm_ManagerBatch_Load(object sender, EventArgs e)
        {
            RefreshBatch();
        }
        public bool Cal(int width, GridView view)
        {
            view.IndicatorWidth = view.IndicatorWidth < width ? width : view.IndicatorWidth;
            return true;
        }

        private void LoadSttGridView(RowIndicatorCustomDrawEventArgs e, GridView dgv)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
            int width = Convert.ToInt32(size.Width) + 20;
            BeginInvoke(new MethodInvoker(delegate { Cal(width, dgv); }));
        }

        private void RefreshBatch()
        {
            var temp = (from var in Global.db.tbl_Batches orderby var.fDateCreated descending select var);
            gridControl1.DataSource = temp;
        }

        

        private void btn_TaoBatch_Click(object sender, EventArgs e)
        {
            new frm_CreateBatch().ShowDialog();
            RefreshBatch();
        }
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            LoadSttGridView(e,gridView1);
        }

        private void tbn_Xoa_Nhieu_Batch_Click(object sender, EventArgs e)
        {
            int i = 0;
            string s = "";
            foreach (var rowHandle in gridView1.GetSelectedRows())
            {
                i += 1;
                string fbatchname = gridView1.GetRowCellValue(rowHandle, "fBatchName").ToString();
                s += fbatchname + "\n";
            }
            if (i<=0)
            {
                MessageBox.Show("Bạn chưa chọn batch. Vui lòng chọn batch trước khi xóa");
                return;
            }
            if(MessageBox.Show("Bạn muốn xóa "+i+" batch sau:\n"+s,"Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.No)
                return;
            foreach (var rowHandle in gridView1.GetSelectedRows())
            {
                string fbatchname = gridView1.GetRowCellValue(rowHandle,"fBatchName").ToString();
                string temp = Global.StrPath + "\\" + fbatchname;
                Global.db.XoaBatch_QuanLyDuAn(fbatchname, Global.StrIdProject);
                Directory.Delete(temp, true);
            }
            RefreshBatch();
        }

        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fbatchname = gridView1.GetFocusedRowCellValue("fBatchName").ToString();
            string temp = Global.StrPath + "\\" + fbatchname;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa batch: " + fbatchname + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Global.db.XoaBatch_QuanLyDuAn(fbatchname, Global.StrIdProject);
                    Directory.Delete(temp, true);
                    MessageBox.Show("Đã xóa batch thành công!");

                }
                catch (Exception)
                {

                    MessageBox.Show("Xóa batch bị lỗi!");

                }

            }
            RefreshBatch();
        }
    }
}