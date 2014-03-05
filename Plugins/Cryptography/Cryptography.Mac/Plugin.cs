// Plugin.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;

namespace Loqu8.MvvmCross.Plugins.Cryptography.Mac
{
    public class Plugin
        : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<IMvxCryptography>(new MvxCryptography());
            //  Mvx.RegisterSingleton<IMvxCryptography>(new MvxMacCryptography());
        }
    }
}
