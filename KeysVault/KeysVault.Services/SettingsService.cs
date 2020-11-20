using KeysVault.Data;
using KeysVault.Entities;
using System.Threading.Tasks;

namespace KeysVault.Services
{
    /// <summary>
    /// Provides access to User related Settings and data.
    /// </summary>
    public class SettingsService
    {
        private static SettingsService _instance;

        protected SettingsService()
        {
        }

        public static SettingsService Instance()
        {
            if (_instance == null)
            {
                _instance = new SettingsService();
            }

            return _instance;
        }

        /// <summary>
        /// Gets the Settings.
        /// </summary>
        /// <returns>Settings: The Settings for User</returns>
        public Task<Settings> GetSettingsAsync()
        {
            return Task.Factory.StartNew(() =>
            {
                return SettingsData.Instance().GetSettings();
            });
        }

        /// <summary>
        /// Save the Settings.
        /// </summary>
        /// <returns>Int32: Quantity of inserted entities</returns>
        public Task<int> SaveNewSettingsAsync(Settings settings)
        {
            return Task.Factory.StartNew(() =>
            {
                return SettingsData.Instance().SaveSettings(settings);
            });
        }

        /// <summary>
        /// Updates the supplied User Settings.
        /// </summary>
        /// <param name="settings">Settings which are to be updated.</param>
        /// <returns>User: User with the updated settings.</returns>
        public Task<Settings> UpdateSettingsAsync(Settings settings)
        {
            return Task.Factory.StartNew(() =>
            {
                if (ValidationService.Instance().Settings(settings))
                {
                    if (SettingsData.Instance().UpdateSettings(settings) > 0)
                    {
                        return settings;
                    }
                    else return null;
                }
                else return null;
            });
        }
    }
}
