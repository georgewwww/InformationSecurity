using KeysVault.Database;
using KeysVault.Entities;

namespace KeysVault.Data
{
    public class SettingsData
    {
        private static SettingsData _instance;

        private DbContext Database = DbContext.Instance();

        protected SettingsData()
        {
        }

        public static SettingsData Instance()
        {
            if (_instance == null)
            {
                _instance = new SettingsData();
            }

            return _instance;
        }

        public int UpdateSettings(Settings settings)
        {
            return Database.UpdateSettings(settings);
        }

        public int SaveSettings(Settings settings)
        {
            return Database.AddSettings(settings);
        }

        public Settings GetSettings()
        {
            return Database.GetSettings();
        }
    }
}
