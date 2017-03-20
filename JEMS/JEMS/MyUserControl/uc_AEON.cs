﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace JEMS.MyUserControl
{
    public partial class uc_AEON : UserControl
    {
        List<Category> category = new List<Category>();
        public event AllTextChange Changed;
        private bool nonNumberEntered = false;

        public uc_AEON()
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
            category.Add(new Category() { Set_Value = "リットル（ℓ）" });
            category.Add(new Category() { Set_Value = "個・台" });
            category.Add(new Category() { Set_Value = "?" });
            category.Add(new Category() { Set_Value = "●" });
        }
        public void ResetData()
        {
            txt_Truong02.Text = "";
            txt_Truong03_1.Text = "";
            txt_Truong03_2.Text = "";
            txt_Truong04.Text = "";

            txt_Truong05.Text = "";
            txt_Truong06.Text = "";
            txt_Truong07.Text = "";
            txt_Truong08.ItemIndex = 0;

            txt_Truong13.Text = "";
            txt_Truong14.Text = "";
            txt_Truong15.Text = "";
            txt_Truong16.ItemIndex = 0;

            txt_Truong21.Text = "";
            txt_Truong22.Text = "";
            txt_Truong23.Text = "";
            txt_Truong24.ItemIndex = 0;

            txt_Truong29.Text = "";
            txt_Truong30.Text = "";
            txt_Truong31.Text = "";
            txt_Truong32.ItemIndex = 0;

            txt_Truong37.Text = "";
            txt_Truong38.Text = "";
            txt_Truong39.Text = "";
            txt_Truong40.ItemIndex = 0;

            txt_Truong45.Text = "";
            txt_Truong46.Text = "";
            txt_Truong47.Text = "";
            txt_Truong48.ItemIndex = 0;

            txt_Truong53.Text = "";
            txt_Truong54.Text = "";
            txt_Truong55.Text = "";
            txt_Truong56.ItemIndex = 0;

            txt_Truong61.Text = "";
            txt_Truong62.Text = "";
            txt_Truong63.Text = "";
            txt_Truong64.ItemIndex = 0;
            
            txt_Truong02.BackColor = Color.White;
            txt_Truong03_1.BackColor = Color.White;
            txt_Truong03_2.BackColor = Color.White;
            txt_Truong04.BackColor = Color.White;
            txt_Truong05.BackColor = Color.White;
            txt_Truong06.BackColor = Color.White;
            txt_Truong07.BackColor = Color.White;
            txt_Truong08.BackColor = Color.White;
            txt_Truong13.BackColor = Color.White;
            txt_Truong14.BackColor = Color.White;
            txt_Truong15.BackColor = Color.White;
            txt_Truong16.BackColor = Color.White;
            txt_Truong21.BackColor = Color.White;
            txt_Truong22.BackColor = Color.White;
            txt_Truong23.BackColor = Color.White;
            txt_Truong24.BackColor = Color.White;
            txt_Truong29.BackColor = Color.White;
            txt_Truong30.BackColor = Color.White;
            txt_Truong31.BackColor = Color.White;
            txt_Truong32.BackColor = Color.White;
            txt_Truong37.BackColor = Color.White;
            txt_Truong38.BackColor = Color.White;
            txt_Truong39.BackColor = Color.White;
            txt_Truong40.BackColor = Color.White;
            txt_Truong45.BackColor = Color.White;
            txt_Truong46.BackColor = Color.White;
            txt_Truong47.BackColor = Color.White;
            txt_Truong48.BackColor = Color.White;
            txt_Truong53.BackColor = Color.White;
            txt_Truong54.BackColor = Color.White;
            txt_Truong55.BackColor = Color.White;
            txt_Truong56.BackColor = Color.White;
            txt_Truong61.BackColor = Color.White;
            txt_Truong62.BackColor = Color.White;
            txt_Truong63.BackColor = Color.White;
            txt_Truong64.BackColor = Color.White;
            chk_qc.Checked = false;
            txt_Truong02.Focus();
        }

        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_Truong02.Text) &&
                string.IsNullOrEmpty(txt_Truong03_1.Text) &&
                string.IsNullOrEmpty(txt_Truong03_2.Text) &&
                string.IsNullOrEmpty(txt_Truong04.Text) &&
                string.IsNullOrEmpty(txt_Truong05.Text) &&
                string.IsNullOrEmpty(txt_Truong06.Text) &&
                string.IsNullOrEmpty(txt_Truong07.Text) &&
                string.IsNullOrEmpty(txt_Truong08.Text) &&
                string.IsNullOrEmpty(txt_Truong13.Text) &&
                string.IsNullOrEmpty(txt_Truong14.Text) &&
                string.IsNullOrEmpty(txt_Truong15.Text) &&
                string.IsNullOrEmpty(txt_Truong16.Text) &&
                string.IsNullOrEmpty(txt_Truong21.Text) &&
                string.IsNullOrEmpty(txt_Truong22.Text) &&
                string.IsNullOrEmpty(txt_Truong23.Text) &&
                string.IsNullOrEmpty(txt_Truong24.Text) &&
                string.IsNullOrEmpty(txt_Truong29.Text) &&
                string.IsNullOrEmpty(txt_Truong30.Text) &&
                string.IsNullOrEmpty(txt_Truong31.Text) &&
                string.IsNullOrEmpty(txt_Truong32.Text) &&
                string.IsNullOrEmpty(txt_Truong37.Text) &&
                string.IsNullOrEmpty(txt_Truong38.Text) &&
                string.IsNullOrEmpty(txt_Truong39.Text) &&
                string.IsNullOrEmpty(txt_Truong40.Text) &&
                string.IsNullOrEmpty(txt_Truong45.Text) &&
                string.IsNullOrEmpty(txt_Truong46.Text) &&
                string.IsNullOrEmpty(txt_Truong47.Text) &&
                string.IsNullOrEmpty(txt_Truong48.Text) &&
                string.IsNullOrEmpty(txt_Truong53.Text) &&
                string.IsNullOrEmpty(txt_Truong54.Text) &&
                string.IsNullOrEmpty(txt_Truong55.Text) &&
                string.IsNullOrEmpty(txt_Truong56.Text) &&
                string.IsNullOrEmpty(txt_Truong61.Text) &&
                string.IsNullOrEmpty(txt_Truong62.Text) &&
                string.IsNullOrEmpty(txt_Truong63.Text) &&
                string.IsNullOrEmpty(txt_Truong64.Text) &&
                chk_qc.Checked==false)
                return true;
            return false;
        }
        public bool CheckQC()
        {
            if (txt_Truong02.Text.ToString().IndexOf('?') >= 0 || txt_Truong02.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong03_1.Text.ToString().IndexOf('?') >= 0 || txt_Truong03_1.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong03_2.Text.ToString().IndexOf('?') >= 0 || txt_Truong03_2.Text.ToString().IndexOf('●') >= 0 ||
                txt_Truong04.Text.ToString().IndexOf('?') >= 0 || txt_Truong04.Text.ToString().IndexOf('●') >= 0 ||
                txt_Truong05.Text.ToString().IndexOf('?') >= 0 || txt_Truong05.Text.ToString().IndexOf('●') >= 0 ||
                txt_Truong06.Text.ToString().IndexOf('?') >= 0 || txt_Truong06.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong07.Text.ToString().IndexOf('?') >= 0 || txt_Truong07.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong08.Text.ToString().IndexOf('?') >= 0 || txt_Truong08.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong13.Text.ToString().IndexOf('?') >= 0 || txt_Truong13.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong14.Text.ToString().IndexOf('?') >= 0 || txt_Truong14.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong15.Text.ToString().IndexOf('?') >= 0 || txt_Truong15.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong16.Text.ToString().IndexOf('?') >= 0 || txt_Truong16.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong21.Text.ToString().IndexOf('?') >= 0 || txt_Truong21.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong22.Text.ToString().IndexOf('?') >= 0 || txt_Truong22.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong23.Text.ToString().IndexOf('?') >= 0 || txt_Truong23.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong24.Text.ToString().IndexOf('?') >= 0 || txt_Truong24.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong29.Text.ToString().IndexOf('?') >= 0 || txt_Truong29.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong30.Text.ToString().IndexOf('?') >= 0 || txt_Truong30.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong31.Text.ToString().IndexOf('?') >= 0 || txt_Truong31.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong32.Text.ToString().IndexOf('?') >= 0 || txt_Truong32.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong37.Text.ToString().IndexOf('?') >= 0 || txt_Truong37.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong38.Text.ToString().IndexOf('?') >= 0 || txt_Truong38.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong39.Text.ToString().IndexOf('?') >= 0 || txt_Truong39.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong40.Text.ToString().IndexOf('?') >= 0 || txt_Truong40.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong45.Text.ToString().IndexOf('?') >= 0 || txt_Truong45.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong46.Text.ToString().IndexOf('?') >= 0 || txt_Truong46.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong47.Text.ToString().IndexOf('?') >= 0 || txt_Truong47.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong48.Text.ToString().IndexOf('?') >= 0 || txt_Truong48.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong53.Text.ToString().IndexOf('?') >= 0 || txt_Truong53.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong54.Text.ToString().IndexOf('?') >= 0 || txt_Truong54.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong55.Text.ToString().IndexOf('?') >= 0 || txt_Truong55.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong56.Text.ToString().IndexOf('?') >= 0 || txt_Truong56.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong61.Text.ToString().IndexOf('?') >= 0 || txt_Truong61.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong62.Text.ToString().IndexOf('?') >= 0 || txt_Truong62.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong63.Text.ToString().IndexOf('?') >= 0 || txt_Truong63.Text.ToString().IndexOf('●') >= 0  ||
                txt_Truong64.Text.ToString().IndexOf('?') >= 0 || txt_Truong64.Text.ToString().IndexOf('●') >= 0  ||
                (txt_Truong05.Text.ToString() == "" && (txt_Truong06.Text.ToString() != "" || txt_Truong07.Text.ToString() != "" || txt_Truong08.Text.ToString() != "")) ||
                (txt_Truong05.Text.ToString() != "" && (txt_Truong06.Text.ToString() == "" && txt_Truong07.Text.ToString() == "" && txt_Truong08.Text.ToString() == "")) ||
                (txt_Truong13.Text.ToString() == "" && (txt_Truong14.Text.ToString() != "" || txt_Truong15.Text.ToString() != "" || txt_Truong16.Text.ToString() != "")) ||
                (txt_Truong13.Text.ToString() != "" && (txt_Truong14.Text.ToString() == "" && txt_Truong15.Text.ToString() == "" && txt_Truong16.Text.ToString() == "")) ||
                (txt_Truong21.Text.ToString() == "" && (txt_Truong22.Text.ToString() != "" || txt_Truong23.Text.ToString() != "" || txt_Truong24.Text.ToString() != "")) ||
                (txt_Truong21.Text.ToString() != "" && (txt_Truong22.Text.ToString() == "" && txt_Truong23.Text.ToString() == "" && txt_Truong24.Text.ToString() == "")) ||
                (txt_Truong29.Text.ToString() == "" && (txt_Truong30.Text.ToString() != "" || txt_Truong31.Text.ToString() != "" || txt_Truong32.Text.ToString() != "")) ||
                (txt_Truong29.Text.ToString() != "" && (txt_Truong30.Text.ToString() == "" && txt_Truong31.Text.ToString() == "" && txt_Truong32.Text.ToString() == "")) ||
                (txt_Truong37.Text.ToString() == "" && (txt_Truong38.Text.ToString() != "" || txt_Truong39.Text.ToString() != "" || txt_Truong40.Text.ToString() != "")) ||
                (txt_Truong37.Text.ToString() != "" && (txt_Truong38.Text.ToString() == "" && txt_Truong39.Text.ToString() == "" && txt_Truong40.Text.ToString() == "")) ||
                (txt_Truong45.Text.ToString() == "" && (txt_Truong46.Text.ToString() != "" || txt_Truong47.Text.ToString() != "" || txt_Truong48.Text.ToString() != "")) ||
                (txt_Truong45.Text.ToString() != "" && (txt_Truong46.Text.ToString() == "" && txt_Truong47.Text.ToString() == "" && txt_Truong48.Text.ToString() == "")) ||
                (txt_Truong53.Text.ToString() == "" && (txt_Truong54.Text.ToString() != "" || txt_Truong55.Text.ToString() != "" || txt_Truong56.Text.ToString() != "")) ||
                (txt_Truong53.Text.ToString() != "" && (txt_Truong54.Text.ToString() == "" && txt_Truong55.Text.ToString() == "" && txt_Truong56.Text.ToString() == "")) ||
                (txt_Truong61.Text.ToString() == "" && (txt_Truong62.Text.ToString() != "" || txt_Truong63.Text.ToString() != "" || txt_Truong64.Text.ToString() != "")) ||
                (txt_Truong61.Text.ToString() != "" && (txt_Truong62.Text.ToString() == "" && txt_Truong63.Text.ToString() == "" && txt_Truong64.Text.ToString() == "")) ||
                chk_qc.Checked)
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
            if (txt_Truong02.Text.ToString().IndexOf('?') >= 0)
                txt_Truong02.Text = "?";
            if (txt_Truong02.Text.Length != 6 && txt_Truong02.Text != "" && txt_Truong02.Text != "?" && txt_Truong02.Text.ToString().IndexOf('●') < 0)
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
            if (txt_Truong03_1.Text.ToString().IndexOf('?') >= 0)
                txt_Truong03_1.Text = "?";
            //if (txt_Truong03_1.Text != "" && txt_Truong03_1.Text != "?" && txt_Truong03_1.Text.ToString().IndexOf('●') < 0)
            //{
            //    if (txt_Truong03_1.Text.Length != 6)
            //    {
            //        txt_Truong03_1.BackColor = Color.Red;
            //        txt_Truong03_1.ForeColor = Color.White;
            //    }
            //    else
            //    {
            //        txt_Truong03_1.BackColor = Color.White;
            //        txt_Truong03_1.ForeColor = Color.Black;
            //    }
            //}
            //else
            //{
            //    txt_Truong03_1.BackColor = Color.White;
            //    txt_Truong03_1.ForeColor = Color.Black;
            //}
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong03_2_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong03_2.Text.ToString().IndexOf('?') >= 0)
                txt_Truong03_2.Text = "?";
            //if (txt_Truong03_2.Text != "" && txt_Truong03_2.Text != "?" && txt_Truong03_2.Text != "●" && txt_Truong03_2.Text.ToString().IndexOf('●') < 0)
            //{
            //    if (txt_Truong03_2.Text.Length != 6)
            //    {
            //        txt_Truong03_2.BackColor = Color.Red;
            //        txt_Truong03_2.ForeColor = Color.White;
            //    }
            //    else
            //    {
            //        txt_Truong03_2.BackColor = Color.White;
            //        txt_Truong03_2.ForeColor = Color.Black;
            //    }
            //}
            //else
            //{
            //    txt_Truong03_2.BackColor = Color.White;
            //    txt_Truong03_2.ForeColor = Color.Black;
            //}
            if (Changed != null)
                Changed(sender, e);
        }
        private void Set_txtLengColumn1(object sender, EventArgs e, TextEdit tb)
        {
            if (tb.Text.ToString().IndexOf('?') >= 0)
                tb.Text = "?";
            if ((tb.Text.Length < 2 || tb.Text.Length > 3) && tb.Text != "" && tb.Text != "?" && tb.Text.ToString().IndexOf('●') < 0)
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
            if (tb.Text.ToString().IndexOf('?') >= 0)
                tb.Text = "?";
            if ((tb.Text.Length > 4) && tb.Text != "" && tb.Text != "?" && tb.Text.ToString().IndexOf('●') < 0)
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
        private void Set_txtLengColumn3(object sender, EventArgs e,TextEdit tb)
        {
            if (tb.Text.ToString().IndexOf('?') >= 0)
                tb.Text = "?";
            if ((tb.Text.Length > 2) && tb.Text != "" && tb.Text != "?" && tb.Text.ToString().IndexOf('●') < 0)
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
        private void Set_txtLengColumn4(object sender, EventArgs e, TextEdit tb)
        {
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong04_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong04.Text.ToString().IndexOf('?') >= 0)
                txt_Truong04.Text = "?";
            if ((txt_Truong04.Text.Length >1) && txt_Truong04.Text != "" && txt_Truong04.Text != "?" && txt_Truong04.Text.ToString().IndexOf('●') < 0)
            {
                txt_Truong04.BackColor = Color.Red;
                txt_Truong04.ForeColor = Color.White;
            }
            else
            {
                txt_Truong04.BackColor = Color.White;
                txt_Truong04.ForeColor = Color.Black;
            }
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
        private void chk_qc_CheckedChanged(object sender, EventArgs e)
        {
            if (Changed != null)
                Changed(sender, e);
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

            txt_Truong02.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong03_1.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong03_2.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong04.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong05.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong06.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong07.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong08.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong13.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong14.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong15.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong16.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong21.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong22.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong23.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong24.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong29.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong30.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong31.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong32.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong37.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong38.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong39.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong40.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong45.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong46.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong47.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong48.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong53.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong54.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong55.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong56.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong61.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong62.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong63.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong64.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong02.Focus();
        }

        private void Txt_Truong02_GotFocus(object sender, EventArgs e)
        {
            ((TextEdit)sender).SelectAll();
        }
        public void SaveData_AEON(string idImage)
        {
            //Save Data
            Global.db.Insert_AEON_QuanLyDuAn(idImage, Global.StrBatch, Global.StrUsername, txt_Truong02.Text, txt_Truong03_1.Text , txt_Truong03_2.Text, txt_Truong04.Text, txt_Truong05.Text, txt_Truong06.Text, txt_Truong07.Text, txt_Truong08.Text,
                                             txt_Truong13.Text, txt_Truong14.Text, txt_Truong15.Text, txt_Truong16.Text,
                                             txt_Truong21.Text, txt_Truong22.Text, txt_Truong23.Text, txt_Truong24.Text,
                                             txt_Truong29.Text, txt_Truong30.Text, txt_Truong31.Text, txt_Truong32.Text,
                                             txt_Truong37.Text, txt_Truong38.Text, txt_Truong39.Text, txt_Truong40.Text,
                                             txt_Truong45.Text, txt_Truong46.Text, txt_Truong47.Text, txt_Truong48.Text,
                                             txt_Truong53.Text, txt_Truong54.Text, txt_Truong55.Text, txt_Truong56.Text,
                                             txt_Truong61.Text, txt_Truong62.Text, txt_Truong63.Text, txt_Truong64.Text,
                                             CheckQC());
        }
    }
}