using System;

namespace StopWatch
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var Stopper = new StopWatch();
                Stopper.Start();
                System.Threading.Thread.Sleep(1000);
                Stopper.Stop();
                Console.WriteLine(Stopper.Interval.Seconds);

                Stopper.Start();
                System.Threading.Thread.Sleep(1200);
                Stopper.Stop();
                Console.WriteLine(Stopper.Interval.Seconds);

                Stopper.Start();
                Stopper.Start();
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }
    }
}
