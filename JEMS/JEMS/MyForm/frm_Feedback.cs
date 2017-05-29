using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using JEMS.MyUserControl;

namespace JEMS.MyForm
{
    public partial class frm_Feedback : DevExpress.XtraEditors.XtraForm
    {
        public static int num = 0;
        public string LoaiBatch = "";
        public frm_Feedback()
        {
            InitializeComponent();
        }

        private void LoadUser()
        {
            if (chb_User.Checked)
            {
                cbb_username.Visible = true;
                
                cbb_username.Text = "";
                cbb_username.DataSource = Global.db.GetUserFailDeSo(cbb_batch.Text);
                cbb_username.DisplayMember = "UserName";
               
            }
            if (chb_User.Checked == false)
            {
                cbb_username.Visible = false;
            }
        }

        private void GetImageDeso(int n)
        {
            string NameUserChecker = "Checker%";
            var idimage = (from w in (Global.db.GetImageFail(NameUserChecker,cbb_batch.Text )) select w.IdImage).ToList();
            lb_soloi.Text = idimage.Count.ToString();
            if (LoaiBatch == "ASAHI")
            {
                if ((n + 50) < idimage.Count && n >= 0)
                {
                    btn_next.Enabled = true;
                    for (int j = n; j <= n + 49; j++)
                    {
                        string id = idimage[j];
                        uc_ASAHI_Feedback UC_F = new uc_ASAHI_Feedback();
                        string url = Global.Webservice + cbb_batch.Text + "/" + id;
                        UC_F.LoadImage(cbb_batch.Text, url, id);

                        Point p = new Point();
                        foreach (Control ct in pnl_Mainfeedback1.Controls)
                        {
                            p = ct.Location;
                            p.Y += ct.Size.Height;
                        }
                        UC_F.Location = p;
                        
                        UC_F.textBox1.Text = (j + 1).ToString();
                        pnl_Mainfeedback1.Controls.Add(UC_F);
                    }
                }
                else if ((n + 50) >= idimage.Count && n >= 0)
                {
                    btn_next.Enabled = false;
                    for (int j = n; j <= idimage.Count - 1; j++)
                    {
                        string id = idimage[j];
                        uc_ASAHI_Feedback UC_F = new uc_ASAHI_Feedback();
                        string url = Global.Webservice + cbb_batch.Text + "/" + id;
                        UC_F.LoadImage(cbb_batch.Text, url, id);

                        Point p = new Point();
                        foreach (Control ct in pnl_Mainfeedback1.Controls)
                        {
                            p = ct.Location;
                            p.Y += ct.Size.Height;
                        }
                        UC_F.Location = p;
                        UC_F.textBox1.Text = (j + 1).ToString();
                        pnl_Mainfeedback1.Controls.Add(UC_F);
                    }
                }
            }
            else if (LoaiBatch == "EIZEN")
            {
                if ((n + 50) < idimage.Count && n >= 0)
                {
                    btn_next.Enabled = true;
                    for (int j = n; j <= n + 49; j++)
                    {
                        string id = idimage[j];
                        uc_EIZEN_Feedback UC_F = new uc_EIZEN_Feedback();
                        string url = Global.Webservice + cbb_batch.Text + "/" + id;
                        UC_F.LoadImage(cbb_batch.Text, url, id);

                        Point p = new Point();
                        foreach (Control ct in pnl_Mainfeedback1.Controls)
                        {
                            p = ct.Location;
                            p.Y += ct.Size.Height;
                        }
                        UC_F.Location = p;

                        UC_F.textBox1.Text = (j + 1).ToString();
                        pnl_Mainfeedback1.Controls.Add(UC_F);
                    }
                }
                else if ((n + 50) >= idimage.Count && n >= 0)
                {
                    btn_next.Enabled = false;
                    for (int j = n; j <= idimage.Count - 1; j++)
                    {
                        string id = idimage[j];
                        uc_EIZEN_Feedback UC_F = new uc_EIZEN_Feedback();
                        string url = Global.Webservice + cbb_batch.Text + "/" + id;
                        UC_F.LoadImage(cbb_batch.Text, url, id);

                        Point p = new Point();
                        foreach (Control ct in pnl_Mainfeedback1.Controls)
                        {
                            p = ct.Location;
                            p.Y += ct.Size.Height;
                        }
                        UC_F.Location = p;
                        UC_F.textBox1.Text = (j + 1).ToString();
                        pnl_Mainfeedback1.Controls.Add(UC_F);
                    }
                }
            }
            else if (LoaiBatch == "AEON")
            {
                if ((n + 50) < idimage.Count && n >= 0)
                {
                    btn_next.Enabled = true;
                    for (int j = n; j <= n + 49; j++)
                    {
                        string id = idimage[j];
                        uc_AEON_Feedback UC_F = new uc_AEON_Feedback();
                        string url = Global.Webservice + cbb_batch.Text + "/" + id;
                        UC_F.LoadImage(cbb_batch.Text, url, id);

                        Point p = new Point();
                        foreach (Control ct in pnl_Mainfeedback1.Controls)
                        {
                            p = ct.Location;
                            p.Y += ct.Size.Height;
                        }
                        UC_F.Location = p;

                        UC_F.textBox1.Text = (j + 1).ToString();
                        pnl_Mainfeedback1.Controls.Add(UC_F);
                    }
                }
                else if ((n + 50) >= idimage.Count && n >= 0)
                {
                    btn_next.Enabled = false;
                    for (int j = n; j <= idimage.Count - 1; j++)
                    {
                        string id = idimage[j];
                        uc_AEON_Feedback UC_F = new uc_AEON_Feedback();
                        string url = Global.Webservice + cbb_batch.Text + "/" + id;
                        UC_F.LoadImage(cbb_batch.Text, url, id);

                        Point p = new Point();
                        foreach (Control ct in pnl_Mainfeedback1.Controls)
                        {
                            p = ct.Location;
                            p.Y += ct.Size.Height;
                        }
                        UC_F.Location = p;
                        UC_F.textBox1.Text = (j + 1).ToString();
                        pnl_Mainfeedback1.Controls.Add(UC_F);
                    }
                }
            }
        }
        
