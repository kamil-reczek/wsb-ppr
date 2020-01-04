using System;
using System.Threading;

namespace Breakfast
{
    public class BreakfastSync
    {
        // 1. Eggs and Bacon
        // 1.1 Fry bacon
        // 1.2 Fry eggs
        
        // 2. Toast with butter and jam
        // 2.1 Make toast
        // 2.2 Add butter
        // 2.3 Add jam
        
        // 3. Orange Juice

        // 4. Coffee

        public static void MakeEggsAndBacon()
        {
            Console.WriteLine("Making eggs and bacon");
            FryBacon();
            FryEggs();
            Console.WriteLine("Eggs and bacon ready");
        }

        private static void FryBacon()
        {
            Console.WriteLine("\tFrying bacon");
            Thread.Sleep(100);
            Console.WriteLine("\tBacon ready");
        }

        private static void FryEggs()
        {
            Console.WriteLine("\tFrying eggs");
            Thread.Sleep(500);
            Console.WriteLine("\tEggs ready");
        }

        public static int MakeToastWithButterAndJam(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Making toast {i}");
                MakeToast(i);
                AddButter(i);
                AddJam(i);
                Console.WriteLine($"Toast {i} ready");
            }

            Console.WriteLine($"All {n} toasts ready");
            return n;
        }

        private static void MakeToast(int i)
        {
            Console.WriteLine($"\tToasting bread for toast {i}");
            Thread.Sleep(100);
        }

        private static void AddButter(int i)
        {
            Console.WriteLine($"\tAdding butter to toast {i}");
            Thread.Sleep(10);
        }

        private static void AddJam(int i)
        {
            Console.WriteLine($"\tAdding jam to toast {i}");
            Thread.Sleep(10);
        }
        
        public static void MakeOrangeJuice()
        {
            Console.WriteLine("Squeezing oranges");
            Thread.Sleep(1000);
            Console.WriteLine("OJ ready");
        }

        public static int MakeCoffee(int n)
        {
            Console.WriteLine("Brewing coffee");
            Thread.Sleep(n * 200);
            Console.WriteLine("Coffee ready");
            return n;
        }

        public static void PrepareBreakfastSync()
        {
            MakeEggsAndBacon();
            MakeToastWithButterAndJam(5);
            MakeCoffee(2);
            MakeOrangeJuice();
        }
    }
}