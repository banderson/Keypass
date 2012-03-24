using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace KeyPassBusiness
{
    // Adapted from Visual C# 2010 Recipes book (pg. 594)
    public static class CryptoHelper
    {
        static byte[] entropy = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

        public static byte[] Encrypt(byte[] input)
        {
            return ProtectedData.Protect(input, entropy, DataProtectionScope.LocalMachine);
        }

        public static byte[] Decrypt(byte[] output)
        {
            return ProtectedData.Unprotect(output, entropy, DataProtectionScope.CurrentUser);
        }
    }
}
