// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using System;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Storage.Streams;

namespace Loqu8.MvvmCross.Plugins.Cryptography
{
    // Adapts a WinRT hash or crypto algorithm to a ICryptoTransform
    internal abstract class CryptoTransformAdapter : ICryptoTransform
    {
        private static readonly byte[] Empty = new byte[0];

        protected CryptoTransformAdapter()
        {
        }

        public abstract int InputBlockSize
        {
            get;
        }

        public abstract int OutputBlockSize
        {
            get;
        }

        public bool CanReuseTransform
        {
            get { return true; }
        }

        public bool CanTransformMultipleBlocks
        {
            get { return false; }
        }

        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
        {
            if (inputBuffer == null)
                throw new ArgumentNullException("inputBuffer");

            if (inputOffset < 0)
                throw new ArgumentOutOfRangeException("inputOffset");

            if ((inputCount < 0) || (inputCount > inputBuffer.Length))
                throw new ArgumentException("inputCount");

            if ((inputBuffer.Length - inputCount) < inputOffset)
                throw new ArgumentException();

            IBuffer transformed = Transform(inputBuffer.AsBuffer(inputOffset, inputCount));

            uint bytesWritten = transformed.Length;

            Debug.Assert(bytesWritten <= Int32.MaxValue);

            transformed.CopyTo(0, outputBuffer, outputOffset, (int)bytesWritten);

            return (int)bytesWritten;
        }

        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
        {
            return Empty;
        }

        public abstract IBuffer Transform(IBuffer buffer);

        public void Dispose()
        {
        }
    }
}