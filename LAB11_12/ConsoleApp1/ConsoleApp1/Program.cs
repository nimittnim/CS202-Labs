using System;
using System.Threading;

namespace AlarmClockApp
{
    // Define a delegate for the alarm event
    public delegate void AlarmEventHandler();

    // Publisher class
    class AlarmClock
    {
        public event AlarmEventHandler raiseAlarm;

        private TimeSpan userTime;

        public void SetAlarm(TimeSpan time)
        {
            userTime = time;
            Console.WriteLine("Alarm is set for: " + userTime);
            CheckTime();
        }

        private void CheckTime()
        {
            while (true)
            {
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                Console.WriteLine("Tick...");

                if (currentTime.Hours == userTime.Hours &&
                    currentTime.Minutes == userTime.Minutes &&
                    currentTime.Seconds == userTime.Seconds)
                {
                    raiseAlarm?.Invoke();
                    break;
                }

                Thread.Sleep(1000); // Check every second
            }
        }
    }

    // Subscriber class
    class AlarmSubscriber
    {
        public void Ring_alarm()
        {
            Console.WriteLine("\n Alarm ringing! ");
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter alarm time (HH:MM:SS): ");
            string input = Console.ReadLine();

            if (TimeSpan.TryParse(input, out TimeSpan alarmTime))
            {
                AlarmClock alarmClock = new AlarmClock();
                AlarmSubscriber subscriber = new AlarmSubscriber();

                // Subscribe to the alarm event
                alarmClock.raiseAlarm += subscriber.Ring_alarm;

                // Set the alarm
                alarmClock.SetAlarm(alarmTime);
            }
            else
            {
                Console.WriteLine("Invalid time format. Please enter in HH:MM:SS format.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

