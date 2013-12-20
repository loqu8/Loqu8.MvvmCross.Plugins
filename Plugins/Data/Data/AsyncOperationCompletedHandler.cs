using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.Data
{
    // Summary:
    //     Represents a method that handles the completed event of an asynchronous operation.
    //
    // Type parameters:
    //   TResult:
    //     The result.
    public delegate void AsyncOperationCompletedHandler<TResult>(IAsyncOperation<TResult> asyncInfo, AsyncStatus asyncStatus);
}
