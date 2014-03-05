// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using System;
using Windows.Security.Cryptography.Core;
using Windows.Security.Cryptography;

namespace Loqu8.MvvmCross.Plugins.Cryptography.Adaptation
{
    public class CryptographyFactory : ICryptographyFactory
    {
        public CryptographyFactory()
        {
              
        }

        #region ICryptography

        public ISymmetricAlgorithm CreateAesManaged()
        {
            return new SymmetricAlgorithmAdapter(SymmetricAlgorithmNames.AesCbcPkcs7);
        }

        public IHashAlgorithm CreateSha256Managed()
        {
            return new HashAlgorithmAdapter(HashAlgorithmNames.Sha256);
        }

        public IHashAlgorithm CreateSha1Managed()
        {
            return new HashAlgorithmAdapter(HashAlgorithmNames.Sha1);
        }

        public IKeyedHashAlgorithm CreateHMacSha256()
        {
            return new KeyedHashAlgorithmAdapter(MacAlgorithmNames.HmacSha256);
        }

        public IKeyedHashAlgorithm CreateHMacSha1()
        {
            return new KeyedHashAlgorithmAdapter(MacAlgorithmNames.HmacSha1);
        }

        public IDeriveBytes CreateRfc2898DeriveBytes(string password, byte[] salt, int iterations)
        {
            var deriveBytes = new Rfc2898DeriveBytesAdapter(KeyDerivationAlgorithmNames.Pbkdf2Sha1, password);
            deriveBytes.Salt = salt;
            deriveBytes.IterationCount = iterations;

            return deriveBytes;
        }

        #endregion ICryptography
    }
}
