using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.IO.Compression
{
    public static class CompressionExtensions
    {
        public static System.IO.Compression.CompressionMode ToSystem(this CompressionMode mode)
        {
            switch (mode)
            {
                case CompressionMode.Compress:
                    return System.IO.Compression.CompressionMode.Compress;
                case CompressionMode.Decompress:
                    return System.IO.Compression.CompressionMode.Decompress;
                default:
                    throw new NotSupportedException();
            }
        }

        public static System.IO.Compression.CompressionLevel ToSystem(this CompressionLevel level)
        {
            switch (level)
            {
                case CompressionLevel.Fastest:
                    return System.IO.Compression.CompressionLevel.Fastest;
                case CompressionLevel.NoCompression:
                    return System.IO.Compression.CompressionLevel.NoCompression;
                case CompressionLevel.Optimal:
                    return System.IO.Compression.CompressionLevel.Optimal;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
