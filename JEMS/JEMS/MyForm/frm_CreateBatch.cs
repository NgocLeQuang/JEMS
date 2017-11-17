using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JEMS.MyForm
{
    public partial class frm_CreateBatch : DevExpress.XtraEditors.XtraForm
    {
        private string _csvpath = "";
        private string[] _lFileNames;
        private bool _multi;
        private int soluonghinh;

        public frm_CreateBatch()
        {
            InitializeComponent();
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_PathFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_BrowserImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_BatchName.Text))
            {
                MessageBox.Show("Vui lòng điền tên batch", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Types Image|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";

            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _lFileNames = dlg.FileNames;
                txt_ImagePath.Text = Path.GetDirectoryName(dlg.FileName);
            }soluonghinh = 0;
            soluonghinh = dlg.FileNames.Length;
            lb_SoLuongHinh.Text = dlg.FileNames.Length + " files ";
        }

        private void btn_CreateBatch_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show("Quá trình tạo batch đang diễn ra, Bạn hãy chờ quá trình tạo batch kết thúc mới tiếp tục tạo batch mới !");
                return;
            }
            lb_SobatchHoanThanh.Text = "";
            Global.db_BPO.UpdateTimeLastRequest(Global.Strtoken);
            backgroundWorker1.RunWorkerAsync();
        }

        private void txt_BatchName_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_BatchName.Text))
            {
                _multi = false;
                
                txt_PathFolder.Enabled = false;
                btn_Browser.Enabled = false;
            }
            else
            {
                txt_PathFolder.Enabled = true;
                btn_Browser.Enabled = true;
            }
        }

        private void txt_PathFolder_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_PathFolder.Text))
            {
                _multi = true;
                
                txt_BatchName.Enabled = false;
                txt_ImagePath.Enabled = false;
                btn_BrowserImage.Enabled = false;
            }
            else
            {
                txt_BatchName.Enabled = true;
                txt_ImagePath.Enabled = true;
                btn_BrowserImage.Enabled = true;
            }
        }

        private bool flag_load = false;
        private void frm_CreateBatch_Load(object sender, EventArgs e)
        {
            lb_status.Text = "";
            txt_UserCreate.Text = Global.StrUsername;
            txt_DateCreate.Text = DateTime.Now.ToShortDateString() + "  -  " + DateTime.Now.ToShortTimeString();

            txt_LoaiPhieu.DisplayMember = "Text";
            txt_LoaiPhieu.ValueMember = "Value";

            txt_LoaiPhieu.Items.Add(new { Text = "", Value = "" });
            txt_LoaiPhieu.Items.Add(new { Text = "AEON", Value = "AEON" });
            txt_LoaiPhieu.Items.Add(new { Text = "ASAHI", Value = "ASAHI" });
            txt_LoaiPhieu.Items.Add(new { Text = "EIZEN", Value = "EIZEN" });
            txt_LoaiPhieu.Items.Add(new { Text = "YAMAMOTO", Value = "YAMAMOTO" });
            txt_LoaiPhieu.Items.Add(new { Text = "YASUDA", Value = "YASUDA" });
            txt_LoaiPhieu.Items.Add(new { Text = "TAIYO", Value = "TAIYO" });
            txt_LoaiPhieu.SelectedIndex = 0;

            cbb_loaithoigian.DisplayMember = "Text";
            cbb_loaithoigian.ValueMember = "Value";

            cbb_loaithoigian.Items.Add(new { Text = "", Value = "" });
            cbb_loaithoigian.Items.Add(new { Text = "Ngày", Value = "Ngay" });
            cbb_loaithoigian.Items.Add(new { Text = "Giờ", Value = "Gio" });
            cbb_loaithoigian.Items.Add(new { Text = "Phút", Value = "Phut" });
            cbb_loaithoigian.SelectedIndex = 0;
            dateEdit_ngaybatdau.DateTime = DateTime.Now;
            timeEdit_ngaybatdau.Time = DateTime.Now;
            timeEdit_ngayketthuc.Time = DateTime.Now;
            dateEdit_ngayketthuc.DateTime = DateTime.Now;
            flag_load = true;
        }

        public static string[] GetFilesFrom(string searchFolder, string[] filters, bool isRecursive)
        {
            List<string> filesFound = new List<string>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, $"*.{filter}", searchOption));
            }
            return filesFound.ToArray();
        }

        private void UpLoadSingle()
        {
            progressBar1.Step = 1;
            progressBar1.Value = 1;
            progressBar1.Maximum = _lFileNames.Length;
            progressBar1.Minimum = 0;
            ModifyProgressBarColor.SetState(progressBar1, 1);
            var batch = (from w in Global.db.tbl_Batches.Where(w => w.fBatchName == txt_BatchName.Text)select w.fBatchName).FirstOrDefault();
            if (!string.IsNullOrEmpty(txt_ImagePath.Text))
            {
                
                if (string.IsNullOrEmpty(batch))
                {
                    var fBatch = new tbl_Batch
                    {
                        fBatchName = txt_BatchName.Text,
                        fUserCreate = txt_UserCreate.Text,
                        fDateCreated = DateTime.Now,
                        fPathPicture = txt_ImagePath.Text,
                        fLocation = txt_Location.Text,
                        fSoLuongAnh = soluonghinh.ToString(),
                        fLoaiPhieu = txt_LoaiPhieu.Text
                        
                    };
                    Global.db.tbl_Batches.InsertOnSubmit(fBatch);
                    Global.db.SubmitChanges();


                    //DateTime timeStart = new DateTime(dateEdit_ngaybatdau.DateTime.Year,
                    //                            dateEdit_ngaybatdau.DateTime.Month,
                    //                            dateEdit_ngaybatdau.DateTime.Day,
                    //                            timeEdit_ngaybatdau.Time.Hour,
                    //                            timeEdit_ngaybatdau.Time.Minute,
                    //                            timeEdit_ngaybatdau.Time.Second);
                    //DateTime timeEnd = new DateTime(dateEdit_ngayketthuc.DateTime.Year,
                    //                                    dateEdit_ngayketthuc.DateTime.Month,
                    //                                    dateEdit_ngayketthuc.DateTime.Day,
                    //                                    timeEdit_ngayketthuc.Time.Hour,
                    //                                    timeEdit_ngayketthuc.Time.Minute,
                    //                                    timeEdit_ngayketthuc.Time.Second);
                    //int timeNotificationdeadline = 0;
                    //if (cbb_loaithoigian.Text == "Ngày")
                    //{
                    //    timeNotificationdeadline = Convert.ToInt32(nud_thoigiandeadline.Value * 24 * 60);
                    //}
                    //else if (cbb_loaithoigian.Text == "Giờ")
                    //{
                    //    timeNotificationdeadline = Convert.ToInt32(nud_thoigiandeadline.Value * 60);
                    //}
                    //else if (cbb_loaithoigian.Text == "Phút")
                    //{
                    //    timeNotificationdeadline = Convert.ToInt32(nud_thoigiandeadline.Value);
                    //}
                    //var fBatchEntry = new tbl_Batch_Entry()
                    //{
                    //    fIDProject = Global.StrIdProject,
                    //    fBatchName = txt_BatchName.Text,
                    //    fUserCreate = txt_UserCreate.Text,
                    //    fDateCreated = DateTime.Now,
                    //    fPathPicture = txt_ImagePath.Text,
                    //    fLocation = txt_Location.Text,
                    //    fSoLuongAnh = soluonghinh.ToString(),
                    //    fLoaiPhieu = txt_LoaiPhieu.Text,
                    //    fTimeStart = timeStart,
                    //    fTimeEnd = timeEnd,
                    //    fDeadlineNotificationTime = timeNotificationdeadline
                    //};
                    //Global.db_BPO.tbl_Batch_Entries.InsertOnSubmit(fBatchEntry);
                    //Global.db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Batch đã tồn tại vui lòng điền tên batch khác!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn hình ảnh!");
                return;
            }
            string temp = Global.StrPath + "\\" + txt_BatchName.Text;
            if (!Directory.Exists(temp))
            {
                Directory.CreateDirectory(temp);
            }
            else
            {
                MessageBox.Show("Bị trùng tên batch!");
                return;
            }
            foreach (string i in _lFileNames)
            {
                FileInfo fi = new FileInfo(i);
                tbl_Image tempImage = new tbl_Image
                {
                    fbatchname = txt_BatchName.Text,
                    idimage = Path.GetFileName(fi.ToString()),
                    ReadImageDESo = 0,
                    CheckedDESo = 0,
                    Checked_QC = 0,
                    TienDoDESO = "Hình chưa nhập",
                    CheckQC = false
                };
                Global.db.tbl_Images.InsertOnSubmit(tempImage);
                Global.db.SubmitChanges();

                tbl_TienDo tempTblTienDo = new tbl_TienDo
                {
                    IDProject = "JEMS",
                    fBatchName = txt_BatchName.Text,
                    Idimage = Path.GetFileName(fi.ToString()),
                    TienDoDeSo = "Hình chưa nhập",
                    UserCheckDeSo = "",
                    DateCreate = DateTime.Now
                };
                Global.db_BPO.tbl_TienDos.InsertOnSubmit(tempTblTienDo);
                Global.db_BPO.SubmitChanges();

                string des = temp + @"\" + Path.GetFileName(fi.ToString());
                fi.CopyTo(des);
                progressBar1.PerformStep();
            }
            MessageBox.Show("Tạo batch mới thành công!");
            txt_BatchName.Text = "";
            txt_ImagePath.Text = "";
            lb_SoLuongHinh.Text = "";
            txt_LoaiPhieu.SelectedIndex = 0;

        }


       

        private void UpLoadMulti()
        {
            btn_Browser.Enabled = false;
            txt_PathFolder.Enabled = false;
            txt_Location.Enabled = false;
            List<string> lStrBath = new List<string>();
            lStrBath.AddRange(Directory.GetDirectories(txt_PathFolder.Text));
            int countBatchExists = 0;
            string listBatchExxists = "";
            for (int i = 0; i < lStrBath.Count; i++)
            {
                var batchExists = (from w in Global.db.tbl_Batches where w.fBatchName == new DirectoryInfo(lStrBath[i]).Name select w.fBatchName).ToList();
                if (batchExists.Count > 0)
                {
                    countBatchExists += 1;
                    listBatchExxists += batchExists[0] + "\r\n";
                }
            }
            if (countBatchExists>0)
            {
                MessageBox.Show("Batch đã tồn tại :\r\n" + listBatchExxists);
                btn_Browser.Enabled = true;
                txt_PathFolder.Enabled = true;
                txt_Location.Enabled = true;
                return;
            }
            int n = 0;
            foreach (string itemBatch in lStrBath)
            {
                string batchName = "", loaiPhieu = "", pathPicture = "";
                int m = 0;
                batchName = new DirectoryInfo(itemBatch).Name;
                if (batchName.IndexOf("AEON", StringComparison.Ordinal) >= 0 || batchName.IndexOf("aeon", StringComparison.Ordinal) >= 0)
                {
                    loaiPhieu = "AEON";
                }
                else if (batchName.IndexOf("ASAHI", StringComparison.Ordinal) >= 0 || batchName.IndexOf("asahi", StringComparison.Ordinal) >= 0)
                {
                    loaiPhieu = "ASAHI";
                }
                else if (batchName.IndexOf("EIZEN", StringComparison.Ordinal) >= 0 || batchName.IndexOf("eizen", StringComparison.Ordinal) >= 0)
                {
                    loaiPhieu = "EIZEN";
                }
                else if (batchName.IndexOf("YAMAMOTO", StringComparison.Ordinal) >= 0 || batchName.IndexOf("yamamoto", StringComparison.Ordinal) >= 0)
                {
                    loaiPhieu = "YAMAMOTO";
                }
                else if (batchName.IndexOf("YASUDA", StringComparison.Ordinal) >= 0 || batchName.IndexOf("yasuda", StringComparison.Ordinal) >= 0)
                {
                    loaiPhieu = "YASUDA";
                }
                else if (batchName.IndexOf("TAIYO", StringComparison.Ordinal) >= 0 || batchName.IndexOf("taiyo", StringComparison.Ordinal) >= 0)
                {
                    loaiPhieu = "TAIYO";
                }
                else
                {
                    continue;
                }

                n += 1;
                lb_SobatchHoanThanh.Text = n + @" :";

                pathPicture = itemBatch + @"\入力画像";
                var fBatch = new tbl_Batch
                {
                    fBatchName = batchName,
                    fUserCreate = txt_UserCreate.Text,
                    fDateCreated = DateTime.Now,
                    fPathPicture = pathPicture,
                    fLocation = txt_Location.Text,
                    fSoLuongAnh = Directory.GetFiles(pathPicture).Length.ToString(),
                    fLoaiPhieu = loaiPhieu
                };
                Global.db.tbl_Batches.InsertOnSubmit(fBatch);
                Global.db.SubmitChanges();
                
                var filters = new String[] { "jpg", "jpeg", "png", "gif", "tif", "bmp" };
                string[] pathImageLocation = GetFilesFrom(pathPicture, filters, false);
                string pathImageServer = Global.StrPath + "\\" + new DirectoryInfo(itemBatch).Name;
                Directory.CreateDirectory(pathImageServer);
                string imageJPG = "";

                progressBar1.Step = 1;
                progressBar1.Value = 1;
                progressBar1.Maximum = pathImageLocation.Length;
                progressBar1.Minimum = 0;
                ModifyProgressBarColor.SetState(progressBar1, 1);

                foreach (string i in pathImageLocation)
                {
                    FileInfo fi = new FileInfo(i);
                    tbl_Image tempImage = new tbl_Image
                    {
                        fbatchname = batchName,
                        idimage = Path.GetFileName(fi.ToString()),
                        ReadImageDESo = 0,
                        CheckedDESo = 0,
                        Checked_QC = 0,
                        TienDoDESO = "Hình chưa nhập",
                        CheckQC = false
                    };
                    
                    Global.db.tbl_Images.InsertOnSubmit(tempImage);
                    Global.db.SubmitChanges();
                    //tbl_TienDo tempTblTienDo = new tbl_TienDo
                    //{
                    //    IDProject = "JEMS",
                    //    fBatchName = txt_BatchName.Text,
                    //    Idimage = Path.GetFileName(fi.ToString()),
                    //    TienDoDeSo = "Hình chưa nhập",
                    //    UserCheckDeSo = "",
                    //    DateCreate = DateTime.Now
                    //};
                    //Global.db_BPO.tbl_TienDos.InsertOnSubmit(tempTblTienDo);
                    //Global.db_BPO.SubmitChanges();

                    string des = pathImageServer + @"\" + Path.GetFileName(fi.ToString());
                    fi.CopyTo(des);
                    m += 1;
                    lb_SoImageDaHoanThanh.Text = m + @"/" + pathImageLocation.Length;
                    progressBar1.PerformStep();
                }
            }
            MessageBox.Show(@"Tạo batch mới thành công!");
            txt_BatchName.Text = "";
            txt_ImagePath.Text = "";
            lb_SoLuongHinh.Text = "";
            txt_PathFolder.Text = "";
            txt_LoaiPhieu.SelectedIndex = 0;

            //btn_CreateBatch.Enabled = true;
            btn_Browser.Enabled = true;
            txt_PathFolder.Enabled = true;
            txt_Location.Enabled = true;
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_LoaiPhieu.Text) && _multi==false)
            {
                MessageBox.Show("Vui lòng chọn loại phiếu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if((nud_songaylam.Value!=0||nud_sogiolam.Value!=0||nud_sophutlam.Value!=0)&&(nud_thoigiandeadline.Value==0))
            {
                if(MessageBox.Show("Bạn chưa chọn thời gian thông báo deadline. Bạn vẫn tiếp tục","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.No)return;
            }
            if (_multi)
            {
                lb_SobatchHoanThanh.Text = "";
                lb_SoImageDaHoanThanh.Text = "";
                label1.Visible = true;
                lb_SobatchHoanThanh.Visible = true;
                lb_SoImageDaHoanThanh.Visible = true;
                UpLoadMulti();
            }
            else
            {
                lb_SobatchHoanThanh.Text = "";
                lb_SoImageDaHoanThanh.Text = "";
                label1.Visible = false;
                lb_SobatchHoanThanh.Visible = false;
                lb_SoImageDaHoanThanh.Visible = false;
                UpLoadSingle();
            }
        }

        private void frm_CreateBatch_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private bool closePending;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show("Quá trình tạo batch đang diễn ra, Bạn hãy chờ quá trình tạo batch kết thúc!");
                e.Cancel = true;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (closePending) Close();
            closePending = false;
        }

        private bool flag = false;

        //public void HandlingTimeWork()
        //{
        //    try
        //    {
        //        if (!flag) return;
        //        TimeSpan timeAdd = new TimeSpan(Convert.ToInt32(nud_songaylam.Value), Convert.ToInt32(nud_sogiolam.Value), Convert.ToInt32(nud_sophutlam.Value), 0);
        //        DateTime timeStart = new DateTime(dateEdit_ngaybatdau.DateTime.Year,
        //                                            dateEdit_ngaybatdau.DateTime.Month,
        //                                            dateEdit_ngaybatdau.DateTime.Day,
        //                                            timeEdit_ngaybatdau.Time.Hour,
        //                                            timeEdit_ngaybatdau.Time.Minute,
        //                                            timeEdit_ngaybatdau.Time.Second);
        //        DateTime timeEnd = timeStart.Add(timeAdd);
        //        dateEdit_ngayketthuc.EditValue = timeEnd;
        //        timeEdit_ngayketthuc.EditValue = timeEnd;
        //        lb_status.Text = "";
        //    }
        //    catch (Exception i)
        //    {
        //        lb_status.Text = " Ngày kết thúc không được nhỏ hơn ngày bắt đầu";
        //    }
        //}

        //public void HandlingTimeWork_1()
        //{

        //    if (flag_load)
        //        try
        //        {
        //            if (flag) return;
        //            DateTime timeStart = new DateTime(dateEdit_ngaybatdau.DateTime.Year,
        //                                                dateEdit_ngaybatdau.DateTime.Month,
        //                                                dateEdit_ngaybatdau.DateTime.Day,
        //                                                timeEdit_ngaybatdau.Time.Hour,
        //                                                timeEdit_ngaybatdau.Time.Minute,
        //                                                timeEdit_ngaybatdau.Time.Second);
        //            DateTime timeEnd = new DateTime(dateEdit_ngayketthuc.DateTime.Year,
        //                                                dateEdit_ngayketthuc.DateTime.Month,
        //                                                dateEdit_ngayketthuc.DateTime.Day,
        //                                                timeEdit_ngayketthuc.Time.Hour,
        //                                                timeEdit_ngayketthuc.Time.Minute,
        //                                                timeEdit_ngayketthuc.Time.Second);
        //            TimeSpan time = timeEnd.Subtract(timeStart);
        //            nud_songaylam.Value = time.Days;
        //            nud_sogiolam.Value = time.Hours;
        //            nud_sophutlam.Value = time.Minutes;
        //            lb_status.Text = "";
        //        }
        //        catch (Exception e)
        //        {
        //            lb_status.Text = " Ngày kết thúc không được nhỏ hơn ngày bắt đầu";
        //        }
        //}
        private void dateEdit_ngaybatdau_EditValueChanged(object sender, EventArgs e)
        {
            //HandlingTimeWork();
        }

        private void timeEdit_ngaybatdau_EditValueChanged(object sender, EventArgs e)
        {
           // HandlingTimeWork();
        }

        private void nud_songaylam_ValueChanged(object sender, EventArgs e)
        {
            //HandlingTimeWork();
        }

        private void nud_sogiolam_ValueChanged(object sender, EventArgs e)
        {
            //HandlingTimeWork();
        }

        private void nud_sophutlam_ValueChanged(object sender, EventArgs e)
        {
            //HandlingTimeWork();
        }

        private void dateEdit_ngayketthuc_EditValueChanged(object sender, EventArgs e)
        {
            //HandlingTimeWork_1();
        }

        private void timeEdit_ngayketthuc_EditValueChanged(object sender, EventArgs e)
        {
            //HandlingTimeWork_1();
        }

        private void nud_thoigiandeadline_ValueChanged(object sender, EventArgs e)
        {
            //if (!flag_load)
            //    return;
            //DateTime timeStart = new DateTime(dateEdit_ngaybatdau.DateTime.Year,
            //    dateEdit_ngaybatdau.DateTime.Month,
            //    dateEdit_ngaybatdau.DateTime.Day,
            //    timeEdit_ngaybatdau.Time.Hour,
            //    timeEdit_ngaybatdau.Time.Minute,
            //    timeEdit_ngaybatdau.Time.Second);
            //DateTime timeEnd = new DateTime(dateEdit_ngayketthuc.DateTime.Year,
            //    dateEdit_ngayketthuc.DateTime.Month,
            //    dateEdit_ngayketthuc.DateTime.Day,
            //    timeEdit_ngayketthuc.Time.Hour,
            //    timeEdit_ngayketthuc.Time.Minute,
            //    timeEdit_ngayketthuc.Time.Second);
            //TimeSpan time = timeEnd.Subtract(timeStart);
            //if (cbb_loaithoigian.Text == "")
            //{
            //    lb_status.Text = "Bạn chưa chọn kiểu thời gian.Vui lòng chọn kiểu thời gian";
            //    return;
            //}
            //if (timeStart > timeEnd)
            //{
            //    lb_status.Text = "Ngày kết thúc dự án không được trước ngày bắt đầu";
            //    return;
            //}
            //else
            //{
            //    lb_status.Text = "";
            //}
            //if (cbb_loaithoigian.Text == "Ngày")
            //{
            //    float ngay = (float) time.Days + (float) time.Hours / 24 + (float) time.Minutes / (60 * 24);
            //    if (Convert.ToSingle(nud_thoigiandeadline.Value) > ngay)
            //    {
            //        lb_status.Text =
            //            "Thời gian thông báo deadline không được lớn hơn thời gian thực hiện dự án. Thời gian tối đa: " +
            //            time.Days + " ngày " + time.Hours + " giờ " + time.Minutes + " Phút";
            //        return;
            //    }
            //    lb_status.Text = "";
            //}
            //else if (cbb_loaithoigian.Text == "Giờ")
            //{
            //    float gio = (float) time.Days * 24 + (float) time.Hours + (float) time.Minutes / 60;
            //    if (Convert.ToSingle(nud_thoigiandeadline.Value) > gio)
            //    {
            //        lb_status.Text =
            //             "Thời gian thông báo deadline không được lớn hơn thời gian thực hiện dự án. Thời gian tối đa: " +
            //             time.Days + " ngày " + time.Hours + " giờ " + time.Minutes + " Phút";
            //        return;
            //    }
            //    lb_status.Text = "";
            //}
            //else if (cbb_loaithoigian.Text == "Phút")
            //{
            //    float phut = (float) time.Days * (24 * 60) + (float) time.Hours * 60 + (float) time.Minutes;
            //    if (Convert.ToSingle(nud_thoigiandeadline.Value) > phut)
            //    {
            //        lb_status.Text =
            //            "Thời gian thông báo deadline không được lớn hơn thời gian thực hiện dự án. Thời gian tối đa: " +
            //            time.Days + " ngày " + time.Hours + " giờ " + time.Minutes + " Phút";
            //        return;
            //    }
            //    lb_status.Text = "";
            //}
        }
        private void dateEdit_ngaybatdau_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void timeEdit_ngaybatdau_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void nud_songaylam_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void nud_sogiolam_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void nud_sophutlam_Click(object sender, EventArgs e)
        {
            flag = true;
        }

        private void dateEdit_ngayketthuc_Click(object sender, EventArgs e)
        {
            flag = false;
        }

        private void timeEdit_ngayketthuc_Click(object sender, EventArgs e)
        {
            flag = false;
        }

        private void cbb_loaithoigian_SelectedIndexChanged(object sender, EventArgs e)
        {
            //nud_thoigiandeadline_ValueChanged(null, null);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}