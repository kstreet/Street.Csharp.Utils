﻿// this code is based on "Blakomen" (henry-chong.com)'s code in an answer to as SO question
// http://stackoverflow.com/questions/12555049/timer-in-portable-library
// Per StackOverflow Licensing: http://meta.stackoverflow.com/questions/25956/what-is-up-with-the-source-code-license-on-stack-overflow
// This particular Street.Csharp.Utils.PclTimer is licensed under a Creative Commons Attribution-ShareAlike 2.5 Generic License.
// http://creativecommons.org/licenses/by-sa/2.5/legalcode
// packaged and resharpered by @kcstreet

using System;
using System.Threading;

namespace Street.Csharp.Utils
{
    public class PclTimer
    {
        private readonly Timer _timer;

        private readonly Action _action;

        public PclTimer (Action action, TimeSpan dueTime, TimeSpan period)
        {
            _action = action;

            _timer = new Timer(PclTimerCallback, null, dueTime, period);           
        }

        private void PclTimerCallback(object state)
        {
            _action.Invoke();
        }

        public bool Change(TimeSpan dueTime, TimeSpan period)
        {
            return _timer.Change(dueTime, period);
        }
    }
}
