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
    ///     Computes a Hash-based Message Authentication Code (HMAC) using the SHA-256 hash function.
    /// </summary>
    public class HMACSHA256 : KeyedHashAlgorithm
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="HMACSHA256 "/> class with the specified key data.
        /// </summary>
        /// <param name="key">
        ///     The secret key for HMACSHA256 encryption. The key can be any length. However, the recommended size is 64 bytes. If the secret key is more than 64 bytes long, it will be hashed (using SHA-256) to derive a 64-byte key. If it is less than 64 bytes long, it will be padded to 64 bytes.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="key"/> is <see langword="null"/>.
        /// </exception>
        public HMACSHA256(byte[] key)
            : base(Mvx.Resolve<ICryptographyFactory>().CreateHMacSha256(), key)
        {
        }
    }
}