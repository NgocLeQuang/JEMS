using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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

        private void RefreshBatch()
        {
            var temp = from var in Global.db.tbl_Batches select var;
            gridControl1.DataSource = temp;
        }

        

        private void btn_TaoBatch_Click(object sender, EventArgs e)
        {
            new frm_CreateBatch().ShowDialog();
            RefreshBatch();
        }
        
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fbatchname = gridView1.GetFocusedRowCellValue("fBatchName").ToString();
            string temp = Global.StrPath + "\\" + fbatchname;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa batch: " + fbatchname + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Global.db.XoaBatch(fbatchname);
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