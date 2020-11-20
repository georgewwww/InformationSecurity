using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;

namespace KeysVault.Security
{
    public class RSA
    {
        private static RSA _instance;

        public RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider();
        public string GeneralKey => "<RSAKeyValue><Modulus>t0eMy8olmPthwEp6832oRM3+JrRXzHtZPzCXGjxI5tP7Vi1j26KqoFNW7pL4T9u9cI7Hvo9GfYn45bP96+YQrJbhPAoSMYNArUGLDTdAremc6BBGMguHGjSdeTLjcSNQUhRHIhppC93pAwfvKYeOpauikGHHdpvd3o+IncZIlbE=</Modulus><Exponent>AQAB</Exponent><P>37c0cgHiOqO5xBGcdTlHFMySvHrsTKlY1i5hTamEb5hT2+5+tscykdORW27NT6XZUu/F/tdQXMx49kQtgGxdvw==</P><Q>0bqAA3CbWxOzvOJtV661z8mx7F2/NgbecVOsauvDZLOs/Pt4JABLC1wCoM1Ffm3Fj1GFHQJ2qrqfjCeqdj3Ijw==</Q><DP>annv5DMxUWeLit428TQJuMSFMl/vB62yMn5woV4FQnflsc+ZT7UPRIjFrhbWcQomnWqxedFQ1lobWFqqrWzmUQ==</DP><DQ>gD40TOYseRKhE1y5U6ZnUjmY7FmetGCa4F0zzuV/QzKDEuaJ3im3uah3ivA6EEb7SNmmNcjt2xPmv4L5vvekjQ==</DQ><InverseQ>rmLP/gFXBJ3KYwsQmNQxMmpjmgcF96HOjhBWDcRKIEOe07yny97tuI7pAF049LI0OG6YMF1fT5TYHYSb5LUWbQ==</InverseQ><D>tHadKeQnVRTg0UgE/E/UKbty7oVQliU2YUPk5I5Lcg10Qwx6cL8gprCovky0d110kKnl/7pvvBjonLS351knPD6hrKwo/C99nupxR4mlPtgmCytB6uA+Rj8VaqSI5Z/KLnn3aShEWR9d9vtcIZoMi0gqoN0UBnhXYLd0h0nBRQk=</D></RSAKeyValue>";
        public string PublicKey => "<RSAKeyValue><Modulus>t0eMy8olmPthwEp6832oRM3+JrRXzHtZPzCXGjxI5tP7Vi1j26KqoFNW7pL4T9u9cI7Hvo9GfYn45bP96+YQrJbhPAoSMYNArUGLDTdAremc6BBGMguHGjSdeTLjcSNQUhRHIhppC93pAwfvKYeOpauikGHHdpvd3o+IncZIlbE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        private RSA()
        { }

        public static RSA Instance()
        {
            if (_instance == null)
            {
                _instance = new RSA();
            }

            return _instance;
        }

        public byte[] Encryption(byte[] data, bool doOAEPPadding)
        {
            try
            {
                var byteConverter = new UnicodeEncoding();
                RSACryptoServiceProvider rsaService = new RSACryptoServiceProvider();
                rsaService.FromXmlString(PublicKey);

                var dwKeySize = 1024;
                int keySize = dwKeySize / 8;
                // The hash function in use by the .NET RSACryptoServiceProvider here is SHA1
                // int maxLength = ( keySize ) - 2 - ( 2 * SHA1.Create().ComputeHash( rawBytes ).Length );
                int maxLength = keySize - 42;
                int dataLength = data.Length;
                int iterations = dataLength / maxLength;
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i <= iterations; i++)
                {
                    byte[] tempBytes = new byte[(dataLength - maxLength * i > maxLength) ? maxLength : dataLength - maxLength * i];
                    Buffer.BlockCopy(data, maxLength * i, tempBytes, 0, tempBytes.Length);
                    byte[] encryptedBytes = rsaService.Encrypt(tempBytes, doOAEPPadding);
                    // Be aware the RSACryptoServiceProvider reverses the order of encrypted bytes after encryption and before decryption.
                    // If you do not require compatibility with Microsoft Cryptographic API (CAPI) and/or other vendors.
                    // Comment out the next line and the corresponding one in the DecryptString function.
                    Array.Reverse(encryptedBytes);
                    // Why convert to base 64?
                    // Because it is the largest power-of-two base printable using only ASCII characters
                    stringBuilder.Append(Convert.ToBase64String(encryptedBytes));
                }
                return byteConverter.GetBytes(stringBuilder.ToString());
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

        public byte[] Decryption(string data, bool doOAEPPadding)
        {
            try
            {
                RSACryptoServiceProvider RSAService = new RSACryptoServiceProvider();
                RSAService.FromXmlString(GeneralKey);

                var dwKeySize = 1024;
                int base64BlockSize = ((dwKeySize / 8) % 3 != 0) ? (((dwKeySize / 8) / 3) * 4) + 4 : ((dwKeySize / 8) / 3) * 4;
                int iterations = data.Length / base64BlockSize;
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < iterations; i++)
                {
                    byte[] encryptedBytes = Convert.FromBase64String(data.Substring(base64BlockSize * i, base64BlockSize));
                    // Be aware the RSACryptoServiceProvider reverses the order of encrypted bytes after encryption and before decryption.
                    // If you do not require compatibility with Microsoft Cryptographic API (CAPI) and/or other vendors.
                    // Comment out the next line and the corresponding one in the EncryptString function.
                    Array.Reverse(encryptedBytes);
                    arrayList.AddRange(RSAService.Decrypt(encryptedBytes, doOAEPPadding));
                }
                return arrayList.ToArray(Type.GetType("System.Byte")) as byte[];
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        }
    }
}
