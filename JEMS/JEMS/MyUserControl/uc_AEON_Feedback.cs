using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ImageGlass;
using JEMS;

namespace JEMS.MyUserControl
{
    public partial class uc_AEON_Feedback : UserControl
    {
        public uc_AEON_Feedback()
        {
            InitializeComponent();
        }

        public void LoadImage(string fbatchname,string url_image,string idimage)
        {
            uc_PictureBox1.LoadImage(url_image, idimage, 100);
            uc_PictureBox1.imageBox1.SizeMode = ImageBoxSizeMode.Fit;
            LoadText_User(fbatchname, idimage);
            LoadChecker(fbatchname, idimage);
            SoSanhTextBox();
            SoSanhChecker();
        }
        
        public void LoadText_User(string fbatchname, string idimage)
        {
            var deso = (from w in Global.db.tbl_DeSo_Backups
                        where w.fBatchName == fbatchname && w.IdImage == idimage
                        select w).ToList();

            uc_AEON1.LoadData(deso[0]);
            uc_AEON2.LoadData(deso[1]);
        }

        public void LoadChecker(string fbatchname, string idimage)
        {
            var deso = (from w in Global.db.tbl_DeSos
                        where w.fBatchName == fbatchname && w.UserName == "Checker" && w.IdImage == idimage
                        select w).ToList();

            uc_AEON3.LoadDataChecker(deso[0]);
        }

        public void LoadChecker_User(string fbatchname, string idimage)
        {
            var deso = (from w in Global.db.tbl_DeSos
                        where w.fBatchName == fbatchname && w.IdImage == idimage && w.True == 1
                        select w).ToList();

            uc_AEON3.LoadDataChecker(deso[0]);
        } 

        private void SoSanhTextBox()
        {
            changeColorUser(uc_AEON1.txt_Truong02, uc_AEON2.txt_Truong02);
            changeColorUser(uc_AEON1.txt_Truong03_1, uc_AEON2.txt_Truong03_1);
            changeColorUser(uc_AEON1.txt_Truong03_2, uc_AEON2.txt_Truong03_2);
            changeColorUser(uc_AEON1.txt_Truong04, uc_AEON2.txt_Truong04);
            changeColorUser(uc_AEON1.txt_Truong05, uc_AEON2.txt_Truong05);
            changeColorUser(uc_AEON1.txt_Truong06, uc_AEON2.txt_Truong06);
            changeColorUser(uc_AEON1.txt_Truong07, uc_AEON2.txt_Truong07);
            changeColorUser(uc_AEON1.txt_Truong08, uc_AEON2.txt_Truong08, "");
            changeColorUser(uc_AEON1.txt_Truong13, uc_AEON2.txt_Truong13);
            changeColorUser(uc_AEON1.txt_Truong14, uc_AEON2.txt_Truong14);
            changeColorUser(uc_AEON1.txt_Truong15, uc_AEON2.txt_Truong15);
            changeColorUser(uc_AEON1.txt_Truong16, uc_AEON2.txt_Truong16,"");
            changeColorUser(uc_AEON1.txt_Truong21, uc_AEON2.txt_Truong21);
            changeColorUser(uc_AEON1.txt_Truong22, uc_AEON2.txt_Truong22);
            changeColorUser(uc_AEON1.txt_Truong23, uc_AEON2.txt_Truong23);
            changeColorUser(uc_AEON1.txt_Truong24, uc_AEON2.txt_Truong24,"");
            changeColorUser(uc_AEON1.txt_Truong29, uc_AEON2.txt_Truong29);
            changeColorUser(uc_AEON1.txt_Truong30, uc_AEON2.txt_Truong30);
            changeColorUser(uc_AEON1.txt_Truong31, uc_AEON2.txt_Truong31);
            changeColorUser(uc_AEON1.txt_Truong32, uc_AEON2.txt_Truong32,"");
            changeColorUser(uc_AEON1.txt_Truong37, uc_AEON2.txt_Truong37);
            changeColorUser(uc_AEON1.txt_Truong38, uc_AEON2.txt_Truong38);
            changeColorUser(uc_AEON1.txt_Truong39, uc_AEON2.txt_Truong39);
            changeColorUser(uc_AEON1.txt_Truong40, uc_AEON2.txt_Truong40,"");
            changeColorUser(uc_AEON1.txt_Truong45, uc_AEON2.txt_Truong45);
            changeColorUser(uc_AEON1.txt_Truong46, uc_AEON2.txt_Truong46);
            changeColorUser(uc_AEON1.txt_Truong47, uc_AEON2.txt_Truong47);
            changeColorUser(uc_AEON1.txt_Truong48, uc_AEON2.txt_Truong48,"");
            changeColorUser(uc_AEON1.txt_Truong53, uc_AEON2.txt_Truong53);
            changeColorUser(uc_AEON1.txt_Truong54, uc_AEON2.txt_Truong54);
            changeColorUser(uc_AEON1.txt_Truong55, uc_AEON2.txt_Truong55);
            changeColorUser(uc_AEON1.txt_Truong56, uc_AEON2.txt_Truong56,"");
            changeColorUser(uc_AEON1.txt_Truong61, uc_AEON2.txt_Truong61);
            changeColorUser(uc_AEON1.txt_Truong62, uc_AEON2.txt_Truong62);
            changeColorUser(uc_AEON1.txt_Truong63, uc_AEON2.txt_Truong63);
            changeColorUser(uc_AEON1.txt_Truong64, uc_AEON2.txt_Truong64,"");
        }

