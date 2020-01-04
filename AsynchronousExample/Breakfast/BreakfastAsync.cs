using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;

namespace Breakfast
{
    public static class BreakfastAsync
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

        public static async Task MakeEggsAndBacon()
        {
            Console.WriteLine("Making eggs and bacon");
//            await FryBaconAsync();
//            await FryEggsAsync();
            var baconTask = FryBaconAsync();
            var eggsTask = FryEggsAsync();

            await Task.WhenAll(baconTask, eggsTask);
            
//            var taskList = new List<Task> {baconTask, eggsTask};
//            while (taskList.Any())
//            {
//                Task finished = await Task.WhenAny(taskList);
//                taskList.Remove(finished);
//            }
            Console.WriteLine("Eggs and bacon ready");
        }

        private static async Task FryBaconAsync()
        {
            Console.WriteLine("\tFrying bacon");
            await Task.Delay(500);
            Console.WriteLine("\tBacon ready");
        }

        private static async Task FryEggsAsync()
        {
            Console.WriteLine("\tFrying eggs");
            await Task.Delay(100); 
            Console.WriteLine("\tEggs ready");
        }

        public static async Task<int> MakeToastWithButterAndJamAsync(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Making toast {i}");
                await MakeToastAsync(i);
                AddButter(i);
                AddJam(i);
                Console.WriteLine($"Toast {i} ready");
            }

            Console.WriteLine($"All {n} toasts ready");
            return n;
        }

        private static async Task MakeToastAsync(int i)
        {
            Console.WriteLine($"\tToasting bread for toast {i}");
            await Task.Delay(100);
        }

        private static void AddButter(int i)
        {
            Console.WriteLine($"\tAdding butter on toast {i}");
            Thread.Sleep(10);
        }

        private static void AddJam(int i)
        {
            Console.WriteLine($"\tAdding jam on toast {i}");
            Thread.Sleep(10);
        }
        
        public static async Task MakeOrangeJuiceAsync()
        {
            Console.WriteLine("Squeezing oranges");
            await Task.Delay(1000);
            Console.WriteLine("OJ ready");
        }

        public static async Task<int> MakeCoffeeAsync(int n)
        {
            Console.WriteLine("Brewing coffee");
            await Task.Delay(n * 200);
            Console.WriteLine("Coffee ready");
            return n;
        }

        public static void PrepareBreakfast()
        {
            Task[] tasks = {MakeEggsAndBacon(), MakeToastWithButterAndJamAsync(5), MakeCoffeeAsync(2), MakeOrangeJuiceAsync()};

            Task.WaitAll(tasks);
        }
    }
}