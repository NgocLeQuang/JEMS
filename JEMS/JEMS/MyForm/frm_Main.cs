using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using JEMS.MyForm;

namespace JEMS.MyForm
{
    public partial class frm_Main : DevExpress.XtraEditors.XtraForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            lb_IdImage.Text = "";
            lb_fBatchName.Text = Global.StrBatch;
            lb_UserName.Text = Global.StrUsername;
            lb_TongSoHinh.Text = (from w in Global.db_JEMS.tbl_Images where w.fbatchname == Global.StrBatch select w.idimage).Count().ToString();
            lb_SoHinhConLai.Text = (from w in Global.db_JEMS.tbl_Images
                                    where w.ReadImageDESo < 2 && w.fbatchname == Global.StrBatch && (w.UserNameDESo != Global.StrUsername || w.UserNameDESo==null|| w.UserNameDESo=="")
                                    select w.idimage).Count().ToString();
            lb_SoHinhLamDuoc.Text = (from w in Global.db_JEMS.tbl_MissImage_DESOs
                                     where w.UserName == Global.StrUsername && w.fBatchName == Global.StrBatch
                                     select w.IdImage).Count().ToString();
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btn_Start_Submit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Logout_Click(object sender, EventArgs e)
        {

        }

        private void btn_quanlyuser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frm_User().ShowDialog();
        }

        private void btn_qyanlybatch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frm_ManagerBatch().ShowDialog();
        }
    }
}
