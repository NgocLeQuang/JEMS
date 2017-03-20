using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace JEMS.MyForm
{
    public partial class frm_ChiTietTienDo : DevExpress.XtraEditors.XtraForm
    {
        public frm_ChiTietTienDo()
        {
            InitializeComponent();
        }

        private void frm_ChiTietTienDo_Load(object sender, EventArgs e)
        {
            lb_TongSoHinh.Text =(from w in Global.db.tbl_Images where w.fbatchname == lb_fBatchName.Text select w.idimage).Count().ToString();

            lb_SoHinhChuaNhap.Text = (from w in Global.db.tbl_Images where w.fbatchname == lb_fBatchName.Text && w.TienDoDESO == "Hình chưa nhập" select w.idimage).Count().ToString();
            lb_SoHinhDangNhap.Text = (from w in Global.db.tbl_Images where w.fbatchname == lb_fBatchName.Text && w.TienDoDESO == "Hình đang nhập" select w.idimage).Count().ToString();
            lb_SoHinhChoCheck.Text = (from w in Global.db.tbl_Images where w.fbatchname == lb_fBatchName.Text && w.TienDoDESO == "Hình chờ check" select w.idimage).Count().ToString();
            lb_SoHinhDangCheck.Text = (from w in Global.db.tbl_Images where w.fbatchname == lb_fBatchName.Text && w.TienDoDESO == "Hình đang check" select w.idimage).Count().ToString();
            lb_SoHinhHoanThanh.Text = (from w in Global.db.tbl_Images where w.fbatchname == lb_fBatchName.Text && w.TienDoDESO == "Hình hoàn thành" select w.idimage).Count().ToString();

            gridControl1.DataSource = null;
            gridControl1.DataSource = Global.db.ChiTietTienDo(lb_fBatchName.Text);
            gridView1.RowCellStyle += GridView1_RowCellStyle;
        }

        private void GridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            //doi mau row chan
            //if (e.RowHandle >= 0)
            //{
            //    if (e.RowHandle % 2 == 0)//    {
            //        e.Appearance.BackColor = Color.AntiqueWhite;
            //    }
            //}
            //Doi mau cell cua colummn Status, neu co gia tri Actived thi co mau xanh, neu co gia tri N/A thi co mau hong`
            if (e.Column.FieldName == "ThongTin")
            {
                string category = view.GetRowCellDisplayText(e.RowHandle, view.Columns["ThongTin"]);
                if (category == "Hình đang nhập")
                    e.Appearance.BackColor = Color.HotPink;
                else if (category == "Hình chờ check")
                {
                    e.Appearance.BackColor = Color.OrangeRed;
                    e.Appearance.ForeColor = Color.White;
                }
                else if (category == "Hình đang check")
                {
                    e.Appearance.BackColor = Color.Purple;
                    e.Appearance.ForeColor = Color.White;
                }
                else if (category == "Hình hoàn thành")
                {
                    e.Appearance.BackColor = Color.Green;
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }

        private void popupContainerControl1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void repositoryItemPopupContainerEdit1_Click(object sender, EventArgs e)
        {
            string idimage = gridView1.GetFocusedRowCellValue("idimage").ToString();
            gridControl2.DataSource = null;
            
            gridControl2.DataSource = Global.db.ChiTietUserDeSo(lb_fBatchName.Text, idimage);
        }
    }
}