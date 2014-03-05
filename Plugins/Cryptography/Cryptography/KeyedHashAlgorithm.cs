// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using Loqu8.MvvmCross.Plugins.Cryptography.Adaptation;

namespace Loqu8.MvvmCross.Plugins.Cryptography
{
    /// <summary>
    ///     Represents the abstract class from which all implementations of keyed hash algorithms must derive.
    /// </summary>
    public class KeyedHashAlgorithm : HashAlgorithm
    {
        internal KeyedHashAlgorithm(IKeyedHashAlgorithm underlyingAlgorithm, byte[] key)
            : base(underlyingAlgorithm)
        {
            underlyingAlgorithm.SetKey(key);
        }
    }
}