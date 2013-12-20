using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.Data
{
    // Summary:
    //     Provides read access to an input stream.
    public interface IDataReader
    {
        // Summary:
        //     Gets or sets the byte order of the data in the input stream.
        //
        // Returns:
        //     One of the enumeration values.
        ByteOrder ByteOrder { get; set; }
        //
        // Summary:
        //     Gets or sets the read options for the input stream.
        //
        // Returns:
        //     One of the enumeration values.
        InputStreamOptions InputStreamOptions { get; set; }
        //
        // Summary:
        //     Gets the size of the buffer that has not been read.
        //
        // Returns:
        //     The size of the buffer that has not been read, in bytes.
        uint UnconsumedBufferLength { get; }
        //
        // Summary:
        //     Gets or sets the Unicode character encoding for the input stream.
        //
        // Returns:
        //     One of the enumeration values.
        UnicodeEncoding UnicodeEncoding { get; set; }

        // Summary:
        //     Detaches a buffer that was previously attached to the reader.
        //
        // Returns:
        //     The detached buffer.
        IBuffer DetachBuffer();
        //
        // Summary:
        //     Detaches a stream that was previously attached to the reader.
        //
        // Returns:
        //     The detached stream.
        IInputStream DetachStream();
        //
        // Summary:
        //     Loads data from the input stream.
        //
        // Parameters:
        //   count:
        //     The count of bytes to load into the intermediate buffer.
        //
        // Returns:
        //     The asynchronous operation.
        DataReaderLoadOperation LoadAsync(uint count);
        //
        // Summary:
        //     Reads a Boolean value from the input stream.
        //
        // Returns:
        //     The value.
        bool ReadBoolean();
        //
        // Summary:
        //     Reads a buffer from the input stream.
        //
        // Parameters:
        //   length:
        //     The length of the buffer, in bytes.
        //
        // Returns:
        //     The buffer.
        IBuffer ReadBuffer(uint length);
        //
        // Summary:
        //     Reads a byte value from the input stream.
        //
        // Returns:
        //     The value.
        byte ReadByte();
        //
        // Summary:
        //     Reads an array of byte values from the input stream.
        //
        // Parameters:
        //   value:
        //     The array of values.
        void ReadBytes(byte[] value);
        //
        // Summary:
        //     Reads a date and time value from the input stream.
        //
        // Returns:
        //     The value.
        DateTimeOffset ReadDateTime();
        //
        // Summary:
        //     Reads a floating-point value from the input stream.
        //
        // Returns:
        //     The value.
        double ReadDouble();
        //
        // Summary:
        //     Reads a GUID value from the input stream.
        //
        // Returns:
        //     The value.
        Guid ReadGuid();
        //
        // Summary:
        //     Reads a 16-bit integer value from the input stream.
        //
        // Returns:
        //     The value.
        short ReadInt16();
        //
        // Summary:
        //     Reads a 32-bit integer value from the input stream.
        //
        // Returns:
        //     The value.
        int ReadInt32();
        //
        // Summary:
        //     Reads a 64-bit integer value from the input stream.
        //
        // Returns:
        //     The value.
        long ReadInt64();
        //
        // Summary:
        //     Reads a floating-point value from the input stream.
        //
        // Returns:
        //     The value.
        float ReadSingle();
        //
        // Summary:
        //     Reads a string value from the input stream.
        //
        // Parameters:
        //   codeUnitCount:
        //     The length of the string.
        //
        // Returns:
        //     The value.
        string ReadString(uint codeUnitCount);
        //
        // Summary:
        //     Reads a time interval from the input stream.
        //
        // Returns:
        //     The value.
        TimeSpan ReadTimeSpan();
        //
        // Summary:
        //     Reads a 16-bit unsigned integer from the input stream.
        //
        // Returns:
        //     The value.
        ushort ReadUInt16();
        //
        // Summary:
        //     Reads a 32-bit unsigned integer from the input stream.
        //
        // Returns:
        //     The value.
        uint ReadUInt32();
        //
        // Summary:
        //     Reads a 64-bit unsigned integer from the input stream.
        //
        // Returns:
        //     The value.
        ulong ReadUInt64();
    }
}
