using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.IO.Compression
{
    // Summary:
    //     Specifies whether to compress or decompress the underlying stream.
    public enum CompressionMode
    {
        // Summary:
        //     Decompresses the underlying stream.
        Decompress = 0,
        //
        // Summary:
        //     Compresses the underlying stream.
        Compress = 1,
    }
}
