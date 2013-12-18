using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Loqu8.MvvmCross.Plugins.IO
{
    public abstract class MvxBaseStream : IMvxStream
    {
        protected Stream _stream;
        protected IMvxStream _mvxStream;

        // Summary:
        //     When overridden in a derived class, gets a value indicating whether the current
        //     stream supports reading.
        //
        // Returns:
        //     true if the stream supports reading; otherwise, false.
        public bool CanRead
        {
            get { return (_stream != null) ? _stream.CanRead : _mvxStream.CanRead; }
        }

        //
        // Summary:
        //     When overridden in a derived class, gets a value indicating whether the current
        //     stream supports seeking.
        //
        // Returns:
        //     true if the stream supports seeking; otherwise, false.
        public bool CanSeek
        {
            get { return (_stream != null) ? _stream.CanSeek : _mvxStream.CanSeek; }
        }

        //
        // Summary:
        //     Gets a value that determines whether the current stream can time out.
        //
        // Returns:
        //     A value that determines whether the current stream can time out.
        public bool CanTimeout
        {
            get { return (_stream != null) ? _stream.CanTimeout : _mvxStream.CanTimeout; }
        }

        //
        // Summary:
        //     When overridden in a derived class, gets a value indicating whether the current
        //     stream supports writing.
        //
        // Returns:
        //     true if the stream supports writing; otherwise, false.
        public bool CanWrite
        {
            get { return (_stream != null) ? _stream.CanWrite : _mvxStream.CanWrite; }
        }

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
        public long Length
        {
            get { return (_stream != null) ? _stream.Length : _mvxStream.Length; }
        }

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
        public long Position
        {
            get
            {
                return (_stream != null) ? _stream.Position : _mvxStream.Position;
            }
            set
            {
                if (_stream != null)
                {
                    _stream.Position = value;
                }
                else
                {
                    _mvxStream.Position = value;
                }
            }
        }

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
        public int ReadTimeout
        {
            get
            {
                return (_stream != null) ? _stream.ReadTimeout : _mvxStream.ReadTimeout;
            }
            set
            {
                if (_stream != null)
                {
                    _stream.ReadTimeout = value;
                }
                else
                {
                    _mvxStream.ReadTimeout = value;
                }
            }
        }

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
        public int WriteTimeout
        {
            get
            {
                return (_stream != null) ? _stream.WriteTimeout : _mvxStream.WriteTimeout;
            }
            set
            {
                if (_stream != null)
                {
                    _stream.WriteTimeout = value;
                }
                else
                {
                    _mvxStream.WriteTimeout = value;
                }
            }
        }

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
        public void CopyTo(Stream destination)
        {
            if (_stream != null)
            {
                _stream.CopyTo(destination);
            }
            else
            {
                _mvxStream.CopyTo(destination);
            }
        }

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
        public void CopyTo(Stream destination, int bufferSize)
        {
            if (_stream != null)
            {
                _stream.CopyTo(destination, bufferSize);
            }
            else
            {
                _mvxStream.CopyTo(destination, bufferSize);
            }
        }

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
        public async Task CopyToAsync(Stream destination)
        {
            if (_stream != null)
            {
                await _stream.CopyToAsync(destination);
            }
            else
            {
                await _mvxStream.CopyToAsync(destination);
            }
        }

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
        public async Task CopyToAsync(Stream destination, int bufferSize)
        {
            if (_stream != null)
            {
                await _stream.CopyToAsync(destination, bufferSize);
            }
            else
            {
                await _mvxStream.CopyToAsync(destination, bufferSize);
            }
        }

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
        public async Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
        {
            if (_stream != null)
            {
                await _stream.CopyToAsync(destination, bufferSize, cancellationToken);
            }
            else
            {
                await _stream.CopyToAsync(destination, bufferSize, cancellationToken);
            }
        }

        //
        // Summary:
        //     Releases all resources used by the System.IO.Stream.
        public void Dispose()
        {
            if (_stream != null)
            {
                _stream.Dispose();
            }

            if (_mvxStream != null)
            {
                _mvxStream.Dispose();
            }
        }

        //
        // Summary:
        //     When overridden in a derived class, clears all buffers for this stream and
        //     causes any buffered data to be written to the underlying device.
        //
        // Exceptions:
        //   System.IO.IOException:
        //     An I/O error occurs.
        public void Flush()
        {
            if (_stream != null)
            {
                _stream.Flush();
            }
            else
            {
                _mvxStream.Flush();
            }
        }

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
        public async Task FlushAsync()
        {
            if (_stream != null)
            {
                await _stream.FlushAsync();
            }
            else
            {
                await _mvxStream.FlushAsync();
            }
        }

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
        public async Task FlushAsync(CancellationToken cancellationToken)
        {
            if (_stream != null)
            {
                await _stream.FlushAsync(cancellationToken);
            }
            else
            {
                await _mvxStream.FlushAsync(cancellationToken);
            }
        }

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
        public int Read(byte[] buffer, int offset, int count)
        {
            if (_stream != null)
            {
                return _stream.Read(buffer, offset, count);
            }

            return _mvxStream.Read(buffer, offset, count);
        }

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
        public async Task<int> ReadAsync(byte[] buffer, int offset, int count)
        {
            if (_stream != null)
            {
                return await _stream.ReadAsync(buffer, offset, count);
            }

            return await _mvxStream.ReadAsync(buffer, offset, count);
        }

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
        public async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            if (_stream != null)
            {
                return await _stream.ReadAsync(buffer, offset, count, cancellationToken);
            }

            return await _mvxStream.ReadAsync(buffer, offset, count, cancellationToken);
        }

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
        public int ReadByte()
        {
            if (_stream != null)
            {
                return _stream.ReadByte();
            }

            return _mvxStream.ReadByte();
        }

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
        public long Seek(long offset, SeekOrigin origin)
        {
            if (_stream != null)
            {
                return _stream.Seek(offset, origin);
            }

            return _mvxStream.Seek(offset, origin);
        }

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
        public void SetLength(long value)
        {
            if (_stream != null)
            {
                _stream.SetLength(value);
            }
            else
            {
                _mvxStream.SetLength(value);
            }
        }

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
        public void Write(byte[] buffer, int offset, int count)
        {
            if (_stream != null)
            {
                _stream.Write(buffer, offset, count);
            }
            else
            {
                _mvxStream.Write(buffer, offset, count);
            }
        }

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
        public async Task WriteAsync(byte[] buffer, int offset, int count)
        {
            if (_stream != null)
            {
                await _stream.WriteAsync(buffer, offset, count);
            }
            else
            {
                await _mvxStream.WriteAsync(buffer, offset, count);
            }
        }

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
        public async Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            if (_stream != null)
            {
                await _stream.WriteAsync(buffer, offset, count, cancellationToken);
            }
            else
            {
                await _mvxStream.WriteAsync(buffer, offset, count, cancellationToken);
            }
        }

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
        public void WriteByte(byte value)
        {
            if (_stream != null)
            {
                _stream.WriteByte(value);
            }
            else
            {
                _mvxStream.WriteByte(value);
            }
        }
    }
}