namespace XPorter.Infrastructure.IniFile.Models
{
    public struct IniKVPairs
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string[] Annotation { get; set; }

        public IniKVPairs(string key, string value, string[] annotation)
        {
            this.Key = key;
            this.Value = value;
            this.Annotation = annotation;
        }
    }

}
