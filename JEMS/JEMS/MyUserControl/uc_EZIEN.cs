using System;
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
    public partial class uc_EZIEN : UserControl
    {
        List<Category> category = new List<Category>();
        public event AllTextChange Changed;
        private bool nonNumberEntered = false;
        public uc_EZIEN()
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
            txt_Truong85.Text = "";
            txt_Truong0.Text = "";
            txt_Truong86.Text = "";

            txt_Truong02.BackColor = Color.White;
            txt_Truong03_1.BackColor = Color.White;
            txt_Truong03_2.BackColor = Color.White;
            txt_Truong05.BackColor = Color.White;
            txt_Truong06.BackColor = Color.White;
            txt_Truong07.BackColor = Color.White;
            txt_Truong08.BackColor = Color.White;
            txt_Truong85.BackColor = Color.White;
            txt_Truong0.BackColor = Color.White;
            txt_Truong86.BackColor = Color.White;
            chk_qc.Checked = false;
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
                string.IsNullOrEmpty(txt_Truong85.Text) &&
                string.IsNullOrEmpty(txt_Truong0.Text) &&
                string.IsNullOrEmpty(txt_Truong86.Text) &&
                chk_qc.Checked == false)
                return true;
            return false;
        }

        private void txt_Truong02_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong02.Text.ToString().IndexOf('?') >= 0)
                txt_Truong02.Text = "?";
            if (txt_Truong02.Text.Length != 6 && txt_Truong02.Text != "" && txt_Truong02.Text != "?")
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
            if (txt_Truong03_1.Text != "" && txt_Truong03_1.Text != "?")
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
                    txt_Truong03_2.Focus();
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
            if (txt_Truong03_2.Text.ToString().IndexOf('?') >= 0)
                txt_Truong03_2.Text = "?";
            if (txt_Truong03_2.Text != "" && txt_Truong03_2.Text != "?")
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
                if (txt_Truong03_2.Text.Length == 0)
                    txt_Truong03_1.Focus();
                txt_Truong03_2.BackColor = Color.White;
                txt_Truong03_2.ForeColor = Color.Black;
            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong05_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong05.Text.ToString().IndexOf('?') >= 0)
                txt_Truong05.Text = "?";
            if (txt_Truong05.Text.Length != 2 && txt_Truong05.Text != "" && txt_Truong05.Text != "?")
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
            if (txt_Truong06.Text.ToString().IndexOf('?') >= 0)
                txt_Truong06.Text = "?";
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong07_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong07.Text.ToString().IndexOf('?') >= 0)
                txt_Truong07.Text = "?";
            if (Changed != null)
                Changed(sender, e);
        }
        private void txt_Truong85_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong85.Text.ToString().IndexOf('?') >= 0)
                txt_Truong85.Text = "?";
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong0_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong0.Text.ToString().IndexOf('?') >= 0)
                txt_Truong0.Text = "?";
            if (txt_Truong0.Text != txt_Truong02.Text && txt_Truong0.Text != "" && txt_Truong0.Text != "?")
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

        private void txt_Truong86_TextChanged(object sender, EventArgs e)
        {
            if (txt_Truong86.Text.ToString().IndexOf('?') >= 0)
                txt_Truong86.Text = "?";
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

            txt_Truong02.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong03_1.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong03_2.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong05.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong06.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong07.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong08.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong85.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong0.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong86.GotFocus += Txt_Truong02_GotFocus;
        }

        private void Txt_Truong02_GotFocus(object sender, EventArgs e)
        {
            ((TextEdit)sender).SelectAll();
        }
        public void SaveData_EIZEN(string idImage)
        {
            string txtTruong03 = txt_Truong03_1.Text + txt_Truong03_2.Text;
            if (txtTruong03.ToString().IndexOf('?') >= 0)
                txtTruong03 = "?";
            //Save Data
            bool qc;
            if (chk_qc.Checked == true)
                qc = true;
            else
                qc = false;
            Global.db_JEMS.Insert_EIZEN(idImage, Global.StrBatch, Global.StrUsername, txt_Truong02.Text, txtTruong03, txt_Truong05.Text, txt_Truong06.Text,txt_Truong07.Text, txt_Truong08.Text, txt_Truong85.Text,txt_Truong86.Text,qc);
        }
       
    }
}
