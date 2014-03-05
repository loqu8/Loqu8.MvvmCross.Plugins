// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using System;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Loqu8.MvvmCross.Plugins.Cryptography.Adaptation
{
    // Adapts a WinRT MacAlgorithmProvider to IHashAlgorithm
    internal class KeyedHashAlgorithmAdapter : HashCryptoTransformAdapter, IKeyedHashAlgorithm
    {
        private readonly MacAlgorithmProvider _provider;
        private CryptographicKey _key;

        public KeyedHashAlgorithmAdapter(string algorithmName)
        {
            Debug.Assert(algorithmName != null && algorithmName.Length > 0);

            _provider = MacAlgorithmProvider.OpenAlgorithm(algorithmName);
        }

        public void SetKey(byte[] key)
        {
            if (key == null)
                throw new ArgumentNullException("value");

            // Don't use AsBuffer here, because we want to clone the key
            var keyBuffer = WindowsRuntimeBuffer.Create(key, 0, key.Length, key.Length);

            _key = _provider.CreateKey(keyBuffer);
        }

        public override IBuffer Transform(IBuffer buffer)
        {
            Debug.Assert(buffer != null);

            return CryptographicEngine.Sign(_key, buffer);
        }
    }
}