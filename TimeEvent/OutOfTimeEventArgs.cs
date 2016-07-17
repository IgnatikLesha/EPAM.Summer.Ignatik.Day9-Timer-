using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeEvent
{
    public class OutOfTimeEventArgs: EventArgs
    {
        private string message;
        private double time;

        public string Message {
            get { return message; }
            set
            {
                if(ReferenceEquals(value, null))
                    throw new ArgumentException();
                message = value;
            }
        }

        public double Time
        {
            get { return time; }
            set
            {
                if(value < 0)
                    throw new ArgumentException();
                time = value;
            }

        }

        public OutOfTimeEventArgs(string message, double time)
        {
            Message = message;
            Time = time;
        }
    }
}
