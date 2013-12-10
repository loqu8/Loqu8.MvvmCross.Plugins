﻿using System;

namespace Loqu8.MvvmCross.Plugins.$safeprojectname$
{
    public class MvxStopwatch : IStopwatch
    {        
        System.Diagnostics.$safeprojectname$ _stopwatch;

        public MvxStopwatch()
        {
            _stopwatch = new System.Diagnostics.$safeprojectname$();
        }

        #region IStopwatch

        public long Frequency
        {
            get
            {
                return System.Diagnostics.$safeprojectname$.Frequency;
            }
        }

        public bool IsHighResolution
        {
            get
            {
                return System.Diagnostics.$safeprojectname$.IsHighResolution;
            }
        }

        public TimeSpan Elapsed
        {
            get
            {
                return _stopwatch.Elapsed;
            }
        }

        public long ElapsedMilliseconds
        {
            get
            {
                return _stopwatch.ElapsedMilliseconds;
            }
        }

        public long ElapsedTicks
        {
            get
            {
                return _stopwatch.ElapsedTicks;
            }
        }

        public bool IsRunning
        {
            get
            {
                return _stopwatch.IsRunning;
            }
        }

        public long GetTimestamp()
        {
            return System.Diagnostics.$safeprojectname$.GetTimestamp();
        }

        public void Reset()
        {
            _stopwatch.Reset();
        }

        public void Restart()
        {
            _stopwatch.Restart();
        }

        public void Start()
        {
            _stopwatch.Start();
        }

        public void Stop()
        {
            _stopwatch.Stop();
        }

        #endregion IStopwatch
    }
}
