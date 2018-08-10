using System;

namespace StopWatch
{
    class StopWatch
    {
        private DateTime StartTime { get; set; } 
        private DateTime StopTime { get; set; }
        private bool IsRunning { get; set; }
        public TimeSpan Interval { get; set; }

        public StopWatch() {
            IsRunning = false;    
        }

        public void Start() {
            if (IsRunning)
                throw new System.InvalidOperationException("You already started the stopper!");
            
            StartTime = DateTime.Now;
            Interval = TimeSpan.Zero;
            IsRunning = true;
        }

        public void Stop() {
            StopTime = DateTime.Now;
            Interval =  StopTime - StartTime;
            IsRunning = false;
        }
    }
}
