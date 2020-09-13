using System;
using System.Security.Cryptography;
using System.Text;

namespace AES_project
{
    public class Aes
    {
        private readonly RijndaelManaged rijndael = new RijndaelManaged();
        private readonly UnicodeEncoding unicodeEncoding = new UnicodeEncoding();

        private const int KEY_SIZE = 256;
        private const int CHUNK_SIZE = 128;

        private static readonly byte[] Salt = new byte[] { 10, 20, 30, 40, 50, 60, 70, 80 };

        private void InitializeRijndael()
        {
            rijndael.Mode = CipherMode.CBC;
            rijndael.Padding = PaddingMode.PKCS7;
        }

        public Aes()
        {
            InitializeRijndael();

            rijndael.KeySize = KEY_SIZE;
            rijndael.BlockSize = CHUNK_SIZE;

            rijndael.GenerateKey();
            rijndael.GenerateIV();
        }

        public Aes(string base64key, string base64iv)
        {
            InitializeRijndael();

            rijndael.Key = CreateKey(base64key, KEY_SIZE / 8);
            rijndael.IV = Convert.FromBase64String(base64iv);
        }

        public Aes(byte[] key, byte[] iv)
        {
            InitializeRijndael();

            rijndael.Key = key;
            rijndael.IV = iv;
        }

        public string Decrypt(byte[] cipher)
        {
            ICryptoTransform transform = rijndael.CreateDecryptor();
            byte[] decryptedValue = transform.TransformFinalBlock(cipher, 0, cipher.Length);
            return unicodeEncoding.GetString(decryptedValue);
        }

        public string DecryptFromBase64String(string base64cipher)
        {
            return Decrypt(Convert.FromBase64String(base64cipher));
        }

        public byte[] EncryptToByte(string plain)
        {
            ICryptoTransform encryptor = rijndael.CreateEncryptor();
            byte[] cipher = unicodeEncoding.GetBytes(plain);
            byte[] encryptedValue = encryptor.TransformFinalBlock(cipher, 0, cipher.Length);
            return encryptedValue;
        }

        public string EncryptToBase64String(string plain)
        {
            return Convert.ToBase64String(EncryptToByte(plain));
        }

        public string GetKey()
        {
            return Convert.ToBase64String(rijndael.Key);
        }

        public string GetIV()
        {
            return Convert.ToBase64String(rijndael.IV);
        }

        public override string ToString()
        {
            return "KEY:" + GetKey() + Environment.NewLine + "IV:" + GetIV();
        }

        private byte[] CreateKey(string password, int keyBytes = 32)
        {
            const int Iterations = 300;
            var keyGenerator = new Rfc2898DeriveBytes(password, Salt, Iterations);
            return keyGenerator.GetBytes(keyBytes);
        }
    }
}
