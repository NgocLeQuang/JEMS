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
                a.lb_programName.Text = "           Dự Án JEMS";
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
                a.UrlUpdateVersion = @"\\10.10.10.254\DE_Viet\2017\BAO-CAO-LUONG2017";
                //a.LoginEvent += a_LoginEvent;
                //a.ButtonLoginEven += a_ButtonLoginEven;
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
    }
}
