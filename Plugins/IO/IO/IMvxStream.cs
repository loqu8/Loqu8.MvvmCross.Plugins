using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loqu8.MvvmCross.Plugins.IO
{
    public interface IMvxStream : IDisposable
    {
        // Summary:
        //     When overridden in a derived class, gets a value indicating whether the current
        //     stream supports reading.
        //
        // Returns:
        //     true if the stream supports reading; otherwise, false.
        bool CanRead { get; }

        //
        // Summary:
        //     When overridden in a derived class, gets a value indicating whether the current
        //     stream supports seeking.
        //
        // Returns:
        //     true if the stream supports seeking; otherwise, false.
        bool CanSeek { get; }

        //
        // Summary:
        //     Gets a value that determines whether the current stream can time out.
        //
        // Returns:
        //     A value that determines whether the current stream can time out.
        bool CanTimeout { get; }

        //
        // Summary:
        //     When overridden in a derived class, gets a value indicating whether the current
        //     stream supports writing.
        //
        // Returns:
        //     true if the stream supports writing; otherwise, false.
        bool CanWrite { get; }

        //
        // Summary:
        //     When overridden in a derived class, gets the length in bytes of the stream.
        //
        // Returns:
        //     A long value representing the length of the stream in bytes.
        //
        // Exceptions:
        //   System.NotSupportedException:
        //     A class derived from Stream does not support seeking.
        //
        //   System.ObjectDisposedException:
        //     Methods were called after the stream was closed.
        long Length { get; }

        //
        // Summary:
        //     When overridden in a derived class, gets or sets the position within the
        //     current stream.
        //
        // Returns:
        //     The current position within the stream.
        //
        // Exceptions:
        //   System.IO.IOException:
        //     An I/O error occurs.
        //
        //   System.NotSupportedException:
        //     The stream does not support seeking.
        //
        //   System.ObjectDisposedException:
        //     Methods were called after the stream was closed.
        long Position { get; set; }

        //
        // Summary:
        //     Gets or sets a value, in miliseconds, that determines how long the stream
        //     will attempt to read before timing out.
        //
        // Returns:
        //     A value, in miliseconds, that determines how long the stream will attempt
        //     to read before timing out.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The System.IO.Stream.ReadTimeout method always throws an System.InvalidOperationException.
        int ReadTimeout { get; set; }

        //
        // Summary:
        //     Gets or sets a value, in miliseconds, that determines how long the stream
        //     will attempt to write before timing out.
        //
        // Returns:
        //     A value, in miliseconds, that determines how long the stream will attempt
        //     to write before timing out.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The System.IO.Stream.WriteTimeout method always throws an System.InvalidOperationException.
        int WriteTimeout { get; set; }

        // Summary:
        //     Reads the bytes from the current stream and writes them to another stream.
        //
        // Parameters:
        //   destination:
        //     The stream to which the contents of the current stream will be copied.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     destination is null.
        //
        //   System.NotSupportedException:
        //     The current stream does not support reading.-or-destination does not support
        //     writing.
        //
        //   System.ObjectDisposedException:
        //     Either the current stream or destination were closed before the System.IO.Stream.CopyTo(System.IO.Stream)
        //     method was called.
        //
        //   System.IO.IOException:
        //     An I/O error occurred.
        void CopyTo(Stream destination);

        //
        // Summary:
        //     Reads the bytes from the current stream and writes them to another stream,
        //     using a specified buffer size.
        //
        // Parameters:
        //   destination:
        //     The stream to which the contents of the current stream will be copied.
        //
        //   bufferSize:
        //     The size of the buffer. This value must be greater than zero. The default
        //     size is 4096.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     destination is null.
        //
        //   System.ArgumentOutOfRangeException:
        //     bufferSize is negative or zero.
        //
        //   System.NotSupportedException:
        //     The current stream does not support reading.-or-destination does not support
        //     writing.
        //
        //   System.ObjectDisposedException:
        //     Either the current stream or destination were closed before the System.IO.Stream.CopyTo(System.IO.Stream)
        //     method was called.
        //
        //   System.IO.IOException:
        //     An I/O error occurred.
        void CopyTo(Stream destination, int bufferSize);

        //
        // Summary:
        //     Asynchronously reads the bytes from the current stream and writes them to
        //     another stream.
        //
        // Parameters:
        //   destination:
        //     The stream to which the contents of the current stream will be copied.
        //
        // Returns:
        //     A task that represents the asynchronous copy operation.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     destination is null.
        //
        //   System.ObjectDisposedException:
        //     Either the current stream or the destination stream is disposed.
        //
        //   System.NotSupportedException:
        //     The current stream does not support reading, or the destination stream does
        //     not support writing.
        Task CopyToAsync(Stream destination);

        //
        // Summary:
        //     Asynchronously reads the bytes from the current stream and writes them to
        //     another stream, using a specified buffer size.
        //
        // Parameters:
        //   destination:
        //     The stream to which the contents of the current stream will be copied.
        //
        //   bufferSize:
        //     The size, in bytes, of the buffer. This value must be greater than zero.
        //     The default size is 4096.
        //
        // Returns:
        //     A task that represents the asynchronous copy operation.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     destination is null.
        //
        //   System.ArgumentOutOfRangeException:
        //     buffersize is negative or zero.
        //
        //   System.ObjectDisposedException:
        //     Either the current stream or the destination stream is disposed.
        //
        //   System.NotSupportedException:
        //     The current stream does not support reading, or the destination stream does
        //     not support writing.
        Task CopyToAsync(Stream destination, int bufferSize);

        //
        // Summary:
        //     Asynchronously reads the bytes from the current stream and writes them to
        //     another stream, using a specified buffer size and cancellation token.
        //
        // Parameters:
        //   destination:
        //     The stream to which the contents of the current stream will be copied.
        //
        //   bufferSize:
        //     The size, in bytes, of the buffer. This value must be greater than zero.
        //     The default size is 4096.
        //
        //   cancellationToken:
        //     The token to monitor for cancellation requests. The default value is System.Threading.CancellationToken.None.
        //
        // Returns:
        //     A task that represents the asynchronous copy operation.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     destination is null.
        //
        //   System.ArgumentOutOfRangeException:
        //     buffersize is negative or zero.
        //
        //   System.ObjectDisposedException:
        //     Either the current stream or the destination stream is disposed.
        //
        //   System.NotSupportedException:
        //     The current stream does not support reading, or the destination stream does
        //     not support writing.
        Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken);

        //
        // Summary:
        //     When overridden in a derived class, clears all buffers for this stream and
        //     causes any buffered data to be written to the underlying device.
        //
        // Exceptions:
        //   System.IO.IOException:
        //     An I/O error occurs.
        void Flush();

        //
        // Summary:
        //     Asynchronously clears all buffers for this stream and causes any buffered
        //     data to be written to the underlying device.
        //
        // Returns:
        //     A task that represents the asynchronous flush operation.
        //
        // Exceptions:
        //   System.ObjectDisposedException:
        //     The stream has been disposed.
        Task FlushAsync();

        //
        // Summary:
        //     Asynchronously clears all buffers for this stream, causes any buffered data
        //     to be written to the underlying device, and monitors cancellation requests.
        //
        // Parameters:
        //   cancellationToken:
        //     The token to monitor for cancellation requests. The default value is System.Threading.CancellationToken.None.
        //
        // Returns:
        //     A task that represents the asynchronous flush operation.
        //
        // Exceptions:
        //   System.ObjectDisposedException:
        //     The stream has been disposed.
        Task FlushAsync(CancellationToken cancellationToken);

        //
        // Summary:
        //     When overridden in a derived class, reads a sequence of bytes from the current
        //     stream and advances the position within the stream by the number of bytes
        //     read.
        //
        // Parameters:
        //   buffer:
        //     An array of bytes. When this method returns, the buffer contains the specified
        //     byte array with the values between offset and (offset + count - 1) replaced
        //     by the bytes read from the current source.
        //
        //   offset:
        //     The zero-based byte offset in buffer at which to begin storing the data read
        //     from the current stream.
        //
        //   count:
        //     The maximum number of bytes to be read from the current stream.
        //
        // Returns:
        //     The total number of bytes read into the buffer. This can be less than the
        //     number of bytes requested if that many bytes are not currently available,
        //     or zero (0) if the end of the stream has been reached.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     The sum of offset and count is larger than the buffer length.
        //
        //   System.ArgumentNullException:
        //     buffer is null.
        //
        //   System.ArgumentOutOfRangeException:
        //     offset or count is negative.
        //
        //   System.IO.IOException:
        //     An I/O error occurs.
        //
        //   System.NotSupportedException:
        //     The stream does not support reading.
        //
        //   System.ObjectDisposedException:
        //     Methods were called after the stream was closed.
        int Read(byte[] buffer, int offset, int count);

        //
        // Summary:
        //     Asynchronously reads a sequence of bytes from the current stream and advances
        //     the position within the stream by the number of bytes read.
        //
        // Parameters:
        //   buffer:
        //     The buffer to write the data into.
        //
        //   offset:
        //     The byte offset in buffer at which to begin writing data from the stream.
        //
        //   count:
        //     The maximum number of bytes to read.
        //
        // Returns:
        //     A task that represents the asynchronous read operation. The value of the
        //     TResult parameter contains the total number of bytes read into the buffer.
        //     The result value can be less than the number of bytes requested if the number
        //     of bytes currently available is less than the requested number, or it can
        //     be 0 (zero) if the end of the stream has been reached.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     buffer is null.
        //
        //   System.ArgumentOutOfRangeException:
        //     offset or count is negative.
        //
        //   System.ArgumentException:
        //     The sum of offset and count is larger than the buffer length.
        //
        //   System.NotSupportedException:
        //     The stream does not support reading.
        //
        //   System.ObjectDisposedException:
        //     The stream has been disposed.
        //
        //   System.InvalidOperationException:
        //     The stream is currently in use by a previous read operation.
        Task<int> ReadAsync(byte[] buffer, int offset, int count);

        //
        // Summary:
        //     Asynchronously reads a sequence of bytes from the current stream, advances
        //     the position within the stream by the number of bytes read, and monitors
        //     cancellation requests.
        //
        // Parameters:
        //   buffer:
        //     The buffer to write the data into.
        //
        //   offset:
        //     The byte offset in buffer at which to begin writing data from the stream.
        //
        //   count:
        //     The maximum number of bytes to read.
        //
        //   cancellationToken:
        //     The token to monitor for cancellation requests. The default value is System.Threading.CancellationToken.None.
        //
        // Returns:
        //     A task that represents the asynchronous read operation. The value of the
        //     TResult parameter contains the total number of bytes read into the buffer.
        //     The result value can be less than the number of bytes requested if the number
        //     of bytes currently available is less than the requested number, or it can
        //     be 0 (zero) if the end of the stream has been reached.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     buffer is null.
        //
        //   System.ArgumentOutOfRangeException:
        //     offset or count is negative.
        //
        //   System.ArgumentException:
        //     The sum of offset and count is larger than the buffer length.
        //
        //   System.NotSupportedException:
        //     The stream does not support reading.
        //
        //   System.ObjectDisposedException:
        //     The stream has been disposed.
        //
        //   System.InvalidOperationException:
        //     The stream is currently in use by a previous read operation.
        Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);

        //
        // Summary:
        //     Reads a byte from the stream and advances the position within the stream
        //     by one byte, or returns -1 if at the end of the stream.
        //
        // Returns:
        //     The unsigned byte cast to an Int32, or -1 if at the end of the stream.
        //
        // Exceptions:
        //   System.NotSupportedException:
        //     The stream does not support reading.
        //
        //   System.ObjectDisposedException:
        //     Methods were called after the stream was closed.
        int ReadByte();

        //
        // Summary:
        //     When overridden in a derived class, sets the position within the current
        //     stream.
        //
        // Parameters:
        //   offset:
        //     A byte offset relative to the origin parameter.
        //
        //   origin:
        //     A value of type System.IO.SeekOrigin indicating the reference point used
        //     to obtain the new position.
        //
        // Returns:
        //     The new position within the current stream.
        //
        // Exceptions:
        //   System.IO.IOException:
        //     An I/O error occurs.
        //
        //   System.NotSupportedException:
        //     The stream does not support seeking, such as if the stream is constructed
        //     from a pipe or console output.
        //
        //   System.ObjectDisposedException:
        //     Methods were called after the stream was closed.
        long Seek(long offset, SeekOrigin origin);

        //
        // Summary:
        //     When overridden in a derived class, sets the length of the current stream.
        //
        // Parameters:
        //   value:
        //     The desired length of the current stream in bytes.
        //
        // Exceptions:
        //   System.IO.IOException:
        //     An I/O error occurs.
        //
        //   System.NotSupportedException:
        //     The stream does not support both writing and seeking, such as if the stream
        //     is constructed from a pipe or console output.
        //
        //   System.ObjectDisposedException:
        //     Methods were called after the stream was closed.
        void SetLength(long value);

        //
        // Summary:
        //     When overridden in a derived class, writes a sequence of bytes to the current
        //     stream and advances the current position within this stream by the number
        //     of bytes written.
        //
        // Parameters:
        //   buffer:
        //     An array of bytes. This method copies count bytes from buffer to the current
        //     stream.
        //
        //   offset:
        //     The zero-based byte offset in buffer at which to begin copying bytes to the
        //     current stream.
        //
        //   count:
        //     The number of bytes to be written to the current stream.
        void Write(byte[] buffer, int offset, int count);

        //
        // Summary:
        //     Asynchronously writes a sequence of bytes to the current stream and advances
        //     the current position within this stream by the number of bytes written.
        //
        // Parameters:
        //   buffer:
        //     The buffer to write data from.
        //
        //   offset:
        //     The zero-based byte offset in buffer from which to begin copying bytes to
        //     the stream.
        //
        //   count:
        //     The maximum number of bytes to write.
        //
        // Returns:
        //     A task that represents the asynchronous write operation.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     buffer is null.
        //
        //   System.ArgumentOutOfRangeException:
        //     offset or count is negative.
        //
        //   System.ArgumentException:
        //     The sum of offset and count is larger than the buffer length.
        //
        //   System.NotSupportedException:
        //     The stream does not support writing.
        //
        //   System.ObjectDisposedException:
        //     The stream has been disposed.
        //
        //   System.InvalidOperationException:
        //     The stream is currently in use by a previous write operation.
        Task WriteAsync(byte[] buffer, int offset, int count);

        //
        // Summary:
        //     Asynchronously writes a sequence of bytes to the current stream, advances
        //     the current position within this stream by the number of bytes written, and
        //     monitors cancellation requests.
        //
        // Parameters:
        //   buffer:
        //     The buffer to write data from.
        //
        //   offset:
        //     The zero-based byte offset in buffer from which to begin copying bytes to
        //     the stream.
        //
        //   count:
        //     The maximum number of bytes to write.
        //
        //   cancellationToken:
        //     The token to monitor for cancellation requests. The default value is System.Threading.CancellationToken.None.
        //
        // Returns:
        //     A task that represents the asynchronous write operation.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     buffer is null.
        //
        //   System.ArgumentOutOfRangeException:
        //     offset or count is negative.
        //
        //   System.ArgumentException:
        //     The sum of offset and count is larger than the buffer length.
        //
        //   System.NotSupportedException:
        //     The stream does not support writing.
        //
        //   System.ObjectDisposedException:
        //     The stream has been disposed.
        //
        //   System.InvalidOperationException:
        //     The stream is currently in use by a previous write operation.
        Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);

        //
        // Summary:
        //     Writes a byte to the current position in the stream and advances the position
        //     within the stream by one byte.
        //
        // Parameters:
        //   value:
        //     The byte to write to the stream.
        //
        // Exceptions:
        //   System.IO.IOException:
        //     An I/O error occurs.
        //
        //   System.NotSupportedException:
        //     The stream does not support writing, or the stream is already closed.
        //
        //   System.ObjectDisposedException:
        //     Methods were called after the stream was closed.
        void WriteByte(byte value);
    }
}
