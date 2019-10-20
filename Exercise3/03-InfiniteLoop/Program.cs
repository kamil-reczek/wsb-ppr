using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InfiniteLoop
{
    class Program
    {
        private static int GetInt(string msg)
        {
            int result = 0;
            Console.Write(msg);
            if (!int.TryParse(Console.ReadLine(), out result)) result = -1;
            return result;
        }
        private static void MainLoop()
        {
            Console.WriteLine("--- INFINITE LOOP ---");
            Random rnd = new Random();
            Console.WriteLine($"Random integer= {rnd.Next(1000)}");
            while (true)
            {
                if (GetInt("Press 0 to exit: ") == 0) break;
                // This will generate random number within interval [0, 1000)
                Console.WriteLine($"Random integer= {rnd.Next(1000)}");
            } while (true) ;
        }
        static void Main(string[] args)
        {
            MainLoop();
        }
    }
}
