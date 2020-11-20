using KeysVault.Services;
using KeysVault.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeysVault.Entities;

namespace KeysVault.Services
{
    /// <summary>
    /// Provides access to User related Passwords and data.
    /// </summary>
    public class PasswordsService
    {
        private static PasswordsService _instance;

        protected PasswordsService()
        {
        }

        public static PasswordsService Instance()
        {
            if (_instance == null)
            {
                _instance = new PasswordsService();
            }

            return _instance;
        }

        /// <summary>
        /// Gets All Passwords for the Supplied User.
        /// </summary>
        /// <param name="settings">Settings the Password is to be updated.</param>
        /// <returns>List of Passwords for the supplied User.</returns>
        public Task<List<Password>> GetAllPasswordsAsync(Settings settings)
        {
            return Task.Factory.StartNew(() =>
            {
                List<Password> passwords = PasswordsData.Instance().GetPasswords();

                if (passwords != null)
                {
                    passwords = CryptoService.Instance().DecryptPasswords(settings.Master, passwords);

                    if (ValidationService.Instance().Passwords(passwords))
                    {
                        return passwords;
                    }
                    else return null;
                }
                else return null;
            });
        }


        /// <summary>
        /// Gets All Passwords for the Supplied User.
        /// </summary>
        /// <param name="settings">Settings the Password is to be updated.</param>
        /// <returns>List of Passwords for the supplied User.</returns>
        public List<Password> GetAllPasswords(Settings settings)
        {
            List<Password> passwords = PasswordsData.Instance().GetPasswords();

            if (passwords != null)
            {
                passwords = CryptoService.Instance().DecryptPasswords(settings.Master, passwords);

                if (ValidationService.Instance().Passwords(passwords))
                {
                    return passwords;
                }
                else return null;
            }
            else return null;
        }
        /// <summary>
        /// Saves a new Password for the supplied User
        /// </summary>
        /// <param name="settings">Settings the Password is to be updated.</param>
        /// <param name="password">Password to be saved.</param>
        /// <returns>Password: The newly saved Password.</returns>
        public Task<Password> SaveNewPasswordAsync(Settings settings, Password password)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    if (ValidationService.Instance().Password(password))
                    {
                        var encryptedPassword = CryptoService.Instance().EncryptPassword(settings.Master, password);
                        PasswordsData.Instance().SaveNewPassword(encryptedPassword);
                        return password;
                    }
                }
                catch (Exception)
                { }
                return null;
            });
        }

        /// <summary>
        /// Saves List of new Passwords for the supplied User
        /// </summary>
        /// <param name="settings">Settings the Password is to be updated.</param>
        /// <param name="passwords">Passwords List to be saved.</param>
        /// <returns>List of Password: The newly saved Passwords.</returns>
        public Task<List<Password>> SaveNewPasswordsAsync(Settings settings, List<Password> passwords)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    if (ValidationService.Instance().Passwords(passwords))
                    {
                        var encryptedPasswords = CryptoService.Instance().EncryptPasswords(settings.Master, passwords);
                        PasswordsData.Instance().SaveNewPasswords(passwords);
                        return passwords;
                    }
                }
                catch (Exception)
                { }
                return null;
            });
        }

        /// <summary>
        /// Updates the supplied Password.
        /// </summary>
        /// <param name="settings">Settings the Password is to be updated.</param>
        /// <param name="password">Password to be updated.</param>
        /// <returns>Password: The updated password.</returns>
        public Task<Password> UpdatePasswordAsync(Settings settings, Password password)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    if (ValidationService.Instance().Password(password))
                    {
                        var encryptedPassword = CryptoService.Instance().EncryptPassword(settings.Master, password);
                        PasswordsData.Instance().UpdatePassword(password);
                        return password;
                    }
                }
                catch (Exception)
                { }
                return null;
            });
        }

        /// <summary>
        /// Removes Password from the Supplied User.
        /// </summary>
        /// <param name="password">Password to be removed.</param>
        /// <returns>Boolean: True if Password Deleted otherwise False.</returns>
        public Task<bool> RemovePasswordAsync(Password password)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    if (ValidationService.Instance().Password(password))
                    {
                        // No need for decrypting password. We only need ID in the Delete method for work
                        PasswordsData.Instance().DeletePassword(password);
                        return true;
                    }
                }
                catch (Exception)
                { }
                return false;
            });
        }

        /// <summary>
        /// Searches the Required Passwords
        /// </summary>
        /// <param name="settings">Settings the Password is to be updated.</param>
        /// <param name="Search">Search Keyword</param>
        /// <param name="LooksFor">Looks for Password Name, Email or Username</param>
        /// <param name="Options">Options for Search Keywords Matched either Equals or Contains </param>
        /// <returns>List of Password: Passwords matching the search criteria.</returns>
        public Task<List<Password>> SearchPasswordsAsync(Settings settings, string Search, string LooksFor, string Options)
        {
            return Task.Factory.StartNew(() =>
            {
                List<Password> AllPasswords = GetAllPasswords(settings);
                if (ValidationService.Instance().Passwords(AllPasswords))
                {
                    List<Password> searchedPasswords = null;

                    if (string.IsNullOrEmpty(Search))
                    {
                        return AllPasswords;
                    }
                    else
                    {
                        switch (Options)
                        {
                            case "Contains":
                                if (LooksFor == "Username")
                                {
                                    searchedPasswords = AllPasswords.Where(p => p.Username.ToLower().Contains(Search.ToLower())).ToList();
                                }
                                else if (LooksFor == "Email")
                                {
                                    searchedPasswords = AllPasswords.Where(p => p.Email.ToLower().Contains(Search.ToLower())).ToList();
                                }
                                else
                                {
                                    searchedPasswords = AllPasswords.Where(p => p.Name.ToLower().Contains(Search.ToLower())).ToList();
                                }
                                break;
                            case "Equals":
                                if (LooksFor == "Username")
                                {
                                    searchedPasswords = AllPasswords.Where(p => p.Username.ToLower().Equals(Search.ToLower())).ToList();
                                }
                                else if (LooksFor == "Email")
                                {
                                    searchedPasswords = AllPasswords.Where(p => p.Email.ToLower().Equals(Search.ToLower())).ToList();
                                }
                                else
                                {
                                    searchedPasswords = AllPasswords.Where(p => p.Name.ToLower().Equals(Search.ToLower())).ToList();
                                }
                                break;
                        }
                        return searchedPasswords;
                    }
                }
                else return null;
            });
        }

        /// <summary>
        /// Changes the master for encryption.
        /// </summary>
        /// <param name="settings">Settings the Password is to be updated.</param>
        /// <param name="NewMaster">The new master to be updated.</param>
        /// <returns>List of Password: The updated passwords.</returns>
        public Task<Settings> ChangeMasterEncryption(Settings settings, string NewMaster)
        {
            return Task.Factory.StartNew(async () =>
            {
                if (ValidationService.Instance().Settings(settings))
                {
                    List<Password> allPasswords = GetAllPasswords(settings);

                    settings.Master = NewMaster;
                    settings = await SettingsService.Instance().UpdateSettingsAsync(settings);

                    // to encrypt passes
                    if (PasswordsData.Instance().UpdatePasswords(CryptoService.Instance().EncryptPasswords(settings.Master, allPasswords)) > 0)
                    {
                        return settings;
                    }
                    else return null;
                }
                else return null;
            }).Result;
        }

        /// <summary>
        /// Determines weather the Supplied Passwords are Same or Not.
        /// </summary>
        /// <param name="Pass1">Password to be Matched.</param>
        /// <param name="Pass2">Password to be Matched With.</param>
        /// <returns>Boolean: True if Same otherwise False.</returns>
        public bool IsSame(string Pass1, string Pass2)
        {
            return string.Equals(Pass1, Pass2);
        }

        /// <summary>
        /// Determines weather the Supplied Passwords are Same or Not.
        /// </summary>
        /// <param name="Pass1">Password to be Matched.</param>
        /// <param name="Pass2">Password to be Matched With.</param>
        /// <returns>Boolean: True if Same otherwise False.</returns>
        public Task<bool> IsSameAsync(string Pass1, string Pass2)
        {
            return Task.Factory.StartNew(() =>
            {
                return string.Equals(Pass1, Pass2);
            });
        }
    }
}
