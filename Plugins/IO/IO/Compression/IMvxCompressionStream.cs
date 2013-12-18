using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.IO.Compression
{
    public interface IMvxCompressionStream : IMvxStream
    {
        // Summary:
        //     Gets a reference to the underlying stream.
        //
        // Returns:
        //     A stream object that represents the underlying stream.
        //
        // Exceptions:
        //   System.ObjectDisposedException:
        //     The underlying stream is closed.
        Stream BaseStream { get; }
    }
}
