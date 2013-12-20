using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.Data
{
    // Summary:
    //     Represents a sequential stream of bytes to be read.
    public interface IInputStream : IDisposable
    {
        // Summary:
        //     Returns an asynchronous byte reader object.
        //
        // Parameters:
        //   buffer:
        //     The buffer into which the asynchronous read operation places the bytes that
        //     are read.
        //
        //   count:
        //     The number of bytes to read that is less than or equal to the Capacity value.
        //
        //   options:
        //     Specifies the type of the asynchronous read operation.
        //
        // Returns:
        //     The asynchronous operation.
        IAsyncOperationWithProgress<IBuffer, uint> ReadAsync(IBuffer buffer, uint count, InputStreamOptions options);
    }
}
