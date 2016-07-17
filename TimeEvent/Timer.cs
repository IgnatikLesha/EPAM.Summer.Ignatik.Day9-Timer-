using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeEvent
{
    class Timer
    {
        public event EventHandler<OutOfTimeEventArgs> OutOfTime = delegate { };

        private void OnOutOfTime(OutOfTimeEventArgs e)
        {
            OutOfTime(this, e);
        }

        public void SimulateOutOfTime(string message, double time)
        {
            OnOutOfTime(new OutOfTimeEventArgs(message, time));
        }
    }
}
