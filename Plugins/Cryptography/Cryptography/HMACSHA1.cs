// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using Cirrious.CrossCore;
using System;
using Loqu8.MvvmCross.Plugins.Cryptography.Adaptation;

namespace Loqu8.MvvmCross.Plugins.Cryptography
{
    /// <summary>
    ///     Computes a Hash-based Message Authentication Code (HMAC) using the SHA-1 hash function.
    /// </summary>
    public class HMACSHA1 : KeyedHashAlgorithm
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="HMACSHA1"/> class with the specified key data.
        /// </summary>
        /// <param name="key">
        ///     The secret key for HMACSHA1 encryption. The key can be any length, but if it is more than 64 bytes long it will be hashed (using SHA-1) to derive a 64-byte key. Therefore, the recommended size of the secret key is 64 bytes.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="key"/> is <see langword="null"/>.
        /// </exception>
        public HMACSHA1(byte[] key)
            : base(Mvx.Resolve<ICryptographyFactory>().CreateHMacSha1(), key)
        {
        }
    }
}