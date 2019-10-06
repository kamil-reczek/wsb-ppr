using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EvenNumber
{
    class Program
    {
        private static int getInt(string msg)
        {
            int result = 0;
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out result)) break;
                Console.WriteLine("Not an integer. Try again!");
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(getInt("Provide an integer ") % 2 == 0 ? "Even number": "Odd number") ;
        }
    }
}