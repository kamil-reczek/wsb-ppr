using System;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleExample1
{
    class Program
    {

        private static async Task<int> MethodAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine($"{i} Async Method");
                }
            });
            return 666;
        }

        private static async Task Method2Async()
        {
            await Task.Delay(0);
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine($"{i} Async Method 2");
            }
        }
        private static void MethodSync()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} Sync method");
            }
        }

        private static long Factorial(int n)
        {
            long r = 1;
            if (n < 1) return r;
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Factorial {i}");
                    r *= i;
                }
            }

            return r;

        }

        private static async Task<long> FactorialAsync(int n)
        {
            long r = 0;
            await Task.Run(() => r = Factorial(n));
            return r;
        }
        
        static void Main(string[] args)
        {
            Task<long> factorial = FactorialAsync(11);
//            Task task1 = MethodAsync();
//            Task task2 = Method2Async();
            MethodSync();

//            task1.Wait();
//            task2.Wait();
//            factorial.Wait();
            long r = factorial.Result;

            Console.WriteLine(r);
        }
    }
}