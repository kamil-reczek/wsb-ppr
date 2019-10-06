using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_QuadraticFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, x, y;
            Console.WriteLine("Provide function's coefficients: a, b, c");
            Console.Write("a= ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = float.Parse(Console.ReadLine());
            Console.Write("c= ");
            c = float.Parse(Console.ReadLine());
            Console.WriteLine($"f(x) = {a}x^2 + {b}x + {c}");
            Console.Write("Provide point x=");
            x = float.Parse(Console.ReadLine());

            y = a * x * x + b * x + c;

            Console.WriteLine($"f({x}) = {y}");

        }
    }
}
