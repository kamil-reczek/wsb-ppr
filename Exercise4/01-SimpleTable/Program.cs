using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperLibrary;

namespace _01_SimpleTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[5];
            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = ReadValues.GetInt($"tab[{i}] = ");
            }

            Console.Write("Reversed tab= ");
            for(int i = tab.Length - 1; i > -1; i--)
            {
                Console.Write($"{tab[i]} ");
            }
            Console.WriteLine();

        }
    }
}
