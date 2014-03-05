// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using System;
using System.Diagnostics;

namespace Loqu8.MvvmCross.Plugins.Cryptography.Adaptation
{
    // Adapts a HashDeriveBytes to a IHashDeriveBytes
    internal class Rfc2898DeriveBytesAdapter : IDeriveBytes
    {
        private readonly System.Security.Cryptography.Rfc2898DeriveBytes _underlyingDeriveBytes;

        public Rfc2898DeriveBytesAdapter(System.Security.Cryptography.Rfc2898DeriveBytes underlyingDeriveBytes)
        {
            Debug.Assert(underlyingDeriveBytes != null);

            _underlyingDeriveBytes = underlyingDeriveBytes;
        }

        internal System.Security.Cryptography.DeriveBytes UnderlyingDeriveBytes
        {
            get { return _underlyingDeriveBytes; }
        }

        public int IterationCount
        {
            get { return _underlyingDeriveBytes.IterationCount; }
            set { _underlyingDeriveBytes.IterationCount = value; }
        }

        public byte[] Salt
        {
            get { return _underlyingDeriveBytes.Salt; }
            set { _underlyingDeriveBytes.Salt = value; }
        }

        public byte[] GetBytes(int cb)
        {
            return _underlyingDeriveBytes.GetBytes(cb);
        }

        public void Dispose()
        {
            IDisposable disposable = _underlyingDeriveBytes as IDisposable;
            if (disposable != null)
            {   // Only true on .NET
                disposable.Dispose();
            }
        }

        public void Reset()
        {
            _underlyingDeriveBytes.Reset();
        }
    }
}