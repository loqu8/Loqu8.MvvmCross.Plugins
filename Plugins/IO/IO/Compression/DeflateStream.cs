using Cirrious.CrossCore;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Loqu8.MvvmCross.Plugins.IO.Compression
{
    public class DeflateStream : MvxCompressionStream
    {
        protected override IMvxCompressionStreamFactory CreateFactory()
        {
            return Mvx.Resolve<IMvxDeflateStreamFactory>();
        }

        // Summary:
        //     Initializes a new instance of the IO.Compression.DeflateStream class
        //     by using the specified stream and compression level.
        //
        // Parameters:
        //   stream:
        //     The stream to compress.
        //
        //   compressionLevel:
        //     One of the enumeration values that indicates whether to emphasize speed or
        //     compression efficiency when compressing the stream.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     stream is null.
        //
        //   System.ArgumentException:
        //     The stream does not support write operations such as compression. (The System.IO.Stream.CanWrite
        //     property on the stream object is false.)
        public DeflateStream(Stream stream, CompressionLevel compressionLevel)
            : base(stream, compressionLevel)
        {
        }

        //
        // Summary:
        //     Initializes a new instance of the IO.Compression.DeflateStream class
        //     by using the specified stream and compression mode.
        //
        // Parameters:
        //   stream:
        //     The stream to compress or decompress.
        //
        //   mode:
        //     One of the enumeration values that indicates whether to compress or decompress
        //     the stream.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     stream is null.
        //
        //   System.ArgumentException:
        //     mode is not a valid System.IO.Compression.CompressionMode value.-or-System.IO.Compression.CompressionMode
        //     is System.IO.Compression.CompressionMode.Compress and System.IO.Stream.CanWrite
        //     is false.-or-System.IO.Compression.CompressionMode is System.IO.Compression.CompressionMode.Decompress
        //     and System.IO.Stream.CanRead is false.
        public DeflateStream(Stream stream, CompressionMode mode)
            : base(stream, mode)
        {
        }

        //
        // Summary:
        //     Initializes a new instance of the IO.Compression.DeflateStream class
        //     by using the specified stream and compression level, and optionally leaves
        //     the stream open.
        //
        // Parameters:
        //   stream:
        //     The stream to compress.
        //
        //   compressionLevel:
        //     One of the enumeration values that indicates whether to emphasize speed or
        //     compression efficiency when compressing the stream.
        //
        //   leaveOpen:
        //     true to leave the stream object open after disposing the IO.Compression.DeflateStream
        //     object; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     stream is null.
        //
        //   System.ArgumentException:
        //     The stream does not support write operations such as compression. (The System.IO.Stream.CanWrite
        //     property on the stream object is false.)
        public DeflateStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen)
            : base(stream, compressionLevel, leaveOpen)
        {
        }

        //
        // Summary:
        //     Initializes a new instance of the IO.Compression.DeflateStream class
        //     by using the specified stream and compression mode, and optionally leaves
        //     the stream open.
        //
        // Parameters:
        //   stream:
        //     The stream to compress or decompress.
        //
        //   mode:
        //     One of the enumeration values that indicates whether to compress or decompress
        //     the stream.
        //
        //   leaveOpen:
        //     true to leave the stream open after disposing the IO.Compression.DeflateStream
        //     object; otherwise, false.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     stream is null.
        //
        //   System.ArgumentException:
        //     mode is not a valid System.IO.Compression.CompressionMode value.-or-System.IO.Compression.CompressionMode
        //     is System.IO.Compression.CompressionMode.Compress and System.IO.Stream.CanWrite
        //     is false.-or-System.IO.Compression.CompressionMode is System.IO.Compression.CompressionMode.Decompress
        //     and System.IO.Stream.CanRead is false.
        public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen)
            : base(stream, mode, leaveOpen)
        {
        }
    }
}