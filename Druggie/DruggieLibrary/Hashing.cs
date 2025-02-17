using System.Security.Cryptography;

namespace DruggieLibrary
{
    public class Hashing
    {
        private static int saltLengthLimit = 32;
        public static byte[] GetSalt()
        {
            return GetSalt(saltLengthLimit);
        }
        private static byte[] GetSalt(int maximumSaltLength)
        {
            var salt = new byte[maximumSaltLength];
            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetNonZeroBytes(salt);
            }

            return salt;
        }

        public static byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes =
              new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }

        public static bool CompareHash(byte[] hash1, byte[] hash2)
        {
            if (hash1.Length == hash2.Length)
                for (int i = 0; i < hash1.Length; i++)
                {
                    if (hash1[i] != hash2[i])
                        return false;
                }

            return true;
        }
    }
}