        private void SoSanhTextBoxSingle()
        {
            changeColorUser_Single(uc_AEON2.txt_Truong02, uc_AEON3.txt_Truong02);
            changeColorUser_Single(uc_AEON2.txt_Truong03_1, uc_AEON3.txt_Truong03_1);
            changeColorUser_Single(uc_AEON2.txt_Truong03_2, uc_AEON3.txt_Truong03_2);
            changeColorUser_Single(uc_AEON2.txt_Truong04, uc_AEON3.txt_Truong04);
            changeColorUser_Single(uc_AEON2.txt_Truong05, uc_AEON3.txt_Truong05);
            changeColorUser_Single(uc_AEON2.txt_Truong06, uc_AEON3.txt_Truong06);
            changeColorUser_Single(uc_AEON2.txt_Truong07, uc_AEON3.txt_Truong07);
            changeColorUser_Single(uc_AEON2.txt_Truong08, uc_AEON3.txt_Truong08,"");
            changeColorUser_Single(uc_AEON2.txt_Truong13, uc_AEON3.txt_Truong13);
            changeColorUser_Single(uc_AEON2.txt_Truong14, uc_AEON3.txt_Truong14);
            changeColorUser_Single(uc_AEON2.txt_Truong15, uc_AEON3.txt_Truong15);
            changeColorUser_Single(uc_AEON2.txt_Truong16, uc_AEON3.txt_Truong16,"");
            changeColorUser_Single(uc_AEON2.txt_Truong21, uc_AEON3.txt_Truong21);
            changeColorUser_Single(uc_AEON2.txt_Truong22, uc_AEON3.txt_Truong22);
            changeColorUser_Single(uc_AEON2.txt_Truong23, uc_AEON3.txt_Truong23);
            changeColorUser_Single(uc_AEON2.txt_Truong24, uc_AEON3.txt_Truong24,"");
            changeColorUser_Single(uc_AEON2.txt_Truong29, uc_AEON3.txt_Truong29);
            changeColorUser_Single(uc_AEON2.txt_Truong30, uc_AEON3.txt_Truong30);
            changeColorUser_Single(uc_AEON2.txt_Truong31, uc_AEON3.txt_Truong31);
            changeColorUser_Single(uc_AEON2.txt_Truong32, uc_AEON3.txt_Truong32,"");
            changeColorUser_Single(uc_AEON2.txt_Truong37, uc_AEON3.txt_Truong37);
            changeColorUser_Single(uc_AEON2.txt_Truong38, uc_AEON3.txt_Truong38);
            changeColorUser_Single(uc_AEON2.txt_Truong39, uc_AEON3.txt_Truong39);
            changeColorUser_Single(uc_AEON2.txt_Truong40, uc_AEON3.txt_Truong40,"");
            changeColorUser_Single(uc_AEON2.txt_Truong45, uc_AEON3.txt_Truong45);
            changeColorUser_Single(uc_AEON2.txt_Truong46, uc_AEON3.txt_Truong46);
            changeColorUser_Single(uc_AEON2.txt_Truong47, uc_AEON3.txt_Truong47);
            changeColorUser_Single(uc_AEON2.txt_Truong48, uc_AEON3.txt_Truong48,"");
            changeColorUser_Single(uc_AEON2.txt_Truong53, uc_AEON3.txt_Truong53);
            changeColorUser_Single(uc_AEON2.txt_Truong54, uc_AEON3.txt_Truong54);
            changeColorUser_Single(uc_AEON2.txt_Truong55, uc_AEON3.txt_Truong55);
            changeColorUser_Single(uc_AEON2.txt_Truong56, uc_AEON3.txt_Truong56,"");
            changeColorUser_Single(uc_AEON2.txt_Truong61, uc_AEON3.txt_Truong61);
            changeColorUser_Single(uc_AEON2.txt_Truong62, uc_AEON3.txt_Truong62);
            changeColorUser_Single(uc_AEON2.txt_Truong63, uc_AEON3.txt_Truong63);
            changeColorUser_Single(uc_AEON2.txt_Truong64, uc_AEON3.txt_Truong64,"");
        }

