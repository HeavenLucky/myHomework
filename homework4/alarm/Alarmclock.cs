using System;
using System.Threading;

namespace alarm
{

    public class TickEventArgs : EventArgs {
       public int hour = DateTime.Now.Hour;
       public int mimute = DateTime.Now.Minute;
    }
    public class AlarmEventArgs : EventArgs
    {
       public int hour = DateTime.Now.Hour;
       public int mimute = DateTime.Now.Minute;
    }
    public delegate void TickEventHandler(object sender, TickEventArgs tickEventArgs);

    public delegate void AlarmEventHandler(object sender,AlarmEventArgs alarmEventArgs);
    public class Alarmclock
    {
            private DateTime addatetime;

            public event TickEventHandler Tick;

        public event AlarmEventHandler Alarm;
        public Alarmclock()
        {

        }
       
        public void Ticking() {

            string advancedTime = Console.ReadLine();
            while (true)
            {
                TickEventArgs tickEventArgs = new TickEventArgs();
            AlarmEventArgs alarmEventArgs = new AlarmEventArgs();
            DateTime addatetime = Convert.ToDateTime(advancedTime);

           int  adminute = addatetime.Minute;
            int adhour = addatetime.Hour;

          
                Tick(this, tickEventArgs);
                Thread.Sleep(1000);

                if (adhour == DateTime.Now.Hour && adminute == DateTime.Now.Minute)
                {
                    Alarm(this, alarmEventArgs);
                }
            }
          
        }

       

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入预定时间");
            var alarm = new Alarmclock();
            alarm.Tick += ShowTime;
            alarm.Alarm += Alarm;
            while (true) { alarm.Ticking(); }
        

        }
        public static void ShowTime(object sender, TickEventArgs tickEventArgs)
        {
            Console.WriteLine("现在的时间是：" + tickEventArgs.hour+"时"+tickEventArgs.mimute+"分");

        }
        public static void Alarm(object sender, AlarmEventArgs alarmEventArgs) {
            Console.WriteLine("到点啦！！");
        }
        
       



    }
}