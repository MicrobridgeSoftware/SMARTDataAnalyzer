using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartDataAnalyzer.ApplicationUtil
{
    public static class DecryptFoxProHash
    {
        private static string passPhrase = "Prey!@,...577687";
        private static string saltValue = "s@1tValue124326";        // can be any string
        private static string hashAlgorithm = "SHA1";             // can be "MD5"
        private static int passwordIterations = 2;                  // can be any number
        private static string initVector = "@1B2c3D4e5F123!@"; // must be 16 bytes
        private static int keySize = 256;

        public static string Decrypt(string cipherText)
        {

            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

            PasswordDeriveBytes password = new PasswordDeriveBytes(
                                                            passPhrase,
                                                            saltValueBytes,
                                                            hashAlgorithm,
                                                            passwordIterations);

            byte[] keyBytes = password.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);

            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);

            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                            decryptor,
                                                            CryptoStreamMode.Read);

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes,
                                                        0,
                                                        plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();

            string plainText = Encoding.UTF8.GetString(plainTextBytes,
                                                        0,
                                                        decryptedByteCount);
            return plainText;
        }
    }
}
