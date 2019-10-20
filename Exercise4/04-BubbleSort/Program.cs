using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperLibrary;

namespace _04_BubbleSort
{
    class Program
    {
        private static void BubbleSort(int[] tab)
        {
            int temp;
            for (int i = 0; i <= tab.Length - 2; i++)
            {
                for (int j = 0; j <= tab.Length - 2; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        temp = tab[j + 1];
                        tab[j + 1] = tab[j];
                        tab[j] = temp;
                    }
                }
            }
        }

        private static void DisplayTable(int[] tab)
        {
            Console.Write("[ ");
            for(int i = 0; i <tab.Length; i++)
            {
                Console.Write($"{tab[i]} ");
            }
            Console.WriteLine("]");
        }

        private static void MainLoop()
        {
            int[] tab = Tables.GenerateRandomIntTable(ReadValues.GetUint("table size= "));
            DisplayTable(tab);
            BubbleSort(tab);
            DisplayTable(tab);
        }
        static void Main(string[] args)
        {
            MainLoop();
        }
    }
}
