using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCessentials.assets
{

    /// <summary>
    /// Konfigurationseinstellungen für die Anwendung.
    /// </summary>
    public static class config
    {
        // Main Application Details
        public static string ApplicationName    = "PCessentials";
        public static string ApplicationVersion = "DEV-0.0.0.0.1";//{BUILD}-{VERSION}
        public static string AuthorName         = "JDi-Coding";

        // Application Settings

        public static string Language = "en-US";

        //Theme
        public static event Action DarkModeChanged;
        public static bool isDarkmode() => Properties.Settings.Default.DarkModeEnabled;
        public static void SetDarkMode(bool enabled)
        {
            //On Value Change
            if (Properties.Settings.Default.DarkModeEnabled != enabled)
            {
                Properties.Settings.Default.DarkModeEnabled = enabled;
                Properties.Settings.Default.Save();
                DarkModeChanged?.Invoke();
            }
        }


    }
}
