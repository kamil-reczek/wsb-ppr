using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public static class Tables
    {
        public static int[] CreateIntTab()
        {
            return new int[ReadValues.GetUint($"size= ")];
        }

        public static void PopulateIntTable(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = ReadValues.GetInt($"tab[{i}]= ");
            }
        }

        public static uint[] CreateUintTab()
        {
            return new uint[ReadValues.GetUint($"size= ")];
        }

        public static void PopulateUintTable(uint[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = ReadValues.GetUint($"tab[{i}]= ");
            }
        }

        public static int[] GenerateRandomIntTable(uint size)
        {
            Random rnd = new Random();
            int[] tab = new int[size];
            for (uint i = 0; i < tab.Length; i++) tab[i] = rnd.Next(1000);
            return tab;
        }
    }
}
