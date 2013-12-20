using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.Data
{
    // Summary:
    //     Represents a method that handles the completed event of an asynchronous operation
    //     that provides progress updates.
    //
    // Type parameters:
    //   TResult:
    //     The result.
    //
    //   TProgress:
    //     The progress information.
    public delegate void AsyncOperationWithProgressCompletedHandler<TResult, TProgress>(IAsyncOperationWithProgress<TResult, TProgress> asyncInfo, AsyncStatus asyncStatus);
}
