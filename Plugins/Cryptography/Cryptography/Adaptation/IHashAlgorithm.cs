// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using System;
using System.IO;

namespace Loqu8.MvvmCross.Plugins.Cryptography.Adaptation
{
    public interface IHashAlgorithm : IDisposable
    {
        byte[] ComputeHash(byte[] buffer);

        byte[] ComputeHash(byte[] buffer, int offset, int count);

        byte[] ComputeHash(Stream inputStream);
    }
}