        private void SoSanhChecker()
        {
            changeColorChecker(uc_AEON1.txt_Truong02, uc_AEON2.txt_Truong02, uc_AEON3.txt_Truong02);
            changeColorChecker(uc_AEON1.txt_Truong03_1, uc_AEON2.txt_Truong03_1, uc_AEON3.txt_Truong03_1);
            changeColorChecker(uc_AEON1.txt_Truong03_2, uc_AEON2.txt_Truong03_2, uc_AEON3.txt_Truong03_2);
            changeColorChecker(uc_AEON1.txt_Truong04, uc_AEON2.txt_Truong04, uc_AEON3.txt_Truong04);
            changeColorChecker(uc_AEON1.txt_Truong05, uc_AEON2.txt_Truong05, uc_AEON3.txt_Truong05);
            changeColorChecker(uc_AEON1.txt_Truong06, uc_AEON2.txt_Truong06, uc_AEON3.txt_Truong06);
            changeColorChecker(uc_AEON1.txt_Truong07, uc_AEON2.txt_Truong07, uc_AEON3.txt_Truong07);
            changeColorChecker(uc_AEON1.txt_Truong08, uc_AEON2.txt_Truong08, uc_AEON3.txt_Truong08,"");
            changeColorChecker(uc_AEON1.txt_Truong13, uc_AEON2.txt_Truong13, uc_AEON3.txt_Truong13);
            changeColorChecker(uc_AEON1.txt_Truong14, uc_AEON2.txt_Truong14, uc_AEON3.txt_Truong14);
            changeColorChecker(uc_AEON1.txt_Truong15, uc_AEON2.txt_Truong15, uc_AEON3.txt_Truong15);
            changeColorChecker(uc_AEON1.txt_Truong16, uc_AEON2.txt_Truong16, uc_AEON3.txt_Truong16,"");
            changeColorChecker(uc_AEON1.txt_Truong21, uc_AEON2.txt_Truong21, uc_AEON3.txt_Truong21);
            changeColorChecker(uc_AEON1.txt_Truong22, uc_AEON2.txt_Truong22, uc_AEON3.txt_Truong22);
            changeColorChecker(uc_AEON1.txt_Truong23, uc_AEON2.txt_Truong23, uc_AEON3.txt_Truong23);
            changeColorChecker(uc_AEON1.txt_Truong24, uc_AEON2.txt_Truong24, uc_AEON3.txt_Truong24,"");
            changeColorChecker(uc_AEON1.txt_Truong29, uc_AEON2.txt_Truong29, uc_AEON3.txt_Truong29);
            changeColorChecker(uc_AEON1.txt_Truong30, uc_AEON2.txt_Truong30, uc_AEON3.txt_Truong30);
            changeColorChecker(uc_AEON1.txt_Truong31, uc_AEON2.txt_Truong31, uc_AEON3.txt_Truong31);
            changeColorChecker(uc_AEON1.txt_Truong32, uc_AEON2.txt_Truong32, uc_AEON3.txt_Truong32,"");
            changeColorChecker(uc_AEON1.txt_Truong37, uc_AEON2.txt_Truong37, uc_AEON3.txt_Truong37);
            changeColorChecker(uc_AEON1.txt_Truong38, uc_AEON2.txt_Truong38, uc_AEON3.txt_Truong38);
            changeColorChecker(uc_AEON1.txt_Truong39, uc_AEON2.txt_Truong39, uc_AEON3.txt_Truong39);
            changeColorChecker(uc_AEON1.txt_Truong40, uc_AEON2.txt_Truong40, uc_AEON3.txt_Truong40,"");
            changeColorChecker(uc_AEON1.txt_Truong45, uc_AEON2.txt_Truong45, uc_AEON3.txt_Truong45);
            changeColorChecker(uc_AEON1.txt_Truong46, uc_AEON2.txt_Truong46, uc_AEON3.txt_Truong46);
            changeColorChecker(uc_AEON1.txt_Truong47, uc_AEON2.txt_Truong47, uc_AEON3.txt_Truong47);
            changeColorChecker(uc_AEON1.txt_Truong48, uc_AEON2.txt_Truong48, uc_AEON3.txt_Truong48,"");
            changeColorChecker(uc_AEON1.txt_Truong53, uc_AEON2.txt_Truong53, uc_AEON3.txt_Truong53);
            changeColorChecker(uc_AEON1.txt_Truong54, uc_AEON2.txt_Truong54, uc_AEON3.txt_Truong54);
            changeColorChecker(uc_AEON1.txt_Truong55, uc_AEON2.txt_Truong55, uc_AEON3.txt_Truong55);
            changeColorChecker(uc_AEON1.txt_Truong56, uc_AEON2.txt_Truong56, uc_AEON3.txt_Truong56,"");
            changeColorChecker(uc_AEON1.txt_Truong61, uc_AEON2.txt_Truong61, uc_AEON3.txt_Truong61);
            changeColorChecker(uc_AEON1.txt_Truong62, uc_AEON2.txt_Truong62, uc_AEON3.txt_Truong62);
            changeColorChecker(uc_AEON1.txt_Truong63, uc_AEON2.txt_Truong63, uc_AEON3.txt_Truong63);
            changeColorChecker(uc_AEON1.txt_Truong64, uc_AEON2.txt_Truong64, uc_AEON3.txt_Truong64,"");
        }

