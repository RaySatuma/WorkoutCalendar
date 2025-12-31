using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace finalProject
{
    public static class AppStorage
    {
        public static readonly string AppDir =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "finalProject");

        public static readonly string TxtPath = Path.Combine(AppDir, "settings.txt");

        public static void SaveProfile(string userName, string languageKey)
        {
            var data = LoadAllAsDictionary();
            data["UserName"] = userName ?? "";
            data["Language"] = languageKey ?? "Language";
            WriteDictionary(data);
        }

        public static void SaveBody(int sex, int age, float height, float weight, int exerciseLevel)
        {
            var data = LoadAllAsDictionary();
            data["Sex"] = sex.ToString();
            data["Age"] = age.ToString();
            data["Height"] = height.ToString(CultureInfo.InvariantCulture);
            data["Weight"] = weight.ToString(CultureInfo.InvariantCulture);
            data["ExerciseLevel"] = exerciseLevel.ToString();
            WriteDictionary(data);
        }

        public static (string userName, string languageKey, int sex, int age, float height, float weight, int exerciseLevel) Load()
        {
            var data = LoadAllAsDictionary();

            string userName = data.TryGetValue("UserName", out var n) ? n : "";
            string language = data.TryGetValue("Language", out var l) ? l : "Language";

            int sex = TryInt(data, "Sex");
            int age = TryInt(data, "Age");
            float height = TryFloat(data, "Height");
            float weight = TryFloat(data, "Weight");
            int ex = TryInt(data, "ExerciseLevel");

            return (userName, language, sex, age, height, weight, ex);
        }

        private static int TryInt(Dictionary<string, string> data, string key)
            => data.TryGetValue(key, out var v) && int.TryParse(v, out var x) ? x : 0;

        private static float TryFloat(Dictionary<string, string> data, string key)
            => data.TryGetValue(key, out var v) && float.TryParse(v, NumberStyles.Float, CultureInfo.InvariantCulture, out var x) ? x : 0f;

        private static Dictionary<string, string> LoadAllAsDictionary()
        {
            var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            if (!File.Exists(TxtPath)) return dict;

            foreach (var line in File.ReadAllLines(TxtPath))
            {
                if (string.IsNullOrWhiteSpace(line) || !line.Contains('=')) continue;
                var parts = line.Split(new[] { '=' }, 2);
                dict[parts[0].Trim()] = parts[1].Trim();
            }
            return dict;
        }

        private static void WriteDictionary(Dictionary<string, string> dict)
        {
            Directory.CreateDirectory(AppDir);
            var lines = dict.Select(kv => $"{kv.Key}={kv.Value}").ToArray();
            File.WriteAllLines(TxtPath, lines);
        }
    }
}
