using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace BillibleHoursClock
{
    class Watch
    {
        Stopwatch sw;
        
        public Watch() => sw = new Stopwatch();
        public void StartWatch() => sw.Start();
        public void StopWatch() => sw.Stop();
        public void ResetWatch() => sw.Reset();

        public bool IsWatchRunning => sw.IsRunning;
        public TimeSpan HowMuchTimehasPassed => sw.Elapsed;

        
    }
}
