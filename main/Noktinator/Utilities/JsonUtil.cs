using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;
using System.IO;

namespace Noktinator
{
    public static class JsonUtil
    {
        /// <summary>
        /// Path to the json file where the nails are stored localy
        /// </summary>
        private static readonly string path = "nails/nails.json";

        /// <summary>
        /// Returns a list of nails loaded from the local storage json file nails.json
        /// </summary>
        /// <returns></returns>
        public static List<Nail> LoadNails()
        {
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Nail>>(json);
        }

        /// <summary>
        /// Saves the list of nails that is given to the local storage json file nails.json
        /// </summary>
        /// <param name="nails"></param>
        public static void SaveNails(List<Nail> nails)
        {
            string json = JsonConvert.SerializeObject(nails, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Opens the local storage json file nails.josn inside notepad
        /// </summary>
        public static void OpenNailsJson()
        {
            Process.Start("notepad.exe", path);
        }
    }
}
