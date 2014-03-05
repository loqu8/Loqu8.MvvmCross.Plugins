// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
namespace Loqu8.MvvmCross.Plugins.Cryptography.Adaptation
{
    public interface IKeyedHashAlgorithm : IHashAlgorithm
    {
        void SetKey(byte[] key);
    }
}