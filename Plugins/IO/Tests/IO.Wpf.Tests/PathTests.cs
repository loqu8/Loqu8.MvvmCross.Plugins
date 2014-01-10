using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Loqu8.MvvmCross.Plugins.IO;
using Cirrious.MvvmCross.Test.Core;
using Cirrious.CrossCore.Plugins;
using Cirrious.CrossCore.Platform;
using Cirrious.CrossCore;
using System.Diagnostics;

namespace IO.Wpf.Tests
{
    
    [TestFixture]
    public class PathTests : MvxIoCSupportingTest
    {    
        public PathTests()
        {
        }

        [SetUp]
        public void ASetup()
        {
            Setup();

            Ioc.RegisterSingleton<IMvxPath>(new MvxPath());
            Ioc.RegisterSingleton<IFileSystem>(new DesktopFileSystem());
            Ioc.RegisterType<IFile, FileSystemFile>();
            Ioc.RegisterType<IFolder, FileSystemFolder>();
        }

        [Test]
        public void GetDirectory([Values (@"C:\Temp", "checkers", @"..\..\")] string path)
        {
            var absolute = Path.GetDirectoryName(path);
            Assert.AreNotEqual(absolute, path);
            Debug.WriteLine(absolute);
        }

        [Test]
        public void GetTemp()
        {
            var temp = Path.GetTempPath();
            MvxTrace.Trace("hello from Mvx");
            Trace.WriteLine("hello from Trace");
            Debug.WriteLine("hello from Debug");
            Assert.NotNull(temp);
        }

        [Test]
        public void GetFileSystem()
        {
            var fileSystem = Mvx.Resolve<IFileSystem>();
            var folder = fileSystem.LocalStorage;
            MvxTrace.TaggedTrace("Test", folder.Path + "blah");
            Assert.NotNull(folder);
            Assert.IsNotNullOrEmpty(folder.Path);
        }
    }
}
