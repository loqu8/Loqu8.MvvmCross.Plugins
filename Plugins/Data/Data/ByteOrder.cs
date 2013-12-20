using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.Data
{
    // Summary:
    //     Specifies the byte order of a stream.
    public enum ByteOrder
    {
        // Summary:
        //     The least significant byte (lowest address) is stored first.
        LittleEndian = 0,
        //
        // Summary:
        //     The most significant byte (highest address) is stored first.
        BigEndian = 1,
    }
}
