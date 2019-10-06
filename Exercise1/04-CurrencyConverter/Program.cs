using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        private static float pln2usdExRate = 3.94f;
        static void Main(string[] args)
        {
            float pln = 100;
            float usd = pln / pln2usdExRate;

            Console.WriteLine($"{pln} PLN can buy {usd:0.00} USD");
        }
    }
}