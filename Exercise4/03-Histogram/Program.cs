using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperLibrary;

namespace _03_Histogram
{
    class Program
    {
        private static int GetProperInt(string msg)
        {
            int result = 0;
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out result) && result <=5 && result >= 1) break;
                Console.WriteLine("Provide integer within range[1, 5].Try again!");
            }
            return result;
        }

        private static void PopulateTable(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = GetProperInt($"tab[{i}]= ");
            }
        }

        private static string[] GetHistogram(int[] tab)
        {
            string[] hist = new string[5];
            for(int i = 0; i < tab.Length; i++)
            {
                hist[tab[i] - 1] += "*";
            }
            return hist;
        }

        private static void DisplayHistogram(string[] hist)
        {
            for(int i = 0; i < hist.Length; i++)
            {
                Console.WriteLine($"{i + 1} {hist[i]}");
            }
        }

        private static void MainLoop()
        {
            int size = ReadValues.GetInt("tab size= ");
            int[] tab = new int[size];
            PopulateTable(tab);
            DisplayHistogram(GetHistogram(tab));
        }

        static void Main(string[] args)
        {
            MainLoop();
        }
    }
}
