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
    public partial class uc_EIZEN_Feedback : UserControl
    {
        public uc_EIZEN_Feedback()
        {
            InitializeComponent();
        }

        public void LoadImage(string fbatchname,string url_image,string idimage)
        {
            uc_PictureBox1.LoadImage(url_image, idimage, 50);
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

            uc_EZIEN_Feedback_Item1.LoadData(deso[0]);
            uc_EZIEN_Feedback_Item2.LoadData(deso[1]);
        }

        public void LoadChecker(string fbatchname, string idimage)
        {
            var deso = (from w in Global.db.tbl_DeSos
                        where w.fBatchName == fbatchname && w.UserName == "Checker" && w.IdImage == idimage
                        select w).ToList();

            uc_EZIEN_Feedback_Item3.LoadDataChecker(deso[0]);
        }

        public void LoadChecker_User(string fbatchname, string idimage)
        {
            var deso = (from w in Global.db.tbl_DeSos
                        where w.fBatchName == fbatchname && w.IdImage == idimage && w.True == 1
                        select w).ToList();

            uc_EZIEN_Feedback_Item3.LoadDataChecker(deso[0]);
        } 

        private void SoSanhTextBox()
        {
            changeColorUser(uc_EZIEN_Feedback_Item1.txt_Truong02, uc_EZIEN_Feedback_Item2.txt_Truong02);
            changeColorUser(uc_EZIEN_Feedback_Item1.txt_Truong05, uc_EZIEN_Feedback_Item2.txt_Truong05);
            changeColorUser(uc_EZIEN_Feedback_Item1.txt_Truong06, uc_EZIEN_Feedback_Item2.txt_Truong06);
            changeColorUser(uc_EZIEN_Feedback_Item1.txt_Truong07, uc_EZIEN_Feedback_Item2.txt_Truong07);
            changeColorUser(uc_EZIEN_Feedback_Item1.txt_Truong08, uc_EZIEN_Feedback_Item2.txt_Truong08);
            changeColorUser(uc_EZIEN_Feedback_Item1.txt_Truong03_1, uc_EZIEN_Feedback_Item2.txt_Truong03_1);
            changeColorUser(uc_EZIEN_Feedback_Item1.txt_Truong03_2, uc_EZIEN_Feedback_Item2.txt_Truong03_2);
            changeColorUser(uc_EZIEN_Feedback_Item1.txt_Truong85, uc_EZIEN_Feedback_Item2.txt_Truong85);
            changeColorUser(uc_EZIEN_Feedback_Item1.txt_Truong86, uc_EZIEN_Feedback_Item2.txt_Truong86);
            changeColorUser(uc_EZIEN_Feedback_Item1.txt_Truong0, uc_EZIEN_Feedback_Item2.txt_Truong0);
        }

        private void SoSanhTextBoxSingle()
        {
            changeColorUser(uc_EZIEN_Feedback_Item2.txt_Truong02, uc_EZIEN_Feedback_Item3.txt_Truong02);
            changeColorUser(uc_EZIEN_Feedback_Item2.txt_Truong05, uc_EZIEN_Feedback_Item3.txt_Truong05);
            changeColorUser(uc_EZIEN_Feedback_Item2.txt_Truong06, uc_EZIEN_Feedback_Item3.txt_Truong06);
            changeColorUser(uc_EZIEN_Feedback_Item2.txt_Truong07, uc_EZIEN_Feedback_Item3.txt_Truong07);
            changeColorUser(uc_EZIEN_Feedback_Item2.txt_Truong08, uc_EZIEN_Feedback_Item3.txt_Truong08);
            changeColorUser(uc_EZIEN_Feedback_Item2.txt_Truong03_1, uc_EZIEN_Feedback_Item3.txt_Truong03_1);
            changeColorUser(uc_EZIEN_Feedback_Item2.txt_Truong03_2, uc_EZIEN_Feedback_Item3.txt_Truong03_2);
            changeColorUser(uc_EZIEN_Feedback_Item2.txt_Truong85, uc_EZIEN_Feedback_Item3.txt_Truong85);
            changeColorUser(uc_EZIEN_Feedback_Item2.txt_Truong86, uc_EZIEN_Feedback_Item3.txt_Truong86);
            changeColorUser(uc_EZIEN_Feedback_Item2.txt_Truong0, uc_EZIEN_Feedback_Item3.txt_Truong0);
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

        private void SoSanhChecker()
        {
            changeColorChecker(uc_EZIEN_Feedback_Item1.txt_Truong02, uc_EZIEN_Feedback_Item2.txt_Truong02, uc_EZIEN_Feedback_Item3.txt_Truong02);
            changeColorChecker(uc_EZIEN_Feedback_Item1.txt_Truong05, uc_EZIEN_Feedback_Item2.txt_Truong05, uc_EZIEN_Feedback_Item3.txt_Truong05);
            changeColorChecker(uc_EZIEN_Feedback_Item1.txt_Truong06, uc_EZIEN_Feedback_Item2.txt_Truong06, uc_EZIEN_Feedback_Item3.txt_Truong06);
            changeColorChecker(uc_EZIEN_Feedback_Item1.txt_Truong07, uc_EZIEN_Feedback_Item2.txt_Truong07, uc_EZIEN_Feedback_Item3.txt_Truong07);
            changeColorChecker(uc_EZIEN_Feedback_Item1.txt_Truong08, uc_EZIEN_Feedback_Item2.txt_Truong08, uc_EZIEN_Feedback_Item3.txt_Truong08);
            changeColorChecker(uc_EZIEN_Feedback_Item1.txt_Truong03_1, uc_EZIEN_Feedback_Item2.txt_Truong03_1, uc_EZIEN_Feedback_Item3.txt_Truong03_1);
            changeColorChecker(uc_EZIEN_Feedback_Item1.txt_Truong03_2, uc_EZIEN_Feedback_Item2.txt_Truong03_2, uc_EZIEN_Feedback_Item3.txt_Truong03_2);
            changeColorChecker(uc_EZIEN_Feedback_Item1.txt_Truong85, uc_EZIEN_Feedback_Item2.txt_Truong85, uc_EZIEN_Feedback_Item3.txt_Truong85);
            changeColorChecker(uc_EZIEN_Feedback_Item1.txt_Truong86, uc_EZIEN_Feedback_Item2.txt_Truong86, uc_EZIEN_Feedback_Item3.txt_Truong86);
            changeColorChecker(uc_EZIEN_Feedback_Item1.txt_Truong0, uc_EZIEN_Feedback_Item2.txt_Truong0, uc_EZIEN_Feedback_Item3.txt_Truong0);
            

        }

        public void LoadImageUser(string user, string fbatchname, string urlImage, string idimage)
        {
            uc_PictureBox1.LoadImage(urlImage, idimage, 50);
            uc_PictureBox1.imageBox1.SizeMode = ImageBoxSizeMode.Fit;
            LoadText_User(user, fbatchname, idimage);
            LoadChecker_User(fbatchname, idimage);
            SoSanhTextBoxSingle();}

        public void LoadText_User(string user, string fbatchname, string idimage)
        {
            var deso = (from w in Global.db.tbl_DeSo_Backups
                        where w.fBatchName == fbatchname && w.IdImage == idimage && w.UserName == user
                        select w).ToList();

            uc_EZIEN_Feedback_Item2.LoadData(deso[0]);
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
    }
}
