// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using System;

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
            SymmetricAlgorithmAdapter adapter;
#if CRYPTSVC
            try
            {
                // prefer os-level encryption for gov't compliance reasons but check support in iOS, etc.
                adapter = new SymmetricAlgorithmAdapter(new System.Security.Cryptography.AesCryptoServiceProvider());
            }
            catch
            {
#endif
                adapter = new SymmetricAlgorithmAdapter(new System.Security.Cryptography.AesManaged());
#if CRYPTSVC
            }
#endif
            return adapter;
        }

        public IHashAlgorithm CreateSha256Managed()
        {
            HashAlgorithmAdapter adapter;
#if CRYPTSVC
            try {
                // prefer os-level encryption for gov't compliance reasons but check support in iOS, etc.
                adapter = new HashAlgorithmAdapter(new System.Security.Cryptography.SHA256CryptoServiceProvider());
            }
            catch {
#endif
                adapter = new HashAlgorithmAdapter(new System.Security.Cryptography.SHA256Managed());
#if CRYPTSVC
            }
#endif
            return adapter;
        }

        public IHashAlgorithm CreateSha1Managed()
        {
            HashAlgorithmAdapter adapter;
#if CRYPTSVC
            try
            {
                // prefer os-level encryption for gov't compliance reasons but check support in iOS, etc.
                adapter = new HashAlgorithmAdapter(new System.Security.Cryptography.SHA1CryptoServiceProvider());
            }
            catch
            {
#endif
                adapter = new HashAlgorithmAdapter(new System.Security.Cryptography.SHA1Managed());
#if CRYPTSVC
            }
#endif
            return adapter;
        }

        public IKeyedHashAlgorithm CreateHMacSha256()
        {
            return new KeyedHashAlgorithmAdapter(new System.Security.Cryptography.HMACSHA256());
        }

        public IKeyedHashAlgorithm CreateHMacSha1()
        {
            return new KeyedHashAlgorithmAdapter(new System.Security.Cryptography.HMACSHA1());
        }

        public IDeriveBytes CreateRfc2898DeriveBytes(string password, byte[] salt, int iterations)
        {
            return new Rfc2898DeriveBytesAdapter(new System.Security.Cryptography.Rfc2898DeriveBytes(password, salt, iterations));
        }

        #endregion ICryptography
    }
}
