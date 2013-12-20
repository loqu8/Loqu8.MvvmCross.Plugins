using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.Data
{
    // Summary:
    //     Specifies the status of an asynchronous operation.
    public enum AsyncStatus
    {
        // Summary:
        //     The operation has started.
        Started = 0,
        //
        // Summary:
        //     The operation has completed.
        Completed = 1,
        //
        // Summary:
        //     The operation was canceled.
        Canceled = 2,
        //
        // Summary:
        //     The operation has encountered an error.
        Error = 3,
    }
}
