﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JEMS
{
    internal class Global
    {
        public static DataBPODataContext db_BPO = new DataBPODataContext();
        public static DataJEMSDataContext db = new DataJEMSDataContext();
        public static string StrMachine = "";
        public static string StrUserWindow = "";
        public static string StrIpAddress = "";
        public static string StrUsername = "";
        public static string StrBatch = "";
        public static string StrRole = "";
        public static string Strtoken = "";
        public static string StrIdimage = "";
        public static string StrCheck = "";
        public static string StrPath = @"\\10.10.10.248\JEMS$";
        public static string Webservice = "http://10.10.10.248:8888/JEMS/";
        public static string LoaiPhieu = "";
        public static string StrIdProject = "JEMS";
        public static int FreeTime = 0;
    }
    
}
