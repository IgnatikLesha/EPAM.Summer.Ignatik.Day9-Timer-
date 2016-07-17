using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeEvent
{
    class Student
    {
        public void Register(Timer timer)
        {
            timer.OutOfTime += StudentMessage;
        }

        private void StudentMessage(object sender, OutOfTimeEventArgs eventArgs)
        {
            Console.WriteLine("The time is out!");
            Console.WriteLine("{0} have passed! {1}", eventArgs.Time, eventArgs.Message);
        }

        public void Unregister(Timer timer)
        {
            timer.OutOfTime -= StudentMessage;
        }
    }
}
