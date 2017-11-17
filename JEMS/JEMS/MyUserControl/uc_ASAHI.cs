using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace JEMS.MyUserControl
{
    public delegate void AllTextChange(object sender, EventArgs e);
    public partial class uc_ASAHI : UserControl
    {
        List<Category> category = new List<Category>();
        public event AllTextChange Changed;
        public uc_ASAHI()
        {
            InitializeComponent();
        }
        public class Category
        {
            public string Set_Value { get; set; }
        }
        private void SetDataLookUpEdit()
        {
            category.Add(new Category() { Set_Value = "" });
            category.Add(new Category() { Set_Value = "t" });
            category.Add(new Category() { Set_Value = "m3" });
            category.Add(new Category() { Set_Value = "kg" });
            category.Add(new Category() { Set_Value = "リットル" });
            category.Add(new Category() { Set_Value = "個・台" });
            category.Add(new Category() { Set_Value = "?" });
            category.Add(new Category() { Set_Value = "●" });
        }
        public void ResetData()
        {
            txt_Truong02.Text = "";
            txt_Truong03_1.Text = "";
            txt_Truong03_2.Text = "";
            txt_Truong05.Text = "";
            txt_Truong06.Text = "";
            txt_Truong08.ItemIndex = 4;
            txt_Truong85.Text = "";
            txt_Truong0.Text = "";

            txt_Truong02.BackColor = Color.White;
            txt_Truong03_1.BackColor = Color.White;
            txt_Truong03_2.BackColor = Color.White;
            txt_Truong05.BackColor = Color.White;
            txt_Truong06.BackColor = Color.White;
            txt_Truong08.BackColor = Color.White;
            txt_Truong85.BackColor = Color.White;
            txt_Truong0.BackColor = Color.White;

            txt_Truong02.ForeColor = Color.Black;
            txt_Truong03_1.ForeColor = Color.Black;
            txt_Truong03_2.ForeColor = Color.Black;
            txt_Truong05.ForeColor = Color.Black;
            txt_Truong06.ForeColor = Color.Black;
            txt_Truong08.ForeColor = Color.Black;
            txt_Truong85.ForeColor = Color.Black;
            txt_Truong0.ForeColor = Color.Black;


            chk_qc.Checked = false;
            chk_abc.Checked = false;
            txt_Truong02.Focus();
        }

        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_Truong02.Text) &&
                string.IsNullOrEmpty(txt_Truong03_1.Text) &&
                string.IsNullOrEmpty(txt_Truong03_2.Text) &&
                string.IsNullOrEmpty(txt_Truong05.Text) &&
                string.IsNullOrEmpty(txt_Truong06.Text) &&
                string.IsNullOrEmpty(txt_Truong08.Text) &&
                string.IsNullOrEmpty(txt_Truong85.Text) &&
                string.IsNullOrEmpty(txt_Truong0.Text)&&
                chk_qc.Checked == false)
                return true;
            return false;
        }
        
        public bool CheckQC()
        {
            if (txt_Truong02.Text.IndexOf('?') >= 0 || txt_Truong02.Text.IndexOf('●') >= 0  ||
                txt_Truong03_1.Text.IndexOf('?') >= 0  || txt_Truong03_1.Text.IndexOf('●') >= 0 ||
                txt_Truong03_2.Text.IndexOf('?') >= 0  || txt_Truong03_2.Text.IndexOf('●') >= 0 ||
                txt_Truong05.Text.IndexOf('?') >= 0  || txt_Truong05.Text.IndexOf('●') >= 0 ||
                txt_Truong06.Text.IndexOf('?') >= 0  || txt_Truong06.Text.IndexOf('●') >= 0 ||
                txt_Truong08.Text.IndexOf('?') >= 0  || txt_Truong08.Text.IndexOf('●') >= 0 ||
                txt_Truong85.Text.IndexOf('?') >= 0  || txt_Truong85.Text.IndexOf('●') >= 0 ||
                txt_Truong0.Text.IndexOf('?') >= 0  || txt_Truong0.Text.IndexOf('●') >= 0 ||
                (txt_Truong05.Text == "" && (txt_Truong06.Text != "" || txt_Truong08.Text != "")) ||
                (txt_Truong05.Text != "" && (txt_Truong06.Text == "" && txt_Truong08.Text == "")) ||
                (txt_Truong02.Text != txt_Truong0.Text) ||
                chk_qc.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RegexString(string input)
        {
            bool r = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (Regex.IsMatch(input[i].ToString(), @"^[a-zA-Z]+$"))
                {
                    r = true;
                    break;
                }
            }
            return r;
        }
        public bool CheckABC()
        {
            if (RegexString(txt_Truong05.Text) || chk_abc.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void txt_Truong02_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong02.Text.IndexOf('?') >= 0)
                txt_Truong02.Text = "?";
            if (txt_Truong02.Text.Length != 6 && txt_Truong02.Text != "" && txt_Truong02.Text != "?" && txt_Truong02.Text.IndexOf('●') < 0)
            {
                txt_Truong02.BackColor = Color.Red;
                txt_Truong02.ForeColor = Color.White;
            }
            else
            {
                txt_Truong02.BackColor = Color.White;
                txt_Truong02.ForeColor = Color.Black;

            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong03_1_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong03_1.Text.IndexOf('?') >= 0)
                txt_Truong03_1.Text = "?";
            if (txt_Truong03_1.Text != "" && txt_Truong03_1.Text != "?" && txt_Truong03_1.Text.IndexOf('●') < 0)
            {
                if (txt_Truong03_1.Text.Length != 8)
                {
                    txt_Truong03_1.BackColor = Color.Red;
                    txt_Truong03_1.ForeColor = Color.White;
                }
                else
                {
                    txt_Truong03_1.BackColor = Color.White;
                    txt_Truong03_1.ForeColor = Color.Black;
                }
            }
            else
            {
                txt_Truong03_1.BackColor = Color.White;
                txt_Truong03_1.ForeColor = Color.Black;
            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong03_2_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong03_2.Text.IndexOf('?') >= 0)
                txt_Truong03_2.Text = "?";
            if (txt_Truong03_2.Text != "" && txt_Truong03_2.Text != "?" && txt_Truong03_2.Text.IndexOf('●') < 0)
            {
                if (txt_Truong03_2.Text.Length != 8)
                {
                    txt_Truong03_2.BackColor = Color.Red;
                    txt_Truong03_2.ForeColor = Color.White;
                }
                else
                {
                    txt_Truong03_2.BackColor = Color.White;
                    txt_Truong03_2.ForeColor = Color.Black;
                }
            }
            else
            {
                txt_Truong03_2.BackColor = Color.White;
                txt_Truong03_2.ForeColor = Color.Black;
            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong05_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong05.Text.IndexOf('?') >= 0)
                txt_Truong05.Text = "?";
            if ((txt_Truong05.Text.Length < 2|| txt_Truong05.Text.Length >3) && txt_Truong05.Text != "" && txt_Truong05.Text != "?" && txt_Truong05.Text.IndexOf('●') < 0)
            {
                txt_Truong05.BackColor = Color.Red;
                txt_Truong05.ForeColor = Color.White;
            }
            else
            {
                txt_Truong05.BackColor = Color.White;
                txt_Truong05.ForeColor = Color.Black;
            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong06_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong06.Text.IndexOf('?') >= 0)
                txt_Truong06.Text = "?";
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong85_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong85.Text.IndexOf('?') >= 0)
                txt_Truong85.Text = "?";
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong0_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong0.Text.IndexOf('?') >= 0)
                txt_Truong0.Text = "?";
            if (txt_Truong0.Text != txt_Truong02.Text && txt_Truong0.Text != "" && txt_Truong0.Text != "?" && txt_Truong0.Text.IndexOf('●') < 0)
            {
                txt_Truong0.BackColor = Color.Red;
                txt_Truong0.ForeColor = Color.White;
                txt_Truong02.BackColor = Color.Red;
                txt_Truong02.ForeColor = Color.White;
            }
            else
            {
                txt_Truong0.BackColor = Color.White;
                txt_Truong0.ForeColor = Color.Black;
                txt_Truong02.BackColor = Color.White;
                txt_Truong02.ForeColor = Color.Black;
            }
            if (Changed != null)
                Changed(sender, e);
        }
        private void uc_ASAHI_Load(object sender, EventArgs e)
        {
            SetDataLookUpEdit();
            txt_Truong08.Properties.DataSource = category;
            txt_Truong08.Properties.DisplayMember = "Set_Value";
            txt_Truong08.Properties.ValueMember = "Set_Value";
            ResetData();
            txt_Truong02.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong03_1.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong03_2.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong05.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong06.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong08.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong85.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong0.GotFocus += Txt_Truong02_GotFocus;
        }

        private void Txt_Truong02_GotFocus(object sender, EventArgs e)
        {
            ((TextEdit)sender).SelectAll();
        }
        public void SaveData_ASAHI(string idImage)
        {
            
            string txtTruong03 = txt_Truong03_1.Text + txt_Truong03_2.Text;
            if (txtTruong03.ToString().IndexOf('?') >= 0)
                txtTruong03 = "?";
            //Save Data
            
            Global.db.Insert_ASAHI_NewABC(idImage, Global.StrBatch, Global.StrUsername,txt_Truong0.Text,txt_Truong02.Text,txtTruong03,txt_Truong05.Text,txt_Truong06.Text,txt_Truong08.Text,txt_Truong85.Text, CheckQC(),CheckABC());
        }

        private void chk_qc_CheckedChanged(object sender, EventArgs e)
        {
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong08_EditValueChanged(object sender, EventArgs e)
        {
            if (Changed != null)
                Changed(sender, e);
        }

        private void chk_abc_CheckedChanged(object sender, EventArgs e)
        {
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong02_Leave(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txt_Truong02.Text))
            //{
            //    string tempYear = DateTime.Now.Year.ToString().Substring(2,2);
            //    string tempMonth = DateTime.Now.Month.ToString();
            //    string tempDay = DateTime.Now.Day.ToString();
            //    if (tempMonth.Length < 2)
            //        tempMonth = "0" + tempMonth;
            //    if (tempDay.Length < 2)
            //        tempDay = "0" + tempDay;
            //    string temp = tempYear + tempMonth + tempDay;
            //    if (temp != txt_Truong02.Text)
            //    {
            //        txt_Truong02.BackColor = Color.Red;
            //        txt_Truong02.ForeColor = Color.White;
            //    }
            //    else
            //    {
            //        txt_Truong02.BackColor = Color.White;
            //        txt_Truong02.ForeColor = Color.Black;
            //    }

            //}
            try
            {
                if (txt_Truong02.Text.Length != 6)
                    return;
                string tempYear = "20" + txt_Truong02.Text.Substring(0, 2) + "/";
                string tempMonth = txt_Truong02.Text.Substring(2, 2) + "/";
                string tempDay = txt_Truong02.Text.Substring(4, 2);

                string tempYearNow = DateTime.Now.Year + "/";
                string tempMonthNow = DateTime.Now.Month + "/";
                string tempDayNow = DateTime.Now.Day.ToString();

                if (tempMonthNow.Length < 3)
                    tempMonthNow = "0" + tempMonthNow;
                if (tempDayNow.Length < 2)
                    tempDayNow = "0" + tempDayNow;

                DateTime tempDate = DateTime.Parse(tempYear + tempMonth + tempDay + " 00:00:00");
                DateTime tempDateNow = DateTime.Parse(tempYearNow + tempMonthNow + tempDayNow + " 00:00:00");

                if (tempDate > tempDateNow)
                {
                    txt_Truong02.BackColor = Color.Red;
                    txt_Truong02.ForeColor = Color.White;
                }
                else
                {
                    txt_Truong02.BackColor = Color.White;
                    txt_Truong02.ForeColor = Color.Black;
                }
            }
            catch (Exception)
            {
                txt_Truong02.BackColor = Color.Red;
                txt_Truong02.ForeColor = Color.White;
            }
        }
    }
}
