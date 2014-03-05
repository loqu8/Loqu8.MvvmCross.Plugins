// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Loqu8.MvvmCross.Plugins.Cryptography.Adaptation
{
    // Adapts a WinRT SymmetricKeyAlgorithmProvider to an encrypting ICryptoTransform
    internal class SymmetricEncryptorAdapter : SymmetricCryptoTransformAdapter
    {
        public SymmetricEncryptorAdapter(SymmetricKeyAlgorithmProvider provider, byte[] key, byte[] iv)
            : base(provider, key, iv)
        {
        }

        public override IBuffer Transform(IBuffer buffer)
        {
            return CryptographicEngine.Encrypt(Key, buffer, IV);
        }
    }
}