        public void LoadImageUser(string user, string fbatchname, string urlImage, string idimage)
        {
            uc_PictureBox1.LoadImage(urlImage, idimage, 100);
            uc_PictureBox1.imageBox1.SizeMode = ImageBoxSizeMode.Fit;
            LoadText_User(user, fbatchname, idimage);
            LoadChecker_User(fbatchname, idimage);
            SoSanhTextBoxSingle();}

        public void LoadText_User(string user, string fbatchname, string idimage)
        {
            var deso = (from w in Global.db.tbl_DeSo_Backups
                        where w.fBatchName == fbatchname && w.IdImage == idimage && w.UserName == user
                        select w).ToList();

            uc_AEON2.LoadData(deso[0]);
        }

        private void changeColorUser_Single(TextEdit txt2, TextEdit txt3)
        {
            if (txt2.Text != txt3.Text)
            {
                txt2.ForeColor = Color.White;
                txt2.BackColor = Color.Red;
                txt3.ForeColor = Color.White;
                txt3.BackColor = Color.Green;
            }
            else
            {
                txt2.ForeColor = Color.Black;
                txt2.BackColor = Color.White;
                txt3.ForeColor = Color.Black;
                txt3.BackColor = Color.White;
            }
        }
        private void changeColorUser(TextEdit txt1, TextEdit txt2)
        {
            if (txt1.Text != txt2.Text)
            {
                txt1.ForeColor = Color.White;
                txt1.BackColor = Color.Red;
                txt2.ForeColor = Color.White;
                txt2.BackColor = Color.Red;
            }
            else
            {
                txt1.ForeColor = Color.Black;
                txt1.BackColor = Color.White;
                txt2.ForeColor = Color.Black;
                txt2.BackColor = Color.White;
            }
        }

