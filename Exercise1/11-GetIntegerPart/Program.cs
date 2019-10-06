using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GetIntegerPart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Provide number a= ");
            double a = double.Parse(Console.ReadLine());

            int b = (int)a;
            Console.WriteLine($"Integer part of a= {b}");
        }
    }
}
