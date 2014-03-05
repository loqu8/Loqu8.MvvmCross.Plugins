// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using System.Diagnostics;
using System.IO;

namespace Loqu8.MvvmCross.Plugins.Cryptography.Adaptation
{
    // Adapts a HashAlgorithm to a IHashAlgorithm
    internal class HashAlgorithmAdapter : IHashAlgorithm
    {
        private readonly System.Security.Cryptography.HashAlgorithm _underlyingAlgorithm;

        public HashAlgorithmAdapter(System.Security.Cryptography.HashAlgorithm underlyingAlgorithm)
        {
            Debug.Assert(underlyingAlgorithm != null);

            _underlyingAlgorithm = underlyingAlgorithm;
        }

        internal System.Security.Cryptography.HashAlgorithm UnderlyingAlgorithm
        {
            get { return _underlyingAlgorithm; }
        }

        public byte[] ComputeHash(byte[] buffer)
        {
            return _underlyingAlgorithm.ComputeHash(buffer);
        }

        public byte[] ComputeHash(byte[] buffer, int offset, int count)
        {
            return _underlyingAlgorithm.ComputeHash(buffer, offset, count);
        }

        public byte[] ComputeHash(Stream inputStream)
        {
            return _underlyingAlgorithm.ComputeHash(inputStream);
        }

        public void Dispose()
        {
            _underlyingAlgorithm.Clear();
        }
    }
}