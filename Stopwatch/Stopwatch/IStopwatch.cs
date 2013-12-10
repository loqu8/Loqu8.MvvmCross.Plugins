using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.MvvmCross.Plugins.Stopwatch
{
    public interface IStopwatch
    {
        // Summary:
        //     Gets the frequency of the timer as the number of ticks per second. This field
        //     is read-only.
        long Frequency { get; }
        //
        // Summary:
        //     Indicates whether the timer is based on a high-resolution performance counter.
        //     This field is read-only.
        bool IsHighResolution { get; }

        // Summary:
        //     Gets the total elapsed time measured by the current instance.
        //
        // Returns:
        //     A read-only System.TimeSpan representing the total elapsed time measured
        //     by the current instance.
        TimeSpan Elapsed { get; }
        //
        // Summary:
        //     Gets the total elapsed time measured by the current instance, in milliseconds.
        //
        // Returns:
        //     A read-only long integer representing the total number of milliseconds measured
        //     by the current instance.
        long ElapsedMilliseconds { get; }
        //
        // Summary:
        //     Gets the total elapsed time measured by the current instance, in timer ticks.
        //
        // Returns:
        //     A read-only long integer representing the total number of timer ticks measured
        //     by the current instance.
        long ElapsedTicks { get; }
        //
        // Summary:
        //     Gets a value indicating whether the System.Diagnostics.Stopwatch timer is
        //     running.
        //
        // Returns:
        //     true if the System.Diagnostics.Stopwatch instance is currently running and
        //     measuring elapsed time for an interval; otherwise, false.
        bool IsRunning { get; }

        // Summary:
        //     Gets the current number of ticks in the timer mechanism.
        //
        // Returns:
        //     A long integer representing the tick counter value of the underlying timer
        //     mechanism.
        long GetTimestamp();
        //
        // Summary:
        //     Stops time interval measurement and resets the elapsed time to zero.
        void Reset();
        //
        // Summary:
        //     Stops time interval measurement, resets the elapsed time to zero, and starts
        //     measuring elapsed time.
        void Restart();
        //
        // Summary:
        //     Starts, or resumes, measuring elapsed time for an interval.
        void Start();
        //
        // Summary:
        //     Stops measuring elapsed time for an interval.
        void Stop();    
    }
}
