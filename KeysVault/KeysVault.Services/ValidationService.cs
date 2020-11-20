using System.Collections.Generic;
using KeysVault.Entities;
using KeysVault.Globals;

namespace KeysVault.Services
{
    /// <summary>
    /// Provides Validation for Different Entities and Objects in BearPass
    /// </summary>
    public class ValidationService
    {
        private static ValidationService _instance;

        protected ValidationService()
        {
        }

        public static ValidationService Instance()
        {
            if (_instance == null)
            {
                _instance = new ValidationService();
            }

            return _instance;
        }

        /// <summary>
        /// Determines wether the supplied Password object is valid.
        /// </summary>
        /// <param name="password">Password object be validated.</param>
        /// <returns>Boolean: True if Valid otherwise False.</returns>
        public bool Password(Password password)
        {
            if (password != null)
            {
                if (Verifier.Email(password.Email) && Verifier.Text(password.Text))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        /// <summary>
        /// Determines wether the supplied List of Password objects is valid.
        /// </summary>
        /// <param name="passwords">List of type Password object be validated.</param>
        /// <returns>Boolean: True if Valid otherwise False.</returns>
        public bool Passwords(List<Password> passwords)
        {
            if (passwords != null)
            {
                bool result = true;

                foreach (Password password in passwords)
                {
                    if (password != null)
                    {
                        if (!Verifier.Email(password.Email) || !Verifier.Text(password.Text))
                        {
                            result = false;
                        }
                    }
                    else result = false;
                }

                return result;
            }
            else return false;
        }

        /// <summary>
        /// Determines wether the supplied Settings object is valid.
        /// </summary>
        /// <param name="settings">Settings object be validated.</param>
        /// <returns>Boolean: True if Valid otherwise False.</returns>
        public bool Settings(Settings settings)
        {
            if (settings != null)
            {
                if (Verifier.Id(settings.Id))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        /// <summary>
        /// Determines wether the supplied File path is valid.
        /// </summary>
        /// <param name="fileName">File Path be validated.</param>
        /// <returns>Boolean: True if Valid otherwise False.</returns>
        public bool File(string fileName)
        {
            if (Verifier.Text(fileName))
            {
                return System.IO.File.Exists(fileName);
            }
            else return false;
        }
    }
}
