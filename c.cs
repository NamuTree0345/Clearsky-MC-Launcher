using CmlLib.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CmlLib;
using System.Windows.Forms;
using System.Configuration;

namespace ClearSky_LauncherR1
{
    class c
    {
        public static MLogin login = new MLogin();
        public static MSession session;
        public static int screenHeight = 600; public static int screenWidth = 800;
        public static int maxRam = 2480;

        public static void info(string msg) {
            MessageBox.Show(msg, "ClearSky Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void error(string msg) {
            MessageBox.Show(msg, "ClearSky Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void loginSuccess(Form form) {
            new LauncherMain().Show();
            form.Hide();
        }

        public static void setConfig(string key, string value) {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            KeyValueConfigurationCollection cfgCollection = config.AppSettings.Settings;

            cfgCollection.Remove(key);
            cfgCollection.Add(key, value);
            config.Save();
        }

        public static string getConfig(string key) {
            return ConfigurationManager.AppSettings[key];
        }

        public static void AddAppConfig(string key, string value) {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            KeyValueConfigurationCollection cfgCollection = config.AppSettings.Settings;

            cfgCollection.Add(key, value);
            config.Save();
        }

        public static void RemoveAppConfig(string key) {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            KeyValueConfigurationCollection cfgCollection = config.AppSettings.Settings;

            try
            {
                cfgCollection.Remove(key);

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            }
            catch { }
        }
    }
}
