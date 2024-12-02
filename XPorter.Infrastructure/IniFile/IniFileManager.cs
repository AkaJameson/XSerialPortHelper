using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using XPorter.Infrastructure.IniFile.Models;

namespace XPorter.Infrastructure.IniFile
{
    public class IniFileManager : IIniFileManager
    {
        private static Encoding DefaultEncoding = Encoding.UTF8;
        public Dictionary<string, XIniFile> Files { get; set; } = new Dictionary<string, XIniFile>();
        private static Lazy<IniFileManager> _lazy = new Lazy<IniFileManager>(() => new IniFileManager());
        private IniFileManager()
        {

        }
        public static IniFileManager GetManager() => _lazy.Value;
        public void LoadFile(string path, Encoding encoding)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"File not found: {path}");
            }
            // 读取文件内容
            string[] fileContent;
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
            if (encoding == null)
            {
                fileContent = File.ReadAllLines(path, DefaultEncoding);
            }
            else
            {
                fileContent = File.ReadAllLines(path, encoding);
            }
            var sections = new List<Section>();
            Section currentSection = default(Section);
            List<IniKVPairs> currentKVPairs = new List<IniKVPairs>();
            List<string> currentAnnotations = new List<string>();

            foreach (var line in fileContent)
            {
                var trimmedLine = line.Trim();

                // 如果是空行或注释，跳过
                if (string.IsNullOrEmpty(trimmedLine) || trimmedLine.StartsWith(";"))
                {
                    // 如果是注释行，添加到当前注释列表
                    if (!string.IsNullOrEmpty(trimmedLine))
                    {
                        currentAnnotations.Add(trimmedLine);
                    }
                    continue;
                }

                // 如果是节的开始
                if (trimmedLine.StartsWith("[") && trimmedLine.EndsWith("]"))
                {
                    // 如果有前一个节，保存
                    if (currentSection.SectionName != null)
                    {
                        currentSection.IniKVPairs = currentKVPairs.ToArray();
                        sections.Add(currentSection);
                    }

                    // 开始一个新的节
                    var sectionName = trimmedLine.Trim('[', ']');
                    currentSection = new Section { SectionName = sectionName, IniKVPairs = new IniKVPairs[0] };
                    currentKVPairs.Clear();
                    currentAnnotations.Clear();
                }
                else
                {
                    // 否则是键值对
                    var keyValueParts = trimmedLine.Split(new[] { '=' }, 2);
                    if (keyValueParts.Length == 2)
                    {
                        var key = keyValueParts[0].Trim();
                        var value = keyValueParts[1].Trim();

                        // 将当前注释传递给键值对
                        var annotation = currentAnnotations.ToArray();

                        // 创建新的键值对并添加到当前节的 KVPairs 中
                        currentKVPairs.Add(new IniKVPairs(key, value, annotation));

                        // 清空当前注释列表，因为下一个键值对的注释应该是新的
                        currentAnnotations.Clear();
                    }
                }
            }

            // 保存最后一个节
            if (currentSection.SectionName != null)
            {
                currentSection.IniKVPairs = currentKVPairs.ToArray();
                sections.Add(currentSection);
            }

            // 添加到 Files 中
            var iniFile = new XIniFile { Sections = sections.ToArray(), IsEdit = false, filePath = path, Encoding = encoding == null ? DefaultEncoding : encoding };
            Files[fileNameWithoutExtension] = iniFile;
        }
        // 重载（重新加载文件）
        public void ReloadFile(string Name)
        {
            Encoding encoding;
            string path;
            if (Files.ContainsKey(Name))
            {
                path = Files[Name].filePath;
                encoding = Files[Name].Encoding;
                Files.Remove(Name);
                LoadFile(path, encoding);
            }
            else
            {
                throw new ArgumentNullException($"不存在{Name}的file文件");
            }
        }
        public XIniFile GetFile(string Name)
        {
            if (Files.ContainsKey(Name))
            {
                return Files[Name];
            }
            return null;
        }
    }
}
