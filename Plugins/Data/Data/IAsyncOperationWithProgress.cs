using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.Data
{
    // Summary:
    //     Represents an asynchronous operation that includes progress updates.
    //
    // Type parameters:
    //   TResult:
    //     The type of the result.
    //
    //   TProgress:
    //     The type of the progress data.
    public interface IAsyncOperationWithProgress<TResult, TProgress> : IAsyncInfo
    {
        // Summary:
        //     Gets or sets the method that handles the operation completed event.
        //
        // Returns:
        //     The method that handles the event.
        AsyncOperationWithProgressCompletedHandler<TResult, TProgress> Completed { get; set; }
        //
        // Summary:
        //     Gets or sets the method that handles progress events.
        //
        // Returns:
        //     The method that handles the events.
        AsyncOperationProgressHandler<TResult, TProgress> Progress { get; set; }

        // Summary:
        //     Returns the results of the operation.
        //
        // Returns:
        //     The results of the operation.
        TResult GetResults();
    }
}
