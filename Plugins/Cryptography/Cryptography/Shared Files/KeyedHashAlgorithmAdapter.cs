// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
namespace Loqu8.MvvmCross.Plugins.Cryptography.Adaptation
{
    // Adapts a KeyedHashAlgorithm to a IKeyedHashAlgorithm
    internal class KeyedHashAlgorithmAdapter : HashAlgorithmAdapter, IKeyedHashAlgorithm
    {
        private readonly System.Security.Cryptography.KeyedHashAlgorithm _underlyingAlgorithm;

        public KeyedHashAlgorithmAdapter(System.Security.Cryptography.KeyedHashAlgorithm underlyingAlgorithm)
            : base(underlyingAlgorithm)
        {
            _underlyingAlgorithm = underlyingAlgorithm;
        }

        public void SetKey(byte[] key)
        {
            _underlyingAlgorithm.Key = key;
        }
    }
}