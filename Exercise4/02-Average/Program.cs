using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperLibrary;

namespace _02_Average
{
    class Program
    {
        private static double GetAverage(int[] tab)
        {
            if(tab.Length > 0)
            {
                int sum = 0;
                foreach (int i in tab) sum += i;
                return sum / tab.Length;
            }
            return double.NaN;
        }

        private static void PopulateTable(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = ReadValues.GetInt($"tab[{i}]= ");
            }
        }
        static void Main(string[] args)
        {
            uint n = ReadValues.GetUint("n= ");
            int[] tab = new int[n];
            PopulateTable(tab);
            string tabStr = string.Join(",", tab);
            Console.WriteLine($"For number: {tabStr} the avarage= {GetAverage(tab)}");
        }
    }
}
