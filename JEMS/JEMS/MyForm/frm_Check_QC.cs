
using JEMS.Properties;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JEMS.MyForm
{
    public partial class frm_Check_QC : XtraForm
    {
        private bool _Flag=false;
        public frm_Check_QC()
        {
            InitializeComponent();
        }

        private void ResetData()
        {
            if (Global.StrCheck == "CHECKQC")
            {
                uc_AEON1.ResetData();
                uc_AEON2.ResetData();

                uc_ASAHI1.ResetData();
                uc_ASAHI2.ResetData();

                uc_EZIEN1.ResetData();
                uc_EZIEN2.ResetData();

                uc_YAMAMOTO1.ResetData();
                uc_YAMAMOTO2.ResetData();

                uc_YASUDA1.ResetData();
                uc_YASUDA2.ResetData();
            }

            uc_PictureBox1.imageBox1.Image = null;
        }

        private void Compare_TextBox(TextEdit t1, TextEdit t2)
        {
            if (!string.IsNullOrEmpty(t1.Text) || !string.IsNullOrEmpty(t2.Text))
            {
                if (t1.Text != t2.Text)
                {
                    t1.BackColor = Color.PaleVioletRed;
                    t1.ForeColor = Color.White;
                    t2.BackColor = Color.PaleVioletRed;
                    t1.ForeColor = Color.White;
                }
            }
            else
            {
                t1.BackColor = Color.White;
                t1.ForeColor = Color.Black;
                t2.BackColor = Color.White;
                t2.ForeColor = Color.Black;
            }
        }

        private void Compare_LookUpEdit(LookUpEdit t1, LookUpEdit t2)
        {
            if (t1.ItemIndex != t2.ItemIndex)
            {
                t1.BackColor = Color.PaleVioletRed;
                t2.BackColor = Color.PaleVioletRed;
            }
            else
            {
                t1.BackColor = Color.White;
                t2.BackColor = Color.White;
            }
        }

        private void frm_Check_Load(object sender, EventArgs e)
        {
            try
            {
                lb_fBatchName.Text = Global.StrBatch;
                tp_AEON_DeSo1.PageVisible = false;
                tp_ASAHI_DeSo1.PageVisible = false;
                tp_EIZEN_DeSo1.PageVisible = false;
                tp_YAMAMOTO_DeSo1.PageVisible = false;
                tp_YASUDA_DeSo1.PageVisible = false;

                tp_AEON_DeSo2.PageVisible = false;
                tp_ASAHI_DeSo2.PageVisible = false;
                tp_EIZEN_DeSo2.PageVisible = false;
                tp_YAMAMOTO_DeSo2.PageVisible = false;
                tp_YASUDA_DeSo2.PageVisible = false;

                if (Global.StrCheck == "CHECKQC")
                {

                    var soloi = (from w in Global.db.GetSoLoi_CheckQC(Global.StrBatch) select w.Column1).FirstOrDefault();
                    lb_Loi.Text = soloi + " Lỗi";

                    if (Global.LoaiPhieu == "ASAHI")
                    {
                        tp_ASAHI_DeSo1.PageVisible = true;
                        tp_ASAHI_DeSo2.PageVisible = true;
                    }
                    else if (Global.LoaiPhieu == "EIZEN")
                    {
                        tp_EIZEN_DeSo1.PageVisible = true;
                        tp_EIZEN_DeSo2.PageVisible = true;
                    }
                    else if (Global.LoaiPhieu == "YAMAMOTO")
                    {
                        tp_YAMAMOTO_DeSo1.PageVisible = true;
                        tp_YAMAMOTO_DeSo2.PageVisible = true;
                    }
                    else if (Global.LoaiPhieu == "YASUDA")
                    {
                        tp_YASUDA_DeSo1.PageVisible = true;

                        tp_YASUDA_DeSo2.PageVisible = true;
                    }
                    else if (Global.LoaiPhieu == "AEON")
                    {
                        tp_AEON_DeSo1.PageVisible = true;
                        tp_AEON_DeSo2.PageVisible = true;

                        uc_AEON1.txt_Truong03_1.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON1.txt_Truong03_1.Leave += Txt_Truong02_Leave;
                        uc_AEON1.txt_Truong05.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON1.txt_Truong05.Leave += Txt_Truong02_Leave;
                        uc_AEON1.txt_Truong13.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON1.txt_Truong13.Leave += Txt_Truong02_Leave;
                        uc_AEON1.txt_Truong21.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON1.txt_Truong21.Leave += Txt_Truong02_Leave;
                        uc_AEON1.txt_Truong29.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON1.txt_Truong29.Leave += Txt_Truong02_Leave;
                        uc_AEON1.txt_Truong37.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON1.txt_Truong37.Leave += Txt_Truong02_Leave;
                        uc_AEON1.txt_Truong45.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON1.txt_Truong45.Leave += Txt_Truong02_Leave;
                        uc_AEON1.txt_Truong61.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON1.txt_Truong61.Leave += Txt_Truong02_Leave;
                        uc_AEON1.txt_Truong53.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON1.txt_Truong53.Leave += Txt_Truong02_Leave;

                        uc_AEON2.txt_Truong03_1.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON2.txt_Truong03_1.Leave += Txt_Truong02_Leave;
                        uc_AEON2.txt_Truong05.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON2.txt_Truong05.Leave += Txt_Truong02_Leave;
                        uc_AEON2.txt_Truong13.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON2.txt_Truong13.Leave += Txt_Truong02_Leave;
                        uc_AEON2.txt_Truong21.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON2.txt_Truong21.Leave += Txt_Truong02_Leave;
                        uc_AEON2.txt_Truong29.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON2.txt_Truong29.Leave += Txt_Truong02_Leave;
                        uc_AEON2.txt_Truong37.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON2.txt_Truong37.Leave += Txt_Truong02_Leave;
                        uc_AEON2.txt_Truong45.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON2.txt_Truong45.Leave += Txt_Truong02_Leave;
                        uc_AEON2.txt_Truong61.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON2.txt_Truong61.Leave += Txt_Truong02_Leave;
                        uc_AEON2.txt_Truong53.GotFocus += Txt_Truong02_GotFocus;
                        uc_AEON2.txt_Truong53.Leave += Txt_Truong02_Leave;
                    }

                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;

                    uc_AEON1.Changed += Uc_ASAHI1_Changed;
                    uc_ASAHI1.Changed += Uc_ASAHI1_Changed;
                    uc_EZIEN1.Changed += Uc_ASAHI1_Changed;
                    uc_YAMAMOTO1.Changed += Uc_ASAHI1_Changed;
                    uc_YASUDA1.Changed += Uc_ASAHI1_Changed;

                    uc_AEON2.Changed += Uc_ASAHI2_Changed;
                    uc_ASAHI2.Changed += Uc_ASAHI2_Changed;
                    uc_EZIEN2.Changed += Uc_ASAHI2_Changed;
                    uc_YAMAMOTO2.Changed += Uc_ASAHI2_Changed;
                    uc_YASUDA2.Changed += Uc_ASAHI2_Changed;
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi" + i);
            }
        }

        private void Txt_Truong02_Leave(object sender, EventArgs e)
        {
            _Flag = false;
        }

        private void Txt_Truong02_GotFocus(object sender, EventArgs e)
        {
            _Flag = true;
        }

        private void Uc_ASAHI2_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo2.Visible = false;
            btn_SuaVaLuu_User2.Visible = true;
        }

        private void Uc_ASAHI1_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo1.Visible = false;
            btn_SuaVaLuu_User1.Visible = true;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (Global.StrCheck == "CHECKQC")
            {
                var nhap = (from w in Global.db.tbl_Images
                            where w.fbatchname == Global.StrBatch && w.ReadImageDESo == 2
                            select w.idimage).Count();
                var sohinh = (from w in Global.db.tbl_Images
                              where w.fbatchname == Global.StrBatch
                              select w.idimage).Count();
                var check = (from w in Global.db.tbl_MissImage_DESOs
                             where w.fBatchName == Global.StrBatch && w.Submit == 0
                             select w.IdImage).Count();
                if (sohinh > nhap)
                {
                    MessageBox.Show("Chưa nhập xong DeSo!");
                    return;
                }
                if (check > 0)
                {
                    var listUser = (from w in Global.db.tbl_MissImage_DESOs
                                    where w.fBatchName == Global.StrBatch && w.Submit == 0
                                    select w.UserName).ToList();
                    string sss = "";
                    foreach (var item in listUser)
                    {
                        sss += item + "\r\n";
                    }

                    if (listUser.Count > 0)
                    {
                        MessageBox.Show("Những user lấy hình về nhưng không nhập: \r\n" + sss);
                        return;
                    }
                }
                string temp = GetImage_DeSo();
                if (temp == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show("Lỗi load hình");
                    return;
                }

                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
                
            }
            btn_Start.Visible = false;
        }
        
        private void Load_DeSo(string strBatch, string idimage)
        {
            var deso = (from w in Global.db.tbl_DeSos
                        where w.fBatchName == strBatch && w.IdImage == idimage
                        select new
                        { w.UserName,
                            w.Truong_0,
                            w.Truong_02,
                            w.Truong_03,
                            w.Truong_03_2,
                            w.Truong_04,
                            w.Truong_05,
                            w.Truong_06,
                            w.Truong_07,
                            w.Truong_08,
                            w.Truong_12,
                            w.Truong_13,
                            w.Truong_14,
                            w.Truong_15,
                            w.Truong_16,
                            w.Truong_17,
                            w.Truong_18,
                            w.Truong_19,
                            w.Truong_20,
                            w.Truong_21,
                            w.Truong_22,
                            w.Truong_23,
                            w.Truong_24,
                            w.Truong_25,
                            w.Truong_26,
                            w.Truong_27,
                            w.Truong_28,
                            w.Truong_29,
                            w.Truong_30,
                            w.Truong_31,
                            w.Truong_32,
                            w.Truong_33,
                            w.Truong_34,
                            w.Truong_35,
                            w.Truong_36,
                            w.Truong_37,
                            w.Truong_38,
                            w.Truong_39,
                            w.Truong_40,
                            w.Truong_41,
                            w.Truong_42,
                            w.Truong_43,
                            w.Truong_44,
                            w.Truong_45,
                            w.Truong_46,
                            w.Truong_47,
                            w.Truong_48,
                            w.Truong_49,
                            w.Truong_50,
                            w.Truong_51,
                            w.Truong_52,
                            w.Truong_53,
                            w.Truong_54,
                            w.Truong_55,
                            w.Truong_56,
                            w.Truong_57,
                            w.Truong_58,
                            w.Truong_59,
                            w.Truong_60,
                            w.Truong_61,
                            w.Truong_62,
                            w.Truong_63,
                            w.Truong_64,
                            w.Truong_65,
                            w.Truong_66,
                            w.Truong_67,
                            w.Truong_68,
                            w.Truong_69,
                            w.Truong_70,
                            w.Truong_71,
                            w.Truong_72,
                            w.Truong_73,
                            w.Truong_74,
                            w.Truong_75,
                            w.Truong_76,
                            w.Truong_77,
                            w.Truong_78,
                            w.Truong_79,
                            w.Truong_80,
                            w.Truong_81,
                            w.Truong_82,
                            w.Truong_83,
                            w.Truong_84,
                            w.Truong_85,
                            w.Truong_86,
                            w.Truong_87,
                            w.Truong_88,
                            w.Truong_89,
                            w.Truong_90,
                            w.Truong_91,
                            w.CheckQC
                        }).ToList();
            lb_username1.Text = deso[0].UserName;
            lb_username2.Text = deso[1].UserName;

            if (Global.LoaiPhieu == "ASAHI")
            {
                tabcontrol_DeSo1.SelectedTabPage = tp_ASAHI_DeSo1;

                uc_ASAHI1.txt_Truong02.Text = deso[0].Truong_02;
                uc_ASAHI1.txt_Truong0.Text = deso[0].Truong_0;
                if (deso[0].Truong_03.Length > 8)
                {
                    uc_ASAHI1.txt_Truong03_1.Text = deso[0].Truong_03?.Substring(0, 8);
                    uc_ASAHI1.txt_Truong03_2.Text = deso[0].Truong_03?.Substring(8, deso[0].Truong_03.Length - 8);
                }
                else
                {
                    uc_ASAHI1.txt_Truong03_1.Text = string.IsNullOrEmpty(deso[0].Truong_03) ? "" : deso[0].Truong_03;
                    uc_ASAHI1.txt_Truong03_2.Text = "";
                }
                uc_ASAHI1.txt_Truong05.Text = deso[0].Truong_05;
                uc_ASAHI1.txt_Truong06.Text = deso[0].Truong_06;
                uc_ASAHI1.txt_Truong08.EditValue = deso[0].Truong_08;
                uc_ASAHI1.txt_Truong85.Text = deso[0].Truong_85;
                if(deso[0].CheckQC==true)
                uc_ASAHI1.chk_qc.Checked = true;


                tabcontrol_DeSo2.SelectedTabPage = tp_ASAHI_DeSo2;
                uc_ASAHI2.txt_Truong02.Text = deso[1].Truong_02;
                uc_ASAHI2.txt_Truong0.Text = deso[1].Truong_0;
                if (deso[1].Truong_03.Length > 8)
                {
                    uc_ASAHI2.txt_Truong03_1.Text = deso[1].Truong_03?.Substring(0, 8);
                    uc_ASAHI2.txt_Truong03_2.Text = deso[1].Truong_03?.Substring(8, deso[1].Truong_03.Length - 8);
                }
                else
                {
                    uc_ASAHI2.txt_Truong03_1.Text = string.IsNullOrEmpty(deso[1].Truong_03) ? "" : deso[1].Truong_03;
                    uc_ASAHI2.txt_Truong03_2.Text = "";
                }
                uc_ASAHI2.txt_Truong05.Text = deso[1].Truong_05;
                uc_ASAHI2.txt_Truong06.Text = deso[1].Truong_06;
                uc_ASAHI2.txt_Truong08.EditValue = deso[1].Truong_08;
                uc_ASAHI2.txt_Truong85.Text = deso[1].Truong_85;
                if (deso[1].CheckQC == true)
                    uc_ASAHI2.chk_qc.Checked = true;

                uc_ASAHI1.txt_Truong02.Focus();

            }
            else if (Global.LoaiPhieu == "EIZEN")
            {
                tabcontrol_DeSo1.SelectedTabPage = tp_EIZEN_DeSo1;
                uc_EZIEN1.txt_Truong02.Text = deso[0].Truong_02;
                uc_EZIEN1.txt_Truong0.Text = deso[0].Truong_0;
                if (deso[0].Truong_03.Length > 6)
                {
                    uc_EZIEN1.txt_Truong03_1.Text = deso[0].Truong_03?.Substring(0, 6);
                    uc_EZIEN1.txt_Truong03_2.Text = deso[0].Truong_03?.Substring(6, deso[0].Truong_03.Length - 6);
                }
                else
                {
                    uc_EZIEN1.txt_Truong03_1.Text = string.IsNullOrEmpty(deso[0].Truong_03) ? "" : deso[0].Truong_03;
                    uc_EZIEN1.txt_Truong03_2.Text = "";
                }
                uc_EZIEN1.txt_Truong05.Text = deso[0].Truong_05;
                uc_EZIEN1.txt_Truong06.Text = deso[0].Truong_06;
                uc_EZIEN1.txt_Truong07.Text = deso[0].Truong_07;
                uc_EZIEN1.txt_Truong08.Text = deso[0].Truong_08;
                uc_EZIEN1.txt_Truong85.Text = deso[0].Truong_85;
                uc_EZIEN1.txt_Truong86.Text = deso[0].Truong_86;
                if (deso[0].CheckQC == true)
                    uc_EZIEN1.chk_qc.Checked = true;


                tabcontrol_DeSo2.SelectedTabPage = tp_EIZEN_DeSo2;
                uc_EZIEN2.txt_Truong02.Text = deso[1].Truong_02;
                uc_EZIEN2.txt_Truong0.Text = deso[1].Truong_0;
                if (deso[1].Truong_03.Length > 6)
                {
                    uc_EZIEN2.txt_Truong03_1.Text = deso[1].Truong_03?.Substring(0, 6);
                    uc_EZIEN2.txt_Truong03_2.Text = deso[1].Truong_03?.Substring(6, deso[1].Truong_03.Length - 6);
                }
                else
                {
                    uc_EZIEN2.txt_Truong03_1.Text = string.IsNullOrEmpty(deso[1].Truong_03) ? "" : deso[1].Truong_03;
                    uc_EZIEN2.txt_Truong03_2.Text = "";
                }
                uc_EZIEN2.txt_Truong05.Text = deso[1].Truong_05;
                uc_EZIEN2.txt_Truong06.Text = deso[1].Truong_06;
                uc_EZIEN2.txt_Truong07.Text = deso[1].Truong_07;
                uc_EZIEN2.txt_Truong08.Text = deso[1].Truong_08;
                uc_EZIEN2.txt_Truong85.Text = deso[1].Truong_85;
                uc_EZIEN2.txt_Truong86.Text = deso[1].Truong_86;
                if (deso[1].CheckQC == true)
                    uc_EZIEN2.chk_qc.Checked = true;

                uc_EZIEN1.txt_Truong02.Focus();
            }
            else if (Global.LoaiPhieu == "YAMAMOTO")
            {
                tabcontrol_DeSo1.SelectedTabPage = tp_YAMAMOTO_DeSo1;
                
                uc_YAMAMOTO1.txt_Truong02.Text = deso[0].Truong_02;
                if (deso[0].Truong_03.Length > 6)
                {
                    uc_YAMAMOTO1.txt_Truong03_1.Text = deso[0].Truong_03?.Substring(0, 6);
                    uc_YAMAMOTO1.txt_Truong03_2.Text = deso[0].Truong_03?.Substring(6, deso[0].Truong_03.Length - 6);
                }
                else
                {
                    uc_YAMAMOTO1.txt_Truong03_1.Text = string.IsNullOrEmpty(deso[0].Truong_03) ? "" : deso[0].Truong_03;
                    uc_YAMAMOTO1.txt_Truong03_2.Text = "";
                }
                uc_YAMAMOTO1.txt_Truong05.Text = deso[0].Truong_05;
                uc_YAMAMOTO1.txt_Truong06.Text = deso[0].Truong_06;
                uc_YAMAMOTO1.txt_Truong07.Text = deso[0].Truong_07;
                uc_YAMAMOTO1.txt_Truong08.Text = deso[0].Truong_08;
                uc_YAMAMOTO1.txt_Truong13.Text = deso[0].Truong_13;
                uc_YAMAMOTO1.txt_Truong14.Text = deso[0].Truong_14;
                uc_YAMAMOTO1.txt_Truong15.Text = deso[0].Truong_15;
                uc_YAMAMOTO1.txt_Truong16.Text = deso[0].Truong_16;
                uc_YAMAMOTO1.txt_Truong21.Text = deso[0].Truong_21;
                uc_YAMAMOTO1.txt_Truong22.Text = deso[0].Truong_22;
                uc_YAMAMOTO1.txt_Truong23.Text = deso[0].Truong_23;
                uc_YAMAMOTO1.txt_Truong24.Text = deso[0].Truong_24;
                uc_YAMAMOTO1.txt_Truong29.Text = deso[0].Truong_29;
                uc_YAMAMOTO1.txt_Truong30.Text = deso[0].Truong_30;
                uc_YAMAMOTO1.txt_Truong31.Text = deso[0].Truong_31;
                uc_YAMAMOTO1.txt_Truong32.Text = deso[0].Truong_32;
                uc_YAMAMOTO1.txt_Truong37.Text = deso[0].Truong_37;
                uc_YAMAMOTO1.txt_Truong38.Text = deso[0].Truong_38;
                uc_YAMAMOTO1.txt_Truong39.Text = deso[0].Truong_39;
                uc_YAMAMOTO1.txt_Truong40.Text = deso[0].Truong_40;
                uc_YAMAMOTO1.txt_Truong45.Text = deso[0].Truong_45;
                uc_YAMAMOTO1.txt_Truong46.Text = deso[0].Truong_46;
                uc_YAMAMOTO1.txt_Truong47.Text = deso[0].Truong_47;
                uc_YAMAMOTO1.txt_Truong48.Text = deso[0].Truong_48;
                uc_YAMAMOTO1.txt_Truong53.Text = deso[0].Truong_53;
                uc_YAMAMOTO1.txt_Truong54.Text = deso[0].Truong_54;
                uc_YAMAMOTO1.txt_Truong55.Text = deso[0].Truong_55;
                uc_YAMAMOTO1.txt_Truong56.Text = deso[0].Truong_56;
                uc_YAMAMOTO1.txt_Truong61.Text = deso[0].Truong_61;
                uc_YAMAMOTO1.txt_Truong62.Text = deso[0].Truong_62;
                uc_YAMAMOTO1.txt_Truong63.Text = deso[0].Truong_63;
                uc_YAMAMOTO1.txt_Truong64.Text = deso[0].Truong_64;
                uc_YAMAMOTO1.txt_Truong69.Text = deso[0].Truong_69;
                uc_YAMAMOTO1.txt_Truong70.Text = deso[0].Truong_70;
                uc_YAMAMOTO1.txt_Truong71.Text = deso[0].Truong_71;
                uc_YAMAMOTO1.txt_Truong72.Text = deso[0].Truong_72;
                uc_YAMAMOTO1.txt_Truong77.Text = deso[0].Truong_77;
                uc_YAMAMOTO1.txt_Truong78.Text = deso[0].Truong_78;
                uc_YAMAMOTO1.txt_Truong79.Text = deso[0].Truong_79;
                uc_YAMAMOTO1.txt_Truong80.Text = deso[0].Truong_80;
                uc_YAMAMOTO1.txt_Truong85.Text = deso[0].Truong_85;
                uc_YAMAMOTO1.txt_Truong86.Text = deso[0].Truong_86;
                if (deso[0].CheckQC == true)
                    uc_YAMAMOTO1.chk_qc.Checked = true;


                tabcontrol_DeSo2.SelectedTabPage = tp_YAMAMOTO_DeSo2;
                uc_YAMAMOTO2.txt_Truong02.Text = deso[1].Truong_02;
                if (deso[1].Truong_03.Length > 6)
                {
                    uc_YAMAMOTO2.txt_Truong03_1.Text = deso[1].Truong_03?.Substring(0, 6);
                    uc_YAMAMOTO2.txt_Truong03_2.Text = deso[1].Truong_03?.Substring(6, deso[1].Truong_03.Length - 6);
                }
                else
                {
                    uc_YAMAMOTO2.txt_Truong03_1.Text = string.IsNullOrEmpty(deso[1].Truong_03) ? "" : deso[1].Truong_03;
                    uc_YAMAMOTO2.txt_Truong03_2.Text = "";
                }
                uc_YAMAMOTO2.txt_Truong05.Text = deso[1].Truong_05;
                uc_YAMAMOTO2.txt_Truong06.Text = deso[1].Truong_06;
                uc_YAMAMOTO2.txt_Truong07.Text = deso[1].Truong_07;
                uc_YAMAMOTO2.txt_Truong08.Text = deso[1].Truong_08;
                uc_YAMAMOTO2.txt_Truong13.Text = deso[1].Truong_13;
                uc_YAMAMOTO2.txt_Truong14.Text = deso[1].Truong_14;
                uc_YAMAMOTO2.txt_Truong15.Text = deso[1].Truong_15;
                uc_YAMAMOTO2.txt_Truong16.Text = deso[1].Truong_16;
                uc_YAMAMOTO2.txt_Truong21.Text = deso[1].Truong_21;
                uc_YAMAMOTO2.txt_Truong22.Text = deso[1].Truong_22;
                uc_YAMAMOTO2.txt_Truong23.Text = deso[1].Truong_23;
                uc_YAMAMOTO2.txt_Truong24.Text = deso[1].Truong_24;
                uc_YAMAMOTO2.txt_Truong29.Text = deso[1].Truong_29;
                uc_YAMAMOTO2.txt_Truong30.Text = deso[1].Truong_30;
                uc_YAMAMOTO2.txt_Truong31.Text = deso[1].Truong_31;
                uc_YAMAMOTO2.txt_Truong32.Text = deso[1].Truong_32;
                uc_YAMAMOTO2.txt_Truong37.Text = deso[1].Truong_37;
                uc_YAMAMOTO2.txt_Truong38.Text = deso[1].Truong_38;
                uc_YAMAMOTO2.txt_Truong39.Text = deso[1].Truong_39;
                uc_YAMAMOTO2.txt_Truong40.Text = deso[1].Truong_40;
                uc_YAMAMOTO2.txt_Truong45.Text = deso[1].Truong_45;
                uc_YAMAMOTO2.txt_Truong46.Text = deso[1].Truong_46;
                uc_YAMAMOTO2.txt_Truong47.Text = deso[1].Truong_47;
                uc_YAMAMOTO2.txt_Truong48.Text = deso[1].Truong_48;
                uc_YAMAMOTO2.txt_Truong53.Text = deso[1].Truong_53;
                uc_YAMAMOTO2.txt_Truong54.Text = deso[1].Truong_54;
                uc_YAMAMOTO2.txt_Truong55.Text = deso[1].Truong_55;
                uc_YAMAMOTO2.txt_Truong56.Text = deso[1].Truong_56;
                uc_YAMAMOTO2.txt_Truong61.Text = deso[1].Truong_61;
                uc_YAMAMOTO2.txt_Truong62.Text = deso[1].Truong_62;
                uc_YAMAMOTO2.txt_Truong63.Text = deso[1].Truong_63;
                uc_YAMAMOTO2.txt_Truong64.Text = deso[1].Truong_64;
                uc_YAMAMOTO2.txt_Truong69.Text = deso[1].Truong_69;
                uc_YAMAMOTO2.txt_Truong70.Text = deso[1].Truong_70;
                uc_YAMAMOTO2.txt_Truong71.Text = deso[1].Truong_71;
                uc_YAMAMOTO2.txt_Truong72.Text = deso[1].Truong_72;
                uc_YAMAMOTO2.txt_Truong77.Text = deso[1].Truong_77;
                uc_YAMAMOTO2.txt_Truong78.Text = deso[1].Truong_78;
                uc_YAMAMOTO2.txt_Truong79.Text = deso[1].Truong_79;
                uc_YAMAMOTO2.txt_Truong80.Text = deso[1].Truong_80;
                uc_YAMAMOTO2.txt_Truong85.Text = deso[1].Truong_85;
                uc_YAMAMOTO2.txt_Truong86.Text = deso[1].Truong_86;
                if (deso[1].CheckQC == true)
                    uc_YAMAMOTO2.chk_qc.Checked = true;


                uc_YAMAMOTO1.txt_Truong02.Focus();
            }
            else if (Global.LoaiPhieu == "YASUDA")
            {
                tabcontrol_DeSo1.SelectedTabPage = tp_YASUDA_DeSo1;

                uc_YASUDA1.txt_Truong02.Text = deso[0].Truong_02;
                uc_YASUDA1.txt_Truong0.Text = deso[0].Truong_0;
                if (deso[0].Truong_03.Length > 6)
                {
                    uc_YASUDA1.txt_Truong03_1.Text = deso[0].Truong_03?.Substring(0, 6);
                    uc_YASUDA1.txt_Truong03_2.Text = deso[0].Truong_03?.Substring(6, deso[0].Truong_03.Length - 6);
                }
                else
                {
                    uc_YASUDA1.txt_Truong03_1.Text = string.IsNullOrEmpty(deso[0].Truong_03) ? "" : deso[0].Truong_03;
                    uc_YASUDA1.txt_Truong03_2.Text = "";
                }
                uc_YASUDA1.txt_Truong05.Text = deso[0].Truong_05;
                uc_YASUDA1.txt_Truong06.Text = deso[0].Truong_06;
                uc_YASUDA1.txt_Truong07.Text = deso[0].Truong_07;
                uc_YASUDA1.txt_Truong08.Text = deso[0].Truong_08;
                uc_YASUDA1.txt_Truong12.Text = deso[0].Truong_12;
                uc_YASUDA1.txt_Truong13.Text = deso[0].Truong_13;
                uc_YASUDA1.txt_Truong14.Text = deso[0].Truong_14;
                uc_YASUDA1.txt_Truong15.Text = deso[0].Truong_15;
                uc_YASUDA1.txt_Truong16.Text = deso[0].Truong_16;
                uc_YASUDA1.txt_Truong20.Text = deso[0].Truong_20;
                uc_YASUDA1.txt_Truong21.Text = deso[0].Truong_21;
                uc_YASUDA1.txt_Truong22.Text = deso[0].Truong_22;
                uc_YASUDA1.txt_Truong23.Text = deso[0].Truong_23;
                uc_YASUDA1.txt_Truong24.Text = deso[0].Truong_24;
                uc_YASUDA1.txt_Truong28.Text = deso[0].Truong_28;
                uc_YASUDA1.txt_Truong29.Text = deso[0].Truong_29;
                uc_YASUDA1.txt_Truong30.Text = deso[0].Truong_30;
                uc_YASUDA1.txt_Truong31.Text = deso[0].Truong_31;
                uc_YASUDA1.txt_Truong32.Text = deso[0].Truong_32;
                uc_YASUDA1.txt_Truong36.Text = deso[0].Truong_36;
                uc_YASUDA1.txt_Truong37.Text = deso[0].Truong_37;
                uc_YASUDA1.txt_Truong38.Text = deso[0].Truong_38;
                uc_YASUDA1.txt_Truong39.Text = deso[0].Truong_39;
                uc_YASUDA1.txt_Truong40.Text = deso[0].Truong_40;
                uc_YASUDA1.txt_Truong44.Text = deso[0].Truong_44;
                uc_YASUDA1.txt_Truong45.Text = deso[0].Truong_45;
                uc_YASUDA1.txt_Truong46.Text = deso[0].Truong_46;
                uc_YASUDA1.txt_Truong47.Text = deso[0].Truong_47;
                uc_YASUDA1.txt_Truong48.Text = deso[0].Truong_48;
                uc_YASUDA1.txt_Truong52.Text = deso[0].Truong_52;
                uc_YASUDA1.txt_Truong53.Text = deso[0].Truong_53;
                uc_YASUDA1.txt_Truong54.Text = deso[0].Truong_54;
                uc_YASUDA1.txt_Truong55.Text = deso[0].Truong_55;
                uc_YASUDA1.txt_Truong56.Text = deso[0].Truong_56;
                uc_YASUDA1.txt_Truong60.Text = deso[0].Truong_60;
                uc_YASUDA1.txt_Truong61.Text = deso[0].Truong_61;
                uc_YASUDA1.txt_Truong62.Text = deso[0].Truong_62;
                uc_YASUDA1.txt_Truong63.Text = deso[0].Truong_63;
                uc_YASUDA1.txt_Truong64.Text = deso[0].Truong_64;
                uc_YASUDA1.txt_Truong68.Text = deso[0].Truong_68;
                uc_YASUDA1.txt_Truong69.Text = deso[0].Truong_69;
                uc_YASUDA1.txt_Truong70.Text = deso[0].Truong_70;
                uc_YASUDA1.txt_Truong71.Text = deso[0].Truong_71;
                uc_YASUDA1.txt_Truong72.Text = deso[0].Truong_72;
                uc_YASUDA1.txt_Truong76.Text = deso[0].Truong_76;
                uc_YASUDA1.txt_Truong77.Text = deso[0].Truong_77;
                uc_YASUDA1.txt_Truong78.Text = deso[0].Truong_78;
                uc_YASUDA1.txt_Truong79.Text = deso[0].Truong_79;
                uc_YASUDA1.txt_Truong80.Text = deso[0].Truong_80;
                uc_YASUDA1.txt_Truong84.Text = deso[0].Truong_84;
                uc_YASUDA1.txt_Truong85.Text = deso[0].Truong_85;
                uc_YASUDA1.txt_Truong87.Text = deso[0].Truong_87;
                uc_YASUDA1.txt_Truong92.Text = deso[0].Truong_91;
                if (deso[0].CheckQC == true)
                    uc_YASUDA1.chk_qc.Checked = true;



                tabcontrol_DeSo2.SelectedTabPage = tp_YASUDA_DeSo2;
                uc_YASUDA2.txt_Truong02.Text = deso[1].Truong_02;
                uc_YASUDA2.txt_Truong0.Text = deso[1].Truong_0;
                if (deso[1].Truong_03.Length > 6)
                {
                    uc_YASUDA2.txt_Truong03_1.Text = deso[1].Truong_03?.Substring(0, 6);
                    uc_YASUDA2.txt_Truong03_2.Text = deso[1].Truong_03?.Substring(6, deso[1].Truong_03.Length - 6);
                }
                else
                {
                    uc_YASUDA2.txt_Truong03_1.Text = string.IsNullOrEmpty(deso[1].Truong_03) ? "" : deso[1].Truong_03;
                    uc_YASUDA2.txt_Truong03_2.Text = "";
                }
                uc_YASUDA2.txt_Truong05.Text = deso[1].Truong_05;
                uc_YASUDA2.txt_Truong06.Text = deso[1].Truong_06;
                uc_YASUDA2.txt_Truong07.Text = deso[1].Truong_07;
                uc_YASUDA2.txt_Truong08.Text = deso[1].Truong_08;
                uc_YASUDA2.txt_Truong12.Text = deso[1].Truong_12;
                uc_YASUDA2.txt_Truong13.Text = deso[1].Truong_13;
                uc_YASUDA2.txt_Truong14.Text = deso[1].Truong_14;
                uc_YASUDA2.txt_Truong15.Text = deso[1].Truong_15;
                uc_YASUDA2.txt_Truong16.Text = deso[1].Truong_16;
                uc_YASUDA2.txt_Truong20.Text = deso[1].Truong_20;
                uc_YASUDA2.txt_Truong21.Text = deso[1].Truong_21;
                uc_YASUDA2.txt_Truong22.Text = deso[1].Truong_22;
                uc_YASUDA2.txt_Truong23.Text = deso[1].Truong_23;
                uc_YASUDA2.txt_Truong24.Text = deso[1].Truong_24;
                uc_YASUDA2.txt_Truong28.Text = deso[1].Truong_28;
                uc_YASUDA2.txt_Truong29.Text = deso[1].Truong_29;
                uc_YASUDA2.txt_Truong30.Text = deso[1].Truong_30;
                uc_YASUDA2.txt_Truong31.Text = deso[1].Truong_31;
                uc_YASUDA2.txt_Truong32.Text = deso[1].Truong_32;
                uc_YASUDA2.txt_Truong36.Text = deso[1].Truong_36;
                uc_YASUDA2.txt_Truong37.Text = deso[1].Truong_37;
                uc_YASUDA2.txt_Truong38.Text = deso[1].Truong_38;
                uc_YASUDA2.txt_Truong39.Text = deso[1].Truong_39;
                uc_YASUDA2.txt_Truong40.Text = deso[1].Truong_40;
                uc_YASUDA2.txt_Truong44.Text = deso[1].Truong_44;
                uc_YASUDA2.txt_Truong45.Text = deso[1].Truong_45;
                uc_YASUDA2.txt_Truong46.Text = deso[1].Truong_46;
                uc_YASUDA2.txt_Truong47.Text = deso[1].Truong_47;
                uc_YASUDA2.txt_Truong48.Text = deso[1].Truong_48;
                uc_YASUDA2.txt_Truong52.Text = deso[1].Truong_52;
                uc_YASUDA2.txt_Truong53.Text = deso[1].Truong_53;
                uc_YASUDA2.txt_Truong54.Text = deso[1].Truong_54;
                uc_YASUDA2.txt_Truong55.Text = deso[1].Truong_55;
                uc_YASUDA2.txt_Truong56.Text = deso[1].Truong_56;
                uc_YASUDA2.txt_Truong60.Text = deso[1].Truong_60;
                uc_YASUDA2.txt_Truong61.Text = deso[1].Truong_61;
                uc_YASUDA2.txt_Truong62.Text = deso[1].Truong_62;
                uc_YASUDA2.txt_Truong63.Text = deso[1].Truong_63;
                uc_YASUDA2.txt_Truong64.Text = deso[1].Truong_64;
                uc_YASUDA2.txt_Truong68.Text = deso[1].Truong_68;
                uc_YASUDA2.txt_Truong69.Text = deso[1].Truong_69;
                uc_YASUDA2.txt_Truong70.Text = deso[1].Truong_70;
                uc_YASUDA2.txt_Truong71.Text = deso[1].Truong_71;
                uc_YASUDA2.txt_Truong72.Text = deso[1].Truong_72;
                uc_YASUDA2.txt_Truong76.Text = deso[1].Truong_76;
                uc_YASUDA2.txt_Truong77.Text = deso[1].Truong_77;
                uc_YASUDA2.txt_Truong78.Text = deso[1].Truong_78;
                uc_YASUDA2.txt_Truong79.Text = deso[1].Truong_79;
                uc_YASUDA2.txt_Truong80.Text = deso[1].Truong_80;
                uc_YASUDA2.txt_Truong84.Text = deso[1].Truong_84;
                uc_YASUDA2.txt_Truong85.Text = deso[1].Truong_85;
                uc_YASUDA2.txt_Truong87.Text = deso[1].Truong_87;
                uc_YASUDA2.txt_Truong92.Text = deso[1].Truong_91;
                if (deso[1].CheckQC == true)
                    uc_YASUDA2.chk_qc.Checked = true;

                uc_YASUDA1.txt_Truong02.Focus();
            }

            else if (Global.LoaiPhieu == "AEON")
            {
                tabcontrol_DeSo1.SelectedTabPage = tp_AEON_DeSo1;

                uc_AEON1.txt_Truong02.Text = deso[0].Truong_02;
                uc_AEON1.txt_Truong03_1.Text = deso[0].Truong_03;
                uc_AEON1.txt_Truong03_2.Text = deso[0].Truong_03_2;
                uc_AEON1.txt_Truong04.Text = deso[0].Truong_04;
                uc_AEON1.txt_Truong05.Text = deso[0].Truong_05;
                uc_AEON1.txt_Truong06.Text = deso[0].Truong_06;
                uc_AEON1.txt_Truong07.Text = deso[0].Truong_07;
                uc_AEON1.txt_Truong08.Text = deso[0].Truong_08;
                uc_AEON1.txt_Truong13.Text = deso[0].Truong_13;
                uc_AEON1.txt_Truong14.Text = deso[0].Truong_14;
                uc_AEON1.txt_Truong15.Text = deso[0].Truong_15;
                uc_AEON1.txt_Truong16.Text = deso[0].Truong_16;
                uc_AEON1.txt_Truong21.Text = deso[0].Truong_21;
                uc_AEON1.txt_Truong22.Text = deso[0].Truong_22;
                uc_AEON1.txt_Truong23.Text = deso[0].Truong_23;
                uc_AEON1.txt_Truong24.Text = deso[0].Truong_24;
                uc_AEON1.txt_Truong29.Text = deso[0].Truong_29;
                uc_AEON1.txt_Truong30.Text = deso[0].Truong_30;
                uc_AEON1.txt_Truong31.Text = deso[0].Truong_31;
                uc_AEON1.txt_Truong32.Text = deso[0].Truong_32;
                uc_AEON1.txt_Truong37.Text = deso[0].Truong_37;
                uc_AEON1.txt_Truong38.Text = deso[0].Truong_38;
                uc_AEON1.txt_Truong39.Text = deso[0].Truong_39;
                uc_AEON1.txt_Truong40.Text = deso[0].Truong_40;
                uc_AEON1.txt_Truong45.Text = deso[0].Truong_45;
                uc_AEON1.txt_Truong46.Text = deso[0].Truong_46;
                uc_AEON1.txt_Truong47.Text = deso[0].Truong_47;
                uc_AEON1.txt_Truong48.Text = deso[0].Truong_48;
                uc_AEON1.txt_Truong53.Text = deso[0].Truong_53;
                uc_AEON1.txt_Truong54.Text = deso[0].Truong_54;
                uc_AEON1.txt_Truong55.Text = deso[0].Truong_55;
                uc_AEON1.txt_Truong56.Text = deso[0].Truong_56;
                uc_AEON1.txt_Truong61.Text = deso[0].Truong_61;
                uc_AEON1.txt_Truong62.Text = deso[0].Truong_62;
                uc_AEON1.txt_Truong63.Text = deso[0].Truong_63;
                uc_AEON1.txt_Truong64.Text = deso[0].Truong_64;
                if (deso[0].CheckQC == true)
                    uc_AEON1.chk_qc.Checked = true;


                tabcontrol_DeSo2.SelectedTabPage = tp_AEON_DeSo2;
                uc_AEON2.txt_Truong02.Text = deso[1].Truong_02;
                uc_AEON2.txt_Truong03_1.Text = deso[1].Truong_03;
                uc_AEON2.txt_Truong03_2.Text = deso[1].Truong_03_2;
                uc_AEON2.txt_Truong04.Text = deso[1].Truong_04;
                uc_AEON2.txt_Truong05.Text = deso[1].Truong_05;
                uc_AEON2.txt_Truong06.Text = deso[1].Truong_06;
                uc_AEON2.txt_Truong07.Text = deso[1].Truong_07;
                uc_AEON2.txt_Truong08.Text = deso[1].Truong_08;
                uc_AEON2.txt_Truong13.Text = deso[1].Truong_13;
                uc_AEON2.txt_Truong14.Text = deso[1].Truong_14;
                uc_AEON2.txt_Truong15.Text = deso[1].Truong_15;
                uc_AEON2.txt_Truong16.Text = deso[1].Truong_16;
                uc_AEON2.txt_Truong21.Text = deso[1].Truong_21;
                uc_AEON2.txt_Truong22.Text = deso[1].Truong_22;
                uc_AEON2.txt_Truong23.Text = deso[1].Truong_23;
                uc_AEON2.txt_Truong24.Text = deso[1].Truong_24;
                uc_AEON2.txt_Truong29.Text = deso[1].Truong_29;
                uc_AEON2.txt_Truong30.Text = deso[1].Truong_30;
                uc_AEON2.txt_Truong31.Text = deso[1].Truong_31;
                uc_AEON2.txt_Truong32.Text = deso[1].Truong_32;
                uc_AEON2.txt_Truong37.Text = deso[1].Truong_37;
                uc_AEON2.txt_Truong38.Text = deso[1].Truong_38;
                uc_AEON2.txt_Truong39.Text = deso[1].Truong_39;
                uc_AEON2.txt_Truong40.Text = deso[1].Truong_40;
                uc_AEON2.txt_Truong45.Text = deso[1].Truong_45;
                uc_AEON2.txt_Truong46.Text = deso[1].Truong_46;
                uc_AEON2.txt_Truong47.Text = deso[1].Truong_47;
                uc_AEON2.txt_Truong48.Text = deso[1].Truong_48;
                uc_AEON2.txt_Truong53.Text = deso[1].Truong_53;
                uc_AEON2.txt_Truong54.Text = deso[1].Truong_54;
                uc_AEON2.txt_Truong55.Text = deso[1].Truong_55;
                uc_AEON2.txt_Truong56.Text = deso[1].Truong_56;
                uc_AEON2.txt_Truong61.Text = deso[1].Truong_61;
                uc_AEON2.txt_Truong62.Text = deso[1].Truong_62;
                uc_AEON2.txt_Truong63.Text = deso[1].Truong_63;
                uc_AEON2.txt_Truong64.Text = deso[1].Truong_64;
                if (deso[1].CheckQC == true)
                    uc_AEON2.chk_qc.Checked = true;



                uc_AEON1.txt_Truong02.Focus();
            }


            Compare_TextBox(uc_ASAHI1.txt_Truong0, uc_ASAHI2.txt_Truong0);
            Compare_TextBox(uc_ASAHI1.txt_Truong02, uc_ASAHI2.txt_Truong02);
            Compare_TextBox(uc_ASAHI1.txt_Truong03_1, uc_ASAHI2.txt_Truong03_1);
            Compare_TextBox(uc_ASAHI1.txt_Truong03_2, uc_ASAHI2.txt_Truong03_2);
            Compare_TextBox(uc_ASAHI1.txt_Truong05, uc_ASAHI2.txt_Truong05);
            Compare_TextBox(uc_ASAHI1.txt_Truong06, uc_ASAHI2.txt_Truong06);
            Compare_TextBox(uc_ASAHI1.txt_Truong08, uc_ASAHI2.txt_Truong08);
            Compare_TextBox(uc_ASAHI1.txt_Truong85, uc_ASAHI2.txt_Truong85);

            Compare_TextBox(uc_EZIEN1.txt_Truong0, uc_EZIEN2.txt_Truong0);
            Compare_TextBox(uc_EZIEN1.txt_Truong02, uc_EZIEN2.txt_Truong02);
            Compare_TextBox(uc_EZIEN1.txt_Truong03_1, uc_EZIEN2.txt_Truong03_1);
            Compare_TextBox(uc_EZIEN1.txt_Truong03_2, uc_EZIEN2.txt_Truong03_2);
            Compare_TextBox(uc_EZIEN1.txt_Truong05, uc_EZIEN2.txt_Truong05);
            Compare_TextBox(uc_EZIEN1.txt_Truong06, uc_EZIEN2.txt_Truong06);
            Compare_TextBox(uc_EZIEN1.txt_Truong07, uc_EZIEN2.txt_Truong07);
            Compare_TextBox(uc_EZIEN1.txt_Truong08, uc_EZIEN2.txt_Truong08);
            Compare_TextBox(uc_EZIEN1.txt_Truong85, uc_EZIEN2.txt_Truong85);
            Compare_TextBox(uc_EZIEN1.txt_Truong86, uc_EZIEN2.txt_Truong86);
            
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong02, uc_YAMAMOTO2.txt_Truong02);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong03_1, uc_YAMAMOTO2.txt_Truong03_1);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong03_2, uc_YAMAMOTO2.txt_Truong03_2);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong05, uc_YAMAMOTO2.txt_Truong05);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong06, uc_YAMAMOTO2.txt_Truong06);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong07, uc_YAMAMOTO2.txt_Truong07);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong08, uc_YAMAMOTO2.txt_Truong08);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong13, uc_YAMAMOTO2.txt_Truong13);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong14, uc_YAMAMOTO2.txt_Truong14);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong15, uc_YAMAMOTO2.txt_Truong15);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong16, uc_YAMAMOTO2.txt_Truong16);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong21, uc_YAMAMOTO2.txt_Truong21);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong22, uc_YAMAMOTO2.txt_Truong22);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong23, uc_YAMAMOTO2.txt_Truong23);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong24, uc_YAMAMOTO2.txt_Truong24);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong29, uc_YAMAMOTO2.txt_Truong29);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong30, uc_YAMAMOTO2.txt_Truong30);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong31, uc_YAMAMOTO2.txt_Truong31);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong32, uc_YAMAMOTO2.txt_Truong32);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong37, uc_YAMAMOTO2.txt_Truong37);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong38, uc_YAMAMOTO2.txt_Truong38);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong39, uc_YAMAMOTO2.txt_Truong39);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong40, uc_YAMAMOTO2.txt_Truong40);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong45, uc_YAMAMOTO2.txt_Truong45);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong46, uc_YAMAMOTO2.txt_Truong46);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong47, uc_YAMAMOTO2.txt_Truong47);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong48, uc_YAMAMOTO2.txt_Truong48);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong53, uc_YAMAMOTO2.txt_Truong53);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong54, uc_YAMAMOTO2.txt_Truong54);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong55, uc_YAMAMOTO2.txt_Truong55);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong56, uc_YAMAMOTO2.txt_Truong56);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong61, uc_YAMAMOTO2.txt_Truong61);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong62, uc_YAMAMOTO2.txt_Truong62);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong63, uc_YAMAMOTO2.txt_Truong63);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong64, uc_YAMAMOTO2.txt_Truong64);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong69, uc_YAMAMOTO2.txt_Truong69);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong70, uc_YAMAMOTO2.txt_Truong70);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong71, uc_YAMAMOTO2.txt_Truong71);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong72, uc_YAMAMOTO2.txt_Truong72);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong77, uc_YAMAMOTO2.txt_Truong77);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong78, uc_YAMAMOTO2.txt_Truong78);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong79, uc_YAMAMOTO2.txt_Truong79);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong80, uc_YAMAMOTO2.txt_Truong80);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong85, uc_YAMAMOTO2.txt_Truong85);
            Compare_TextBox(uc_YAMAMOTO1.txt_Truong86, uc_YAMAMOTO2.txt_Truong86);




            Compare_TextBox(uc_YASUDA1.txt_Truong0, uc_YASUDA2.txt_Truong0);
            Compare_TextBox(uc_YASUDA1.txt_Truong02, uc_YASUDA2.txt_Truong02);
            Compare_TextBox(uc_YASUDA1.txt_Truong03_1, uc_YASUDA2.txt_Truong03_1);
            Compare_TextBox(uc_YASUDA1.txt_Truong03_2, uc_YASUDA2.txt_Truong03_2);
            Compare_TextBox(uc_YASUDA1.txt_Truong05, uc_YASUDA2.txt_Truong05);
            Compare_TextBox(uc_YASUDA1.txt_Truong06, uc_YASUDA2.txt_Truong06);
            Compare_TextBox(uc_YASUDA1.txt_Truong07, uc_YASUDA2.txt_Truong07);
            Compare_TextBox(uc_YASUDA1.txt_Truong08, uc_YASUDA2.txt_Truong08);
            Compare_TextBox(uc_YASUDA1.txt_Truong12, uc_YASUDA2.txt_Truong12);
            Compare_TextBox(uc_YASUDA1.txt_Truong13, uc_YASUDA2.txt_Truong13);
            Compare_TextBox(uc_YASUDA1.txt_Truong14, uc_YASUDA2.txt_Truong14);
            Compare_TextBox(uc_YASUDA1.txt_Truong15, uc_YASUDA2.txt_Truong15);
            Compare_TextBox(uc_YASUDA1.txt_Truong16, uc_YASUDA2.txt_Truong16);
            Compare_TextBox(uc_YASUDA1.txt_Truong20, uc_YASUDA2.txt_Truong20);
            Compare_TextBox(uc_YASUDA1.txt_Truong21, uc_YASUDA2.txt_Truong21);
            Compare_TextBox(uc_YASUDA1.txt_Truong22, uc_YASUDA2.txt_Truong22);
            Compare_TextBox(uc_YASUDA1.txt_Truong23, uc_YASUDA2.txt_Truong23);
            Compare_TextBox(uc_YASUDA1.txt_Truong24, uc_YASUDA2.txt_Truong24);
            Compare_TextBox(uc_YASUDA1.txt_Truong28, uc_YASUDA2.txt_Truong28);
            Compare_TextBox(uc_YASUDA1.txt_Truong29, uc_YASUDA2.txt_Truong29);
            Compare_TextBox(uc_YASUDA1.txt_Truong30, uc_YASUDA2.txt_Truong30);
            Compare_TextBox(uc_YASUDA1.txt_Truong31, uc_YASUDA2.txt_Truong31);
            Compare_TextBox(uc_YASUDA1.txt_Truong32, uc_YASUDA2.txt_Truong32);
            Compare_TextBox(uc_YASUDA1.txt_Truong36, uc_YASUDA2.txt_Truong36);
            Compare_TextBox(uc_YASUDA1.txt_Truong37, uc_YASUDA2.txt_Truong37);
            Compare_TextBox(uc_YASUDA1.txt_Truong38, uc_YASUDA2.txt_Truong38);
            Compare_TextBox(uc_YASUDA1.txt_Truong39, uc_YASUDA2.txt_Truong39);
            Compare_TextBox(uc_YASUDA1.txt_Truong40, uc_YASUDA2.txt_Truong40);
            Compare_TextBox(uc_YASUDA1.txt_Truong44, uc_YASUDA2.txt_Truong44);
            Compare_TextBox(uc_YASUDA1.txt_Truong45, uc_YASUDA2.txt_Truong45);
            Compare_TextBox(uc_YASUDA1.txt_Truong46, uc_YASUDA2.txt_Truong46);
            Compare_TextBox(uc_YASUDA1.txt_Truong47, uc_YASUDA2.txt_Truong47);
            Compare_TextBox(uc_YASUDA1.txt_Truong48, uc_YASUDA2.txt_Truong48);
            Compare_TextBox(uc_YASUDA1.txt_Truong52, uc_YASUDA2.txt_Truong52);
            Compare_TextBox(uc_YASUDA1.txt_Truong53, uc_YASUDA2.txt_Truong53);
            Compare_TextBox(uc_YASUDA1.txt_Truong54, uc_YASUDA2.txt_Truong54);
            Compare_TextBox(uc_YASUDA1.txt_Truong55, uc_YASUDA2.txt_Truong55);
            Compare_TextBox(uc_YASUDA1.txt_Truong56, uc_YASUDA2.txt_Truong56);
            Compare_TextBox(uc_YASUDA1.txt_Truong60, uc_YASUDA2.txt_Truong60);
            Compare_TextBox(uc_YASUDA1.txt_Truong61, uc_YASUDA2.txt_Truong61);
            Compare_TextBox(uc_YASUDA1.txt_Truong62, uc_YASUDA2.txt_Truong62);
            Compare_TextBox(uc_YASUDA1.txt_Truong63, uc_YASUDA2.txt_Truong63);
            Compare_TextBox(uc_YASUDA1.txt_Truong64, uc_YASUDA2.txt_Truong64);
            Compare_TextBox(uc_YASUDA1.txt_Truong68, uc_YASUDA2.txt_Truong68);
            Compare_TextBox(uc_YASUDA1.txt_Truong69, uc_YASUDA2.txt_Truong69);
            Compare_TextBox(uc_YASUDA1.txt_Truong70, uc_YASUDA2.txt_Truong70);
            Compare_TextBox(uc_YASUDA1.txt_Truong71, uc_YASUDA2.txt_Truong71);
            Compare_TextBox(uc_YASUDA1.txt_Truong72, uc_YASUDA2.txt_Truong72);
            Compare_TextBox(uc_YASUDA1.txt_Truong76, uc_YASUDA2.txt_Truong76);
            Compare_TextBox(uc_YASUDA1.txt_Truong77, uc_YASUDA2.txt_Truong77);
            Compare_TextBox(uc_YASUDA1.txt_Truong78, uc_YASUDA2.txt_Truong78);
            Compare_TextBox(uc_YASUDA1.txt_Truong79, uc_YASUDA2.txt_Truong79);
            Compare_TextBox(uc_YASUDA1.txt_Truong80, uc_YASUDA2.txt_Truong80);
            Compare_TextBox(uc_YASUDA1.txt_Truong84, uc_YASUDA2.txt_Truong84);
            Compare_TextBox(uc_YASUDA1.txt_Truong85, uc_YASUDA2.txt_Truong85);
            Compare_TextBox(uc_YASUDA1.txt_Truong87, uc_YASUDA2.txt_Truong87);
            Compare_TextBox(uc_YASUDA1.txt_Truong92, uc_YASUDA2.txt_Truong92);

            Compare_TextBox(uc_AEON1.txt_Truong02, uc_AEON2.txt_Truong02);
            Compare_TextBox(uc_AEON1.txt_Truong03_1, uc_AEON2.txt_Truong03_1);
            Compare_TextBox(uc_AEON1.txt_Truong03_2, uc_AEON2.txt_Truong03_2);
            Compare_TextBox(uc_AEON1.txt_Truong04, uc_AEON2.txt_Truong04);
            Compare_TextBox(uc_AEON1.txt_Truong05, uc_AEON2.txt_Truong05);
            Compare_TextBox(uc_AEON1.txt_Truong06, uc_AEON2.txt_Truong06);
            Compare_TextBox(uc_AEON1.txt_Truong07, uc_AEON2.txt_Truong07);
            Compare_TextBox(uc_AEON1.txt_Truong08, uc_AEON2.txt_Truong08);
            Compare_TextBox(uc_AEON1.txt_Truong13, uc_AEON2.txt_Truong13);
            Compare_TextBox(uc_AEON1.txt_Truong14, uc_AEON2.txt_Truong14);
            Compare_TextBox(uc_AEON1.txt_Truong15, uc_AEON2.txt_Truong15);
            Compare_TextBox(uc_AEON1.txt_Truong16, uc_AEON2.txt_Truong16);
            Compare_TextBox(uc_AEON1.txt_Truong21, uc_AEON2.txt_Truong21);
            Compare_TextBox(uc_AEON1.txt_Truong22, uc_AEON2.txt_Truong22);
            Compare_TextBox(uc_AEON1.txt_Truong23, uc_AEON2.txt_Truong23);
            Compare_TextBox(uc_AEON1.txt_Truong24, uc_AEON2.txt_Truong24);
            Compare_TextBox(uc_AEON1.txt_Truong29, uc_AEON2.txt_Truong29);
            Compare_TextBox(uc_AEON1.txt_Truong30, uc_AEON2.txt_Truong30);
            Compare_TextBox(uc_AEON1.txt_Truong31, uc_AEON2.txt_Truong31);
            Compare_TextBox(uc_AEON1.txt_Truong32, uc_AEON2.txt_Truong32);
            Compare_TextBox(uc_AEON1.txt_Truong37, uc_AEON2.txt_Truong37);
            Compare_TextBox(uc_AEON1.txt_Truong38, uc_AEON2.txt_Truong38);
            Compare_TextBox(uc_AEON1.txt_Truong39, uc_AEON2.txt_Truong39);
            Compare_TextBox(uc_AEON1.txt_Truong40, uc_AEON2.txt_Truong40);
            Compare_TextBox(uc_AEON1.txt_Truong45, uc_AEON2.txt_Truong45);
            Compare_TextBox(uc_AEON1.txt_Truong46, uc_AEON2.txt_Truong46);
            Compare_TextBox(uc_AEON1.txt_Truong47, uc_AEON2.txt_Truong47);
            Compare_TextBox(uc_AEON1.txt_Truong48, uc_AEON2.txt_Truong48);
            Compare_TextBox(uc_AEON1.txt_Truong53, uc_AEON2.txt_Truong53);
            Compare_TextBox(uc_AEON1.txt_Truong54, uc_AEON2.txt_Truong54);
            Compare_TextBox(uc_AEON1.txt_Truong55, uc_AEON2.txt_Truong55);
            Compare_TextBox(uc_AEON1.txt_Truong56, uc_AEON2.txt_Truong56);
            Compare_TextBox(uc_AEON1.txt_Truong61, uc_AEON2.txt_Truong61);
            Compare_TextBox(uc_AEON1.txt_Truong62, uc_AEON2.txt_Truong62);
            Compare_TextBox(uc_AEON1.txt_Truong63, uc_AEON2.txt_Truong63);
            Compare_TextBox(uc_AEON1.txt_Truong64, uc_AEON2.txt_Truong64);



        }

        private string GetImage_DeSo()
        {
            var temp = (from w in Global.db.tbl_MissCheck_QCs
                        where w.fBatchName == Global.StrBatch && w.UserName == Global.StrUsername && w.Submit == 0
                        select w.IdImage).FirstOrDefault();
            if (string.IsNullOrEmpty(temp))
            {
                var getFilename =
                    (from w in Global.db.ImageCheck_QC_QuanLyDuAn(Global.StrBatch, Global.StrUsername)
                     select w.Column1).FirstOrDefault();
                if (string.IsNullOrEmpty(getFilename))
                {
                    return "NULL";
                }
                else
                {
                    lb_Image.Text = getFilename;
                    uc_PictureBox1.imageBox1.Image = null;
                    if (uc_PictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + getFilename, getFilename,
                                Properties.Settings.Default.ZoomImage) == "Error")
                    {
                        uc_PictureBox1.imageBox1.Image = Resources.svn_deleted;
                        return "Error";
                    }
                }
            }
            else
            {
                lb_Image.Text = temp;
                uc_PictureBox1.imageBox1.Image = null;
                if (uc_PictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + temp, temp,
                            Properties.Settings.Default.ZoomImage) == "Error")
                {
                    uc_PictureBox1.imageBox1.Image = Resources.svn_deleted;
                    return "Error";
                }
            }
            return "ok";
        }


        private void btn_Luu_DeSo1_Click(object sender, EventArgs e)
        {
            Global.db_BPO.UpdateTimeLastRequest(Global.Strtoken);
            if (Global.StrCheck == "CHECKQC")
            {
                if (tabcontrol_DeSo1.SelectedTabPage == tp_ASAHI_DeSo1)
                {
                    Global.db.LuuDESo_QC_QuanLyDuAn(lb_Image.Text, Global.StrBatch, lb_username1.Text, lb_username2.Text, Global.StrUsername, uc_ASAHI1.CheckQC());
                }
                else if (tabcontrol_DeSo1.SelectedTabPage == tp_EIZEN_DeSo1)
                {
                    Global.db.LuuDESo_QC_QuanLyDuAn(lb_Image.Text, Global.StrBatch, lb_username1.Text, lb_username2.Text, Global.StrUsername, uc_EZIEN1.CheckQC());
                }
                else if (tabcontrol_DeSo1.SelectedTabPage == tp_YAMAMOTO_DeSo1)
                {
                    Global.db.LuuDESo_QC_QuanLyDuAn(lb_Image.Text, Global.StrBatch, lb_username1.Text, lb_username2.Text, Global.StrUsername, uc_YAMAMOTO1.CheckQC());
                }
                else if (tabcontrol_DeSo1.SelectedTabPage == tp_YASUDA_DeSo1)
                {
                    Global.db.LuuDESo_QC_QuanLyDuAn(lb_Image.Text, Global.StrBatch, lb_username1.Text, lb_username2.Text, Global.StrUsername, uc_YASUDA1.CheckQC());
                }
                else if (tabcontrol_DeSo1.SelectedTabPage == tp_AEON_DeSo1)
                {
                    Global.db.LuuDESo_QC_QuanLyDuAn(lb_Image.Text, Global.StrBatch, lb_username1.Text, lb_username2.Text, Global.StrUsername, uc_AEON1.CheckQC());
                }
                ResetData();

                var soloi = (from w in Global.db.GetSoLoi_CheckQC(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + " Lỗi";
                string temp = GetImage_DeSo();

                if (temp == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show("Lỗi load hình");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
        }

        private void btn_Luu_DeSo2_Click(object sender, EventArgs e)
        {
            Global.db_BPO.UpdateTimeLastRequest(Global.Strtoken);
            if (Global.StrCheck == "CHECKQC")
            {
                if (tabcontrol_DeSo2.SelectedTabPage == tp_ASAHI_DeSo2)
                {
                    Global.db.LuuDESo_QC_QuanLyDuAn(lb_Image.Text, Global.StrBatch, lb_username2.Text, lb_username1.Text, Global.StrUsername, uc_ASAHI2.CheckQC());
                }
                else if (tabcontrol_DeSo2.SelectedTabPage == tp_EIZEN_DeSo2)
                {
                    Global.db.LuuDESo_QC_QuanLyDuAn(lb_Image.Text, Global.StrBatch, lb_username2.Text, lb_username1.Text, Global.StrUsername,uc_EZIEN2.CheckQC());
                }
                else if (tabcontrol_DeSo2.SelectedTabPage == tp_YAMAMOTO_DeSo2)
                {
                    Global.db.LuuDESo_QC_QuanLyDuAn(lb_Image.Text, Global.StrBatch, lb_username2.Text, lb_username1.Text, Global.StrUsername,uc_YAMAMOTO2.CheckQC());
                }
                else if (tabcontrol_DeSo2.SelectedTabPage == tp_YASUDA_DeSo2)
                {
                    Global.db.LuuDESo_QC_QuanLyDuAn(lb_Image.Text, Global.StrBatch, lb_username2.Text, lb_username1.Text, Global.StrUsername, uc_YASUDA2.CheckQC());
                }
                else if (tabcontrol_DeSo2.SelectedTabPage == tp_AEON_DeSo2)
                {
                    Global.db.LuuDESo_QC_QuanLyDuAn(lb_Image.Text, Global.StrBatch, lb_username2.Text, lb_username1.Text, Global.StrUsername, uc_AEON2.CheckQC());
                }

                var soloi = (from w in Global.db.GetSoLoi_CheckQC(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + " Lỗi";
                ResetData();
                string temp = GetImage_DeSo();

                if (temp == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show("Lỗi load hình");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
        }

        private void btn_SuaVaLuu_User1_Click(object sender, EventArgs e)
        {
            Global.db_BPO.UpdateTimeLastRequest(Global.Strtoken);
            if (Global.StrCheck == "CHECKQC")
            {
                if (tabcontrol_DeSo1.SelectedTabPage == tp_ASAHI_DeSo1)
                {
                    string txTtruong03 = uc_ASAHI1.txt_Truong03_1.Text + uc_ASAHI1.txt_Truong03_2.Text;
                    Global.db.SuaVaLuu_deso_QC_QuanLyDuAn(lb_username1.Text, lb_username2.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername,
                            uc_ASAHI1.txt_Truong0.Text, uc_ASAHI1.txt_Truong02.Text, txTtruong03, "", uc_ASAHI1.txt_Truong05.Text, uc_ASAHI1.txt_Truong06.Text, "", uc_ASAHI1.txt_Truong08.Text,
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", uc_ASAHI1.txt_Truong85.Text, "", "", "",
                            "", "", "", "", "", "", "", "", "", "", uc_ASAHI1.CheckQC());
                }
                else if (tabcontrol_DeSo1.SelectedTabPage == tp_EIZEN_DeSo1)
                {
                    string txTtruong03 = uc_EZIEN1.txt_Truong03_1.Text + uc_EZIEN1.txt_Truong03_2.Text;
                    Global.db.SuaVaLuu_deso_QC_QuanLyDuAn(lb_username1.Text, lb_username2.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername,
                            uc_EZIEN1.txt_Truong0.Text, uc_EZIEN1.txt_Truong02.Text, txTtruong03, "", uc_EZIEN1.txt_Truong05.Text, uc_EZIEN1.txt_Truong06.Text, uc_EZIEN1.txt_Truong07.Text, uc_EZIEN1.txt_Truong08.Text,
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", uc_EZIEN1.txt_Truong85.Text, uc_EZIEN1.txt_Truong86.Text, "", "",
                            "", "", "", "", "", "", "", "", "", "", uc_EZIEN1.CheckQC());
                }
                else if (tabcontrol_DeSo1.SelectedTabPage == tp_YAMAMOTO_DeSo1)
                {
                    string txTtruong03 = uc_YAMAMOTO1.txt_Truong03_1.Text + uc_YAMAMOTO1.txt_Truong03_2.Text;
                    Global.db.SuaVaLuu_deso_QC_QuanLyDuAn(lb_username1.Text, lb_username2.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername,
                            "", uc_YAMAMOTO1.txt_Truong02.Text, txTtruong03, "", uc_YAMAMOTO1.txt_Truong05.Text, uc_YAMAMOTO1.txt_Truong06.Text, uc_YAMAMOTO1.txt_Truong07.Text, uc_YAMAMOTO1.txt_Truong08.Text,
                            "", "", "", "", uc_YAMAMOTO1.txt_Truong13.Text, uc_YAMAMOTO1.txt_Truong14.Text, uc_YAMAMOTO1.txt_Truong15.Text, uc_YAMAMOTO1.txt_Truong16.Text,
                            "", "", "", "", uc_YAMAMOTO1.txt_Truong21.Text, uc_YAMAMOTO1.txt_Truong22.Text, uc_YAMAMOTO1.txt_Truong23.Text, uc_YAMAMOTO1.txt_Truong24.Text,
                            "", "", "", "", uc_YAMAMOTO1.txt_Truong29.Text, uc_YAMAMOTO1.txt_Truong30.Text, uc_YAMAMOTO1.txt_Truong31.Text, uc_YAMAMOTO1.txt_Truong32.Text,
                            "", "", "", "", uc_YAMAMOTO1.txt_Truong37.Text, uc_YAMAMOTO1.txt_Truong38.Text, uc_YAMAMOTO1.txt_Truong39.Text, uc_YAMAMOTO1.txt_Truong40.Text,
                            "", "", "", "", uc_YAMAMOTO1.txt_Truong45.Text, uc_YAMAMOTO1.txt_Truong46.Text, uc_YAMAMOTO1.txt_Truong47.Text, uc_YAMAMOTO1.txt_Truong48.Text,
                            "", "", "", "", uc_YAMAMOTO1.txt_Truong53.Text, uc_YAMAMOTO1.txt_Truong54.Text, uc_YAMAMOTO1.txt_Truong55.Text, uc_YAMAMOTO1.txt_Truong56.Text,
                            "", "", "", "", uc_YAMAMOTO1.txt_Truong61.Text, uc_YAMAMOTO1.txt_Truong62.Text, uc_YAMAMOTO1.txt_Truong63.Text, uc_YAMAMOTO1.txt_Truong64.Text,
                            "", "", "", "", uc_YAMAMOTO1.txt_Truong69.Text, uc_YAMAMOTO1.txt_Truong70.Text, uc_YAMAMOTO1.txt_Truong71.Text, uc_YAMAMOTO1.txt_Truong72.Text,
                            "", "", "", "", uc_YAMAMOTO1.txt_Truong77.Text, uc_YAMAMOTO1.txt_Truong78.Text, uc_YAMAMOTO1.txt_Truong79.Text, uc_YAMAMOTO1.txt_Truong80.Text,
                            "", "", "", "", uc_YAMAMOTO1.txt_Truong85.Text, uc_YAMAMOTO1.txt_Truong86.Text, "", "", "", "", "", "", "", "", "", "", "", "", uc_YAMAMOTO1.CheckQC());
                }
                else if (tabcontrol_DeSo1.SelectedTabPage == tp_YASUDA_DeSo1)
                {
                    string txTtruong03 = uc_YASUDA1.txt_Truong03_1.Text + uc_YASUDA1.txt_Truong03_2.Text;
                    Global.db.SuaVaLuu_deso_QC_QuanLyDuAn(lb_username1.Text, lb_username2.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername,
                            uc_YASUDA1.txt_Truong0.Text, uc_YASUDA1.txt_Truong02.Text, txTtruong03, "", uc_YASUDA1.txt_Truong05.Text, uc_YASUDA1.txt_Truong06.Text, uc_YASUDA1.txt_Truong07.Text, uc_YASUDA1.txt_Truong08.Text,
                            "", "", "", uc_YASUDA1.txt_Truong12.Text, uc_YASUDA1.txt_Truong13.Text, uc_YASUDA1.txt_Truong14.Text, uc_YASUDA1.txt_Truong15.Text, uc_YASUDA1.txt_Truong16.Text,
                            "", "", "", uc_YASUDA1.txt_Truong20.Text, uc_YASUDA1.txt_Truong21.Text, uc_YASUDA1.txt_Truong22.Text, uc_YASUDA1.txt_Truong23.Text, uc_YASUDA1.txt_Truong24.Text,
                            "", "", "", uc_YASUDA1.txt_Truong28.Text, uc_YASUDA1.txt_Truong29.Text, uc_YASUDA1.txt_Truong30.Text, uc_YASUDA1.txt_Truong31.Text, uc_YASUDA1.txt_Truong32.Text,
                            "", "", "", uc_YASUDA1.txt_Truong36.Text, uc_YASUDA1.txt_Truong37.Text, uc_YASUDA1.txt_Truong38.Text, uc_YASUDA1.txt_Truong39.Text, uc_YASUDA1.txt_Truong40.Text,
                            "", "", "", uc_YASUDA1.txt_Truong44.Text, uc_YASUDA1.txt_Truong45.Text, uc_YASUDA1.txt_Truong46.Text, uc_YASUDA1.txt_Truong47.Text, uc_YASUDA1.txt_Truong48.Text,
                            "", "", "", uc_YASUDA1.txt_Truong52.Text, uc_YASUDA1.txt_Truong53.Text, uc_YASUDA1.txt_Truong54.Text, uc_YASUDA1.txt_Truong55.Text, uc_YASUDA1.txt_Truong56.Text,
                            "", "", "", uc_YASUDA1.txt_Truong60.Text, uc_YASUDA1.txt_Truong61.Text, uc_YASUDA1.txt_Truong62.Text, uc_YASUDA1.txt_Truong63.Text, uc_YASUDA1.txt_Truong64.Text,
                            "", "", "", uc_YASUDA1.txt_Truong68.Text, uc_YASUDA1.txt_Truong69.Text, uc_YASUDA1.txt_Truong70.Text, uc_YASUDA1.txt_Truong71.Text, uc_YASUDA1.txt_Truong72.Text,
                            "", "", "", uc_YASUDA1.txt_Truong76.Text, uc_YASUDA1.txt_Truong77.Text, uc_YASUDA1.txt_Truong78.Text, uc_YASUDA1.txt_Truong79.Text, uc_YASUDA1.txt_Truong80.Text,
                            "", "", "", uc_YASUDA1.txt_Truong84.Text, uc_YASUDA1.txt_Truong85.Text,"", uc_YASUDA1.txt_Truong87.Text, "", "", "", uc_YASUDA1.txt_Truong92.Text, "", "", "", "", "", "", "", uc_YASUDA1.CheckQC());
                }
                else if (tabcontrol_DeSo1.SelectedTabPage == tp_AEON_DeSo1)
                {
                    Global.db.SuaVaLuu_deso_QC_QuanLyDuAn_New(lb_username1.Text, lb_username2.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername,
                            "", uc_AEON1.txt_Truong02.Text, uc_AEON1.txt_Truong03_1.Text, uc_AEON1.txt_Truong03_2.Text, uc_AEON1.txt_Truong04.Text, uc_AEON1.txt_Truong05.Text, uc_AEON1.txt_Truong06.Text, uc_AEON1.txt_Truong07.Text, uc_AEON1.txt_Truong08.Text,
                            "", "", "", "", uc_AEON1.txt_Truong13.Text, uc_AEON1.txt_Truong14.Text, uc_AEON1.txt_Truong15.Text, uc_AEON1.txt_Truong16.Text,
                            "", "", "", "", uc_AEON1.txt_Truong21.Text, uc_AEON1.txt_Truong22.Text, uc_AEON1.txt_Truong23.Text, uc_AEON1.txt_Truong24.Text,
                            "", "", "", "", uc_AEON1.txt_Truong29.Text, uc_AEON1.txt_Truong30.Text, uc_AEON1.txt_Truong31.Text, uc_AEON1.txt_Truong32.Text,
                            "", "", "", "", uc_AEON1.txt_Truong37.Text, uc_AEON1.txt_Truong38.Text, uc_AEON1.txt_Truong39.Text, uc_AEON1.txt_Truong40.Text,
                            "", "", "", "", uc_AEON1.txt_Truong45.Text, uc_AEON1.txt_Truong46.Text, uc_AEON1.txt_Truong47.Text, uc_AEON1.txt_Truong48.Text,
                            "", "", "", "", uc_AEON1.txt_Truong53.Text, uc_AEON1.txt_Truong54.Text, uc_AEON1.txt_Truong55.Text, uc_AEON1.txt_Truong56.Text,
                            "", "", "", "", uc_AEON1.txt_Truong61.Text, uc_AEON1.txt_Truong62.Text, uc_AEON1.txt_Truong63.Text, uc_AEON1.txt_Truong64.Text,
                            "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", uc_AEON1.CheckQC());
                }
                ResetData();

                var soloi = (from w in Global.db.GetSoLoi_CheckQC(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + " Lỗi";
                if (GetImage_DeSo() == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;

            }
        }
        private void btn_SuaVaLuu_User2_Click(object sender, EventArgs e)
        {
            Global.db_BPO.UpdateTimeLastRequest(Global.Strtoken);
            if (Global.StrCheck == "CHECKQC")
            {
                if (tabcontrol_DeSo2.SelectedTabPage == tp_ASAHI_DeSo2)
                {
                    string txTtruong03 = uc_ASAHI2.txt_Truong03_1.Text + uc_ASAHI2.txt_Truong03_2.Text;
                    Global.db.SuaVaLuu_deso_QC_QuanLyDuAn(lb_username2.Text, lb_username1.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername,
                            uc_ASAHI2.txt_Truong0.Text, uc_ASAHI2.txt_Truong02.Text, txTtruong03, "", uc_ASAHI2.txt_Truong05.Text, uc_ASAHI2.txt_Truong06.Text, "", uc_ASAHI2.txt_Truong08.Text,
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", uc_ASAHI2.txt_Truong85.Text, "", "", "",
                            "", "", "", "", "", "", "", "", "", "", uc_ASAHI2.CheckQC());
                }
                else if (tabcontrol_DeSo2.SelectedTabPage == tp_EIZEN_DeSo2)
                {
                    string txTtruong03 = uc_EZIEN2.txt_Truong03_1.Text + uc_EZIEN2.txt_Truong03_2.Text;
                    Global.db.SuaVaLuu_deso_QC_QuanLyDuAn(lb_username2.Text, lb_username1.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername,
                            uc_EZIEN2.txt_Truong0.Text, uc_EZIEN2.txt_Truong02.Text, txTtruong03, "", uc_EZIEN2.txt_Truong05.Text, uc_EZIEN2.txt_Truong06.Text, uc_EZIEN2.txt_Truong07.Text, uc_EZIEN2.txt_Truong08.Text,
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", uc_EZIEN2.txt_Truong85.Text, uc_EZIEN2.txt_Truong86.Text, "", "",
                            "", "", "", "", "", "", "", "", "", "", uc_EZIEN2.CheckQC());
                }
                else if (tabcontrol_DeSo2.SelectedTabPage == tp_YAMAMOTO_DeSo2)
                {
                    string txTtruong03 = uc_YAMAMOTO2.txt_Truong03_1.Text + uc_YAMAMOTO2.txt_Truong03_2.Text;
                    Global.db.SuaVaLuu_deso_QC_QuanLyDuAn(lb_username2.Text, lb_username1.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername,
                            "", uc_YAMAMOTO2.txt_Truong02.Text, txTtruong03, "", uc_YAMAMOTO2.txt_Truong05.Text, uc_YAMAMOTO2.txt_Truong06.Text, uc_YAMAMOTO2.txt_Truong07.Text, uc_YAMAMOTO2.txt_Truong08.Text,
                            "", "", "", "", uc_YAMAMOTO2.txt_Truong13.Text, uc_YAMAMOTO2.txt_Truong14.Text, uc_YAMAMOTO2.txt_Truong15.Text, uc_YAMAMOTO2.txt_Truong16.Text,
                            "", "", "", "", uc_YAMAMOTO2.txt_Truong21.Text, uc_YAMAMOTO2.txt_Truong22.Text, uc_YAMAMOTO2.txt_Truong23.Text, uc_YAMAMOTO2.txt_Truong24.Text,
                            "", "", "", "", uc_YAMAMOTO2.txt_Truong29.Text, uc_YAMAMOTO2.txt_Truong30.Text, uc_YAMAMOTO2.txt_Truong31.Text, uc_YAMAMOTO2.txt_Truong32.Text,
                            "", "", "", "", uc_YAMAMOTO2.txt_Truong37.Text, uc_YAMAMOTO2.txt_Truong38.Text, uc_YAMAMOTO2.txt_Truong39.Text, uc_YAMAMOTO2.txt_Truong40.Text,
                            "", "", "", "", uc_YAMAMOTO2.txt_Truong45.Text, uc_YAMAMOTO2.txt_Truong46.Text, uc_YAMAMOTO2.txt_Truong47.Text, uc_YAMAMOTO2.txt_Truong48.Text,
                            "", "", "", "", uc_YAMAMOTO2.txt_Truong53.Text, uc_YAMAMOTO2.txt_Truong54.Text, uc_YAMAMOTO2.txt_Truong55.Text, uc_YAMAMOTO2.txt_Truong56.Text,
                            "", "", "", "", uc_YAMAMOTO2.txt_Truong61.Text, uc_YAMAMOTO2.txt_Truong62.Text, uc_YAMAMOTO2.txt_Truong63.Text, uc_YAMAMOTO2.txt_Truong64.Text,
                            "", "", "", "", uc_YAMAMOTO2.txt_Truong69.Text, uc_YAMAMOTO2.txt_Truong70.Text, uc_YAMAMOTO2.txt_Truong71.Text, uc_YAMAMOTO2.txt_Truong72.Text,
                            "", "", "", "", uc_YAMAMOTO2.txt_Truong77.Text, uc_YAMAMOTO2.txt_Truong78.Text, uc_YAMAMOTO2.txt_Truong79.Text, uc_YAMAMOTO2.txt_Truong80.Text,
                            "", "", "", "", uc_YAMAMOTO2.txt_Truong85.Text, uc_YAMAMOTO2.txt_Truong86.Text, "", "", "", "", "", "", "", "", "", "", "", "", uc_YAMAMOTO2.CheckQC());
                }
                else if (tabcontrol_DeSo2.SelectedTabPage == tp_YASUDA_DeSo2)
                {
                    string txTtruong03 = uc_YASUDA2.txt_Truong03_1.Text + uc_YASUDA2.txt_Truong03_2.Text;
                    Global.db.SuaVaLuu_deso_QC_QuanLyDuAn(lb_username2.Text, lb_username1.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername,
                            uc_YASUDA2.txt_Truong0.Text, uc_YASUDA2.txt_Truong02.Text, txTtruong03, "", uc_YASUDA2.txt_Truong05.Text, uc_YASUDA2.txt_Truong06.Text, uc_YASUDA2.txt_Truong07.Text, uc_YASUDA2.txt_Truong08.Text,
                            "", "", "", uc_YASUDA2.txt_Truong12.Text, uc_YASUDA2.txt_Truong13.Text, uc_YASUDA2.txt_Truong14.Text, uc_YASUDA2.txt_Truong15.Text, uc_YASUDA2.txt_Truong16.Text,
                            "", "", "", uc_YASUDA2.txt_Truong20.Text, uc_YASUDA2.txt_Truong21.Text, uc_YASUDA2.txt_Truong22.Text, uc_YASUDA2.txt_Truong23.Text, uc_YASUDA2.txt_Truong24.Text,
                            "", "", "", uc_YASUDA2.txt_Truong28.Text, uc_YASUDA2.txt_Truong29.Text, uc_YASUDA2.txt_Truong30.Text, uc_YASUDA2.txt_Truong31.Text, uc_YASUDA2.txt_Truong32.Text,
                            "", "", "", uc_YASUDA2.txt_Truong36.Text, uc_YASUDA2.txt_Truong37.Text, uc_YASUDA2.txt_Truong38.Text, uc_YASUDA2.txt_Truong39.Text, uc_YASUDA2.txt_Truong40.Text,
                            "", "", "", uc_YASUDA2.txt_Truong44.Text, uc_YASUDA2.txt_Truong45.Text, uc_YASUDA2.txt_Truong46.Text, uc_YASUDA2.txt_Truong47.Text, uc_YASUDA2.txt_Truong48.Text,
                            "", "", "", uc_YASUDA2.txt_Truong52.Text, uc_YASUDA2.txt_Truong53.Text, uc_YASUDA2.txt_Truong54.Text, uc_YASUDA2.txt_Truong55.Text, uc_YASUDA2.txt_Truong56.Text,
                            "", "", "", uc_YASUDA2.txt_Truong60.Text, uc_YASUDA2.txt_Truong61.Text, uc_YASUDA2.txt_Truong62.Text, uc_YASUDA2.txt_Truong63.Text, uc_YASUDA2.txt_Truong64.Text,
                            "", "", "", uc_YASUDA2.txt_Truong68.Text, uc_YASUDA2.txt_Truong69.Text, uc_YASUDA2.txt_Truong70.Text, uc_YASUDA2.txt_Truong71.Text, uc_YASUDA2.txt_Truong72.Text,
                            "", "", "", uc_YASUDA2.txt_Truong76.Text, uc_YASUDA2.txt_Truong77.Text, uc_YASUDA2.txt_Truong78.Text, uc_YASUDA2.txt_Truong79.Text, uc_YASUDA2.txt_Truong80.Text,
                            "", "", "", uc_YASUDA2.txt_Truong84.Text, uc_YASUDA2.txt_Truong85.Text, "", uc_YASUDA2.txt_Truong87.Text, "", "", "", uc_YASUDA2.txt_Truong92.Text, "", "", "", "", "", "", "", uc_YASUDA2.CheckQC());
                }
                else if (tabcontrol_DeSo2.SelectedTabPage == tp_AEON_DeSo2)
                {
                    Global.db.SuaVaLuu_deso_QC_QuanLyDuAn_New(lb_username1.Text, lb_username2.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername,
                            "", uc_AEON2.txt_Truong02.Text, uc_AEON2.txt_Truong03_1.Text, uc_AEON2.txt_Truong03_2.Text, uc_AEON2.txt_Truong04.Text, uc_AEON2.txt_Truong05.Text, uc_AEON2.txt_Truong06.Text, uc_AEON2.txt_Truong07.Text, uc_AEON2.txt_Truong08.Text,
                            "", "", "", "", uc_AEON2.txt_Truong13.Text, uc_AEON2.txt_Truong14.Text, uc_AEON2.txt_Truong15.Text, uc_AEON2.txt_Truong16.Text,
                            "", "", "", "", uc_AEON2.txt_Truong21.Text, uc_AEON2.txt_Truong22.Text, uc_AEON2.txt_Truong23.Text, uc_AEON2.txt_Truong24.Text,
                            "", "", "", "", uc_AEON2.txt_Truong29.Text, uc_AEON2.txt_Truong30.Text, uc_AEON2.txt_Truong31.Text, uc_AEON2.txt_Truong32.Text,
                            "", "", "", "", uc_AEON2.txt_Truong37.Text, uc_AEON2.txt_Truong38.Text, uc_AEON2.txt_Truong39.Text, uc_AEON2.txt_Truong40.Text,
                            "", "", "", "", uc_AEON2.txt_Truong45.Text, uc_AEON2.txt_Truong46.Text, uc_AEON2.txt_Truong47.Text, uc_AEON2.txt_Truong48.Text,
                            "", "", "", "", uc_AEON2.txt_Truong53.Text, uc_AEON2.txt_Truong54.Text, uc_AEON2.txt_Truong55.Text, uc_AEON2.txt_Truong56.Text,
                            "", "", "", "", uc_AEON2.txt_Truong61.Text, uc_AEON2.txt_Truong62.Text, uc_AEON2.txt_Truong63.Text, uc_AEON2.txt_Truong64.Text,
                            "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "",
                            "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", uc_AEON2.CheckQC());
                }
                ResetData();

                var soloi = (from w in Global.db.GetSoLoi_CheckQC(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + " Lỗi";
                if (GetImage_DeSo() == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
        }
 
        private void tabcontrol_DeSo2_Click(object sender, EventArgs e)
        {
            if (tabcontrol_DeSo2.SelectedTabPage == tp_ASAHI_DeSo2)
                tabcontrol_DeSo1.SelectedTabPage = tp_ASAHI_DeSo1;
            else if (tabcontrol_DeSo2.SelectedTabPage == tp_EIZEN_DeSo2)
                tabcontrol_DeSo1.SelectedTabPage = tp_EIZEN_DeSo1;
            else if (tabcontrol_DeSo2.SelectedTabPage == tp_YAMAMOTO_DeSo2)
                tabcontrol_DeSo1.SelectedTabPage = tp_YAMAMOTO_DeSo1;
            else if (tabcontrol_DeSo2.SelectedTabPage == tp_YASUDA_DeSo2)
                tabcontrol_DeSo1.SelectedTabPage = tp_YASUDA_DeSo1;
            else if (tabcontrol_DeSo2.SelectedTabPage == tp_AEON_DeSo2)
                tabcontrol_DeSo1.SelectedTabPage = tp_AEON_DeSo1;
        }

        private void tabcontrol_DeSo1_Click(object sender, EventArgs e)
        {
            if (tabcontrol_DeSo1.SelectedTabPage == tp_ASAHI_DeSo1)
                tabcontrol_DeSo2.SelectedTabPage = tp_ASAHI_DeSo2;
            else if (tabcontrol_DeSo1.SelectedTabPage == tp_EIZEN_DeSo1)
                tabcontrol_DeSo2.SelectedTabPage = tp_EIZEN_DeSo2;
            else if (tabcontrol_DeSo1.SelectedTabPage == tp_YAMAMOTO_DeSo1)
                tabcontrol_DeSo2.SelectedTabPage = tp_YAMAMOTO_DeSo2;
            else if (tabcontrol_DeSo1.SelectedTabPage == tp_YASUDA_DeSo1)
                tabcontrol_DeSo2.SelectedTabPage = tp_YASUDA_DeSo2;
            else if (tabcontrol_DeSo1.SelectedTabPage == tp_AEON_DeSo1)
                tabcontrol_DeSo2.SelectedTabPage = tp_AEON_DeSo2;
        }

        private void uc_ASAHI1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                uc_ASAHI1.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                uc_ASAHI2.VerticalScroll.Value = e.NewValue;
        }

        private void uc_ASAHI2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                uc_ASAHI2.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                uc_ASAHI1.VerticalScroll.Value = e.NewValue;
        }

        private void uc_EZIEN1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                uc_EZIEN1.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                uc_EZIEN2.VerticalScroll.Value = e.NewValue;
        }

        private void uc_EZIEN2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                uc_EZIEN2.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                uc_EZIEN1.VerticalScroll.Value = e.NewValue;
        }

        private void uc_YAMAMOTO1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                uc_YAMAMOTO1.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                uc_YAMAMOTO2.VerticalScroll.Value = e.NewValue;
        }

        private void uc_YAMAMOTO2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                uc_YAMAMOTO2.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                uc_YAMAMOTO1.VerticalScroll.Value = e.NewValue;
        }

        private void uc_YASUDA1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                uc_YASUDA1.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                uc_YASUDA2.VerticalScroll.Value = e.NewValue;
        }

        private void uc_YASUDA2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                uc_YASUDA2.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                uc_YASUDA1.VerticalScroll.Value = e.NewValue;
        }

        private void uc_AEON1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                uc_AEON1.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                uc_AEON2.VerticalScroll.Value = e.NewValue;
        }

        private void uc_AEON2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                uc_AEON2.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                uc_AEON1.VerticalScroll.Value = e.NewValue;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Check_QC_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control && e.KeyCode == Keys.Enter)
            {
                if (tabcontrol_DeSo2.SelectedTabPage == tp_YAMAMOTO_DeSo2)
                    uc_YAMAMOTO2.txt_Truong03_1.Focus();
            }
            if (e.KeyCode == Keys.Down && _Flag)
            {
                SendKeys.Send("{Tab}");
                SendKeys.Send("{Tab}");
                SendKeys.Send("{Tab}");
                SendKeys.Send("{Tab}");
            }
            if (e.KeyCode == Keys.Up  && _Flag)
            {
                SendKeys.Send("+{Tab}");
                SendKeys.Send("+{Tab}");
                SendKeys.Send("+{Tab}");
                SendKeys.Send("+{Tab}");
            }
            if (e.KeyCode == Keys.Right)
            {
                SendKeys.Send("{Tab}");
            }
            if (e.KeyCode == Keys.Left)
            {
                SendKeys.Send("+{Tab}");
            }
        }
    }
}