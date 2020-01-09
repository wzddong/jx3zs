using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Jx3zs
{
    public class TaskHelper
    {
        public static System.Timers.Timer timer = new System.Timers.Timer();
        public static int timerInterval =3*60*1000;
        public TaskHelper()
        {
            if (timer.Enabled) return;
            timer.Enabled = true;
            timer.Interval = timerInterval;
        }

    }
}
