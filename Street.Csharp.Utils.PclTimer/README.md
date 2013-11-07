Street.Csharp.Utils.PclTimer
===================

Hacky Timer adapter - this is PCL library that targets .net 4.0 (and others in PCL profile 88).
Reference it from 4.5 PCL.

This project is a workaround for this Visual Studio 2012 Issue with Portable Class Libraries:

[http://stackoverflow.com/questions/12555049/timer-in-portable-library](http://stackoverflow.com/questions/12555049/timer-in-portable-library)

Usage:

Reference this DLL in your .NET 4.5 PCL and then:

        private void TimeEvent()
        {
            //place your timer callback code here
        }

        public void SetupTimer()
        {
            //set up timer to run every second
            var pageTimer = new PclTimer(new Action(TimeEvent), TimeSpan.FromMilliseconds(-1), TimeSpan.FromSeconds(1));

            //timer starts one second from now
            pageTimer.Change(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
        }

See: SampleUsage.cs