        private void GetImageDesoUser(int n)
        {

            var idimage = (from w in (Global.db.GetImageFailUserDeSo(cbb_username.Text, cbb_batch.Text)) select w.IdImage).ToList();
            lb_soloi.Text = idimage.Count().ToString();
            if(LoaiBatch== "ASAHI")
            {
                if ((n + 50) < idimage.Count() && n >= 0)
                {
                    btn_next.Enabled = true;
                    for (int j = n; j <= n + 49; j++)
                    {
                        string id = idimage[j];
                        uc_ASAHI_Feedback UC_F = new uc_ASAHI_Feedback();
                        string url = Global.Webservice + cbb_batch.Text + "/" + id; ;

                        UC_F.LoadImageUser(cbb_username.Text, cbb_batch.Text, url, id);

                        Point p = new Point();
                        foreach (Control ct in pnl_Mainfeedback1.Controls)
                        {
                            p = ct.Location;
                            p.Y += ct.Size.Height;
                        }
                        UC_F.uc_ASAHI_Feedback_Item1.Visible = false;
                        UC_F.Location = p;
                        UC_F.textBox1.Text = (j + 1).ToString();
                        pnl_Mainfeedback1.Controls.Add(UC_F);
                    }
                }
                else if ((n + 50) >= idimage.Count && n >= 0)
                {
                    btn_next.Enabled = false;
                    for (int j = n; j <= idimage.Count - 1; j++)
                    {
                        string id = idimage[j];
                        uc_ASAHI_Feedback UC_F = new uc_ASAHI_Feedback();
                        string url = Global.Webservice + cbb_batch.Text + "/" + id; ;

                        UC_F.LoadImageUser(cbb_username.Text, cbb_batch.Text, url, id);

                        Point p = new Point();
                        foreach (Control ct in pnl_Mainfeedback1.Controls)
                        {
                            p = ct.Location;
                            p.Y += ct.Size.Height;
                        }
                        UC_F.uc_ASAHI_Feedback_Item1.Visible = false;
                        UC_F.Location = p;
                        UC_F.textBox1.Text = (j + 1).ToString();
                        pnl_Mainfeedback1.Controls.Add(UC_F);
                    }
                }
            }
            else if (LoaiBatch== "EIZEN")
            {
                if ((n + 50) < idimage.Count() && n >= 0)
                {
                    btn_next.Enabled = true;
                    for (int j = n; j <= n + 49; j++)
                    {
                        string id = idimage[j];
                        uc_EIZEN_Feedback UC_F = new uc_EIZEN_Feedback();
                        string url = Global.Webservice + cbb_batch.Text + "/" + id;

                        UC_F.LoadImageUser(cbb_username.Text, cbb_batch.Text, url, id);

                        Point p = new Point();
                        foreach (Control ct in pnl_Mainfeedback1.Controls)
                        {
                            p = ct.Location;
                            p.Y += ct.Size.Height;
                        }
                        UC_F.uc_EZIEN_Feedback_Item1.Visible = false;
                        UC_F.Location = p;
                        UC_F.textBox1.Text = (j + 1).ToString();
                        pnl_Mainfeedback1.Controls.Add(UC_F);
                    }
                }
                else if ((n + 50) >= idimage.Count && n >= 0)
                {
                    btn_next.Enabled = false;
                    for (int j = n; j <= idimage.Count - 1; j++)
                    {
                        string id = idimage[j];
                        uc_EIZEN_Feedback UC_F = new uc_EIZEN_Feedback();
                        string url = Global.Webservice + cbb_batch.Text + "/" + id; ;

                        UC_F.LoadImageUser(cbb_username.Text, cbb_batch.Text, url, id);

                        Point p = new Point();
                        foreach (Control ct in pnl_Mainfeedback1.Controls)
                        {
                            p = ct.Location;
                            p.Y += ct.Size.Height;
                        }
                        UC_F.uc_EZIEN_Feedback_Item1.Visible = false;
                        UC_F.Location = p;
                        UC_F.textBox1.Text = (j + 1).ToString();
                        pnl_Mainfeedback1.Controls.Add(UC_F);
                    }
                }
            }
            else if (LoaiBatch== "AEON")
            {
                if ((n + 50) < idimage.Count() && n >= 0)
                {
                    btn_next.Enabled = true;
                    for (int j = n; j <= n + 49; j++)
                    {
                        string id = idimage[j];
                        uc_AEON_Feedback UC_F = new uc_AEON_Feedback();
                        string url = Global.Webservice + cbb_batch.Text + "/" + id;

                        UC_F.LoadImageUser(cbb_username.Text, cbb_batch.Text, url, id);

                        Point p = new Point();
                        foreach (Control ct in pnl_Mainfeedback1.Controls)
                        {
                            p = ct.Location;
                            p.Y += ct.Size.Height;
                        }
                        UC_F.uc_AEON1.Visible = false;
                        UC_F.Location = p;
                        UC_F.textBox1.Text = (j + 1).ToString();
                        pnl_Mainfeedback1.Controls.Add(UC_F);
                    }
                }
                else if ((n + 50) >= idimage.Count && n >= 0)
                {
                    btn_next.Enabled = false;
                    for (int j = n; j <= idimage.Count - 1; j++)
                    {
                        string id = idimage[j];
                        uc_AEON_Feedback UC_F = new uc_AEON_Feedback();
                        string url = Global.Webservice + cbb_batch.Text + "/" + id; ;

                        UC_F.LoadImageUser(cbb_username.Text, cbb_batch.Text, url, id);

                        Point p = new Point();
                        foreach (Control ct in pnl_Mainfeedback1.Controls)
                        {
                            p = ct.Location;
                            p.Y += ct.Size.Height;
                        }
                        UC_F.uc_AEON1.Visible = false;
                        UC_F.Location = p;
                        UC_F.textBox1.Text = (j + 1).ToString();
                        pnl_Mainfeedback1.Controls.Add(UC_F);
                    }
                }
            }
        }
        
