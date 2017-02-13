using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using JEMS.Properties;

namespace JEMS.MyForm
{
    public partial class frm_Main : DevExpress.XtraEditors.XtraForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private void setValue()
        {
            if (Global.StrRole == "DESO")
            {
                lb_SoHinhConLai.Text = (from w in Global.db.tbl_Images
                                        where w.ReadImageDESo < 2 && w.fbatchname == Global.StrBatch && w.UserNameDESo != Global.StrUsername
                                        select w.idimage).Count().ToString();
                lb_SoHinhLamDuoc.Text = (from w in Global.db.tbl_MissImage_DESOs
                                         where w.UserName == Global.StrUsername && w.fBatchName == Global.StrBatch
                                         select w.IdImage).Count().ToString();
            }
        }

        public string GetImage()
        {
            if (Global.StrRole == "DESO")
            {
                string temp = (from w in Global.db.tbl_MissImage_DESOs
                               where w.fBatchName == Global.StrBatch && w.UserName == Global.StrUsername && w.Submit == 0
                               select w.IdImage).FirstOrDefault();
                if (string.IsNullOrEmpty(temp))
                {
                    try
                    {
                        var getFilename =
                            (from w in Global.db.LayHinhMoi_DeSo(Global.StrBatch, Global.StrUsername)
                             select w.Column1).FirstOrDefault();
                        if (string.IsNullOrEmpty(getFilename))
                        {
                            return "NULL";
                        }
                        lb_IdImage.Text = getFilename;
                        uc_PictureBox1.imageBox1.Image = null;
                        if (uc_PictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + getFilename, getFilename,
                            Settings.Default.ZoomImage) == "Error")
                        {
                            uc_PictureBox1.imageBox1.Image = Resources.svn_deleted;
                            return "Error";

                        }
                    }
                    catch (Exception i)
                    {
                        return "NULL";
                    }
                }
                else
                {
                    lb_IdImage.Text = temp;
                    uc_PictureBox1.imageBox1.Image = null;
                    if (uc_PictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + temp, temp,
                        Settings.Default.ZoomImage) == "Error")
                    {
                        uc_PictureBox1.imageBox1.Image = Resources.svn_deleted;
                        return "Error";
                    }
                }
                if (tabControl_Main.SelectedTabPage == tp_Asahi_Main)
                    uc_ASAHI1.txt_Truong02.Focus();
                else if (tabControl_Main.SelectedTabPage == tp_EIZEN_Main)
                    uc_EZIEN1.txt_Truong02.Focus();
                else if (tabControl_Main.SelectedTabPage == tp_YAMAMOTO_Main)
                    uc_YAMAMOTO4.txt_Truong02.Focus();
                else if (tabControl_Main.SelectedTabPage == tp_YASUDA_Main)
                    uc_YASUDA1.txt_Truong02.Focus();
            }
            return "OK";
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                Global.LoaiPhieu = (from w in Global.db.tbl_Batches where w.fBatchName == Global.StrBatch select w.fLoaiPhieu).FirstOrDefault();
                lb_IdImage.Text = "";
                lb_fBatchName.Text = Global.StrBatch;
                lb_UserName.Text = Global.StrUsername;
                lb_TongSoHinh.Text = (from w in Global.db.tbl_Images where w.fbatchname == Global.StrBatch select w.idimage).Count().ToString();
                lb_SoHinhConLai.Text = (from w in Global.db.tbl_Images
                                        where w.ReadImageDESo < 2 && w.fbatchname == Global.StrBatch && (w.UserNameDESo != Global.StrUsername || w.UserNameDESo == null || w.UserNameDESo == "")
                                        select w.idimage).Count().ToString();
                lb_SoHinhLamDuoc.Text = (from w in Global.db.tbl_MissImage_DESOs
                                         where w.UserName == Global.StrUsername && w.fBatchName == Global.StrBatch
                                         select w.IdImage).Count().ToString();

                tp_Asahi_Main.PageVisible = false;
                tp_EIZEN_Main.PageVisible = false;
                tp_YAMAMOTO_Main.PageVisible = false;
                tp_YASUDA_Main.PageVisible = false;

                menu_quanly.Enabled = false;

                if (Global.StrRole == "DESO")
                {
                    if (Global.LoaiPhieu == "ASAHI")
                        tp_Asahi_Main.PageVisible = true;
                    else if (Global.LoaiPhieu == "EIZEN")
                        tp_EIZEN_Main.PageVisible = true;
                    else if (Global.LoaiPhieu == "YAMAMOTO")
                        tp_YAMAMOTO_Main.PageVisible = true;
                    else if (Global.LoaiPhieu == "YASUDA")
                        tp_YASUDA_Main.PageVisible = true;
                    
                }
                else
                {
                    btn_Start_Submit.Enabled = false;
                    btn_Submit_Logout.Enabled = false;
                    menu_quanly.Enabled = true;
                }
                setValue();
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi Load Main: " + i.Message);
            }

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
            try
            {
                //Kiểm tra token
                var token = (from w in Global.db_BPO.tbl_TokenLogins
                             where w.UserName == Global.StrUsername && w.IDProject == Global.StrIdProject
                             select w.Token).FirstOrDefault();

                if (token != Global.Strtoken)
                {
                    MessageBox.Show("User đã đăng nhập ở PC khác, bạn vui lòng đăng nhập lại!");
                    DialogResult = DialogResult.Yes;
                }
                if (btn_Start_Submit.Text == "Start")
                {
                    if (string.IsNullOrEmpty(Global.StrBatch))
                    {
                        MessageBox.Show("Vui lòng đăng nhập lại và chọn Batch!");
                        return;
                    }

                    string temp = GetImage();
                    if (temp == "NULL")
                    {
                        MessageBox.Show("Hết Hình!");
                        btn_logout_ItemClick(null, null);
                    }
                    else if (temp == "Error")
                    {
                        MessageBox.Show("Không thể load hình!");
                        btn_logout_ItemClick(null, null);
                    }
                    uc_ASAHI1.ResetData();
                    uc_EZIEN1.ResetData();
                    uc_YAMAMOTO4.ResetData();
                    uc_YASUDA1.ResetData();
                    btn_Start_Submit.Text = "Submit";
                    btn_Submit_Logout.Visible = true;
                }
                else
                {
                    if (Global.StrRole == "DESO")
                    {
                        if (tabControl_Main.SelectedTabPage == tp_Asahi_Main)
                        {
                            if (uc_ASAHI1.IsEmpty())
                            {
                                if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                    return;
                            }
                            uc_ASAHI1.SaveData_ASAHI(lb_IdImage.Text);
                        }
                        else if (tabControl_Main.SelectedTabPage == tp_EIZEN_Main)
                        {
                            if (uc_EZIEN1.IsEmpty())
                            {
                                if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                    return;
                            }
                            uc_EZIEN1.SaveData_EIZEN(lb_IdImage.Text);
                        }
                        else if (tabControl_Main.SelectedTabPage == tp_YAMAMOTO_Main)
                        {
                            if (uc_YAMAMOTO4.IsEmpty())
                            {
                                if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                    return;
                            }
                            uc_YAMAMOTO4.SaveData_YAMAMOTO(lb_IdImage.Text);

                        }
                        else if (tabControl_Main.SelectedTabPage == tp_YASUDA_Main)
                        {
                            if (uc_YASUDA1.IsEmpty())
                            {
                                if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                    return;
                            }

                            uc_YASUDA1.SaveData_YASUDA(lb_IdImage.Text);
                        }

                        uc_ASAHI1.ResetData();
                        uc_EZIEN1.ResetData();
                        uc_YAMAMOTO4.ResetData();
                        uc_YASUDA1.ResetData();
                    }
                    string temp = GetImage();
                    if (temp == "NULL")
                    {
                        MessageBox.Show("Hết Hình!");
                        btn_logout_ItemClick(null, null);
                    }
                    else if (temp == "Error")
                    {
                        MessageBox.Show("Không thể load hình!");
                        btn_logout_ItemClick(null, null);
                    }
                }
                setValue();
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi khi Submit" + i.Message);
            }
        }

        private void btn_Submit_Logout_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra token
                var token = (from w in Global.db_BPO.tbl_TokenLogins
                             where w.UserName == Global.StrUsername && w.IDProject == Global.StrIdProject
                             select w.Token).FirstOrDefault();

                if (token != Global.Strtoken)
                {
                    MessageBox.Show("User đã đăng nhập ở PC khác, bạn vui lòng đăng nhập lại!");
                    DialogResult = DialogResult.Yes;
                }
                
                if (Global.StrRole == "DESO")
                {
                    if (tabControl_Main.SelectedTabPage == tp_Asahi_Main)
                    {
                        if (uc_ASAHI1.IsEmpty())
                        {
                            if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                return;
                        }
                        uc_ASAHI1.SaveData_ASAHI(lb_IdImage.Text);
                    }
                    else if (tabControl_Main.SelectedTabPage == tp_EIZEN_Main)
                    {
                        if (uc_EZIEN1.IsEmpty())
                        {
                            if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                return;
                        }
                        uc_EZIEN1.SaveData_EIZEN(lb_IdImage.Text);
                    }
                    else if (tabControl_Main.SelectedTabPage == tp_YAMAMOTO_Main)
                    {
                        if (uc_YAMAMOTO4.IsEmpty())
                        {
                            if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                return;
                        }
                        uc_YAMAMOTO4.SaveData_YAMAMOTO(lb_IdImage.Text);

                    }
                    else if (tabControl_Main.SelectedTabPage == tp_YASUDA_Main)
                    {
                        if (uc_YASUDA1.IsEmpty())
                        {
                            if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                return;
                        }

                        uc_YASUDA1.SaveData_YASUDA(lb_IdImage.Text);
                    }
                }
                btn_logout_ItemClick(null, null);
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi khi Submit_Logout" + i.Message);
            }
        }

        private void btn_quanlyuser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frm_User().ShowDialog();
        }

        private void btn_qyanlybatch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frm_ManagerBatch().ShowDialog();
        }

        private void btn_Zoomimage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frm_ChangeZoom().ShowDialog();
        }

        private void btn_checkdeso_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Global.StrCheck = "CHECKDESO";
            new frm_Check_DeSo().ShowDialog();
        }

        private void frm_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
                btn_Start_Submit_Click(null, null);
        }

        private void btn_checkqc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Global.StrCheck = "CHECKQC";
            new frm_Check_QC().ShowDialog();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.db_BPO.ResetToken(Global.StrUsername, Global.StrIdProject,Global.Strtoken);
        }

        private void btn_xuatexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frm_ExportExcel().ShowDialog();
        }

        private void btn_nangsuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frm_NangSuat().ShowDialog();
        }

        private void btn_tiendo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frm_TienDo().ShowDialog();
        }
    }
}
