﻿// Plugin.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;
using Loqu8.MvvmCross.Plugins.IO.Compression;

namespace Loqu8.MvvmCross.Plugins.IO.WindowsStore
{
    public class Plugin
        : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<IMvxPath>(new MvxPath());
            Mvx.RegisterSingleton<IFileSystem>(new WinRTFileSystem());
            Mvx.RegisterType<IFile, WinRTFile>();
            Mvx.RegisterType<IFolder, WinRTFolder>();
            Mvx.RegisterSingleton<IDeflateStreamFactory>(new DeflateStreamFactory());
            Mvx.RegisterSingleton<IGZipStreamFactory>(new GZipStreamFactory());
        }
    }
}
