using System;

namespace Wpf_Stopwatch.Model {
    class LapEventArgs : EventArgs {
        public TimeSpan? LapTime { get; set; }
        public LapEventArgs(TimeSpan? lapTime) {
            LapTime = lapTime;
        }
    }
}
