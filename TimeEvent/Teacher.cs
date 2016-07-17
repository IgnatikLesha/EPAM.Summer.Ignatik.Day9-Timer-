using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeEvent
{
    class Teacher
    {
        public void Register(Timer timer)
        {
            timer.OutOfTime += TeacherMessage;
        }

        private void TeacherMessage(object sender, OutOfTimeEventArgs eventArgs)
        {
            Console.WriteLine("The time is out!");
            Console.WriteLine("WTF ?! (0_0) {0} have passed! {1}", eventArgs.Time, eventArgs.Message);
        }

        public void Unregister(Timer timer)
        {
            timer.OutOfTime -= TeacherMessage;
        }
    }
}
