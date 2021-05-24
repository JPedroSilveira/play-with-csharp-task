using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace playWithCsharpTasks
{
    class PlayOne
    {
        const int TASKS = 12;
        public static async Task Run()
        {
            const int rounds = 50;
            long sum = 0;

            for (int x = 0;  x < rounds; x++) 
            {
                var sw = new Stopwatch();
                sw.Start();
                Task[] values = new Task[TASKS];
                for (int i = 0; i < TASKS; i++)
                {
                    values[i] = GetTask();
                }
                await Task.WhenAll(values);
                sum += sw.ElapsedMilliseconds;
            }
            Console.WriteLine($"Average execution time: {sum/rounds}ms");
        }

        private static Task GetTask()
        {
            return Task.Factory.StartNew(() =>
            {
                for(double x = 0; x < 100000000; x+=0.5) {}
            }, TaskCreationOptions.LongRunning);
        }
    }
}
