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
    ///     Computes the SHA-1 hash for the input data using the managed library.
    /// </summary>
    public class SHA1Managed : HashAlgorithm
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SHA1Managed"/> class.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        ///     The Federal Information Processing Standards (FIPS) security setting is enabled. This implementation is not part of the Windows Platform FIPS-validated cryptographic algorithms.
        /// </exception>
        public SHA1Managed()
            : base(Mvx.Resolve<ICryptographyFactory>().CreateSha1Managed())
        {
        }
    }
}