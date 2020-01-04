using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Breakfast
{
    class Program
    {
        private static Stopwatch _sw = new Stopwatch();

        static void Main(string[] args)
        {
            _sw.Start();
            BreakfastSync.PrepareBreakfastSync();
            _sw.Stop();
            Console.WriteLine();
            Console.WriteLine($"Making breakfast SYNCHRONOUSLY took {_sw.ElapsedMilliseconds} milliseconds");
            
            _sw.Reset();
            _sw.Start();
            BreakfastAsync.PrepareBreakfast();
            _sw.Stop();
            Console.WriteLine($"Making breakfast ASYNCHRONOUSLY took {_sw.ElapsedMilliseconds} milliseconds");
        }
    }
}