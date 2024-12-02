using System.Collections.Generic;
using System.Text;
using XPorter.Infrastructure.IniFile.Models;

namespace XPorter.Infrastructure.IniFile
{
    public interface IIniFileManager
    {
        XIniFile GetFile(string Name);
        void LoadFile(string path, Encoding encoding);
        void ReloadFile(string Name);
    }
}