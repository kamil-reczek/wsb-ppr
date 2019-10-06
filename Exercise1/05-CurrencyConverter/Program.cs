using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CurrencyConverter
{
    class Program
    {
        private static float pln2usdExRate = 3.94f;
        static void Main(string[] args)
        {
            Console.Write("PLN= ");
            string input = Console.ReadLine();
            float pln = float.Parse(input);
            float usd = pln / pln2usdExRate;

            Console.WriteLine($"{pln:0.00} PLN can buy {usd:0.00} USD");
        }
    }
}
