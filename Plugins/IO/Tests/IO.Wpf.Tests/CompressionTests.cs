using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loqu8.MvvmCross.Plugins.IO.Compression;
using System.IO;
using Cirrious.MvvmCross.Test.Core;

namespace IO.Wpf.Tests
{
    [TestFixture]
    public class CompressionTests : MvxIoCSupportingTest
    {
        private static string sample = @"Four score and seven years ago our fathers brought forth on this continent, a new nation, conceived in Liberty, and dedicated to the proposition that all men are created equal.
Now we are engaged in a great civil war, testing whether that nation, or any nation so conceived and so dedicated, can long endure. We are met on a great battle-field of that war. We have come to dedicate a portion of that field, as a final resting place for those who here gave their lives that that nation might live. It is altogether fitting and proper that we should do this.
But, in a larger sense, we can not dedicate -- we can not consecrate -- we can not hallow -- this ground. The brave men, living and dead, who struggled here, have consecrated it, far above our poor power to add or detract. The world will little note, nor long remember what we say here, but it can never forget what they did here. It is for us the living, rather, to be dedicated here to the unfinished work which they who fought here have thus far so nobly advanced. It is rather for us to be here dedicated to the great task remaining before us -- that from these honored dead we take increased devotion to that cause for which they gave the last full measure of devotion -- that we here highly resolve that these dead shall not have died in vain -- that this nation, under God, shall have a new birth of freedom -- and that government of the people, by the people, for the people, shall not perish from the earth.";

        [SetUp]
        public void Init()
        {
            Setup();

            Ioc.RegisterSingleton<IMvxDeflateStreamFactory>(new MvxDeflateStreamFactory());
            Ioc.RegisterSingleton<IMvxGZipStreamFactory>(new MvxGZipStreamFactory());            
        }

        [Test]
        public void DeflateTest()
        {
            using (var ms = new MemoryStream())
            {
                var bytes = UTF8Encoding.UTF8.GetBytes(sample);

                using (var ds = new DeflateStream(ms, CompressionMode.Compress))
                {                   
                    ds.Write(bytes, 0, bytes.Length);
                }

                var compressed = ms.ToArray();
                Assert.AreNotEqual(0, compressed.Length);
                Assert.Less(compressed.Length, bytes.Length);

                using (var ms2 = new MemoryStream())
                {
                    using (var ds2 = new DeflateStream(new MemoryStream(compressed), CompressionMode.Decompress))
                    {
	                    const int size = 4096;
	                    byte[] buffer = new byte[size];
                        using (MemoryStream memory = new MemoryStream())
                        {
                            int count = 0;
                            do
                            {
                                count = ds2.Read(buffer, 0, size);
                                if (count > 0)
                                {
                                    memory.Write(buffer, 0, count);
                                }
                            }
                            while (count > 0);
                            var decompressedBytes = memory.ToArray();
                            var result = UTF8Encoding.UTF8.GetString(bytes);
                            Assert.AreEqual(result, sample);
                        }                        
                    }
                }
            }
        }

        [Test]
        public void GZipTest()
        {
            using (var ms = new MemoryStream())
            {
                var bytes = UTF8Encoding.UTF8.GetBytes(sample);

                using (var gz = new GZipStream(ms, CompressionMode.Compress))
                {                    
                    gz.Write(bytes, 0, bytes.Length);
                }

                var compressed = ms.ToArray();
                Assert.AreNotEqual(0, compressed.Length);
                Assert.Less(compressed.Length, bytes.Length);

                using (var ms2 = new MemoryStream())
                {
                    using (var gz2 = new GZipStream(new MemoryStream(compressed), CompressionMode.Decompress))
                    {
	                    const int size = 4096;
	                    byte[] buffer = new byte[size];
                        using (MemoryStream memory = new MemoryStream())
                        {
                            int count = 0;
                            do
                            {
                                count = gz2.Read(buffer, 0, size);
                                if (count > 0)
                                {
                                    memory.Write(buffer, 0, count);
                                }
                            }
                            while (count > 0);
                            var decompressedBytes = memory.ToArray();
                            var result = UTF8Encoding.UTF8.GetString(bytes);
                            Assert.AreEqual(result, sample);
                        }                        
                    }
                }
            }
        }
    }
}
