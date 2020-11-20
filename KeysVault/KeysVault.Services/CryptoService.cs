using KeysVault.Entities;
using KeysVault.Globals;
using KeysVault.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KeysVault.Services
{
    /// <summary>
    /// Provides access to Encryption and Decryption functions.
    /// </summary>
    public class CryptoService
    {
        private static CryptoService _instance;

        protected CryptoService()
        {
        }

        public static CryptoService Instance()
        {
            if (_instance == null)
            {
                _instance = new CryptoService();
            }

            return _instance;
        }

        /// <summary>
        /// Encrypts the Password.
        /// </summary>
        /// <param name="master">The Password that is to be Encrypted.</param>
        /// <param name="password">Password to be encrypted.</param>
        /// <returns>Password: The Password in encrypted format.</returns>
        public Task<Password> EncryptPasswordAsync(string master, Password password)
        {
            return Task.Factory.StartNew(() =>
            {
                if (Verifier.Text(password.Name)) password.Name = Engine.Encrypt(password.Name, master, Defaults.InitVector, Defaults.KeySize);
                if (Verifier.Text(password.Email)) password.Email = Engine.Encrypt(password.Email, master, Defaults.InitVector, Defaults.KeySize);
                if (Verifier.Text(password.Username)) password.Username = Engine.Encrypt(password.Username, master, Defaults.InitVector, Defaults.KeySize);
                if (Verifier.Text(password.Website)) password.Website = Engine.Encrypt(password.Website, master, Defaults.InitVector, Defaults.KeySize);
                if (Verifier.Text(password.Text)) password.Text = Engine.Encrypt(password.Text, master, Defaults.InitVector, Defaults.KeySize);
                return password;
            });
        }


        /// <summary>
        /// Encrypts the Password.
        /// </summary>
        /// <param name="master">The Password that is to be Encrypted.</param>
        /// <param name="password">Password to be encrypted.</param>
        /// <returns>Password: The Password in encrypted format.</returns>
        public Password EncryptPassword(string master, Password password)
        {
            if (Verifier.Text(password.Name))
            {
                password.Name = Engine.Encrypt(password.Name, master, Defaults.InitVector, Defaults.KeySize);
            }
            if (Verifier.Text(password.Email))
            {
                password.Email = Engine.Encrypt(password.Email, master, Defaults.InitVector, Defaults.KeySize);
            }
            if (Verifier.Text(password.Username))
            {
                password.Username = Engine.Encrypt(password.Username, master, Defaults.InitVector, Defaults.KeySize);
            }
            if (Verifier.Text(password.Website))
            {
                password.Website = Engine.Encrypt(password.Website, master, Defaults.InitVector, Defaults.KeySize);
            }
            if (Verifier.Text(password.Text))
            {
                password.Text = Engine.Encrypt(password.Text, master, Defaults.InitVector, Defaults.KeySize);
            }
            return password;
        }

        /// <summary>
        /// Encrypts the List of Passwords.
        /// </summary>
        /// <param name="master">The Password that is to be Encrypted.</param>
        /// <param name="passwords">List of Passwords to be encrypted.</param>
        /// <returns>List of Passwords: The List of Passwords in encrypted format.</returns>
        public Task<List<Password>> EncryptPasswordsAsync(string master, List<Password> passwords)
        {
            return Task.Factory.StartNew(() =>
            {
                List<Password> EncryptedPasswords = new List<Password>();

                foreach (Password password in passwords)
                {
                    EncryptedPasswords.Add(EncryptPassword(master, password));
                }

                return EncryptedPasswords;
            });
        }

        /// <summary>
        /// Encrypts the List of Passwords.
        /// </summary>
        /// <param name="master">The Password that is to be Encrypted.</param>
        /// <param name="passwords">List of Passwords to be encrypted.</param>
        /// <returns>List of Passwords: The List of Passwords in encrypted format.</returns>
        public List<Password> EncryptPasswords(string master, List<Password> passwords)
        {
            List<Password> EncryptedPasswords = new List<Password>();

            foreach (Password password in passwords)
            {
                EncryptedPasswords.Add(EncryptPassword(master, password));
            }

            return EncryptedPasswords;
        }

        /// <summary>
        /// Decrypts the Password for supplied User.
        /// </summary>
        /// <param name="master">The Password that is to be Decrypted.</param>
        /// <param name="password">Password to be Decrypted.</param>
        /// <returns>Password: The Password in Decrypted format.</returns>
        public Task<Password> DecryptPasswordAsync(string master, Password password)
        {
            return Task.Factory.StartNew(() =>
            {
                if (Verifier.Text(password.Name)) password.Name = Engine.Decrypt(password.Name, master, Defaults.InitVector, Defaults.KeySize);
                if (Verifier.Text(password.Email)) password.Email = Engine.Decrypt(password.Email, master, Defaults.InitVector, Defaults.KeySize);
                if (Verifier.Text(password.Username)) password.Username = Engine.Decrypt(password.Username, master, Defaults.InitVector, Defaults.KeySize);
                if (Verifier.Text(password.Website)) password.Website = Engine.Decrypt(password.Website, master, Defaults.InitVector, Defaults.KeySize);
                if (Verifier.Text(password.Text)) password.Text = Engine.Decrypt(password.Text, master, Defaults.InitVector, Defaults.KeySize);
                return password;
            });
        }

        /// <summary>
        /// Decrypts the Password for supplied User.
        /// </summary>
        /// <param name="master">The Password that is to be Decrypted.</param>
        /// <param name="password">Password to be Decrypted.</param>
        /// <returns>Password: The Password in Decrypted format.</returns>
        public Password DecryptPassword(string master, Password password)
        {
            if (Verifier.Text(password.Name)) password.Name = Engine.Decrypt(password.Name, master, Defaults.InitVector, Defaults.KeySize);
            if (Verifier.Text(password.Email)) password.Email = Engine.Decrypt(password.Email, master, Defaults.InitVector, Defaults.KeySize);
            if (Verifier.Text(password.Username)) password.Username = Engine.Decrypt(password.Username, master, Defaults.InitVector, Defaults.KeySize);
            if (Verifier.Text(password.Website)) password.Website = Engine.Decrypt(password.Website, master, Defaults.InitVector, Defaults.KeySize);
            if (Verifier.Text(password.Text)) password.Text = Engine.Decrypt(password.Text, master, Defaults.InitVector, Defaults.KeySize);
            return password;
        }

        /// <summary>
        /// Decrypted the List of Passwords for supplied User.
        /// </summary>
        /// <param name="master">The Password that is to be Decrypted.</param>
        /// <param name="passwords">List of Passwords to be Decrypted.</param>
        /// <returns>List of Passwords: The List of Passwords in Decrypted format.</returns>
        public Task<List<Password>> DecryptPasswordsAsync(string master, List<Password> passwords)
        {
            return Task.Factory.StartNew(() =>
            {
                List<Password> decryptedPasswords = new List<Password>();

                foreach (var password in passwords)
                {
                    decryptedPasswords.Add(DecryptPassword(master, password));
                }
                return decryptedPasswords;
            });
        }

        /// <summary>
        /// Decrypted the List of Passwords for supplied User.
        /// </summary>
        /// <param name="master">The Password that is to be Decrypted.</param>
        /// <param name="passwords">List of Passwords to be Decrypted.</param>
        /// <returns>List of Passwords: The List of Passwords in Decrypted format.</returns>
        public List<Password> DecryptPasswords(string master, List<Password> passwords)
        {
            List<Password> decryptedPasswords = new List<Password>();

            foreach (var password in passwords)
            {
                decryptedPasswords.Add(DecryptPassword(master, password));
            }
            return decryptedPasswords;
        }
    }
}
