using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.IO.Compression
{
    // Summary:
    //     Specifies values that indicate whether a compression operation emphasizes
    //     speed or compression size.
    public enum CompressionLevel
    {
        // Summary:
        //     The compression operation should be optimally compressed, even if the operation
        //     takes a longer time to complete.
        Optimal = 0,
        //
        // Summary:
        //     The compression operation should complete as quickly as possible, even if
        //     the resulting file is not optimally compressed.
        Fastest = 1,
        //
        // Summary:
        //     No compression should be performed on the file.
        NoCompression = 2,
    }
}
