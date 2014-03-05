// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
namespace Loqu8.MvvmCross.Plugins.Cryptography.Adaptation
{
    public interface ICryptographyFactory
    {
        IHashAlgorithm CreateSha256Managed();

        IHashAlgorithm CreateSha1Managed();

        IKeyedHashAlgorithm CreateHMacSha256();

        IKeyedHashAlgorithm CreateHMacSha1();

        ISymmetricAlgorithm CreateAesManaged();

        IDeriveBytes CreateRfc2898DeriveBytes(string password, byte[] salt, int iterations);
    }
}