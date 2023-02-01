using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ShortcutCreator_v2
{
    class Global
    {
        public static string json = Path.Combine(Directory.GetCurrentDirectory(), "config.json");
        public static string exJson = Path.Combine(Directory.GetCurrentDirectory(), DateTime.Now.ToString("dd-MM-yyyy"), DateTime.Now.ToString("HH-mm-ss"), "config.json");

        public static string destinationPath = string.Empty;
        public static string gbShortcut = "Shortcut ";

        public static List<ShortcutConfig> configs = new List<ShortcutConfig>();

        public static LogFile log = new LogFile("log.txt");
        public static int currentEntry = 0;
        public static int upClickDelta = 1;
        public static bool isFirstEntry = true;
    }
}
