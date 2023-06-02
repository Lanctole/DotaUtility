using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DotaUtility.HotKeys
{
    internal static class HotKeyWorker
    {
        private static List<Options> optionsList = new List<Options>{};
        private static string jsonString;
        private static Form1 form;
        public static void InitializeKeys(Form1 form)
        {
            HotKeyWorker.form =form;
            if (File.Exists("options.json"))
            {
                jsonString = File.ReadAllText("options.json");
                optionsList = JsonSerializer.Deserialize<List<Options>>(jsonString);
            }
            else
            {
                optionsList = new List<Options>
                {
                    new Options { Description = "Roshan", Key = Keys.Z, Timer = new System.Timers.Timer(480000) },
                    new Options { Description = "Tormentor", Key = Keys.X, Timer = new System.Timers.Timer(600000) },
                    new Options { Description = "Rune of Experience", Key = Keys.C, Timer = new System.Timers.Timer(420000) }
                };
                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                jsonString = JsonSerializer.Serialize(optionsList, options);
                File.WriteAllText("options.json", jsonString);
            }
        }

        public static void AddToView()
        {
            foreach (Options option in optionsList)
            {
                form.CreateHotKeyLine(option);
            }
        }
    }
}
