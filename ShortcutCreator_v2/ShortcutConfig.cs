using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ShortcutCreator_v2
{
    class ShortcutConfig
    {
        public string LinkName { get; set; }
        public string BrowserPath { get; set; }
        public string IconName { get; set; }
        public string Url { get; set; }

        public static List<ShortcutConfig> ReadJsonList(string json)
        {
            List<ShortcutConfig> configs = new List<ShortcutConfig>();
            try
            {
                Console.WriteLine(json);

                using (var webClient = new WebClient())
                {
                    webClient.Encoding = Encoding.UTF8;
                    string rawJSON = webClient.DownloadString(json);
                    configs = JsonConvert.DeserializeObject<List<ShortcutConfig>>(rawJSON);
                }
                Console.WriteLine("Json is readable as expected. Example host: " + configs[0].Url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERR " + ex.Message);
            }
            return configs;
        }
    }

}
