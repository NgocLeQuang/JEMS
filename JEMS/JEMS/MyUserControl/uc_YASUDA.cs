using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace JEMS.MyUserControl
{
    public partial class uc_YASUDA : UserControl
    {
        List<Category> category = new List<Category>();
        public event AllTextChange Changed;
        private bool nonNumberEntered = false;

        public uc_YASUDA()
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
            txt_Truong07.Text = "";
            txt_Truong08.ItemIndex = 0;

            txt_Truong12.Text = "";
            txt_Truong13.Text = "";
            txt_Truong14.Text = "";
            txt_Truong15.Text = "";
            txt_Truong16.ItemIndex = 0;

            txt_Truong20.Text = "";
            txt_Truong21.Text = "";
            txt_Truong22.Text = "";
            txt_Truong23.Text = "";
            txt_Truong24.ItemIndex = 0;

            txt_Truong28.Text = "";
            txt_Truong29.Text = "";
            txt_Truong30.Text = "";
            txt_Truong31.Text = "";
            txt_Truong32.ItemIndex = 0;

            txt_Truong36.Text = "";
            txt_Truong37.Text = "";
            txt_Truong38.Text = "";
            txt_Truong39.Text = "";
            txt_Truong40.ItemIndex = 0;

            txt_Truong44.Text = "";
            txt_Truong45.Text = "";
            txt_Truong46.Text = "";
            txt_Truong47.Text = "";
            txt_Truong48.ItemIndex = 0;

            txt_Truong52.Text = "";
            txt_Truong53.Text = "";
            txt_Truong54.Text = "";
            txt_Truong55.Text = "";
            txt_Truong56.ItemIndex = 0;

            txt_Truong60.Text = "";
            txt_Truong61.Text = "";
            txt_Truong62.Text = "";
            txt_Truong63.Text = "";
            txt_Truong64.ItemIndex = 0;

            txt_Truong68.Text = "";
            txt_Truong69.Text = "";
            txt_Truong70.Text = "";
            txt_Truong71.Text = "";
            txt_Truong72.ItemIndex = 0;

            txt_Truong76.Text = "";
            txt_Truong77.Text = "";
            txt_Truong78.Text = "";
            txt_Truong79.Text = "";
            txt_Truong80.ItemIndex = 0;

            txt_Truong84.Text = "";
            txt_Truong85.Text = "";
            txt_Truong0.Text = "";
            txt_Truong87.Text = "";
            txt_Truong92.Text = "";

            txt_Truong02.BackColor = Color.White;
            txt_Truong03_1.BackColor = Color.White;
            txt_Truong03_2.BackColor = Color.White;
            txt_Truong05.BackColor = Color.White;
            txt_Truong06.BackColor = Color.White;
            txt_Truong07.BackColor = Color.White;
            txt_Truong08.BackColor = Color.White;
            txt_Truong12.BackColor = Color.White;
            txt_Truong13.BackColor = Color.White;
            txt_Truong14.BackColor = Color.White;
            txt_Truong15.BackColor = Color.White;
            txt_Truong16.BackColor = Color.White;
            txt_Truong20.BackColor = Color.White;
            txt_Truong21.BackColor = Color.White;
            txt_Truong22.BackColor = Color.White;
            txt_Truong23.BackColor = Color.White;
            txt_Truong24.BackColor = Color.White;
            txt_Truong28.BackColor = Color.White;
            txt_Truong29.BackColor = Color.White;
            txt_Truong30.BackColor = Color.White;
            txt_Truong31.BackColor = Color.White;
            txt_Truong32.BackColor = Color.White;
            txt_Truong36.BackColor = Color.White;
            txt_Truong37.BackColor = Color.White;
            txt_Truong38.BackColor = Color.White;
            txt_Truong39.BackColor = Color.White;
            txt_Truong40.BackColor = Color.White;
            txt_Truong44.BackColor = Color.White;
            txt_Truong45.BackColor = Color.White;
            txt_Truong46.BackColor = Color.White;
            txt_Truong47.BackColor = Color.White;
            txt_Truong48.BackColor = Color.White;
            txt_Truong52.BackColor = Color.White;
            txt_Truong53.BackColor = Color.White;
            txt_Truong54.BackColor = Color.White;
            txt_Truong55.BackColor = Color.White;
            txt_Truong56.BackColor = Color.White;
            txt_Truong60.BackColor = Color.White;
            txt_Truong61.BackColor = Color.White;
            txt_Truong62.BackColor = Color.White;
            txt_Truong63.BackColor = Color.White;
            txt_Truong64.BackColor = Color.White;
            txt_Truong68.BackColor = Color.White;
            txt_Truong69.BackColor = Color.White;
            txt_Truong70.BackColor = Color.White;
            txt_Truong71.BackColor = Color.White;
            txt_Truong72.BackColor = Color.White;
            txt_Truong76.BackColor = Color.White;
            txt_Truong77.BackColor = Color.White;
            txt_Truong78.BackColor = Color.White;
            txt_Truong79.BackColor = Color.White;
            txt_Truong80.BackColor = Color.White;
            txt_Truong84.BackColor = Color.White;
            txt_Truong85.BackColor = Color.White;
            txt_Truong0.BackColor = Color.White;
            txt_Truong87.BackColor = Color.White;
            txt_Truong92.BackColor = Color.White;

            txt_Truong02.ForeColor = Color.Black;
            txt_Truong03_1.ForeColor = Color.Black;
            txt_Truong03_2.ForeColor = Color.Black;
            txt_Truong05.ForeColor = Color.Black;
            txt_Truong06.ForeColor = Color.Black;
            txt_Truong07.ForeColor = Color.Black;
            txt_Truong08.ForeColor = Color.Black;
            txt_Truong12.ForeColor = Color.Black;
            txt_Truong13.ForeColor = Color.Black;
            txt_Truong14.ForeColor = Color.Black;
            txt_Truong15.ForeColor = Color.Black;
            txt_Truong16.ForeColor = Color.Black;
            txt_Truong20.ForeColor = Color.Black;
            txt_Truong21.ForeColor = Color.Black;
            txt_Truong22.ForeColor = Color.Black;
            txt_Truong23.ForeColor = Color.Black;
            txt_Truong24.ForeColor = Color.Black;
            txt_Truong28.ForeColor = Color.Black;
            txt_Truong29.ForeColor = Color.Black;
            txt_Truong30.ForeColor = Color.Black;
            txt_Truong31.ForeColor = Color.Black;
            txt_Truong32.ForeColor = Color.Black;
            txt_Truong36.ForeColor = Color.Black;
            txt_Truong37.ForeColor = Color.Black;
            txt_Truong38.ForeColor = Color.Black;
            txt_Truong39.ForeColor = Color.Black;
            txt_Truong40.ForeColor = Color.Black;
            txt_Truong44.ForeColor = Color.Black;
            txt_Truong45.ForeColor = Color.Black;
            txt_Truong46.ForeColor = Color.Black;
            txt_Truong47.ForeColor = Color.Black;
            txt_Truong48.ForeColor = Color.Black;
            txt_Truong52.ForeColor = Color.Black;
            txt_Truong53.ForeColor = Color.Black;
            txt_Truong54.ForeColor = Color.Black;
            txt_Truong55.ForeColor = Color.Black;
            txt_Truong56.ForeColor = Color.Black;
            txt_Truong60.ForeColor = Color.Black;
            txt_Truong61.ForeColor = Color.Black;
            txt_Truong62.ForeColor = Color.Black;
            txt_Truong63.ForeColor = Color.Black;
            txt_Truong64.ForeColor = Color.Black;
            txt_Truong68.ForeColor = Color.Black;
            txt_Truong69.ForeColor = Color.Black;
            txt_Truong70.ForeColor = Color.Black;
            txt_Truong71.ForeColor = Color.Black;
            txt_Truong72.ForeColor = Color.Black;
            txt_Truong76.ForeColor = Color.Black;
            txt_Truong77.ForeColor = Color.Black;
            txt_Truong78.ForeColor = Color.Black;
            txt_Truong79.ForeColor = Color.Black;
            txt_Truong80.ForeColor = Color.Black;
            txt_Truong84.ForeColor = Color.Black;
            txt_Truong85.ForeColor = Color.Black;
            txt_Truong0.ForeColor = Color.Black;
            txt_Truong87.ForeColor = Color.Black;
            txt_Truong92.ForeColor = Color.Black;


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
                string.IsNullOrEmpty(txt_Truong07.Text) &&
                string.IsNullOrEmpty(txt_Truong08.Text) &&
                string.IsNullOrEmpty(txt_Truong12.Text) &&
                string.IsNullOrEmpty(txt_Truong13.Text) &&
                string.IsNullOrEmpty(txt_Truong14.Text) &&
                string.IsNullOrEmpty(txt_Truong15.Text) &&
                string.IsNullOrEmpty(txt_Truong16.Text) &&
                string.IsNullOrEmpty(txt_Truong20.Text) &&
                string.IsNullOrEmpty(txt_Truong21.Text) &&
                string.IsNullOrEmpty(txt_Truong22.Text) &&
                string.IsNullOrEmpty(txt_Truong23.Text) &&
                string.IsNullOrEmpty(txt_Truong24.Text) &&
                string.IsNullOrEmpty(txt_Truong28.Text) &&
                string.IsNullOrEmpty(txt_Truong29.Text) &&
                string.IsNullOrEmpty(txt_Truong30.Text) &&
                string.IsNullOrEmpty(txt_Truong31.Text) &&
                string.IsNullOrEmpty(txt_Truong32.Text) &&
                string.IsNullOrEmpty(txt_Truong36.Text) &&
                string.IsNullOrEmpty(txt_Truong37.Text) &&
                string.IsNullOrEmpty(txt_Truong38.Text) &&
                string.IsNullOrEmpty(txt_Truong39.Text) &&
                string.IsNullOrEmpty(txt_Truong40.Text) &&
                string.IsNullOrEmpty(txt_Truong44.Text) &&
                string.IsNullOrEmpty(txt_Truong45.Text) &&
                string.IsNullOrEmpty(txt_Truong46.Text) &&
                string.IsNullOrEmpty(txt_Truong47.Text) &&
                string.IsNullOrEmpty(txt_Truong48.Text) &&
                string.IsNullOrEmpty(txt_Truong52.Text) &&
                string.IsNullOrEmpty(txt_Truong53.Text) &&
                string.IsNullOrEmpty(txt_Truong54.Text) &&
                string.IsNullOrEmpty(txt_Truong55.Text) &&
                string.IsNullOrEmpty(txt_Truong56.Text) &&
                string.IsNullOrEmpty(txt_Truong60.Text) &&
                string.IsNullOrEmpty(txt_Truong61.Text) &&
                string.IsNullOrEmpty(txt_Truong62.Text) &&
                string.IsNullOrEmpty(txt_Truong63.Text) &&
                string.IsNullOrEmpty(txt_Truong64.Text) &&
                string.IsNullOrEmpty(txt_Truong68.Text) &&
                string.IsNullOrEmpty(txt_Truong69.Text) &&
                string.IsNullOrEmpty(txt_Truong70.Text) &&
                string.IsNullOrEmpty(txt_Truong71.Text) &&
                string.IsNullOrEmpty(txt_Truong72.Text) &&
                string.IsNullOrEmpty(txt_Truong76.Text) &&
                string.IsNullOrEmpty(txt_Truong77.Text) &&
                string.IsNullOrEmpty(txt_Truong78.Text) &&
                string.IsNullOrEmpty(txt_Truong79.Text) &&
                string.IsNullOrEmpty(txt_Truong80.Text) &&
                string.IsNullOrEmpty(txt_Truong84.Text) &&
                string.IsNullOrEmpty(txt_Truong85.Text) &&
                string.IsNullOrEmpty(txt_Truong0.Text) &&
                string.IsNullOrEmpty(txt_Truong87.Text) &&
                string.IsNullOrEmpty(txt_Truong92.Text)&&
                chk_qc.Checked==false)
                return true;
            return false;
        }

        public bool CheckQC()
        {
            if (txt_Truong02.Text.IndexOf('?') >= 0  || txt_Truong02.Text.IndexOf('●') >= 0  ||
                txt_Truong03_1.Text.IndexOf('?') >= 0  || txt_Truong03_1.Text.IndexOf('●') >= 0  ||
                txt_Truong03_2.Text.IndexOf('?') >= 0  || txt_Truong03_2.Text.IndexOf('●') >= 0  ||
                txt_Truong05.Text.IndexOf('?') >= 0  || txt_Truong05.Text.IndexOf('●') >= 0  ||
                txt_Truong06.Text.IndexOf('?') >= 0  || txt_Truong06.Text.IndexOf('●') >= 0  ||
                txt_Truong07.Text.IndexOf('?') >= 0  || txt_Truong07.Text.IndexOf('●') >= 0  ||
                txt_Truong08.Text.IndexOf('?') >= 0  || txt_Truong08.Text.IndexOf('●') >= 0  ||
                txt_Truong12.Text.IndexOf('?') >= 0  || txt_Truong12.Text.IndexOf('●') >= 0  ||
                txt_Truong13.Text.IndexOf('?') >= 0  || txt_Truong13.Text.IndexOf('●') >= 0  ||
                txt_Truong14.Text.IndexOf('?') >= 0  || txt_Truong14.Text.IndexOf('●') >= 0  ||
                txt_Truong15.Text.IndexOf('?') >= 0  || txt_Truong15.Text.IndexOf('●') >= 0  ||
                txt_Truong16.Text.IndexOf('?') >= 0  || txt_Truong16.Text.IndexOf('●') >= 0  ||
                txt_Truong20.Text.IndexOf('?') >= 0  || txt_Truong20.Text.IndexOf('●') >= 0  ||
                txt_Truong21.Text.IndexOf('?') >= 0  || txt_Truong21.Text.IndexOf('●') >= 0  ||
                txt_Truong22.Text.IndexOf('?') >= 0  || txt_Truong22.Text.IndexOf('●') >= 0  ||
                txt_Truong23.Text.IndexOf('?') >= 0  || txt_Truong23.Text.IndexOf('●') >= 0  ||
                txt_Truong24.Text.IndexOf('?') >= 0  || txt_Truong24.Text.IndexOf('●') >= 0  ||
                txt_Truong28.Text.IndexOf('?') >= 0  || txt_Truong28.Text.IndexOf('●') >= 0  ||
                txt_Truong29.Text.IndexOf('?') >= 0  || txt_Truong29.Text.IndexOf('●') >= 0  ||
                txt_Truong30.Text.IndexOf('?') >= 0  || txt_Truong30.Text.IndexOf('●') >= 0  ||
                txt_Truong31.Text.IndexOf('?') >= 0  || txt_Truong31.Text.IndexOf('●') >= 0  ||
                txt_Truong32.Text.IndexOf('?') >= 0  || txt_Truong32.Text.IndexOf('●') >= 0  ||
                txt_Truong36.Text.IndexOf('?') >= 0  || txt_Truong36.Text.IndexOf('●') >= 0  ||
                txt_Truong37.Text.IndexOf('?') >= 0  || txt_Truong37.Text.IndexOf('●') >= 0  ||
                txt_Truong38.Text.IndexOf('?') >= 0  || txt_Truong38.Text.IndexOf('●') >= 0  ||
                txt_Truong39.Text.IndexOf('?') >= 0  || txt_Truong39.Text.IndexOf('●') >= 0  ||
                txt_Truong40.Text.IndexOf('?') >= 0  || txt_Truong40.Text.IndexOf('●') >= 0  ||
                txt_Truong44.Text.IndexOf('?') >= 0  || txt_Truong44.Text.IndexOf('●') >= 0  ||
                txt_Truong45.Text.IndexOf('?') >= 0  || txt_Truong45.Text.IndexOf('●') >= 0  ||
                txt_Truong46.Text.IndexOf('?') >= 0  || txt_Truong46.Text.IndexOf('●') >= 0  ||
                txt_Truong47.Text.IndexOf('?') >= 0  || txt_Truong47.Text.IndexOf('●') >= 0  ||
                txt_Truong48.Text.IndexOf('?') >= 0  || txt_Truong48.Text.IndexOf('●') >= 0  ||
                txt_Truong52.Text.IndexOf('?') >= 0  || txt_Truong52.Text.IndexOf('●') >= 0  ||
                txt_Truong53.Text.IndexOf('?') >= 0  || txt_Truong53.Text.IndexOf('●') >= 0  ||
                txt_Truong54.Text.IndexOf('?') >= 0  || txt_Truong54.Text.IndexOf('●') >= 0  ||
                txt_Truong55.Text.IndexOf('?') >= 0  || txt_Truong55.Text.IndexOf('●') >= 0  ||
                txt_Truong56.Text.IndexOf('?') >= 0  || txt_Truong56.Text.IndexOf('●') >= 0  ||
                txt_Truong60.Text.IndexOf('?') >= 0  || txt_Truong60.Text.IndexOf('●') >= 0  ||
                txt_Truong61.Text.IndexOf('?') >= 0  || txt_Truong61.Text.IndexOf('●') >= 0  ||
                txt_Truong62.Text.IndexOf('?') >= 0  || txt_Truong62.Text.IndexOf('●') >= 0  ||
                txt_Truong63.Text.IndexOf('?') >= 0  || txt_Truong63.Text.IndexOf('●') >= 0  ||
                txt_Truong64.Text.IndexOf('?') >= 0  || txt_Truong64.Text.IndexOf('●') >= 0  ||
                txt_Truong68.Text.IndexOf('?') >= 0  || txt_Truong68.Text.IndexOf('●') >= 0  ||
                txt_Truong69.Text.IndexOf('?') >= 0  || txt_Truong69.Text.IndexOf('●') >= 0  ||
                txt_Truong70.Text.IndexOf('?') >= 0  || txt_Truong70.Text.IndexOf('●') >= 0  ||
                txt_Truong71.Text.IndexOf('?') >= 0  || txt_Truong71.Text.IndexOf('●') >= 0  ||
                txt_Truong72.Text.IndexOf('?') >= 0  || txt_Truong72.Text.IndexOf('●') >= 0  ||
                txt_Truong76.Text.IndexOf('?') >= 0  || txt_Truong76.Text.IndexOf('●') >= 0  ||
                txt_Truong77.Text.IndexOf('?') >= 0  || txt_Truong77.Text.IndexOf('●') >= 0  ||
                txt_Truong78.Text.IndexOf('?') >= 0  || txt_Truong78.Text.IndexOf('●') >= 0  ||
                txt_Truong79.Text.IndexOf('?') >= 0  || txt_Truong79.Text.IndexOf('●') >= 0  ||
                txt_Truong80.Text.IndexOf('?') >= 0  || txt_Truong80.Text.IndexOf('●') >= 0  ||
                txt_Truong84.Text.IndexOf('?') >= 0  || txt_Truong84.Text.IndexOf('●') >= 0  ||
                txt_Truong85.Text.IndexOf('?') >= 0  || txt_Truong85.Text.IndexOf('●') >= 0  ||
                txt_Truong0.Text.IndexOf('?') >= 0  || txt_Truong0.Text.IndexOf('●') >= 0  ||
                txt_Truong87.Text.IndexOf('?') >= 0  || txt_Truong87.Text.IndexOf('●') >= 0  ||
                txt_Truong92.Text.IndexOf('?') >= 0  || txt_Truong92.Text.IndexOf('●') >= 0 ||
                (txt_Truong05.Text == "" && (txt_Truong06.Text != "" || txt_Truong07.Text != ""/* || txt_Truong08.Text != ""*/)) ||
                (txt_Truong05.Text != "" && (txt_Truong06.Text == "" && txt_Truong07.Text == "" /*&& txt_Truong08.Text == ""*/)) ||
                (txt_Truong13.Text == "" && (txt_Truong14.Text != "" || txt_Truong15.Text != "" /*|| txt_Truong16.Text != ""*/)) ||
                (txt_Truong13.Text != "" && (txt_Truong14.Text == "" && txt_Truong15.Text == "" /*&& txt_Truong16.Text == ""*/)) ||
                (txt_Truong21.Text == "" && (txt_Truong22.Text != "" || txt_Truong23.Text != "" /*|| txt_Truong24.Text != ""*/)) ||
                (txt_Truong21.Text != "" && (txt_Truong22.Text == "" && txt_Truong23.Text == "" /*&& txt_Truong24.Text == ""*/)) ||
                (txt_Truong29.Text == "" && (txt_Truong30.Text != "" || txt_Truong31.Text != "" /*|| txt_Truong32.Text != ""*/)) ||
                (txt_Truong29.Text != "" && (txt_Truong30.Text == "" && txt_Truong31.Text == "" /*&& txt_Truong32.Text == ""*/)) ||
                (txt_Truong37.Text == "" && (txt_Truong38.Text != "" || txt_Truong39.Text != "" /*|| txt_Truong40.Text != ""*/)) ||
                (txt_Truong37.Text != "" && (txt_Truong38.Text == "" && txt_Truong39.Text == "" /*&& txt_Truong40.Text == ""*/)) ||
                (txt_Truong45.Text == "" && (txt_Truong46.Text != "" || txt_Truong47.Text != "" /*|| txt_Truong48.Text != ""*/)) ||
                (txt_Truong45.Text != "" && (txt_Truong46.Text == "" && txt_Truong47.Text == "" /*&& txt_Truong48.Text == ""*/)) ||
                (txt_Truong53.Text == "" && (txt_Truong54.Text != "" || txt_Truong55.Text != "" /*|| txt_Truong56.Text != ""*/)) ||
                (txt_Truong53.Text != "" && (txt_Truong54.Text == "" && txt_Truong55.Text == "" /*&& txt_Truong56.Text == ""*/)) ||
                (txt_Truong61.Text == "" && (txt_Truong62.Text != "" || txt_Truong63.Text != "" /*|| txt_Truong64.Text != ""*/)) ||
                (txt_Truong61.Text != "" && (txt_Truong62.Text == "" && txt_Truong63.Text == "" /*&& txt_Truong64.Text == ""*/)) ||
                (txt_Truong69.Text == "" && (txt_Truong70.Text != "" || txt_Truong71.Text != "" /*|| txt_Truong72.Text != ""*/)) ||
                (txt_Truong69.Text != "" && (txt_Truong70.Text == "" && txt_Truong71.Text == "" /*&& txt_Truong72.Text == ""*/)) ||
                (txt_Truong77.Text == "" && (txt_Truong78.Text != "" || txt_Truong79.Text != "" /*|| txt_Truong80.Text != ""*/)) ||
                (txt_Truong77.Text != "" && (txt_Truong78.Text == "" && txt_Truong79.Text == "" /*&& txt_Truong80.Text == ""*/)) ||
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
            if (RegexString(txt_Truong05.Text) ||
                RegexString(txt_Truong13.Text) ||
                RegexString(txt_Truong21.Text) ||
                RegexString(txt_Truong29.Text) ||
                RegexString(txt_Truong37.Text) ||
                RegexString(txt_Truong45.Text) ||
                RegexString(txt_Truong53.Text) ||
                RegexString(txt_Truong61.Text) ||
                RegexString(txt_Truong69.Text) ||
                RegexString(txt_Truong77.Text) ||
                chk_abc.Checked)
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
                if (txt_Truong03_1.Text.Length != 6)
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
                if (txt_Truong03_2.Text.Length != 6)
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
        private void Set_txtLengColumn1(object sender, EventArgs e, TextEdit tb)
        {
            if (tb.Text.IndexOf('?') >= 0)
                tb.Text = "?";
            if ((tb.Text.Length < 2 || tb.Text.Length > 3) && tb.Text != "" && tb.Text != "?" && tb.Text.IndexOf('●') < 0)
            {
                tb.BackColor = Color.Red;
                tb.ForeColor = Color.White;
            }
            else
            {
                tb.BackColor = Color.White;
                tb.ForeColor = Color.Black;
            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void Set_txtLengColumn2(object sender, EventArgs e,TextEdit tb)
        {
            if (tb.Text.IndexOf('?') >= 0)
                tb.Text = "?";
            if (Changed != null)
                Changed(sender, e);
        }
        private void Set_txtLengColumn3(object sender, EventArgs e,TextEdit tb)
        {
            if (tb.Text.IndexOf('?') >= 0)
                tb.Text = "?";
            if (Changed != null)
                Changed(sender, e);
        }
        private void Set_txtLengColumn4(object sender, EventArgs e, TextEdit tb)
        {
            if (Changed != null)
                Changed(sender, e);
        }
        private void Set_txtLengColumn5(object sender, EventArgs e, TextEdit tb)
        {
            if (tb.Text.IndexOf('?') >= 0)
                tb.Text = "?";
            if (Changed != null)
                Changed(sender, e);
        }
        private void txt_Truong05_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn1(sender, e, txt_Truong05);
        }

        private void txt_Truong13_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn1(sender, e, txt_Truong13);
        }

        private void txt_Truong21_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn1(sender, e, txt_Truong21);
        }

        private void txt_Truong29_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn1(sender, e, txt_Truong29);
        }

        private void txt_Truong37_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn1(sender, e, txt_Truong37);
        }

        private void txt_Truong45_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn1(sender, e, txt_Truong45);
        }

        private void txt_Truong53_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn1(sender, e, txt_Truong53);
        }

        private void txt_Truong61_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn1(sender, e, txt_Truong61);
        }

        private void txt_Truong69_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn1(sender, e, txt_Truong69);
        }

        private void txt_Truong77_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn1(sender, e, txt_Truong77);
        }

        private void txt_Truong06_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn2(sender, e, txt_Truong06);
        }

        private void txt_Truong14_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn2(sender, e, txt_Truong14);
        }

        private void txt_Truong22_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn2(sender, e, txt_Truong22);
        }

        private void txt_Truong30_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn2(sender, e, txt_Truong30);
        }

        private void txt_Truong38_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn2(sender, e, txt_Truong38);
        }

        private void txt_Truong46_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn2(sender, e, txt_Truong46);
        }

        private void txt_Truong54_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn2(sender, e, txt_Truong54);
        }

        private void txt_Truong62_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn2(sender, e, txt_Truong62);
        }

        private void txt_Truong70_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn2(sender, e, txt_Truong70);
        }

        private void txt_Truong78_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn2(sender, e, txt_Truong78);
        }

        private void txt_Truong07_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn3(sender, e, txt_Truong07);
        }

        private void txt_Truong15_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn3(sender, e, txt_Truong15);
        }

        private void txt_Truong23_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn3(sender, e, txt_Truong23);
        }

        private void txt_Truong31_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn3(sender, e, txt_Truong31);
        }

        private void txt_Truong39_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn3(sender, e, txt_Truong39);
        }

        private void txt_Truong47_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn3(sender, e, txt_Truong47);
        }

        private void txt_Truong55_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn3(sender, e, txt_Truong55);
        }

        private void txt_Truong63_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn3(sender, e, txt_Truong63);
        }

        private void txt_Truong71_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn3(sender, e, txt_Truong71);
        }

        private void txt_Truong79_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn3(sender, e, txt_Truong79);
        }

        private void txt_Truong08_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn4(sender, e, txt_Truong08);
        }

        private void txt_Truong16_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn4(sender, e, txt_Truong16);
        }

        private void txt_Truong24_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn4(sender, e, txt_Truong24);
        }

        private void txt_Truong32_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn4(sender, e, txt_Truong32);
        }

        private void txt_Truong40_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn4(sender, e, txt_Truong40);
        }

        private void txt_Truong48_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn4(sender, e, txt_Truong48);
        }

        private void txt_Truong56_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn4(sender, e, txt_Truong56);
        }

        private void txt_Truong64_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn4(sender, e, txt_Truong64);
        }

        private void txt_Truong72_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn4(sender, e, txt_Truong72);
        }

        private void txt_Truong80_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn4(sender, e, txt_Truong80);
        }

        private void txt_Truong12_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn5(sender, e, txt_Truong12);
        }

        private void txt_Truong20_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn5(sender, e, txt_Truong20);
        }

        private void txt_Truong28_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn5(sender, e, txt_Truong28);
        }

        private void txt_Truong36_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn5(sender, e, txt_Truong36);
        }

        private void txt_Truong44_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn5(sender, e, txt_Truong44);
        }

        private void txt_Truong52_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn5(sender, e, txt_Truong52);
        }

        private void txt_Truong60_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn5(sender, e, txt_Truong60);
        }

        private void txt_Truong68_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn5(sender, e, txt_Truong68);
        }

        private void txt_Truong76_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn5(sender, e, txt_Truong76);
        }

        private void txt_Truong84_EditValueChanged(object sender, EventArgs e)
        {
            Set_txtLengColumn5(sender, e, txt_Truong84);
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

        private void txt_Truong87_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong87.Text.IndexOf('?') >= 0)
                txt_Truong87.Text = "?";
            if (Changed != null)
                Changed(sender, e);
        }
       
        private void txt_Truong86_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    nonNumberEntered = true;
                }
            }
        }

        private void txt_Truong86_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == false)
            {
                e.Handled = true;
            }
        }
        private void uc_ASAHI_Load(object sender, EventArgs e)
        {
            SetDataLookUpEdit();
            txt_Truong08.Properties.DataSource = category;
            txt_Truong08.Properties.DisplayMember = "Set_Value";
            txt_Truong08.Properties.ValueMember = "Set_Value";

            txt_Truong16.Properties.DataSource = category;
            txt_Truong16.Properties.DisplayMember = "Set_Value";
            txt_Truong16.Properties.ValueMember = "Set_Value";

            txt_Truong24.Properties.DataSource = category;
            txt_Truong24.Properties.DisplayMember = "Set_Value";
            txt_Truong24.Properties.ValueMember = "Set_Value";

            txt_Truong32.Properties.DataSource = category;
            txt_Truong32.Properties.DisplayMember = "Set_Value";
            txt_Truong32.Properties.ValueMember = "Set_Value";

            txt_Truong40.Properties.DataSource = category;
            txt_Truong40.Properties.DisplayMember = "Set_Value";
            txt_Truong40.Properties.ValueMember = "Set_Value";

            txt_Truong48.Properties.DataSource = category;
            txt_Truong48.Properties.DisplayMember = "Set_Value";
            txt_Truong48.Properties.ValueMember = "Set_Value";

            txt_Truong56.Properties.DataSource = category;
            txt_Truong56.Properties.DisplayMember = "Set_Value";
            txt_Truong56.Properties.ValueMember = "Set_Value";

            txt_Truong64.Properties.DataSource = category;
            txt_Truong64.Properties.DisplayMember = "Set_Value";
            txt_Truong64.Properties.ValueMember = "Set_Value";

            txt_Truong72.Properties.DataSource = category;
            txt_Truong72.Properties.DisplayMember = "Set_Value";
            txt_Truong72.Properties.ValueMember = "Set_Value";

            txt_Truong80.Properties.DataSource = category;
            txt_Truong80.Properties.DisplayMember = "Set_Value";
            txt_Truong80.Properties.ValueMember = "Set_Value";

            txt_Truong02.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong03_1.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong03_2.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong05.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong06.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong07.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong08.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong12.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong13.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong14.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong15.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong16.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong20.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong21.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong22.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong23.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong24.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong28.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong29.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong30.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong31.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong32.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong36.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong37.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong38.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong39.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong40.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong44.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong45.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong46.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong47.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong48.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong52.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong53.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong54.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong55.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong56.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong60.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong61.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong62.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong63.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong64.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong68.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong69.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong70.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong71.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong72.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong76.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong77.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong78.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong79.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong80.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong84.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong85.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong0.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong87.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong92.GotFocus += Txt_Truong02_GotFocus;

            txt_Truong05.GotFocus += Txt_TruongSo05_GotFocus;
            txt_Truong05.Leave += Txt_TruongSo05_Leave;
            txt_Truong13.GotFocus += Txt_TruongSo05_GotFocus;
            txt_Truong13.Leave += Txt_TruongSo05_Leave;
            txt_Truong21.GotFocus += Txt_TruongSo05_GotFocus;
            txt_Truong21.Leave += Txt_TruongSo05_Leave;
            txt_Truong29.GotFocus += Txt_TruongSo05_GotFocus;
            txt_Truong29.Leave += Txt_TruongSo05_Leave;
            txt_Truong37.GotFocus += Txt_TruongSo05_GotFocus;
            txt_Truong37.Leave += Txt_TruongSo05_Leave;
            txt_Truong45.GotFocus += Txt_TruongSo05_GotFocus;
            txt_Truong45.Leave += Txt_TruongSo05_Leave;
            txt_Truong53.GotFocus += Txt_TruongSo05_GotFocus;
            txt_Truong53.Leave += Txt_TruongSo05_Leave;
            txt_Truong61.GotFocus += Txt_TruongSo05_GotFocus;
            txt_Truong61.Leave += Txt_TruongSo05_Leave;
            txt_Truong69.GotFocus += Txt_TruongSo05_GotFocus;
            txt_Truong69.Leave += Txt_TruongSo05_Leave;
            txt_Truong77.GotFocus += Txt_TruongSo05_GotFocus;
            txt_Truong77.Leave += Txt_TruongSo05_Leave;

        }

        private void Txt_Truong02_GotFocus(object sender, EventArgs e)
        {
            ((TextEdit)sender).SelectAll();
        }
        public void SaveData_YASUDA(string idImage)
        {
            string txtTruong03 = txt_Truong03_1.Text + txt_Truong03_2.Text;
            if (txtTruong03.ToString().IndexOf('?') >= 0)
            txtTruong03 = "?";
            //Save Data
            
            Global.db.Insert_YASUDA_NewABC(idImage, Global.StrBatch, Global.StrUsername, txt_Truong0.Text, txt_Truong02.Text, txtTruong03, txt_Truong05.Text, txt_Truong06.Text, txt_Truong07.Text, txt_Truong08.Text,
                                             txt_Truong12.Text, txt_Truong13.Text, txt_Truong14.Text, txt_Truong15.Text, txt_Truong16.Text,
                                             txt_Truong20.Text, txt_Truong21.Text, txt_Truong22.Text, txt_Truong23.Text, txt_Truong24.Text,
                                             txt_Truong28.Text, txt_Truong29.Text, txt_Truong30.Text, txt_Truong31.Text, txt_Truong32.Text,
                                             txt_Truong36.Text, txt_Truong37.Text, txt_Truong38.Text, txt_Truong39.Text, txt_Truong40.Text,
                                             txt_Truong44.Text, txt_Truong45.Text, txt_Truong46.Text, txt_Truong47.Text, txt_Truong48.Text,
                                             txt_Truong52.Text, txt_Truong53.Text, txt_Truong54.Text, txt_Truong55.Text, txt_Truong56.Text,
                                             txt_Truong60.Text, txt_Truong61.Text, txt_Truong62.Text, txt_Truong63.Text, txt_Truong64.Text,
                                             txt_Truong68.Text, txt_Truong69.Text, txt_Truong70.Text, txt_Truong71.Text, txt_Truong72.Text,
                                             txt_Truong76.Text, txt_Truong77.Text, txt_Truong78.Text, txt_Truong79.Text, txt_Truong80.Text,
                                             txt_Truong84.Text, txt_Truong85.Text, txt_Truong87.Text, txt_Truong92.Text, CheckQC(),CheckABC());
        }

        private void txt_Truong91_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong92.Text.IndexOf('?') >= 0)
                txt_Truong92.Text = "?";
            if (txt_Truong92.Text != "" && txt_Truong92.Text != "?" && txt_Truong92.Text.IndexOf('●') < 0)
            {
                if (txt_Truong92.Text.Length != 6)
                {
                    txt_Truong92.BackColor = Color.Red;
                    txt_Truong92.ForeColor = Color.White;
                }
                else
                {
                    txt_Truong92.BackColor = Color.White;
                    txt_Truong92.ForeColor = Color.Black;
                }
            }
            else
            {
                txt_Truong92.BackColor = Color.White;
                txt_Truong92.ForeColor = Color.Black;
            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void chk_qc_CheckedChanged(object sender, EventArgs e)
        {
            if (Changed != null)
                Changed(sender, e);
        }
        private bool _Flag = false;
        private void Txt_TruongSo05_Leave(object sender, EventArgs e)
        {
            _Flag = false;
        }

        private void Txt_TruongSo05_GotFocus(object sender, EventArgs e)
        {
            _Flag = true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Down && _Flag)
            {
                SendKeys.Send("{Tab}");
                SendKeys.Send("{Tab}");
                SendKeys.Send("{Tab}");
                SendKeys.Send("{Tab}");
                SendKeys.Send("{Tab}");
                return true;
            }
            if (keyData == Keys.Up && _Flag)
            {
                SendKeys.Send("+{Tab}");
                SendKeys.Send("+{Tab}");
                SendKeys.Send("+{Tab}");
                SendKeys.Send("+{Tab}");
                SendKeys.Send("+{Tab}");
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void txt_Truong02_Leave(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txt_Truong02.Text))
            //{
            //    string tempYear = DateTime.Now.Year.ToString().Substring(2, 2);
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
            }}
    }
}
