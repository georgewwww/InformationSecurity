using KeysVault.Entities;
using KeysVault.Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeysVault.Services
{
    /// <summary>
    /// Provides Access to Misellanious Functions and Data.
    /// </summary>
    public class KeyVaultService
    {
        private static KeyVaultService _instance;

        protected KeyVaultService()
        {
        }

        public static KeyVaultService Instance()
        {
            if (_instance == null)
            {
                _instance = new KeyVaultService();
            }

            return _instance;
        }

        /// <summary>
        /// Imports Passwords from the Supplied File
        /// </summary>
        /// <param name="FileName">File from which Passwords to Imported.</param>
        /// <returns>List of Passwords: List of Passwords imported from File.</returns>
        public Task<List<Password>> ImportPasswordsAsync(string FileName)
        {
            return Task.Factory.StartNew(() =>
            {
                if (ValidationService.Instance().File(FileName))
                {
                    return Filer.ImportFromFile(FileName);
                }
                else return null;
            });
        }

        /// <summary>
        /// Exports Passwords to the Supplied File
        /// </summary>
        /// <param name="Passwords">Passwords to be exported</param>
        /// <param name="FileName">File to which Passwords are to be exported.</param>
        /// <returns>Boolean: True if Passwords are exported otherwise False.</returns>
        public Task<bool> ExportPasswordsAsync(List<Password> Passwords, string FileName)
        {
            return Task.Factory.StartNew(() =>
            {
                return Filer.ExportToFile(Passwords, FileName);
            });
        }
    }
}
