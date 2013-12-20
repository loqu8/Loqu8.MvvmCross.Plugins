using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.Data
{
    // Summary:
    //     Specifies the read options for an input stream.
    public enum InputStreamOptions
    {
        // Summary:
        //     No options are specified.
        None = 0,
        //
        // Summary:
        //     The asynchronous read operation should complete when the a specified number
        //     of bytes are available.
        Partial = 1,
        //
        // Summary:
        //     The asynchronous read operation may optionally read ahead and prefetch additional
        //     bytes.
        ReadAhead = 2,
    }
}
