using System.IO;
using System.Reflection;

namespace SaasProductsImport
{
    public static class Settings
    {
        public static string ConfigPath
        {
            get
            {
                return Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Configurations");
            }
        }
    }
}