using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.Data
{
    // Summary:
    //     Represents an asynchronous operation.
    //
    // Type parameters:
    //   TResult:
    //     The type of the result.
    public interface IAsyncOperation<TResult> : IAsyncInfo
    {
        // Summary:
        //     Gets or sets the method that handles operation completed event.
        //
        // Returns:
        //     The method that handles the event.
        AsyncOperationCompletedHandler<TResult> Completed { get; set; }

        // Summary:
        //     Returns the results of the operation.
        //
        // Returns:
        //     The results of the operation.
        TResult GetResults();
    }
}
