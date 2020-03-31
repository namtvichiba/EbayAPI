﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EbayApi.Service
{
    public class AppSettingsHelper
    {
        public static string Endpoint = ConfigurationManager.AppSettings["Endpoint"];
        public static string AppID = ConfigurationManager.AppSettings["AppID"];
        public static string DevID = ConfigurationManager.AppSettings["DevID"];
        public static string CertID = ConfigurationManager.AppSettings["CertID"];
        public static string Token = ConfigurationManager.AppSettings["Token"];
    }
}