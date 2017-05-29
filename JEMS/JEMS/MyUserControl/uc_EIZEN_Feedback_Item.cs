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
    public partial class uc_EIZEN_Feedback_Item : UserControl
    {
        List<Category> category = new List<Category>();
        private bool nonNumberEntered = false;
        public uc_EIZEN_Feedback_Item()
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

            txt_Truong02.ForeColor = Color.Black;
            txt_Truong03_1.ForeColor = Color.Black;
            txt_Truong03_2.ForeColor = Color.Black;
            txt_Truong05.ForeColor = Color.Black;
            txt_Truong06.ForeColor = Color.Black;
            txt_Truong07.ForeColor = Color.Black;
            txt_Truong08.ForeColor = Color.Black;
            txt_Truong85.ForeColor = Color.Black;
            txt_Truong0.ForeColor = Color.Black;
            txt_Truong86.ForeColor = Color.Black;


            chk_qc.Checked = false;
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
                string.IsNullOrEmpty(txt_Truong85.Text) &&
                string.IsNullOrEmpty(txt_Truong0.Text) &&
                string.IsNullOrEmpty(txt_Truong86.Text) &&
                chk_qc.Checked == false)
                return true;
            return false;
        }
        public bool CheckQC()
        {
            if (txt_Truong02.Text.IndexOf('?') >= 0 || txt_Truong02.Text.IndexOf('●') >= 0 ||
                txt_Truong03_1.Text.IndexOf('?') >= 0 || txt_Truong03_1.Text.IndexOf('●') >= 0 ||
                txt_Truong03_2.Text.IndexOf('?') >= 0 || txt_Truong03_2.Text.IndexOf('●') >= 0 ||
                txt_Truong05.Text.IndexOf('?') >= 0 || txt_Truong05.Text.IndexOf('●') >= 0 ||
                txt_Truong06.Text.IndexOf('?') >= 0 || txt_Truong06.Text.IndexOf('●') >= 0 ||
                txt_Truong07.Text.IndexOf('?') >= 0 || txt_Truong07.Text.IndexOf('●') >= 0 ||
                txt_Truong08.Text.IndexOf('?') >= 0 || txt_Truong08.Text.IndexOf('●') >= 0 ||
                txt_Truong85.Text.IndexOf('?') >= 0 || txt_Truong85.Text.IndexOf('●') >= 0 ||
                txt_Truong0.Text.IndexOf('?') >= 0 || txt_Truong0.Text.IndexOf('●') >= 0 ||
                txt_Truong86.Text.IndexOf('?') >= 0 || txt_Truong86.Text.IndexOf('●') >= 0 ||
                (txt_Truong05.Text == "" && (txt_Truong06.Text != "" || txt_Truong07.Text != "" || txt_Truong08.Text != "")) ||
                (txt_Truong05.Text != "" && (txt_Truong06.Text == "" && txt_Truong07.Text == "" && txt_Truong08.Text == "")) ||
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
        }

        private void txt_Truong05_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong05.Text.IndexOf('?') >= 0)
                txt_Truong05.Text = "?";
            if ((txt_Truong05.Text.Length < 2 || txt_Truong05.Text.Length > 3) && txt_Truong05.Text != "" && txt_Truong05.Text != "?" && txt_Truong05.Text.IndexOf('●') < 0)
            {
                txt_Truong05.BackColor = Color.Red;
                txt_Truong05.ForeColor = Color.White;
            }
            else
            {
                txt_Truong05.BackColor = Color.White;
                txt_Truong05.ForeColor = Color.Black;
            }
        }

        private void txt_Truong06_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong06.Text.IndexOf('?') >= 0)
                txt_Truong06.Text = "?";
        }

        private void txt_Truong07_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong07.Text.IndexOf('?') >= 0)
                txt_Truong07.Text = "?";
        }
        private void txt_Truong85_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong85.Text.IndexOf('?') >= 0)
                txt_Truong85.Text = "?";
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
        private void chk_qc_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txt_Truong08_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void txt_Truong86_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong85.Text.IndexOf('?') >= 0)
                txt_Truong85.Text = "?";
        }

        public void LoadData(tbl_DeSo_Backup data)
        {
            lb_user.Text = data.UserName;
            txt_Truong02.Text = data.Truong_02;
            txt_Truong05.Text = data.Truong_05;
            txt_Truong06.Text = data.Truong_06;
            txt_Truong07.Text = data.Truong_07;
            txt_Truong08.EditValue = data.Truong_08;
            if (data.Truong_03.Length > 6)
            {
                txt_Truong03_1.Text = data.Truong_03?.Substring(0, 6);
                txt_Truong03_2.Text = data.Truong_03?.Substring(6, data.Truong_03.Length - 6);
            }
            else
            {
                txt_Truong03_1.Text = string.IsNullOrEmpty(data.Truong_03) ? "" : data.Truong_03;
                txt_Truong03_2.Text = "";
            }
            txt_Truong85.Text = data.Truong_85;
            txt_Truong86.Text = data.Truong_86;
            txt_Truong0.Text = data.Truong_0;
            if (data.CheckQC != null) chk_qc.Checked = data.CheckQC.Value;
        }

        public void LoadDataChecker(tbl_DeSo data)
        {
            lb_user.Text = data.UserName;
            txt_Truong02.Text = data.Truong_02;
            txt_Truong05.Text = data.Truong_05;
            txt_Truong06.Text = data.Truong_06;
            txt_Truong07.Text = data.Truong_07;
            txt_Truong08.EditValue = data.Truong_08;
            if (data.Truong_03.Length > 6)
            {
                txt_Truong03_1.Text = data.Truong_03?.Substring(0, 6);
                txt_Truong03_2.Text = data.Truong_03?.Substring(6, data.Truong_03.Length - 6);
            }
            else
            {
                txt_Truong03_1.Text = string.IsNullOrEmpty(data.Truong_03) ? "" : data.Truong_03;
                txt_Truong03_2.Text = "";
            }
            txt_Truong85.Text = data.Truong_85;
            txt_Truong86.Text = data.Truong_86;
            txt_Truong0.Text = data.Truong_0;
            if (data.CheckQC != null) chk_qc.Checked = data.CheckQC.Value;
        }
    }
}
