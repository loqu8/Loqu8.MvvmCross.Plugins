using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.Data
{
    // Summary:
    //     Supports asynchronous actions and operations.
    public interface IAsyncInfo
    {
        // Summary:
        //     Gets a string that describes an error condition of the asynchronous operation.
        //
        // Returns:
        //     The error string.
        Exception ErrorCode { get; }
        //
        // Summary:
        //     Gets the handle of the asynchronous operation.
        //
        // Returns:
        //     The handle.
        uint Id { get; }
        //
        // Summary:
        //     Gets a value that indicates the status of the asynchronous operation.
        //
        // Returns:
        //     The status of the operation.
        AsyncStatus Status { get; }

        // Summary:
        //     Cancels the asynchronous operation.
        void Cancel();
        //
        // Summary:
        //     Closes the asynchronous operation.
        void Close();
    }
}
