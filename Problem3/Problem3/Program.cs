using System;

namespace Problem3
{
    public class Stopwatch
    {
        DateTime StartTime;
        DateTime StopTime;
        Boolean IsRunning;

        //Method to start the timer and throws exception if stopwatch is already running
        public void Start()
        {
            if (IsRunning)
            {
                throw new InvalidOperationException("Stopwatch already running!");
            }
            StartTime = DateTime.Now;
            IsRunning = true;
        }

        //Method to stop timer and throws exception if stopwatch not running
        public void Stop()
        {
            if (!IsRunning)
            {
                throw new InvalidOperationException("Stopwatch not running!");
            }
            IsRunning = false;
            StopTime = DateTime.Now;
        }

        //Method to calculate the ElaspedTime
        public TimeSpan ElaspedTime()
        {
            if (IsRunning)
            {
                return DateTime.Now - StartTime;
            }
            else
            {
                return StopTime - StartTime;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var stopwatch = new Stopwatch();
                int choice;

                do
                {
                    Console.Write("1-Start Timer\n2-Stop Timer\n3-Read Timer\n0-Exit\n");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: stopwatch.Start(); break;
                        case 2: stopwatch.Stop(); break;
                        case 3: Console.WriteLine(stopwatch.ElaspedTime()); break;
                    }
                } while (choice != 0); //looping until user exit the menu
            }
        }
        
    }
}