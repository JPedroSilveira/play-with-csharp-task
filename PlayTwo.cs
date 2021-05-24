using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace playWithCsharpTasks
{
    class PlayTwo
    {
        const int TASKS = 512;
        const int CALC_UNTIL = 10000000;
        public static async Task Run()
        {
            const int rounds = 50;
            const int jump = CALC_UNTIL / TASKS;
            long sum = 0;
            for (int x = 0;  x < rounds; x++) 
            {
                var sw = new Stopwatch();
                sw.Start();
                Task<List<int>>[] primes = new Task<List<int>>[TASKS];
                for (int i = 0; i < TASKS; i++)
                {
                    int start = i * jump + 1;
                    int end = start + jump - 1;
                    primes[i] = GetPrimeNumbersAsync(start, end);
                }
                var results = await Task.WhenAll(primes);
                sum += sw.ElapsedMilliseconds;
            }
            Console.WriteLine($"Average execution time: {sum/rounds}ms");
        }

        private static async Task<List<int>> GetPrimeNumbersAsync(int minimum, int maximum)
        {
            var count = maximum - minimum + 1;
            List<int> result = new List<int>();

            return await Task.Factory.StartNew(() =>
            {
                for (int i = minimum; i <= maximum; i++)
                {
                    if (IsPrimeNumber(i))
                    {
                        result.Add(i);
                    }
                }
                return result;
            }, TaskCreationOptions.LongRunning);
        }

        static bool IsPrimeNumber(int number)
        {
            bool isPair = number % 2 == 0;
            if (isPair) return false;

            var topLimit = (int)Math.Sqrt(number);
            for (int i = 3; i <= topLimit; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