        private void frmFeedback_Load(object sender, EventArgs e)
        {
            cbb_batch.DataSource = Global.db.GetBatch_Feedback();
            cbb_batch.DisplayMember = "fBatchName";
            cbb_batch.ValueMember = "IDBatch";
            num = 0;
            //LoaiBatch =(from w in Global.db.tbl_Batches where w.fBatchName == cbb_batch.SelectedValue + "" select w.fLoaiPhieu).FirstOrDefault();
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            try
            {
                num = 0;
                lb_soloi.Text = "0";
                pnl_Mainfeedback1.Controls.Clear();
                System.GC.Collect();
                btn_back.Enabled = false;

                if (chb_User.Checked)
                {
                    GetImageDesoUser(num);
                }
                if (chb_User.Checked == false)
                {
                    GetImageDeso(num);
                }
            }
            catch (Exception w) { MessageBox.Show("Không lấy được hình, Lỗi " + w); }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                num += 50;
                if (num < 50)
                {
                    btn_back.Enabled = false;
                }
                else
                {
                    btn_back.Enabled = true;
                }
                pnl_Mainfeedback1.Controls.Clear();
                System.GC.Collect();
                
                if (chb_User.Checked == true)
                {
                    GetImageDesoUser(num);
                }
                if (chb_User.Checked == false)
                {
                    GetImageDeso(num);
                }
            }
            catch (Exception w) { MessageBox.Show("Không lấy được hình, Lỗi " + w); }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                num -= 50;
                if (num < 50)
                {
                    btn_back.Enabled = false;
                }
                else
                {
                    btn_back.Enabled = true;
                }
                pnl_Mainfeedback1.Controls.Clear();
                System.GC.Collect();
                
                if (chb_User.Checked == true)
                {
                    GetImageDesoUser(num);
                }
                if (chb_User.Checked == false)
                {
                    GetImageDeso(num);
                }
            }
            catch (Exception w) { MessageBox.Show("Không lấy được hình, Lỗi " + w); }
        }

        private void cbb_batch_TextChanged(object sender, EventArgs e)
        {
            pnl_Mainfeedback1.Controls.Clear();
            btn_back.Enabled = false;
            btn_next.Enabled = false;
            LoaiBatch = (from w in Global.db.tbl_Batches where w.fBatchName == cbb_batch.Text + "" select w.fLoaiPhieu).FirstOrDefault();
            LoadUser();
        }
        
        private void chb_User_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Mainfeedback1.Controls.Clear();
            btn_back.Enabled = false;
            btn_next.Enabled = false;
            LoadUser();
        }

        private void cbb_username_TextChanged(object sender, EventArgs e)
        {
            pnl_Mainfeedback1.Controls.Clear();
            btn_back.Enabled = false;
            btn_next.Enabled = false;
        }
    }
}