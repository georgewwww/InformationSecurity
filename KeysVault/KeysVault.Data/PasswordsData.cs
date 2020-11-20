using KeysVault.Database;
using KeysVault.Entities;
using System.Collections.Generic;

namespace KeysVault.Data
{
    public class PasswordsData
    {
        private static PasswordsData _instance;

        private readonly DbContext Database = DbContext.Instance();

        protected PasswordsData()
        {
        }

        public static PasswordsData Instance()
        {
            if (_instance == null)
            {
                _instance = new PasswordsData();
            }

            return _instance;
        }

        public void SaveNewPassword(Password password)
        {
            Database.AddNewPassword(password);
        }

        public void SaveNewPasswords(List<Password> passwords)
        {
            Database.AddNewPasswords(passwords);
        }

        public List<Password> GetPasswords()
        {
            return Database.GetPasswords();
        }

        public void UpdatePassword(Password password)
        {
            Database.UpdatePasswordById(password);
        }

        public int UpdatePasswords(List<Password> passwords)
        {
            return Database.UpdatePasswords(passwords);
        }

        public void DeletePassword(Password password)
        {
            Database.DeletePasswordById(password.Id);
        }
    }
}
