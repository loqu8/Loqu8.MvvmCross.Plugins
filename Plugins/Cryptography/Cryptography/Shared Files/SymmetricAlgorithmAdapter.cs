// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using System.Diagnostics;

namespace Loqu8.MvvmCross.Plugins.Cryptography.Adaptation
{
    // Adapts a SymmetricAlgorithm to a ISymmetricAlgorithm
    internal class SymmetricAlgorithmAdapter : ISymmetricAlgorithm
    {
        private readonly System.Security.Cryptography.SymmetricAlgorithm _underlyingAlgorithm;

        public SymmetricAlgorithmAdapter(System.Security.Cryptography.SymmetricAlgorithm underlyingAlgorithm)
        {
            Debug.Assert(underlyingAlgorithm != null);

            _underlyingAlgorithm = underlyingAlgorithm;
        }

        internal System.Security.Cryptography.SymmetricAlgorithm UnderlyingAlgorithm
        {
            get { return _underlyingAlgorithm; }
        }

        public byte[] IV
        {
            get { return _underlyingAlgorithm.IV; }
            set { CryptoServices.TranslateExceptions(() => _underlyingAlgorithm.IV = value); }
        }

        public byte[] Key
        {
            get { return _underlyingAlgorithm.Key; }
            set { CryptoServices.TranslateExceptions(() => _underlyingAlgorithm.Key = value); }
        }

        public int KeySize
        {
            get { return _underlyingAlgorithm.KeySize; }
            set { CryptoServices.TranslateExceptions(() => _underlyingAlgorithm.KeySize = value); }
        }

        public ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
        {
            return CryptoServices.TranslateExceptions(() =>
            {
                var underlyingTransform = _underlyingAlgorithm.CreateEncryptor(key, iv);

                return new CryptoTransformAdapter(underlyingTransform);
            });
        }

        public ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
        {
            return CryptoServices.TranslateExceptions(() =>
            {
                var underlyingTransform = _underlyingAlgorithm.CreateDecryptor(key, iv);

                return new CryptoTransformAdapter(underlyingTransform);
            });
        }

        public void Dispose()
        {
            _underlyingAlgorithm.Clear();
        }
    }
}