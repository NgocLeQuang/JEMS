using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace JEMS.MyForm
{
    public partial class frm_ExportExcel : Form
    {
        string LoaiPhieu = "";
        public frm_ExportExcel()
        {
            InitializeComponent();
        }

        private String getcharacter(int n, String str)
        {
            String kq = "";
            for (int i = 1; i <= n; i++)
            {
                kq = kq.Insert(kq.Length, str);
            }

            return kq;
        }

        private String ThemKyTubatKyPhiatruoc(String input, int iByte, string str)
        {
            if (input.Length >= iByte)
                return input.Substring(input.Length - iByte, iByte);

            return input.Insert(0, getcharacter(iByte - input.Length, str));
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cbb_Batch.Items.Clear();
            var result = from w in Global.db.tbl_Batches
                         select w.fBatchName;

            if (result.Count() > 0)
            {
                cbb_Batch.Items.AddRange(result.ToArray());
                cbb_Batch.DisplayMember = "fBatchName";
                cbb_Batch.ValueMember = "fbatchname";
                cbb_Batch.Text = Global.StrBatch;
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbb_Batch.Text))
            {
                MessageBox.Show("Chưa chọn batch.");
                return;
            }

            //Kiểm tra nhập xong chưa?

            
           
            var result = Global.db.InputFinish(cbb_Batch.Text);
            if (result == 1)
            {
                MessageBox.Show("Batch này chưa nhập xong. Vui lòng nhập xong batch trước khi ExportExcel.");
                return;
            }
        

            var userMissimage = (from w in Global.db.tbl_MissImage_DESOs where w.fBatchName == cbb_Batch.Text && w.Submit==0 select w.UserName).ToList();
            string sss = "";
            foreach (var item in userMissimage)
            {
                sss += item + "\r\n";
            }

            if (userMissimage.Count > 0)
            {
                MessageBox.Show("Những user lấy hình về nhưng không nhập: \r\n" + sss);
                return;
            }

            //Kiểm tra check xong chưa
            var xyz = Global.db.CheckerFinish(cbb_Batch.Text);

            if (xyz != 0)
            {
                MessageBox.Show("Chưa check xong hoặc có user lấy về nhưng chưa check. Vui lòng check trước");

                var u = (from w in Global.db.UserMissImagecheck(cbb_Batch.Text)
                         select w.UserName).ToList();
                string sssss = "";
                foreach (var item in u)
                {
                    sssss += item + "\r\n";
                }

                if (u.Count > 0)
                {
                    MessageBox.Show("Danh sách checker lấy hình về nhưng chưa check: \r\n" + sssss);
                }

                return;
            }
            LoaiPhieu = (from w in Global.db.tbl_Batches where w.fBatchName == cbb_Batch.Text select w.fLoaiPhieu).FirstOrDefault();
            if (LoaiPhieu == "ASAHI")
            {
                //EXport Excel ASAHI

                if (System.IO.File.Exists(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_ASAHI.xlsx"))
                {
                    System.IO.File.Delete(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_ASAHI.xlsx");
                    System.IO.File.WriteAllBytes((System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/ExportExcel_ASAHI.xlsx"), Properties.Resources.ExportExcel_ASAHI);
                }
                else
                {
                    System.IO.File.WriteAllBytes((System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/ExportExcel_ASAHI.xlsx"), Properties.Resources.ExportExcel_ASAHI);
                }
                TableToExcel_ASAHI(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_ASAHI.xlsx");

                //EXport Excel ASAHI_QC

                if (System.IO.File.Exists(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_ASAHI_QC.xlsx"))
                {
                    System.IO.File.Delete(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_ASAHI_QC.xlsx");
                    System.IO.File.WriteAllBytes((System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/ExportExcel_ASAHI_QC.xlsx"), Properties.Resources.ExportExcel_ASAHI);
                }
                else
                {
                    System.IO.File.WriteAllBytes((System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/ExportExcel_ASAHI_QC.xlsx"), Properties.Resources.ExportExcel_ASAHI);
                }
                TableToExcel_ASAHI_QC(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_ASAHI_QC.xlsx");
            }


            else if (LoaiPhieu == "EIZEN")
            {
                //EXport Excel EIZEN

                if (System.IO.File.Exists(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_EIZEN.xlsx"))
                {
                    System.IO.File.Delete(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_EIZEN.xlsx");
                    System.IO.File.WriteAllBytes((System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/ExportExcel_EIZEN.xlsx"), Properties.Resources.ExportExcel_EIZEN);
                }
                else
                {
                    System.IO.File.WriteAllBytes((System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/ExportExcel_EIZEN.xlsx"), Properties.Resources.ExportExcel_EIZEN);
                }
                TableToExcel_EIZEN(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_EIZEN.xlsx");

                //EXport Excel EIZEN_QC

                if (System.IO.File.Exists(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_EIZEN_QC.xlsx"))
                {
                    System.IO.File.Delete(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_EIZEN_QC.xlsx");
                    System.IO.File.WriteAllBytes((System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/ExportExcel_EIZEN_QC.xlsx"), Properties.Resources.ExportExcel_EIZEN);
                }
                else
                {
                    System.IO.File.WriteAllBytes((System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/ExportExcel_EIZEN_QC.xlsx"), Properties.Resources.ExportExcel_EIZEN);
                }
                TableToExcel_ASAHI_QC(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_EIZEN_QC.xlsx");
            }
        }

        public bool TableToExcel_ASAHI(String strfilename)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Global.db.ExportExcel_ASAHI(cbb_Batch.Text);
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Microsoft.Office.Interop.Excel.Sheets _sheet = (Microsoft.Office.Interop.Excel.Sheets)book.Sheets;
                Microsoft.Office.Interop.Excel.Worksheet wrksheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
                int h = 3;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {


                    wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString() : "";   //tên ảnh
                    wrksheet.Cells[h, 2] = dr.Cells[1].Value != null ? dr.Cells[1].Value.ToString() : "";   //truong 02
                    wrksheet.Cells[h, 3] = dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : "";    //03
                    wrksheet.Cells[h, 5] = dr.Cells[3].Value != null ? dr.Cells[3].Value.ToString() : "";   //05
                    wrksheet.Cells[h, 6] = dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : "";   //06
                    wrksheet.Cells[h, 8] = dr.Cells[5].Value != null ? dr.Cells[5].Value.ToString() : "";   //08
                    wrksheet.Cells[h, 85] = dr.Cells[6].Value != null ? dr.Cells[6].Value.ToString() : "";  //85

                    lb_SoDong.Text = (h - 2).ToString() + "/" + dataGridView1.Rows.Count.ToString();
                    Range rowHead = wrksheet.get_Range("A3", "CG" + h);
                    rowHead.Borders.LineStyle = Constants.xlSolid;
                    h++;
                }
                string savePath = "";
                saveFileDialog1.Title = "Save Excel Files";
                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls";
                saveFileDialog1.FileName = cbb_Batch.Text;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    book.SaveCopyAs(saveFileDialog1.FileName);
                    book.Saved = true;
                    savePath = Path.GetDirectoryName(saveFileDialog1.FileName);
                    App.Quit();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xuất excel!");
                    return false;
                }
                Process.Start(savePath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }          
        }

        public bool TableToExcel_ASAHI_QC(String strfilename)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Global.db.ExportExcel_ASAHI_QC(cbb_Batch.Text);
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Microsoft.Office.Interop.Excel.Sheets _sheet = (Microsoft.Office.Interop.Excel.Sheets)book.Sheets;
                Microsoft.Office.Interop.Excel.Worksheet wrksheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
                int h = 3;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {

                    wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString() : "";   //tên ảnh
                    wrksheet.Cells[h, 2] = dr.Cells[1].Value != null ? dr.Cells[1].Value.ToString() : "";   //truong 02
                    wrksheet.Cells[h, 3] = dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : "";    //03
                    wrksheet.Cells[h, 5] = dr.Cells[3].Value != null ? dr.Cells[3].Value.ToString() : "";   //05
                    wrksheet.Cells[h, 6] = dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : "";   //06
                    wrksheet.Cells[h, 8] = dr.Cells[5].Value != null ? dr.Cells[5].Value.ToString() : "";   //08
                    wrksheet.Cells[h, 85] = dr.Cells[6].Value != null ? dr.Cells[6].Value.ToString() : "";  //85

                    lb_SoDong.Text = (h - 2).ToString() + "/" + dataGridView1.Rows.Count.ToString();
                    Range rowHead = wrksheet.get_Range("A3", "CG" + h);
                    rowHead.Borders.LineStyle = Constants.xlSolid;
                    h++;
                }
                string savePath = "";
                saveFileDialog1.Title = "Save Excel Files";
                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls";
                saveFileDialog1.FileName = cbb_Batch.Text+"_QC";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    book.SaveCopyAs(saveFileDialog1.FileName);
                    book.Saved = true;
                    savePath = Path.GetDirectoryName(saveFileDialog1.FileName);
                    App.Quit();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xuất excel!");
                    return false;
                }
                Process.Start(savePath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool TableToExcel_EIZEN(String strfilename)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Global.db.ExportExcel_ASAHI(cbb_Batch.Text);
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Microsoft.Office.Interop.Excel.Sheets _sheet = (Microsoft.Office.Interop.Excel.Sheets)book.Sheets;
                Microsoft.Office.Interop.Excel.Worksheet wrksheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
                int h = 3;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {


                    wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString() : "";   //tên ảnh
                    wrksheet.Cells[h, 2] = dr.Cells[1].Value != null ? dr.Cells[1].Value.ToString() : "";   //truong 02
                    wrksheet.Cells[h, 3] = dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : "";    //03
                    wrksheet.Cells[h, 5] = dr.Cells[3].Value != null ? dr.Cells[3].Value.ToString() : "";   //05
                    wrksheet.Cells[h, 6] = dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : "";   //06
                    wrksheet.Cells[h, 8] = dr.Cells[5].Value != null ? dr.Cells[5].Value.ToString() : "";   //08
                    wrksheet.Cells[h, 85] = dr.Cells[6].Value != null ? dr.Cells[6].Value.ToString() : "";  //85

                    lb_SoDong.Text = (h - 2).ToString() + "/" + dataGridView1.Rows.Count.ToString();
                    Range rowHead = wrksheet.get_Range("A3", "CG" + h);
                    rowHead.Borders.LineStyle = Constants.xlSolid;
                    h++;
                }
                string savePath = "";
                saveFileDialog1.Title = "Save Excel Files";
                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls";
                saveFileDialog1.FileName = cbb_Batch.Text;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    book.SaveCopyAs(saveFileDialog1.FileName);
                    book.Saved = true;
                    savePath = Path.GetDirectoryName(saveFileDialog1.FileName);
                    App.Quit();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xuất excel!");
                    return false;
                }
                Process.Start(savePath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
