using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
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

                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_ASAHI.xlsx"))
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_ASAHI.xlsx");
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_ASAHI.xlsx"), Properties.Resources.ExportExcel_ASAHI);
                }
                else
                {
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_ASAHI.xlsx"), Properties.Resources.ExportExcel_ASAHI);
                }
                TableToExcel_ASAHI(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_ASAHI.xlsx");

                //EXport Excel ASAHI_QC

                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_ASAHI_QC.xlsx"))
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_ASAHI_QC.xlsx");
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_ASAHI_QC.xlsx"), Properties.Resources.ExportExcel_ASAHI);
                }
                else
                {
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_ASAHI_QC.xlsx"), Properties.Resources.ExportExcel_ASAHI);
                }
                TableToExcel_ASAHI_QC(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_ASAHI_QC.xlsx");
            }

            if (LoaiPhieu == "EIZEN")
            {
                //EXport Excel EIZEN

                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_EIZEN.xlsx"))
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_EIZEN.xlsx");
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_EIZEN.xlsx"), Properties.Resources.ExportExcel_EIZEN);
                }
                else
                {
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_EIZEN.xlsx"), Properties.Resources.ExportExcel_EIZEN);
                }
                TableToExcel_EIZEN(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_EIZEN.xlsx");

                //EXport Excel EIZEN_QC

                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_EIZEN_QC.xlsx"))
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_EIZEN_QC.xlsx");
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_EIZEN_QC.xlsx"), Properties.Resources.ExportExcel_EIZEN);
                }
                else
                {
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_EIZEN_QC.xlsx"), Properties.Resources.ExportExcel_EIZEN);
                }
                TableToExcel_EIZEN_QC(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_EIZEN_QC.xlsx");
            }

            else if (LoaiPhieu == "YAMAMOTO")
            {
                //EXport Excel YAMAMOTO

                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_YAMAMOTO.xlsx"))
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_YAMAMOTO.xlsx");
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_YAMAMOTO.xlsx"), Properties.Resources.ExportExcel_YAMAMOTO);
                }
                else
                {
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_YAMAMOTO.xlsx"), Properties.Resources.ExportExcel_YAMAMOTO);
                }
                TableToExcel_YAMAMOTO(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_YAMAMOTO.xlsx");

                //EXport Excel YAMAMOTO_QC

                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_YAMAMOTO_QC.xlsx"))
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_YAMAMOTO_QC.xlsx");
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_YAMAMOTO_QC.xlsx"), Properties.Resources.ExportExcel_YAMAMOTO);
                }
                else
                {
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_YAMAMOTO_QC.xlsx"), Properties.Resources.ExportExcel_YAMAMOTO);
                }
                TableToExcel_YAMAMOTO_QC(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_YAMAMOTO_QC.xlsx");
            }

            else if (LoaiPhieu == "YASUDA")
            {
                //EXport Excel YASUDA

                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_YASUDA.xlsx"))
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_YASUDA.xlsx");
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_YASUDA.xlsx"), Properties.Resources.ExportExcel_YASUDA);
                }
                else
                {
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_YASUDA.xlsx"), Properties.Resources.ExportExcel_YASUDA);
                }
                TableToExcel_YASUDA(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_YASUDA.xlsx");

                //EXport Excel YASUDA_QC

                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_YASUDA_QC.xlsx"))
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_YASUDA_QC.xlsx");
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_YASUDA_QC.xlsx"), Properties.Resources.ExportExcel_YASUDA);
                }
                else
                {
                    File.WriteAllBytes((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExportExcel_YASUDA_QC.xlsx"), Properties.Resources.ExportExcel_YASUDA);
                }
                TableToExcel_YASUDA_QC(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExportExcel_YASUDA_QC.xlsx");
            }

        }

        public bool TableToExcel_ASAHI(String strfilename)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Global.db.ExportExcel_ASAHI(cbb_Batch.Text);
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Sheets _sheet = book.Sheets;
                Worksheet wrksheet = (Worksheet)book.ActiveSheet;
                int h = 3;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    int ii = Convert.ToInt32(dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().IndexOf(".").ToString() : "0");
                    wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().Substring(0, ii) : "";  //tên ảnh
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
                Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Sheets _sheet = book.Sheets;
                Worksheet wrksheet = (Worksheet)book.ActiveSheet;
                int h = 3;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    int ii = Convert.ToInt32(dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().IndexOf(".").ToString() : "0");
                    wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().Substring(0, ii) : "";   //tên ảnh
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
                dataGridView1.DataSource = Global.db.ExportExcel_EIZEN(cbb_Batch.Text);
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Sheets _sheet = book.Sheets;
                Worksheet wrksheet = (Worksheet)book.ActiveSheet;
                int h = 3;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {

                    int ii = Convert.ToInt32(dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().IndexOf(".").ToString() : "0");
                    wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().Substring(0,ii): "";    //tên ảnh
                    wrksheet.Cells[h, 2] = dr.Cells[1].Value != null ? dr.Cells[1].Value.ToString() : "";   //truong 02
                    wrksheet.Cells[h, 3] = dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : "";    //03
                    wrksheet.Cells[h, 5] = dr.Cells[3].Value != null ? dr.Cells[3].Value.ToString() : "";   //05
                    wrksheet.Cells[h, 6] = dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : "";   //06
                    wrksheet.Cells[h, 7] = dr.Cells[5].Value != null ? dr.Cells[5].Value.ToString() : "";   //07
                    wrksheet.Cells[h, 8] = dr.Cells[6].Value != null ? dr.Cells[6].Value.ToString() : "";   //08
                    wrksheet.Cells[h, 85] = dr.Cells[7].Value != null ? dr.Cells[7].Value.ToString() : "";  //85

                    string Truong_86="";
                    if(!string.IsNullOrEmpty(dr.Cells[8].Value != null ? dr.Cells[8].Value.ToString() : ""))
                    {
                        for (int i = 0; i < dr.Cells[8].Value.ToString().Length; i++)
                        {
                            string temp = dr.Cells[8].Value.ToString().Substring(i, 1);
                            if (i < dr.Cells[8].Value.ToString().Length - 1)
                            {
                                switch (temp)
                                {
                                    case "F":
                                        Truong_86 += "廃プラ" + "、";
                                        break;
                                    case "G":
                                        Truong_86 += "紙くず" + "、";
                                        break;
                                    case "H":
                                        Truong_86 += "木くず" + "、";
                                        break;
                                    case "I":
                                        Truong_86 += "繊維くず" + "、";
                                        break;
                                    case "J":
                                        Truong_86 += "動物性残渣" + "、";
                                        break;
                                    case "K":
                                        Truong_86 += "ゴムくず" + "、";
                                        break;
                                    case "L":
                                        Truong_86 += "金属くず" + "、";
                                        break;
                                    case "M":
                                        Truong_86 += "ガラコン陶" + "、";
                                        break;
                                    case "O":
                                        Truong_86 += "瓦礫類" + "、";
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                switch (temp)
                                {
                                    case "F":
                                        Truong_86 += "廃プラ";
                                        break;
                                    case "G":
                                        Truong_86 += "紙くず";
                                        break;
                                    case "H":
                                        Truong_86 += "木くず";
                                        break;
                                    case "I":
                                        Truong_86 += "繊維くず";
                                        break;
                                    case "J":
                                        Truong_86 += "動物性残渣";
                                        break;
                                    case "K":
                                        Truong_86 += "ゴムくず";
                                        break;
                                    case "L":
                                        Truong_86 += "金属くず";
                                        break;
                                    case "M":
                                        Truong_86 += "ガラコン陶";
                                        break;
                                    case "O":
                                        Truong_86 += "瓦礫類";
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }

                    wrksheet.Cells[h, 86] = Truong_86;  //86

                    lb_SoDong.Text = (h - 2).ToString() + "/" + dataGridView1.Rows.Count.ToString();
                    Range rowHead = wrksheet.get_Range("A3", "CH" + h);
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

        public bool TableToExcel_EIZEN_QC(String strfilename)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Global.db.ExportExcel_EIZEN_QC(cbb_Batch.Text);
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Sheets _sheet = book.Sheets;
                Worksheet wrksheet = (Worksheet)book.ActiveSheet;
                int h = 3;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {

                    int ii = Convert.ToInt32(dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().IndexOf(".").ToString() : "0");
                    wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().Substring(0, ii) : "";   //tên ảnh
                    wrksheet.Cells[h, 2] = dr.Cells[1].Value != null ? dr.Cells[1].Value.ToString() : "";   //truong 02
                    wrksheet.Cells[h, 3] = dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : "";    //03
                    wrksheet.Cells[h, 5] = dr.Cells[3].Value != null ? dr.Cells[3].Value.ToString() : "";   //05
                    wrksheet.Cells[h, 6] = dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : "";   //06
                    wrksheet.Cells[h, 7] = dr.Cells[5].Value != null ? dr.Cells[5].Value.ToString() : "";   //07
                    wrksheet.Cells[h, 8] = dr.Cells[6].Value != null ? dr.Cells[6].Value.ToString() : "";   //08
                    wrksheet.Cells[h, 85] = dr.Cells[7].Value != null ? dr.Cells[7].Value.ToString() : "";  //85
                    string Truong_86 = "";
                    if (!string.IsNullOrEmpty(dr.Cells[8].Value != null ? dr.Cells[8].Value.ToString() : ""))
                    {
                        for (int i = 0; i < dr.Cells[8].Value.ToString().Length; i++)
                        {
                            string temp = dr.Cells[8].Value.ToString().Substring(i, 1);
                            if (i < dr.Cells[8].Value.ToString().Length - 1)
                            {
                                switch (temp)
                                {
                                    case "F":
                                        Truong_86 += "廃プラ" + "、";
                                        break;
                                    case "G":
                                        Truong_86 += "紙くず" + "、";
                                        break;
                                    case "H":
                                        Truong_86 += "木くず" + "、";
                                        break;
                                    case "I":
                                        Truong_86 += "繊維くず" + "、";
                                        break;
                                    case "J":
                                        Truong_86 += "動物性残渣" + "、";
                                        break;
                                    case "K":
                                        Truong_86 += "ゴムくず" + "、";
                                        break;
                                    case "L":
                                        Truong_86 += "金属くず" + "、";
                                        break;
                                    case "M":
                                        Truong_86 += "ガラコン陶" + "、";
                                        break;
                                    case "O":
                                        Truong_86 += "瓦礫類" + "、";
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                switch (temp)
                                {
                                    case "F":
                                        Truong_86 += "廃プラ";
                                        break;
                                    case "G":
                                        Truong_86 += "紙くず";
                                        break;
                                    case "H":
                                        Truong_86 += "木くず";
                                        break;
                                    case "I":
                                        Truong_86 += "繊維くず";
                                        break;
                                    case "J":
                                        Truong_86 += "動物性残渣";
                                        break;
                                    case "K":
                                        Truong_86 += "ゴムくず";
                                        break;
                                    case "L":
                                        Truong_86 += "金属くず";
                                        break;
                                    case "M":
                                        Truong_86 += "ガラコン陶";
                                        break;
                                    case "O":
                                        Truong_86 += "瓦礫類";
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                    wrksheet.Cells[h, 86] = Truong_86;  //86

                    lb_SoDong.Text = (h - 2).ToString() + "/" + dataGridView1.Rows.Count.ToString();
                    Range rowHead = wrksheet.get_Range("A3", "CH" + h);
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

        public bool TableToExcel_YAMAMOTO(String strfilename)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Global.db.ExportExcel_YAMAMOTO(cbb_Batch.Text);
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Sheets _sheet = book.Sheets;
                Worksheet wrksheet = (Worksheet)book.ActiveSheet;
                int h = 3;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    int ii = Convert.ToInt32(dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().IndexOf(".").ToString() : "0");
                    wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().Substring(0, ii) : "";   //tên ảnh
                    wrksheet.Cells[h, 2] = dr.Cells[1].Value != null ? dr.Cells[1].Value.ToString() : "";   //truong 02
                    wrksheet.Cells[h, 3] = dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : "";    //03
                    wrksheet.Cells[h, 5] = dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : "";   //05
                    wrksheet.Cells[h, 6] = dr.Cells[5].Value != null ? dr.Cells[5].Value.ToString() : "";   //06
                    wrksheet.Cells[h, 7] = dr.Cells[6].Value != null ? dr.Cells[6].Value.ToString() : "";   //07
                    wrksheet.Cells[h, 8] = dr.Cells[7].Value != null ? dr.Cells[7].Value.ToString() : "";   //08


                    wrksheet.Cells[h, 13] = dr.Cells[12].Value != null ? dr.Cells[12].Value.ToString() : "";   
                    wrksheet.Cells[h, 14] = dr.Cells[13].Value != null ? dr.Cells[13].Value.ToString() : "";   
                    wrksheet.Cells[h, 15] = dr.Cells[14].Value != null ? dr.Cells[14].Value.ToString() : "";   
                    wrksheet.Cells[h, 16] = dr.Cells[15].Value != null ? dr.Cells[15].Value.ToString() : "";

                    wrksheet.Cells[h, 21] = dr.Cells[20].Value != null ? dr.Cells[20].Value.ToString() : "";
                    wrksheet.Cells[h, 22] = dr.Cells[21].Value != null ? dr.Cells[21].Value.ToString() : "";
                    wrksheet.Cells[h, 23] = dr.Cells[22].Value != null ? dr.Cells[22].Value.ToString() : "";
                    wrksheet.Cells[h, 24] = dr.Cells[23].Value != null ? dr.Cells[23].Value.ToString() : "";


                    wrksheet.Cells[h, 29] = dr.Cells[28].Value != null ? dr.Cells[28].Value.ToString() : "";
                    wrksheet.Cells[h, 30] = dr.Cells[29].Value != null ? dr.Cells[29].Value.ToString() : "";
                    wrksheet.Cells[h, 31] = dr.Cells[30].Value != null ? dr.Cells[30].Value.ToString() : "";
                    wrksheet.Cells[h, 32] = dr.Cells[31].Value != null ? dr.Cells[31].Value.ToString() : "";

                    wrksheet.Cells[h, 37] = dr.Cells[36].Value != null ? dr.Cells[36].Value.ToString() : "";
                    wrksheet.Cells[h, 38] = dr.Cells[37].Value != null ? dr.Cells[37].Value.ToString() : "";
                    wrksheet.Cells[h, 39] = dr.Cells[38].Value != null ? dr.Cells[38].Value.ToString() : "";
                    wrksheet.Cells[h, 40] = dr.Cells[39].Value != null ? dr.Cells[39].Value.ToString() : "";

                    wrksheet.Cells[h, 45] = dr.Cells[44].Value != null ? dr.Cells[44].Value.ToString() : "";
                    wrksheet.Cells[h, 46] = dr.Cells[45].Value != null ? dr.Cells[45].Value.ToString() : "";
                    wrksheet.Cells[h, 47] = dr.Cells[46].Value != null ? dr.Cells[46].Value.ToString() : "";
                    wrksheet.Cells[h, 48] = dr.Cells[47].Value != null ? dr.Cells[47].Value.ToString() : "";
                     

                    wrksheet.Cells[h, 53] = dr.Cells[52].Value != null ? dr.Cells[52].Value.ToString() : "";
                    wrksheet.Cells[h, 54] = dr.Cells[53].Value != null ? dr.Cells[53].Value.ToString() : "";
                    wrksheet.Cells[h, 55] = dr.Cells[54].Value != null ? dr.Cells[54].Value.ToString() : "";
                    wrksheet.Cells[h, 56] = dr.Cells[55].Value != null ? dr.Cells[55].Value.ToString() : "";
                
                    wrksheet.Cells[h, 61] = dr.Cells[60].Value != null ? dr.Cells[60].Value.ToString() : "";
                    wrksheet.Cells[h, 62] = dr.Cells[61].Value != null ? dr.Cells[61].Value.ToString() : "";
                    wrksheet.Cells[h, 63] = dr.Cells[62].Value != null ? dr.Cells[62].Value.ToString() : "";
                    wrksheet.Cells[h, 64] = dr.Cells[63].Value != null ? dr.Cells[63].Value.ToString() : "";


                    wrksheet.Cells[h, 69] = dr.Cells[68].Value != null ? dr.Cells[68].Value.ToString() : "";
                    wrksheet.Cells[h, 70] = dr.Cells[69].Value != null ? dr.Cells[69].Value.ToString() : "";
                    wrksheet.Cells[h, 71] = dr.Cells[70].Value != null ? dr.Cells[70].Value.ToString() : "";
                    wrksheet.Cells[h, 72] = dr.Cells[71].Value != null ? dr.Cells[71].Value.ToString() : "";


                    wrksheet.Cells[h, 77] = dr.Cells[76].Value != null ? dr.Cells[76].Value.ToString() : "";
                    wrksheet.Cells[h, 78] = dr.Cells[77].Value != null ? dr.Cells[77].Value.ToString() : "";
                    wrksheet.Cells[h, 79] = dr.Cells[78].Value != null ? dr.Cells[78].Value.ToString() : "";
                    wrksheet.Cells[h, 80] = dr.Cells[79].Value != null ? dr.Cells[79].Value.ToString() : "";


                    wrksheet.Cells[h, 85] = dr.Cells[84].Value != null ? dr.Cells[84].Value.ToString() : "";  //85

                    string Truong_86 = "";
                    if (!string.IsNullOrEmpty(dr.Cells[85].Value != null ? dr.Cells[85].Value.ToString() : ""))
                    {
                        for (int i = 0; i < dr.Cells[85].Value.ToString().Length; i++)
                        {
                            string temp = dr.Cells[85].Value.ToString().Substring(i, 1);
                            if (i < dr.Cells[85].Value.ToString().Length - 1)
                            {
                                switch (temp)
                                {
                                    case "A":
                                        Truong_86 += "燃え殻" + "、";
                                        break;
                                    case "B":
                                        Truong_86 += "汚泥" + "、";
                                        break;
                                    case "C":
                                        Truong_86 += "廃油" + "、";
                                        break;
                                    case "D":
                                        Truong_86 += "廃酸" + "、";
                                        break;
                                    case "E":
                                        Truong_86 += "廃アルカリ" + "、";
                                        break;
                                    case "F":
                                        Truong_86 += "廃プラ" + "、";
                                        break;
                                    case "G":
                                        Truong_86 += "紙くず" + "、";
                                        break;
                                    case "H":
                                        Truong_86 += "木くず" + "、";
                                        break;
                                    case "I":
                                        Truong_86 += "繊維くず" + "、";
                                        break;
                                    case "J":
                                        Truong_86 += "動物性残渣" + "、";
                                        break;
                                    case "K":
                                        Truong_86 += "ゴムくず" + "、";
                                        break;
                                    case "L":
                                        Truong_86 += "金属くず" + "、";
                                        break;
                                    case "M":
                                        Truong_86 += "ガラコン陶" + "、";
                                        break;
                                    case "N":
                                        Truong_86 += "鉱さい" + "、";
                                        break;
                                    case "O":
                                        Truong_86 += "瓦礫類" + "、";
                                        break;
                                    case "P":
                                        Truong_86 += "動物の糞尿" + "、";
                                        break;
                                    case "Q":
                                        Truong_86 += "動物の死体" + "、";
                                        break;
                                    case "R":
                                        Truong_86 += "ばいじん" + "、";
                                        break;
                                    case "S":
                                        Truong_86 += "動物性不要物" + "、";
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                switch (temp)
                                {
                                    case "A":
                                        Truong_86 += "燃え殻";
                                        break;
                                    case "B":
                                        Truong_86 += "汚泥";
                                        break;
                                    case "C":
                                        Truong_86 += "廃油";
                                        break;
                                    case "D":
                                        Truong_86 += "廃酸";
                                        break;
                                    case "E":
                                        Truong_86 += "廃アルカリ";
                                        break;
                                    case "F":
                                        Truong_86 += "廃プラ";
                                        break;
                                    case "G":
                                        Truong_86 += "紙くず";
                                        break;
                                    case "H":
                                        Truong_86 += "木くず";
                                        break;
                                    case "I":
                                        Truong_86 += "繊維くず";
                                        break;
                                    case "J":
                                        Truong_86 += "動物性残渣";
                                        break;
                                    case "K":
                                        Truong_86 += "ゴムくず";
                                        break;
                                    case "L":
                                        Truong_86 += "金属くず";
                                        break;
                                    case "M":
                                        Truong_86 += "ガラコン陶";
                                        break;
                                    case "N":
                                        Truong_86 += "鉱さい";
                                        break;
                                    case "O":
                                        Truong_86 += "瓦礫類";
                                        break;
                                    case "P":
                                        Truong_86 += "動物の糞尿";
                                        break;
                                    case "Q":
                                        Truong_86 += "動物の死体";
                                        break;
                                    case "R":
                                        Truong_86 += "ばいじん";
                                        break;
                                    case "S":
                                        Truong_86 += "動物性不要物";
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }

                    wrksheet.Cells[h, 86] = Truong_86;  //86

                    lb_SoDong.Text = (h - 2).ToString() + "/" + dataGridView1.Rows.Count.ToString();
                    Range rowHead = wrksheet.get_Range("A3", "CH" + h);
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

        public bool TableToExcel_YAMAMOTO_QC(String strfilename)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Global.db.ExportExcel_YAMAMOTO_QC(cbb_Batch.Text);
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Sheets _sheet = book.Sheets;
                Worksheet wrksheet = (Worksheet)book.ActiveSheet;
                int h = 3;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {

                    int ii = Convert.ToInt32(dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().IndexOf(".").ToString() : "0");
                    wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().Substring(0, ii) : "";    //tên ảnh
                    wrksheet.Cells[h, 2] = dr.Cells[1].Value != null ? dr.Cells[1].Value.ToString() : "";   //truong 02
                    wrksheet.Cells[h, 3] = dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : "";    //03
                    wrksheet.Cells[h, 5] = dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : "";   //05
                    wrksheet.Cells[h, 6] = dr.Cells[5].Value != null ? dr.Cells[5].Value.ToString() : "";   //06
                    wrksheet.Cells[h, 7] = dr.Cells[6].Value != null ? dr.Cells[6].Value.ToString() : "";   //07
                    wrksheet.Cells[h, 8] = dr.Cells[7].Value != null ? dr.Cells[7].Value.ToString() : "";   //08


                    wrksheet.Cells[h, 13] = dr.Cells[12].Value != null ? dr.Cells[12].Value.ToString() : "";
                    wrksheet.Cells[h, 14] = dr.Cells[13].Value != null ? dr.Cells[13].Value.ToString() : "";
                    wrksheet.Cells[h, 15] = dr.Cells[14].Value != null ? dr.Cells[14].Value.ToString() : "";
                    wrksheet.Cells[h, 16] = dr.Cells[15].Value != null ? dr.Cells[15].Value.ToString() : "";

                    wrksheet.Cells[h, 21] = dr.Cells[20].Value != null ? dr.Cells[20].Value.ToString() : "";
                    wrksheet.Cells[h, 22] = dr.Cells[21].Value != null ? dr.Cells[21].Value.ToString() : "";
                    wrksheet.Cells[h, 23] = dr.Cells[22].Value != null ? dr.Cells[22].Value.ToString() : "";
                    wrksheet.Cells[h, 24] = dr.Cells[23].Value != null ? dr.Cells[23].Value.ToString() : "";


                    wrksheet.Cells[h, 29] = dr.Cells[28].Value != null ? dr.Cells[28].Value.ToString() : "";
                    wrksheet.Cells[h, 30] = dr.Cells[29].Value != null ? dr.Cells[29].Value.ToString() : "";
                    wrksheet.Cells[h, 31] = dr.Cells[30].Value != null ? dr.Cells[30].Value.ToString() : "";
                    wrksheet.Cells[h, 32] = dr.Cells[31].Value != null ? dr.Cells[31].Value.ToString() : "";

                    wrksheet.Cells[h, 37] = dr.Cells[36].Value != null ? dr.Cells[36].Value.ToString() : "";
                    wrksheet.Cells[h, 38] = dr.Cells[37].Value != null ? dr.Cells[37].Value.ToString() : "";
                    wrksheet.Cells[h, 39] = dr.Cells[38].Value != null ? dr.Cells[38].Value.ToString() : "";
                    wrksheet.Cells[h, 40] = dr.Cells[39].Value != null ? dr.Cells[39].Value.ToString() : "";

                    wrksheet.Cells[h, 45] = dr.Cells[44].Value != null ? dr.Cells[44].Value.ToString() : "";
                    wrksheet.Cells[h, 46] = dr.Cells[45].Value != null ? dr.Cells[45].Value.ToString() : "";
                    wrksheet.Cells[h, 47] = dr.Cells[46].Value != null ? dr.Cells[46].Value.ToString() : "";
                    wrksheet.Cells[h, 48] = dr.Cells[47].Value != null ? dr.Cells[47].Value.ToString() : "";


                    wrksheet.Cells[h, 53] = dr.Cells[52].Value != null ? dr.Cells[52].Value.ToString() : "";
                    wrksheet.Cells[h, 54] = dr.Cells[53].Value != null ? dr.Cells[53].Value.ToString() : "";
                    wrksheet.Cells[h, 55] = dr.Cells[54].Value != null ? dr.Cells[54].Value.ToString() : "";
                    wrksheet.Cells[h, 56] = dr.Cells[55].Value != null ? dr.Cells[55].Value.ToString() : "";

                    wrksheet.Cells[h, 61] = dr.Cells[60].Value != null ? dr.Cells[60].Value.ToString() : "";
                    wrksheet.Cells[h, 62] = dr.Cells[61].Value != null ? dr.Cells[61].Value.ToString() : "";
                    wrksheet.Cells[h, 63] = dr.Cells[62].Value != null ? dr.Cells[62].Value.ToString() : "";
                    wrksheet.Cells[h, 64] = dr.Cells[63].Value != null ? dr.Cells[63].Value.ToString() : "";


                    wrksheet.Cells[h, 69] = dr.Cells[68].Value != null ? dr.Cells[68].Value.ToString() : "";
                    wrksheet.Cells[h, 70] = dr.Cells[69].Value != null ? dr.Cells[69].Value.ToString() : "";
                    wrksheet.Cells[h, 71] = dr.Cells[70].Value != null ? dr.Cells[70].Value.ToString() : "";
                    wrksheet.Cells[h, 72] = dr.Cells[71].Value != null ? dr.Cells[71].Value.ToString() : "";


                    wrksheet.Cells[h, 77] = dr.Cells[76].Value != null ? dr.Cells[76].Value.ToString() : "";
                    wrksheet.Cells[h, 78] = dr.Cells[77].Value != null ? dr.Cells[77].Value.ToString() : "";
                    wrksheet.Cells[h, 79] = dr.Cells[78].Value != null ? dr.Cells[78].Value.ToString() : "";
                    wrksheet.Cells[h, 80] = dr.Cells[79].Value != null ? dr.Cells[79].Value.ToString() : "";


                    wrksheet.Cells[h, 85] = dr.Cells[84].Value != null ? dr.Cells[84].Value.ToString() : "";  //85
                    
                    string Truong_86 = "";
                    if (!string.IsNullOrEmpty(dr.Cells[85].Value != null ? dr.Cells[85].Value.ToString() : ""))
                    {
                        for (int i = 0; i < dr.Cells[85].Value.ToString().Length; i++)
                        {
                            string temp = dr.Cells[85].Value.ToString().Substring(i, 1);
                            if (i < dr.Cells[85].Value.ToString().Length - 1)
                            {
                                switch (temp)
                                {
                                    case "A":
                                        Truong_86 += "燃え殻" + "、";
                                        break;
                                    case "B":
                                        Truong_86 += "汚泥" + "、";
                                        break;
                                    case "C":
                                        Truong_86 += "廃油" + "、";
                                        break;
                                    case "D":
                                        Truong_86 += "廃酸" + "、";
                                        break;
                                    case "E":
                                        Truong_86 += "廃アルカリ" + "、";
                                        break;
                                    case "F":
                                        Truong_86 += "廃プラ" + "、";
                                        break;
                                    case "G":
                                        Truong_86 += "紙くず" + "、";
                                        break;
                                    case "H":
                                        Truong_86 += "木くず" + "、";
                                        break;
                                    case "I":
                                        Truong_86 += "繊維くず" + "、";
                                        break;
                                    case "J":
                                        Truong_86 += "動物性残渣" + "、";
                                        break;
                                    case "K":
                                        Truong_86 += "ゴムくず" + "、";
                                        break;
                                    case "L":
                                        Truong_86 += "金属くず" + "、";
                                        break;
                                    case "M":
                                        Truong_86 += "ガラコン陶" + "、";
                                        break;
                                    case "N":
                                        Truong_86 += "鉱さい" + "、";
                                        break;
                                    case "O":
                                        Truong_86 += "瓦礫類" + "、";
                                        break;
                                    case "P":
                                        Truong_86 += "動物の糞尿" + "、";
                                        break;
                                    case "Q":
                                        Truong_86 += "動物の死体" + "、";
                                        break;
                                    case "R":
                                        Truong_86 += "ばいじん" + "、";
                                        break;
                                    case "S":
                                        Truong_86 += "動物性不要物" + "、";
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                switch (temp)
                                {
                                    case "A":
                                        Truong_86 += "燃え殻";
                                        break;
                                    case "B":
                                        Truong_86 += "汚泥";
                                        break;
                                    case "C":
                                        Truong_86 += "廃油";
                                        break;
                                    case "D":
                                        Truong_86 += "廃酸";
                                        break;
                                    case "E":
                                        Truong_86 += "廃アルカリ";
                                        break;
                                    case "F":
                                        Truong_86 += "廃プラ";
                                        break;
                                    case "G":
                                        Truong_86 += "紙くず";
                                        break;
                                    case "H":
                                        Truong_86 += "木くず";
                                        break;
                                    case "I":
                                        Truong_86 += "繊維くず";
                                        break;
                                    case "J":
                                        Truong_86 += "動物性残渣";
                                        break;
                                    case "K":
                                        Truong_86 += "ゴムくず";
                                        break;
                                    case "L":
                                        Truong_86 += "金属くず";
                                        break;
                                    case "M":
                                        Truong_86 += "ガラコン陶";
                                        break;
                                    case "N":
                                        Truong_86 += "鉱さい";
                                        break;
                                    case "O":
                                        Truong_86 += "瓦礫類";
                                        break;
                                    case "P":
                                        Truong_86 += "動物の糞尿";
                                        break;
                                    case "Q":
                                        Truong_86 += "動物の死体";
                                        break;
                                    case "R":
                                        Truong_86 += "ばいじん";
                                        break;
                                    case "S":
                                        Truong_86 += "動物性不要物";
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }

                    wrksheet.Cells[h, 86] = Truong_86;  //86

                    lb_SoDong.Text = (h - 2).ToString() + "/" + dataGridView1.Rows.Count.ToString();
                    Range rowHead = wrksheet.get_Range("A3", "CH" + h);
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

        public bool TableToExcel_YASUDA(String strfilename)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Global.db.ExportExcel_YAMAMOTO(cbb_Batch.Text);
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Sheets _sheet = book.Sheets;
                Worksheet wrksheet = (Worksheet)book.ActiveSheet;
                int h = 3;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {

                    int ii = Convert.ToInt32(dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().IndexOf(".").ToString() : "0");
                    wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().Substring(0, ii) : "";   //tên ảnh
                    wrksheet.Cells[h, 2] = dr.Cells[1].Value != null ? dr.Cells[1].Value.ToString() : "";   //truong 02
                    wrksheet.Cells[h, 3] = dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : "";    //03
                    wrksheet.Cells[h, 5] = dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : "";   //05
                    wrksheet.Cells[h, 6] = dr.Cells[5].Value != null ? dr.Cells[5].Value.ToString() : "";   //06
                    wrksheet.Cells[h, 7] = dr.Cells[6].Value != null ? dr.Cells[6].Value.ToString() : "";   //07
                    wrksheet.Cells[h, 8] = dr.Cells[7].Value != null ? dr.Cells[7].Value.ToString() : "";   //08


                    wrksheet.Cells[h, 12] = dr.Cells[11].Value != null ? dr.Cells[11].Value.ToString() : "";
                    wrksheet.Cells[h, 13] = dr.Cells[12].Value != null ? dr.Cells[12].Value.ToString() : "";
                    wrksheet.Cells[h, 14] = dr.Cells[13].Value != null ? dr.Cells[13].Value.ToString() : "";
                    wrksheet.Cells[h, 15] = dr.Cells[14].Value != null ? dr.Cells[14].Value.ToString() : "";
                    wrksheet.Cells[h, 16] = dr.Cells[15].Value != null ? dr.Cells[15].Value.ToString() : "";

                    wrksheet.Cells[h, 20] = dr.Cells[19].Value != null ? dr.Cells[19].Value.ToString() : "";
                    wrksheet.Cells[h, 21] = dr.Cells[20].Value != null ? dr.Cells[20].Value.ToString() : "";
                    wrksheet.Cells[h, 22] = dr.Cells[21].Value != null ? dr.Cells[21].Value.ToString() : "";
                    wrksheet.Cells[h, 23] = dr.Cells[22].Value != null ? dr.Cells[22].Value.ToString() : "";
                    wrksheet.Cells[h, 24] = dr.Cells[23].Value != null ? dr.Cells[23].Value.ToString() : "";


                    wrksheet.Cells[h, 28] = dr.Cells[27].Value != null ? dr.Cells[27].Value.ToString() : "";
                    wrksheet.Cells[h, 29] = dr.Cells[28].Value != null ? dr.Cells[28].Value.ToString() : "";
                    wrksheet.Cells[h, 30] = dr.Cells[29].Value != null ? dr.Cells[29].Value.ToString() : "";
                    wrksheet.Cells[h, 31] = dr.Cells[30].Value != null ? dr.Cells[30].Value.ToString() : "";
                    wrksheet.Cells[h, 32] = dr.Cells[31].Value != null ? dr.Cells[31].Value.ToString() : "";

                    wrksheet.Cells[h, 36] = dr.Cells[35].Value != null ? dr.Cells[35].Value.ToString() : "";
                    wrksheet.Cells[h, 37] = dr.Cells[36].Value != null ? dr.Cells[36].Value.ToString() : "";
                    wrksheet.Cells[h, 38] = dr.Cells[37].Value != null ? dr.Cells[37].Value.ToString() : "";
                    wrksheet.Cells[h, 39] = dr.Cells[38].Value != null ? dr.Cells[38].Value.ToString() : "";
                    wrksheet.Cells[h, 40] = dr.Cells[39].Value != null ? dr.Cells[39].Value.ToString() : "";

                    wrksheet.Cells[h, 44] = dr.Cells[43].Value != null ? dr.Cells[43].Value.ToString() : "";
                    wrksheet.Cells[h, 45] = dr.Cells[44].Value != null ? dr.Cells[44].Value.ToString() : "";
                    wrksheet.Cells[h, 46] = dr.Cells[45].Value != null ? dr.Cells[45].Value.ToString() : "";
                    wrksheet.Cells[h, 47] = dr.Cells[46].Value != null ? dr.Cells[46].Value.ToString() : "";
                    wrksheet.Cells[h, 48] = dr.Cells[47].Value != null ? dr.Cells[47].Value.ToString() : "";


                    wrksheet.Cells[h, 52] = dr.Cells[51].Value != null ? dr.Cells[51].Value.ToString() : "";
                    wrksheet.Cells[h, 53] = dr.Cells[52].Value != null ? dr.Cells[52].Value.ToString() : "";
                    wrksheet.Cells[h, 54] = dr.Cells[53].Value != null ? dr.Cells[53].Value.ToString() : "";
                    wrksheet.Cells[h, 55] = dr.Cells[54].Value != null ? dr.Cells[54].Value.ToString() : "";
                    wrksheet.Cells[h, 56] = dr.Cells[55].Value != null ? dr.Cells[55].Value.ToString() : "";

                    wrksheet.Cells[h, 60] = dr.Cells[59].Value != null ? dr.Cells[59].Value.ToString() : "";
                    wrksheet.Cells[h, 61] = dr.Cells[60].Value != null ? dr.Cells[60].Value.ToString() : "";
                    wrksheet.Cells[h, 62] = dr.Cells[61].Value != null ? dr.Cells[61].Value.ToString() : "";
                    wrksheet.Cells[h, 63] = dr.Cells[62].Value != null ? dr.Cells[62].Value.ToString() : "";
                    wrksheet.Cells[h, 64] = dr.Cells[63].Value != null ? dr.Cells[63].Value.ToString() : "";


                    wrksheet.Cells[h, 68] = dr.Cells[67].Value != null ? dr.Cells[67].Value.ToString() : "";
                    wrksheet.Cells[h, 69] = dr.Cells[68].Value != null ? dr.Cells[68].Value.ToString() : "";
                    wrksheet.Cells[h, 70] = dr.Cells[69].Value != null ? dr.Cells[69].Value.ToString() : "";
                    wrksheet.Cells[h, 71] = dr.Cells[70].Value != null ? dr.Cells[70].Value.ToString() : "";
                    wrksheet.Cells[h, 72] = dr.Cells[71].Value != null ? dr.Cells[71].Value.ToString() : "";


                    wrksheet.Cells[h, 76] = dr.Cells[75].Value != null ? dr.Cells[75].Value.ToString() : "";
                    wrksheet.Cells[h, 77] = dr.Cells[76].Value != null ? dr.Cells[76].Value.ToString() : "";
                    wrksheet.Cells[h, 78] = dr.Cells[77].Value != null ? dr.Cells[77].Value.ToString() : "";
                    wrksheet.Cells[h, 79] = dr.Cells[78].Value != null ? dr.Cells[78].Value.ToString() : "";
                    wrksheet.Cells[h, 80] = dr.Cells[79].Value != null ? dr.Cells[79].Value.ToString() : "";


                    wrksheet.Cells[h, 84] = dr.Cells[83].Value != null ? dr.Cells[83].Value.ToString() : "";  //84
                    wrksheet.Cells[h, 85] = dr.Cells[84].Value != null ? dr.Cells[84].Value.ToString() : "";  //85


                    string Truong_87 = "";
                    if (!string.IsNullOrEmpty(dr.Cells[86].Value != null ? dr.Cells[86].Value.ToString() : ""))
                    {
                        for (int i = 0; i < dr.Cells[86].Value.ToString().Length; i++)
                        {
                            string temp = dr.Cells[86].Value.ToString().Substring(i, 1);
                            if (i < dr.Cells[86].Value.ToString().Length - 1)
                            {
                                switch (temp)
                                {
                                    case "A":
                                        Truong_87 += "廃プラ" + "、";
                                        break;
                                    case "B":
                                        Truong_87 += "ゴムくず" + "、";
                                        break;
                                    case "C":
                                        Truong_87 += "金属くず" + "、";
                                        break;
                                    case "D":
                                        Truong_87 += "ガラコン陶" + "、";
                                        break;
                                    case "E":
                                        Truong_87 += "がれき類" + "、";
                                        break;
                                    case "K":
                                        Truong_87 += "紙くず" + "、";
                                        break;
                                    case "L":
                                        Truong_87 += "木くず" + "、";
                                        break;
                                    case "M":
                                        Truong_87 += "繊維くず" + "、";
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                switch (temp)
                                {
                                    case "A":
                                        Truong_87 += "廃プラ";
                                        break;
                                    case "B":
                                        Truong_87 += "ゴムくず";
                                        break;
                                    case "C":
                                        Truong_87 += "金属くず";
                                        break;
                                    case "D":
                                        Truong_87 += "ガラコン陶";
                                        break;
                                    case "E":
                                        Truong_87 += "がれき類";
                                        break;
                                    case "K":
                                        Truong_87 += "紙くず";
                                        break;
                                    case "L":
                                        Truong_87 += "木くず";
                                        break;
                                    case "M":
                                        Truong_87 += "繊維くず";
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }

                    wrksheet.Cells[h, 87] = Truong_87;  //87
                    wrksheet.Cells[h, 92] = dr.Cells[90].Value != null ? dr.Cells[90].Value.ToString() : "";  //91

                    lb_SoDong.Text = (h - 2).ToString() + "/" + dataGridView1.Rows.Count.ToString();
                    Range rowHead = wrksheet.get_Range("A3", "CN" + h);
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

        public bool TableToExcel_YASUDA_QC(String strfilename)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Global.db.ExportExcel_YAMAMOTO_QC(cbb_Batch.Text);
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Sheets _sheet = book.Sheets;
                Worksheet wrksheet = (Worksheet)book.ActiveSheet;
                int h = 3;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {

                    int ii = Convert.ToInt32(dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().IndexOf(".").ToString() : "0");
                    wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString().Substring(0, ii) : "";   //tên ảnh
                    wrksheet.Cells[h, 2] = dr.Cells[1].Value != null ? dr.Cells[1].Value.ToString() : "";   //truong 02
                    wrksheet.Cells[h, 3] = dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : "";    //03
                    wrksheet.Cells[h, 5] = dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : "";   //05
                    wrksheet.Cells[h, 6] = dr.Cells[5].Value != null ? dr.Cells[5].Value.ToString() : "";   //06
                    wrksheet.Cells[h, 7] = dr.Cells[6].Value != null ? dr.Cells[6].Value.ToString() : "";   //07
                    wrksheet.Cells[h, 8] = dr.Cells[7].Value != null ? dr.Cells[7].Value.ToString() : "";   //08


                    wrksheet.Cells[h, 12] = dr.Cells[11].Value != null ? dr.Cells[11].Value.ToString() : "";
                    wrksheet.Cells[h, 13] = dr.Cells[12].Value != null ? dr.Cells[12].Value.ToString() : "";
                    wrksheet.Cells[h, 14] = dr.Cells[13].Value != null ? dr.Cells[13].Value.ToString() : "";
                    wrksheet.Cells[h, 15] = dr.Cells[14].Value != null ? dr.Cells[14].Value.ToString() : "";
                    wrksheet.Cells[h, 16] = dr.Cells[15].Value != null ? dr.Cells[15].Value.ToString() : "";

                    wrksheet.Cells[h, 20] = dr.Cells[19].Value != null ? dr.Cells[19].Value.ToString() : "";
                    wrksheet.Cells[h, 21] = dr.Cells[20].Value != null ? dr.Cells[20].Value.ToString() : "";
                    wrksheet.Cells[h, 22] = dr.Cells[21].Value != null ? dr.Cells[21].Value.ToString() : "";
                    wrksheet.Cells[h, 23] = dr.Cells[22].Value != null ? dr.Cells[22].Value.ToString() : "";
                    wrksheet.Cells[h, 24] = dr.Cells[23].Value != null ? dr.Cells[23].Value.ToString() : "";


                    wrksheet.Cells[h, 28] = dr.Cells[27].Value != null ? dr.Cells[27].Value.ToString() : "";
                    wrksheet.Cells[h, 29] = dr.Cells[28].Value != null ? dr.Cells[28].Value.ToString() : "";
                    wrksheet.Cells[h, 30] = dr.Cells[29].Value != null ? dr.Cells[29].Value.ToString() : "";
                    wrksheet.Cells[h, 31] = dr.Cells[30].Value != null ? dr.Cells[30].Value.ToString() : "";
                    wrksheet.Cells[h, 32] = dr.Cells[31].Value != null ? dr.Cells[31].Value.ToString() : "";

                    wrksheet.Cells[h, 36] = dr.Cells[35].Value != null ? dr.Cells[35].Value.ToString() : "";
                    wrksheet.Cells[h, 37] = dr.Cells[36].Value != null ? dr.Cells[36].Value.ToString() : "";
                    wrksheet.Cells[h, 38] = dr.Cells[37].Value != null ? dr.Cells[37].Value.ToString() : "";
                    wrksheet.Cells[h, 39] = dr.Cells[38].Value != null ? dr.Cells[38].Value.ToString() : "";
                    wrksheet.Cells[h, 40] = dr.Cells[39].Value != null ? dr.Cells[39].Value.ToString() : "";

                    wrksheet.Cells[h, 44] = dr.Cells[43].Value != null ? dr.Cells[43].Value.ToString() : "";
                    wrksheet.Cells[h, 45] = dr.Cells[44].Value != null ? dr.Cells[44].Value.ToString() : "";
                    wrksheet.Cells[h, 46] = dr.Cells[45].Value != null ? dr.Cells[45].Value.ToString() : "";
                    wrksheet.Cells[h, 47] = dr.Cells[46].Value != null ? dr.Cells[46].Value.ToString() : "";
                    wrksheet.Cells[h, 48] = dr.Cells[47].Value != null ? dr.Cells[47].Value.ToString() : "";


                    wrksheet.Cells[h, 52] = dr.Cells[51].Value != null ? dr.Cells[51].Value.ToString() : "";
                    wrksheet.Cells[h, 53] = dr.Cells[52].Value != null ? dr.Cells[52].Value.ToString() : "";
                    wrksheet.Cells[h, 54] = dr.Cells[53].Value != null ? dr.Cells[53].Value.ToString() : "";
                    wrksheet.Cells[h, 55] = dr.Cells[54].Value != null ? dr.Cells[54].Value.ToString() : "";
                    wrksheet.Cells[h, 56] = dr.Cells[55].Value != null ? dr.Cells[55].Value.ToString() : "";

                    wrksheet.Cells[h, 60] = dr.Cells[59].Value != null ? dr.Cells[59].Value.ToString() : "";
                    wrksheet.Cells[h, 61] = dr.Cells[60].Value != null ? dr.Cells[60].Value.ToString() : "";
                    wrksheet.Cells[h, 62] = dr.Cells[61].Value != null ? dr.Cells[61].Value.ToString() : "";
                    wrksheet.Cells[h, 63] = dr.Cells[62].Value != null ? dr.Cells[62].Value.ToString() : "";
                    wrksheet.Cells[h, 64] = dr.Cells[63].Value != null ? dr.Cells[63].Value.ToString() : "";


                    wrksheet.Cells[h, 68] = dr.Cells[67].Value != null ? dr.Cells[67].Value.ToString() : "";
                    wrksheet.Cells[h, 69] = dr.Cells[68].Value != null ? dr.Cells[68].Value.ToString() : "";
                    wrksheet.Cells[h, 70] = dr.Cells[69].Value != null ? dr.Cells[69].Value.ToString() : "";
                    wrksheet.Cells[h, 71] = dr.Cells[70].Value != null ? dr.Cells[70].Value.ToString() : "";
                    wrksheet.Cells[h, 72] = dr.Cells[71].Value != null ? dr.Cells[71].Value.ToString() : "";


                    wrksheet.Cells[h, 76] = dr.Cells[75].Value != null ? dr.Cells[75].Value.ToString() : "";
                    wrksheet.Cells[h, 77] = dr.Cells[76].Value != null ? dr.Cells[76].Value.ToString() : "";
                    wrksheet.Cells[h, 78] = dr.Cells[77].Value != null ? dr.Cells[77].Value.ToString() : "";
                    wrksheet.Cells[h, 79] = dr.Cells[78].Value != null ? dr.Cells[78].Value.ToString() : "";
                    wrksheet.Cells[h, 80] = dr.Cells[79].Value != null ? dr.Cells[79].Value.ToString() : "";


                    wrksheet.Cells[h, 84] = dr.Cells[83].Value != null ? dr.Cells[83].Value.ToString() : "";  //84
                    wrksheet.Cells[h, 85] = dr.Cells[84].Value != null ? dr.Cells[84].Value.ToString() : "";  //85


                    string Truong_87 = "";
                    if (!string.IsNullOrEmpty(dr.Cells[86].Value != null ? dr.Cells[86].Value.ToString() : ""))
                    {
                        for (int i = 0; i < dr.Cells[86].Value.ToString().Length; i++)
                        {
                            string temp = dr.Cells[86].Value.ToString().Substring(i, 1);
                            if (i < dr.Cells[86].Value.ToString().Length - 1)
                            {
                                switch (temp)
                                {
                                    case "A":
                                        Truong_87 += "廃プラ" + "、";
                                        break;
                                    case "B":
                                        Truong_87 += "ゴムくず" + "、";
                                        break;
                                    case "C":
                                        Truong_87 += "金属くず" + "、";
                                        break;
                                    case "D":
                                        Truong_87 += "ガラコン陶" + "、";
                                        break;
                                    case "E":
                                        Truong_87 += "がれき類" + "、";
                                        break;
                                    case "K":
                                        Truong_87 += "紙くず" + "、";
                                        break;
                                    case "L":
                                        Truong_87 += "木くず" + "、";
                                        break;
                                    case "M":
                                        Truong_87 += "繊維くず" + "、";
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                switch (temp)
                                {
                                    case "A":
                                        Truong_87 += "廃プラ";
                                        break;
                                    case "B":
                                        Truong_87 += "ゴムくず";
                                        break;
                                    case "C":
                                        Truong_87 += "金属くず";
                                        break;
                                    case "D":
                                        Truong_87 += "ガラコン陶";
                                        break;
                                    case "E":
                                        Truong_87 += "がれき類";
                                        break;
                                    case "K":
                                        Truong_87 += "紙くず";
                                        break;
                                    case "L":
                                        Truong_87 += "木くず";
                                        break;
                                    case "M":
                                        Truong_87 += "繊維くず";
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }

                    wrksheet.Cells[h, 87] = Truong_87;  //87

                    wrksheet.Cells[h, 92] = dr.Cells[90].Value != null ? dr.Cells[90].Value.ToString() : "";  //91

                    lb_SoDong.Text = (h - 2).ToString() + "/" + dataGridView1.Rows.Count.ToString();
                    Range rowHead = wrksheet.get_Range("A3", "CN" + h);
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
    }
}
