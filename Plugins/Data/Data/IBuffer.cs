using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.Data
{
    // Summary:
    //     Represents a referenced array of bytes used by byte stream read and write
    //     interfaces.
    public interface IBuffer
    {
        // Summary:
        //     Gets the maximum number of bytes that the buffer can hold.
        //
        // Returns:
        //     The maximum number of bytes that the buffer can hold.
        uint Capacity { get; }
        //
        // Summary:
        //     Gets the number of bytes currently in use in the buffer.
        //
        // Returns:
        //     The number of bytes currently in use in the buffer which is less than or
        //     equal to the capacity of the buffer.
        uint Length { get; set; }
    }
}
