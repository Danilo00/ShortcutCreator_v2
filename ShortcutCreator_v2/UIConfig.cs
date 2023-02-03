using System;
using System.Windows.Forms;

namespace ShortcutCreator_v2
{
    public partial class UIConfig : Form
    {
        public UIConfig()
        {
            InitializeComponent();
        }

        private void UIConfig_Load(object sender, EventArgs e)
        {

        }

        private void btn_shortcutGenerator_Click(object sender, EventArgs e)
        {
            Functions.Engine();
        }

        private void bnt_plus_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txt_linkName.Text) && !string.IsNullOrWhiteSpace(txt_browserPath.Text) && !string.IsNullOrWhiteSpace(txt_iconName.Text) && !string.IsNullOrWhiteSpace(txt_url.Text))
            {
                ClearValues();
                Global.currentEntry = Global.configs.Count;
                gb_shortcut.Text = Global.gbShortcut + (Global.currentEntry + 1);
                ShortcutConfig config = new ShortcutConfig() { LinkName = txt_linkName.Text, BrowserPath = txt_browserPath.Text, IconName = txt_iconName.Text, Url = txt_url.Text };
                Global.configs.Add(config);     
            }
            else
            {
                MessageBox.Show("Please do not let empty fields.", "Can't create new configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (Global.currentEntry < Global.configs.Count - 1)
            {
                Global.currentEntry++;
                SetValues();
                gb_shortcut.Text = Global.gbShortcut + (Global.currentEntry + 1);
            }            
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (Global.currentEntry <= Global.configs.Count && Global.currentEntry > 0) 
            {
                Global.currentEntry--;
                SetValues();
                gb_shortcut.Text = Global.gbShortcut + (Global.currentEntry + 1);
            }
        }

        private void btnUpdateConfig_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_linkName.Text) && !string.IsNullOrWhiteSpace(txt_browserPath.Text) && !string.IsNullOrWhiteSpace(txt_iconName.Text) && !string.IsNullOrWhiteSpace(txt_url.Text))
            {
                if (Global.configs.Count > 0)
                {
                    Global.configs[Global.currentEntry].LinkName = txt_linkName.Text;
                    Global.configs[Global.currentEntry].BrowserPath = txt_browserPath.Text;
                    Global.configs[Global.currentEntry].IconName = txt_iconName.Text;
                    Global.configs[Global.currentEntry].Url = txt_url.Text;
                }
                else
                {
                    ShortcutConfig config = new ShortcutConfig() { LinkName = txt_linkName.Text, BrowserPath = txt_browserPath.Text, IconName = txt_iconName.Text, Url = txt_url.Text };
                    Global.configs.Add(config);
                }
            }
            else 
            {
                MessageBox.Show("Please do not let empty fields.", "Can't create new configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void btn_iconFileName_Click(object sender, EventArgs e)
        {
            txt_iconName.Text = Functions.OpenFileDialog();
        }

        private void btn_browserPath_Click(object sender, EventArgs e)
        {
            txt_browserPath.Text = Functions.OpenFileDialog();
        }

        private void btnExportImport_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Select YES to export a configuration file.\nSelect NO to import an existing configuration file.", "EXPORT/IMPORT", MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes)
            {
                // EXPORT
                if (Global.configs.Count > 0)
                {
                    Functions.CreateConfigFile(Global.configs);
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.InitialDirectory = @"C:\";
                    saveFileDialog1.Title = "Export Config.json";
                    saveFileDialog1.CheckPathExists = true;
                    saveFileDialog1.DefaultExt = "json";
                    saveFileDialog1.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.RestoreDirectory = true;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (System.IO.File.Exists(saveFileDialog1.FileName)) System.IO.File.Delete(saveFileDialog1.FileName);
                        System.IO.File.Move(Global.json, saveFileDialog1.FileName);
                    }
                }
                else MessageBox.Show("Please create a configuration.", "Can't do the Export", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(result == DialogResult.No)
            {
                // IMPORT
                if (!Functions.CreateConfigFile(Functions.OpenFileDialog()))
                {
                    MessageBox.Show("Can't Import Configuration. More info in log file.", "Can't do the import", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else { SetValues(); }
            }
        }

        private void btnDeleteConfig_Click(object sender, EventArgs e)
        {

            Global.configs.RemoveAt(Global.currentEntry);
            if (Global.currentEntry > 0)
            {
                Global.currentEntry--;
                gb_shortcut.Text = Global.gbShortcut + (Global.currentEntry + 1);
            }
            SetValues();
        }
        private void onFormClose(object sender, FormClosingEventArgs e)
        {
            //if(Functions.LoadParametersXML()) maybe it is better I save history only if used before
            {
                if (Global.history.ToUpper() == "ON" && Global.configs.Count > 0)
                {
                    Functions.CreateConfigFile(Global.configs);
                    System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Global.exJson));
                    System.IO.File.Move(Global.json, Global.exJson);
                }
            }
        }
        #region RIPETITIVE
        private void ClearValues()
        {
            txt_linkName.Text = "";
            txt_browserPath.Text = "";
            txt_iconName.Text = "";
            txt_url.Text = "";
        }
        private void SetValues()
        {
            try
            {
                txt_linkName.Text = Global.configs[Global.currentEntry].LinkName;
                txt_browserPath.Text = Global.configs[Global.currentEntry].BrowserPath;
                txt_iconName.Text = Global.configs[Global.currentEntry].IconName;
                txt_url.Text = Global.configs[Global.currentEntry].Url;
            }
            catch
            {
                txt_linkName.Text = "";
                txt_browserPath.Text = "";
                txt_iconName.Text = "";
                txt_url.Text = "";
            }
        }
        #endregion
    }
}
