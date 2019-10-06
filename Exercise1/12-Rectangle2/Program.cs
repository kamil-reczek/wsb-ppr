using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Rectangle2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Side b= ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
