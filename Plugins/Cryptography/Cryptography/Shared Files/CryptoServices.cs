// -----------------------------------------------------------------------
// Copyright (c) David Kean. All rights reserved.
// https://pclcontrib.codeplex.com/
// Licensed under MS-PL, modified by T. Uy 3/5/2014
// -----------------------------------------------------------------------
using System;

namespace Loqu8.MvvmCross.Plugins.Cryptography.Adaptation
{
    internal static class CryptoServices
    {
        public static void TranslateExceptions(Action action)
        {
            TranslateExceptions<object>(() => { action(); return null; });
        }

        public static T TranslateExceptions<T>(Func<T> action)
        {
            try
            {
                return action();
            }
            catch (System.Security.Cryptography.CryptographicException ex)
            {
                throw new CryptographicException(ex.Message, ex.InnerException);
            }
        }
    }
}