        private void changeColorChecker(TextEdit txt1, TextEdit txt2, TextEdit txt3)
        {
            if (txt1.ForeColor == Color.White|| txt2.ForeColor == Color.White)
            {
                if (txt1.Text == txt3.Text)
                {
                    txt1.ForeColor = Color.White;
                    txt1.BackColor = Color.Green;
                    txt3.ForeColor = Color.White;
                    txt3.BackColor = Color.Green;
                }
                else
                {
                    txt1.ForeColor = Color.White;
                    txt1.BackColor = Color.Red;

                    txt3.ForeColor = Color.White;
                    txt3.BackColor = Color.Green;
                }
                if (txt2.Text == txt3.Text)
                {
                    txt2.ForeColor = Color.White;
                    txt2.BackColor = Color.Green;
                    txt3.ForeColor = Color.White;
                    txt3.BackColor = Color.Green;
                }
                else
                {
                    txt2.ForeColor = Color.White;
                    txt2.BackColor = Color.Red;

                    txt3.ForeColor = Color.White;
                    txt3.BackColor = Color.Green;
                }
            }
            else
            {
                if (txt1.Text==txt2.Text&& txt1.Text!=txt3.Text)
                {
                    txt1.ForeColor = Color.White;
                    txt1.BackColor = Color.Red;
                    txt2.ForeColor = Color.White;
                    txt2.BackColor = Color.Red;

                    txt3.ForeColor = Color.White;
                    txt3.BackColor = Color.Green;
                }
            }
        }
        private void changeColorUser_Single(LookUpEdit txt2, LookUpEdit txt3,string a)
        {
            if (txt2.ItemIndex != txt3.ItemIndex)
            {
                txt2.ForeColor = Color.White;
                txt2.BackColor = Color.Red;
                txt3.ForeColor = Color.White;
                txt3.BackColor = Color.Green;
            }
            else
            {
                txt2.ForeColor = Color.Black;
                txt2.BackColor = Color.White;
                txt3.ForeColor = Color.Black;
                txt3.BackColor = Color.White;
            }
        }
        private void changeColorUser(LookUpEdit txt1, LookUpEdit txt2, string a)
        {
            if (txt1.ItemIndex != txt2.ItemIndex)
            {
                txt1.ForeColor = Color.White;
                txt1.BackColor = Color.Red;
                txt2.ForeColor = Color.White;
                txt2.BackColor = Color.Red;
            }
            else
            {
                txt1.ForeColor = Color.Black;
                txt1.BackColor = Color.White;
                txt2.ForeColor = Color.Black;
                txt2.BackColor = Color.White;
            }
        }

        private void changeColorChecker(LookUpEdit txt1, LookUpEdit txt2, LookUpEdit txt3, string a)
        {
            if (txt1.ForeColor == Color.White|| txt2.ForeColor == Color.White)
            {
                if (txt1.ItemIndex == txt3.ItemIndex)
                {
                    txt1.ForeColor = Color.White;
                    txt1.BackColor = Color.Green;
                    txt3.ForeColor = Color.White;
                    txt3.BackColor = Color.Green;
                }
                else
                {
                    txt1.ForeColor = Color.White;
                    txt1.BackColor = Color.Red;

                    txt3.ForeColor = Color.White;
                    txt3.BackColor = Color.Green;
                }
                if (txt2.ItemIndex == txt3.ItemIndex)
                {
                    txt2.ForeColor = Color.White;
                    txt2.BackColor = Color.Green;
                    txt3.ForeColor = Color.White;
                    txt3.BackColor = Color.Green;
                }
                else
                {
                    txt2.ForeColor = Color.White;
                    txt2.BackColor = Color.Red;

                    txt3.ForeColor = Color.White;
                    txt3.BackColor = Color.Green;
                }
            }
            else
            {
                if (txt1.ItemIndex == txt2.ItemIndex && txt1.ItemIndex != txt3.ItemIndex)
                {
                    txt1.ForeColor = Color.White;
                    txt1.BackColor = Color.Red;
                    txt2.ForeColor = Color.White;
                    txt2.BackColor = Color.Red;

                    txt3.ForeColor = Color.White;
                    txt3.BackColor = Color.Green;
                }
            }
        }
    }
}
