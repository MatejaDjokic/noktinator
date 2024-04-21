using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace Noktinator
{
    public static class JsonUtil
    {
        private static readonly string path = "nails/nails.json";
        public static List<Nail> LoadNails()
        {
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Nail>>(json);
        }
        public static void SaveNails(List<Nail> nails)
        {
            string json = JsonConvert.SerializeObject(nails, Formatting.Indented);
            File.WriteAllText(path, json);
        }
        public static void OpenNailsJson()
        {
            Process.Start("notepad.exe", path);
        }
    }
}
