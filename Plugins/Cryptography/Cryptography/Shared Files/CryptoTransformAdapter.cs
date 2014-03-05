// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using System.Diagnostics;

namespace Loqu8.MvvmCross.Plugins.Cryptography.Adaptation
{
    // Adapts a .NET ICryptoTransform to a PclContrib ICryptoTransform
    internal class CryptoTransformAdapter : ICryptoTransform
    {
        private readonly System.Security.Cryptography.ICryptoTransform _underlyingTransform;

        public CryptoTransformAdapter(System.Security.Cryptography.ICryptoTransform underlyingTransform)
        {
            Debug.Assert(underlyingTransform != null);

            _underlyingTransform = underlyingTransform;
        }

        public bool CanReuseTransform
        {
            get { return _underlyingTransform.CanReuseTransform; }
        }

        public bool CanTransformMultipleBlocks
        {
            get { return _underlyingTransform.CanTransformMultipleBlocks; }
        }

        public int InputBlockSize
        {
            get { return _underlyingTransform.InputBlockSize; }
        }

        public int OutputBlockSize
        {
            get { return _underlyingTransform.OutputBlockSize; }
        }

        public System.Security.Cryptography.ICryptoTransform UnderlyingTransform
        {
            get { return _underlyingTransform; }
        }

        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
        {
            return CryptoServices.TranslateExceptions(() =>
            {
                return _underlyingTransform.TransformBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset);
            });
        }

        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
        {
            return CryptoServices.TranslateExceptions(() =>
            {
                return _underlyingTransform.TransformFinalBlock(inputBuffer, inputOffset, inputCount);
            });
        }

        public void Dispose()
        {
            _underlyingTransform.Dispose();
        }
    }
}