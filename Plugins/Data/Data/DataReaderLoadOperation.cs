using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.Data
{
    // Summary:
    //     Loads data from an input stream.
    public sealed class DataReaderLoadOperation : IAsyncOperation<uint>, IAsyncInfo
    {
        // Summary:
        //     Gets or sets the handler to call when the data load operation is complete.
        //
        // Returns:
        //     The handler to call when the operation is complete.
        public AsyncOperationCompletedHandler<uint> Completed { get; set; }
        //
        // Summary:
        //     Gets the error code for the data load operation if it fails.
        //
        // Returns:
        //     The status of the operation.
        public Exception ErrorCode { get; }
        //
        // Summary:
        //     Gets a unique identifier that represents the data load operation.
        //
        // Returns:
        //     The identifier.
        public uint Id { get; }
        //
        // Summary:
        //     Gets the current status of the data load operation.
        //
        // Returns:
        //     One of the enumeration values.
        public AsyncStatus Status { get; }

        // Summary:
        //     Requests the cancellation of the data load operation.
        public void Cancel();
        //
        // Summary:
        //     Requests that work associated with the data load operation should stop.
        public void Close();
        //
        // Summary:
        //     Returns the result of the data load operation.
        //
        // Returns:
        //     The result of the operation.
        public uint GetResults();
    }
}
