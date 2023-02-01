using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using IWshRuntimeLibrary;
using System.Configuration;
using Newtonsoft.Json;
using System.Net;

namespace ShortcutCreator_v2
{
    class Functions
    {
        
        public static void CreateConfigFile(List<ShortcutConfig> configs)
        {
            JsonSerializerSettings _options = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
            var jsonString = JsonConvert.SerializeObject(configs, _options);
            System.IO.File.WriteAllText(Global.json, jsonString);
        }
        public static bool CreateConfigFile(string json)
        {
            try
            {
                Console.WriteLine(json);

                using (var webClient = new WebClient())
                {
                    webClient.Encoding = Encoding.UTF8;
                    string rawJSON = webClient.DownloadString(json);
                    Global.configs = JsonConvert.DeserializeObject<List<ShortcutConfig>>(rawJSON);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Global.log.Write($"Functions.LoadParametersXML-->{ex.Message}");
                return false;
            }
        }
        public static bool LoadParametersXML()
        {
            try
            {
                AppSettingsReader appReader = new AppSettingsReader();
                Global.destinationPath = appReader.GetValue("destinationShortcutsPath", typeof(string)).ToString();

                return true;
            }
            catch (Exception ex)
            {
                Global.log.Write($"Functions.LoadParametersXML-->{ex.Message}");
                return false;
            }
        }
        public static void Engine()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (Global.configs.Count > 0)
                {
                    string shortcutPath = string.Empty;
                    foreach (ShortcutConfig config in Global.configs)
                    {
                        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                        if (!LoadParametersXML()) Global.destinationPath = desktopPath;

                        shortcutPath = Path.Combine(Global.destinationPath, config.LinkName + ".lnk"); // Set Link Name
                        WshShell shell = new WshShell();
                        IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
                        shortcut.TargetPath = config.BrowserPath; // Set Browser
                        shortcut.IconLocation = Path.Combine(Directory.GetCurrentDirectory(), config.IconName); // Set Icon
                        shortcut.Arguments = config.Url; // Set Website URL
                        shortcut.Save();
                        Console.WriteLine("Shortcut created at: " + Global.destinationPath);
                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show($"Shortcuts created at: {Global.destinationPath}","SUCCESS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else MessageBox.Show("Please insert at least one configuration.", "Can't create shortcuts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                Global.log.Write($"Functions.Main-->{ex.Message}");
                MessageBox.Show("Something went wrong... \nMore info in log file", "Can't create shortcuts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string OpenFileDialog()
        {
            string ret = string.Empty;
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                    ret = openFileDialog1.FileName;
                }
                return ret;
            }
            catch (Exception ex)
            {
                Global.log.Write($"Functions.Main-->{ex.Message}");
                return ret;
            }
        }

        #region EX APPROACH
        public static void CreateConfigFile()
        {
            try
            {
                // delete config if exist, save before
                if (System.IO.File.Exists(Global.json))
                {
                    System.IO.File.Move(Global.json, Global.exJson);
                    System.IO.File.Delete(Global.json);
                }

                // create config empty for one entry
                System.IO.File.WriteAllText(Global.json,
                      "[" + Environment.NewLine
                    + "{" + Environment.NewLine
                    + "\"LinkName\": \"\"," + Environment.NewLine
                    + "\"BrowserPath\": \"\"," + Environment.NewLine
                    + "\"IconName\": \"\"," + Environment.NewLine
                    + "\"Url\": \"\"," + Environment.NewLine
                    + "}" + Environment.NewLine
                    + "]");
            }
            catch (Exception ex)
            {
                Global.log.Write($"Functions.CreateConfigFile-->{ex.Message}");
            }
        }
        public static void FillConfigEntry(string text, string linkName, string browserPath, string iconName, string url)
        {
            try
            {
                if (System.IO.File.Exists(Global.json))
                {
                    FillEntry(text, "\"LinkName\": \"", linkName);
                    FillEntry(text, "\"BrowserPath\": \"", browserPath);
                    FillEntry(text, "\"IconName\": \"", iconName);
                    FillEntry(text, "\"Url\": \"", url);
                }
            }
            catch (Exception ex)
            {
                Global.log.Write($"Functions.CreateConfigFile-->{ex.Message}");
            }
        }
        public static void FillEntry(string text, string insertPoint, string entry)
        {
            text = System.IO.File.ReadAllText(Global.json);
            int index = text.IndexOf(insertPoint) + insertPoint.Length;
            text = text.Insert(index, entry);
            System.IO.File.WriteAllText(Global.json, text);
        }
        public static string NewEmptyEntry()
        {
            string text = "," + Environment.NewLine
                    + "{" + Environment.NewLine
                    + "\"LinkName\": \"\"," + Environment.NewLine
                    + "\"BrowserPath\": \"\"," + Environment.NewLine
                    + "\"IconName\": \"\"," + Environment.NewLine
                    + "\"Url\": \"\"," + Environment.NewLine
                    + "}" + Environment.NewLine
                    + "]";

            return text;
        }
        #endregion
    }
}
