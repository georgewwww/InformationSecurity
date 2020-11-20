using KeysVault.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KeysVault.Globals
{
    public static class Filer
    {
        public static List<Password> ImportFromFile(string FileName)
        {
            var importedPasswords = new List<Password>();
            try
            {
                var byteConverter = new UnicodeEncoding();

                using var fs = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                using var sr = new StreamReader(fs, Encoding.UTF8);
                string content = sr.ReadToEnd().Replace("\0", string.Empty);

                var byteArray = Security.RSA.Instance().Decryption(content, true);

                importedPasswords = JsonConvert.DeserializeObject<List<Password>>(byteConverter.GetString(byteArray));
            }
            catch (Exception)
            { }

            return importedPasswords;
        }

        public static bool ExportToFile(List<Password> Passwords, string FileName)
        {
            try
            {
                var byteConverter = new UnicodeEncoding();
                var data = byteConverter.GetBytes(JsonConvert.SerializeObject(Passwords));

                var byteArray = Security.RSA.Instance().Encryption(data, true);

                using var fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
                fs.Write(byteArray, 0, byteArray.Length);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
