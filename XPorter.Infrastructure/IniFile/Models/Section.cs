using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace XPorter.Infrastructure.IniFile.Models
{
    public struct Section : IEnumerable<IniKVPairs>
    {
        public string SectionName { get; set; }

        public IniKVPairs[] IniKVPairs { get; set; }

        public Section(string sectionName, IniKVPairs[] IniKeyValuePairs) 
        {
            this.SectionName = sectionName;
            this.IniKVPairs = IniKeyValuePairs;
        }
        public IEnumerator<IniKVPairs> GetEnumerator()
        {
            return ((IEnumerable<IniKVPairs>)IniKVPairs).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public IniKVPairs GetIniKVPair(string Key)
        {
            if(IniKVPairs == null)
            {
                return default;
            }
            return IniKVPairs.FirstOrDefault(kv => kv.Key.Equals(Key,System.StringComparison.OrdinalIgnoreCase));
        }

        public List<KeyValuePair<string,string>> ToList()
        {
            return IniKVPairs.Select(p=>new KeyValuePair<string, string>(p.Key, p.Value)).ToList();
        }
    }
}
