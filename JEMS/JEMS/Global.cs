using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JEMS
{
    internal class Global
    {
        public static DataEntryBPODataContext db_BPO = new DataEntryBPODataContext();
        public static JEMSDataContext db = new JEMSDataContext();
        public static string StrMachine = "";
        public static string StrUserWindow = "";
        public static string StrIpAddress = "";
        public static string StrUsername = "";
        public static string StrBatch = "";
        public static string StrRole = "";
        public static string Strtoken = "";
        public static string StrIdimage = "";
        public static string StrCheck = "";
        public static string StrPath = @"\\10.10.10.253\ImageJEMS$";
        public static string Webservice = "http://10.10.10.253:8888/ImageJEMS/";
        public static string LoaiPhieu = "";
        public static string StrIdProject = "";
    }
}
