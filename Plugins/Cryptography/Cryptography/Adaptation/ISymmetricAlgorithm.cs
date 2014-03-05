// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using System;

namespace Loqu8.MvvmCross.Plugins.Cryptography.Adaptation
{
    public interface ISymmetricAlgorithm : IDisposable
    {
        byte[] Key
        {
            get;
            set;
        }

        byte[] IV
        {
            get;
            set;
        }

        ICryptoTransform CreateEncryptor(byte[] key, byte[] iv);
        ICryptoTransform CreateDecryptor(byte[] key, byte[] iv);
    }
}