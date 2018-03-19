using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoAPKTool.model
{
    public class AppInfoModel
    {
        public string signHashMd5 { get; set; }
        public string pkg { get; set; }
        public string name;
        public string signCharString;
        public string appVersion { get; set; }
        public string icon { get; set; }
        public string signByteArray { get; set; }
        public string permissions { get; set; }
        public string signHash { get; set; }
    }
}
