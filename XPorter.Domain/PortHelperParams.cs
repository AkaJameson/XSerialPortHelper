using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using XPorter.Infrastructure.IniFile;
using XPorter.Infrastructure.IniFile.Models;

namespace XPorter.Domain
{
    public static class PortHelperParams
    {
        private static XIniFile Inifile { get; set; }

        static PortHelperParams()
        {
            IniFileManager.GetManager().LoadFile($"{AppDomain.CurrentDomain.BaseDirectory}peizhi\\PorterConfig.ini", Encoding.GetEncoding("GB2312"));
            Inifile = IniFileManager.GetManager().GetFile("PorterConfig");
        }

        public static List<KeyValuePair<string,string>> GetDataBits()
        {
            return Inifile.GetSection("DataBits").ToList();
        }

        public static List<KeyValuePair<string,string>> GetBaudRate()
        {
            return Inifile.GetSection("BaudRate").ToList();
        }

        public static List<KeyValuePair<string,string>> GetParity()
        {
            return Inifile.GetSection("Parity").ToList();
        }
        public static List<KeyValuePair<string,string>> GetStopBits()
        {
            return Inifile.GetSection("StopBits").ToList();
        }

    }
}
