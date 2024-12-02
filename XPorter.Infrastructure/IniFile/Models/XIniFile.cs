using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XPorter.Infrastructure.IniFile.Models
{
    public class XIniFile : IEnumerable<Section>
    {
        
        public Section[] Sections { get; set; } = new Section[0];

        public bool IsEdit { get; set; } = false;

        public Encoding Encoding { get; set; } = Encoding.UTF8;

        public string filePath { get; set; } = string.Empty;
        public IEnumerator<Section> GetEnumerator()
        {
            return (IEnumerator<Section>)Sections.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public Section GetSection(string section)
        {
            var findSection = Sections.FirstOrDefault(p => p.SectionName == section);
            return findSection;
        }
    }
}
