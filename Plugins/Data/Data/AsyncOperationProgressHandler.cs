using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.Data
{
    // Summary:
    //     Represents a method that handles progress update events of an asynchronous
    //     operation that provides progress updates.
    //
    // Type parameters:
    //   TResult:
    //     The result.
    //
    //   TProgress:
    //     The progress information.
    public delegate void AsyncOperationProgressHandler<TResult, TProgress>(IAsyncOperationWithProgress<TResult, TProgress> asyncInfo, TProgress progressInfo);
}
