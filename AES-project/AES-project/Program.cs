using Pastel;
using System;
using System.Drawing;
using System.Text;

namespace AES_project
{
    class Program
    {
        private const string ORIGINAL = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque non dui tellus.";
        private const string SAMPLE_KEY = "gCjK+DZ/GCYbKIGiAt1qCA==";
        private const string SAMPLE_IV = "47l5QsSe1POo31adQ/u7nQ==";

        static void Main(string[] args)
        {
            try
            {
                var aes = new Aes(SAMPLE_KEY, SAMPLE_IV);

                Console.WriteLine("ORIGINAL:\t" + ORIGINAL.Pastel(Color.Green));
                Console.WriteLine("AES KEY:\t" + aes.GetKey().Pastel(Color.Green));
                Console.WriteLine("AES IV:\t\t" + aes.GetIV().Pastel(Color.Green));

                Console.WriteLine("\n\nExample for format: " + "string -> byte -> string".Pastel(Color.Orange));
                byte[] encryptedBlock = aes.EncryptToByte(ORIGINAL);
                string decryptedString = aes.Decrypt(encryptedBlock);
                Console.WriteLine(Encoding.UTF8.GetString(encryptedBlock));
                Console.WriteLine(decryptedString);

                Console.WriteLine("\n\nExample for format: " + "string -> base64 -> string".Pastel(Color.Orange));
                string encryptedBase64String = aes.EncryptToBase64String(ORIGINAL);
                decryptedString = aes.DecryptFromBase64String(encryptedBase64String);
                Console.WriteLine(encryptedBase64String);
                Console.WriteLine(decryptedString);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: Something went wrong while processing request. {e.Message}");
            }

            Console.ReadLine();
        }
    }
}
