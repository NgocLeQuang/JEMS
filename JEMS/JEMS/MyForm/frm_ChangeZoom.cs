using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace JEMS.MyForm
{
    public partial class frm_ChangeZoom : DevExpress.XtraEditors.XtraForm
    {
        public frm_ChangeZoom()
        {
            InitializeComponent();
        }

        private void frm_ChangeZoom_Load(object sender, EventArgs e)
        {
            trackBarControl1.EditValue = Properties.Settings.Default.ZoomImage;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ZoomImage = Convert.ToInt32(trackBarControl1.EditValue);
            MessageBox.Show("Thay đổi Zoom thành công!");
            this.Close();
        }
    }
}