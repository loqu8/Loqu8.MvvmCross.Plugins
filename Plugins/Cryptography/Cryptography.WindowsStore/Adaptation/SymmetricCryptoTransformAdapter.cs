﻿// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Loqu8.MvvmCross.Plugins.Cryptography.Adaptation
{
    // Adapts a WinRT SymmetricKeyAlgorithmProvider to ICryptoTransform
    internal abstract class SymmetricCryptoTransformAdapter : CryptoTransformAdapter
    {
        private readonly SymmetricKeyAlgorithmProvider _provider;
        private readonly CryptographicKey _key;
        private readonly IBuffer _iv;

        public SymmetricCryptoTransformAdapter(SymmetricKeyAlgorithmProvider provider, byte[] key, byte[] iv)
        {
            Debug.Assert(provider != null && key != null && iv != null);

            _provider = provider;
            _key = provider.CreateSymmetricKey(key.AsBuffer());
            _iv = iv.AsBuffer();
        }

        public override int InputBlockSize
        {
            get
            {
                uint blockLength = _provider.BlockLength;
                Debug.Assert(blockLength <= Int32.MaxValue);

                return (int)blockLength;
            }
        }

        public override int OutputBlockSize
        {
            get
            {
                uint blockLength = _provider.BlockLength;
                Debug.Assert(blockLength <= Int32.MaxValue);

                return (int)blockLength;
            }
        }

        protected CryptographicKey Key
        {
            get { return _key; }
        }

        protected IBuffer IV
        {
            get { return _iv; }
        }

    }
}
