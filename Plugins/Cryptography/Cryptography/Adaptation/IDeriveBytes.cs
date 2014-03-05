// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using System;

namespace Loqu8.MvvmCross.Plugins.Cryptography.Adaptation
{
    public interface IDeriveBytes : IDisposable
    {
        int IterationCount
        {
            get;
            set;
        }

        byte[] Salt
        {
            get;
            set;
        }

        byte[] GetBytes(int cb);

        void Reset();
    }
}