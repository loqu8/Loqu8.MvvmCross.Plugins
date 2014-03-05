// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using Cirrious.CrossCore;
using Loqu8.MvvmCross.Plugins.Cryptography.Adaptation;

namespace Loqu8.MvvmCross.Plugins.Cryptography
{
    /// <summary>
    ///     Provides a managed implementation of the Advanced Encryption Standard (AES) symmetric algorithm.
    /// </summary>
    public sealed class AesManaged : SymmetricAlgorithm
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AesManaged"/> class.
        /// </summary>
        public AesManaged()
            : base(Mvx.Resolve<ICryptographyFactory>().CreateAesManaged())
        {
        }
    }
}