using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using LibraryLogin;
using JEMS.MyForm;

namespace JEMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            //Application.Run(new Form1());

            bool temp;
            do
            {
                temp = false;
                Frm_Login a = new Frm_Login();
                a.lb_programName.Text = "\n           Dự Án JEMS";
                a.lb_vision.Text = "Phiên bản :";
                a.grb_1.Text = "Thông Tin PC";
                a.lb_machine.Text = "Tên PC :";
                a.lb_user_window.Text = "Tài khoản window:";
                a.lb_ip.Text = "Địa chỉ IP :";
                a.grb_2.Text = "Thông Tin Tài Khoản Đăng Nhập";
                a.lb_username.Text = "Tên đăng nhập :";
                a.lb_password.Text = "Mật khẩu :";
                a.lb_role.Text = "Vai trò :";
                a.lb_date.Text = "Ngày: ";
                a.lb_time.Text = "Giờ: ";
                a.lb_batchno.Text = "BatchName: ";
                a.btn_thoat.Text = "Thoát";
                a.chb_hienthi.Text = "Hiển Thị";
                a.chb_luu.Text = "Lưu";
                a.lb_version.Text = @"1.0";
                a.UrlUpdateVersion = @"\\10.10.10.254\DE_Viet\2017\...";
                a.LoginEvent += a_LoginEvent;
                a.ButtonLoginEven += a_ButtonLoginEven;
                if (a.ShowDialog() == DialogResult.OK)
                {
                    Global.StrMachine = a.StrMachine;
                    Global.StrUserWindow = a.StrUserWindow;
                    Global.StrIpAddress = a.StrIpAddress;
                    Global.StrUsername = a.StrUserName;
                    Global.StrBatch = a.StrBatch;
                    Global.StrRole = a.StrRole;
                    Global.Strtoken = a.Token;
                    frm_Main f = new frm_Main();
                    if (f.ShowDialog() == DialogResult.Yes)
                    {
                        f.Close();
                        temp = true;
                    }
                }
            }
            while (temp);

        }
        private static void a_ButtonLoginEven(int iLogin, string strMachine, string strUserWindow, string strIpAddress, string strUsername, string password, string strBatch, string strRole, string strToken)
        {
            if (iLogin == 1)
            {
                Global.db_BPO.InsertLoginTime(strUsername, DateTime.Now, strUserWindow, strMachine, strIpAddress, strToken);
                //Global.deBPO.UpdateToken_TableUser(strUsername, strToken);
            }
        }
        private static void a_LoginEvent(string username, string password, ref string strVersion, ref int iKiemtraLogin, ref string role, ref ComboBox cbb)
        {
            try
            {
                iKiemtraLogin = Global.db_BPO.KiemTraLogin(username, password);
                strVersion = (from w in Global.db_BPO.tbl_Versions where w.IDProject == "JEMS" select w.IDVersion).FirstOrDefault();
                role = (from w in Global.db_BPO.tbl_Users where w.Username == username select w.IDRole).FirstOrDefault();
                if (!string.IsNullOrEmpty(role))
                    role = role.ToUpper();
                //if (iKiemtraLogin == 1 && role == "ADMIN")
                //{

                //    cbb.DataSource = Global.db_BCL.GetBatch();
                //    cbb.DisplayMember = "fBatchName";
                //}
                //else if (iKiemtraLogin == 1 && role == "DEJP")
                //{
                //    cbb.DataSource = Global.db_BCL.GetBatNotFinishDeJP(username);
                //    cbb.DisplayMember = "fBatchName";
                //}

                //else if (iKiemtraLogin == 1 && role == "DESO")
                //{
                //    cbb.DataSource = Global.db_BCL.GetBatNotFinishDeSo(username);
                //    cbb.DisplayMember = "fBatchName";
                //}
                //else if (iKiemtraLogin == 1 && role == "CHECKERDEJP")
                //{
                //    cbb.DataSource = Global.db_BCL.GetBatNotFinishCheckerDeJP(username);
                //    cbb.DisplayMember = "fBatchName";
                //}
                //else if (iKiemtraLogin == 1 && role == "CHECKERDESO")
                //{
                //    cbb.DataSource = Global.db_BCL.GetBatNotFinishCheckerDeSo(username);
                //    cbb.DisplayMember = "fBatchName";
                //}
            }
            catch (Exception e)
            {
                MessageBox.Show("Error connecting to server, please check your connection Internet\r\n" + e.Message);
            }
        }
    }
}
