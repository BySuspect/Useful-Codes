using System.IO;
using Microsoft.Win32;

namespace MyProject
{
    public static class StartupManager
    {
        public static void AddApplicationToCurrentUserStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.SetValue("My Application", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyApplication.exe"));
                //key.SetValue(AppDomain.CurrentDomain.FriendlyName.Replace(".exe", ""), Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppDomain.CurrentDomain.FriendlyName));

            }
        }

        public static void RemoveApplicationFromCurrentUserStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.DeleteValue("My Application", false);
                //key.DeleteValue(AppDomain.CurrentDomain.FriendlyName.Replace(".exe", ""), false);
            }
        }
    }
}
