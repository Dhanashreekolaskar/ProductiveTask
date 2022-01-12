using System;
using System.Diagnostics;
using System.Threading;

namespace StopWatch
{
   

    class Program
    {
        static void Main()
        {
            // Create new stopwatch.

            Stopwatch stopwatch = new Stopwatch();

            
            stopwatch.Start();

          
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }

            // Stop timing.
            stopwatch.Stop();

            
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
