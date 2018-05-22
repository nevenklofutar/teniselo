using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenisElo.Web.Models
{
    public class Utilities
    {
        private static string _webserverurl = string.Format("http://{0}:{1}", HttpContext.Current.Request.Url.Host, HttpContext.Current.Request.Url.Port);

        public static string WebServerUrl { get { return _webserverurl; } }
    }
}