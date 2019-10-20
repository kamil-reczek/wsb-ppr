using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperLibrary;

namespace _05_SieveOfEratosthenes
{
    class Program
    {
        private static uint[] GetPrimes(uint start, uint end)
        {
            
            uint[] temp = Enumerable.Repeat((uint)1, (int)end + 1).ToArray();
            
            for(uint i = 2; i <= end; i++)
            {
                if(temp[i] == 1)
                {
                    for(uint j = i; i * j <= end; j++)
                    {
                        temp[i * j] = 0;
                    }
                }
            }

            uint primeNum = 0;
            for(uint i = start; i <= end; i++)
            {
                if (temp[i] == 1) primeNum++;
            }

            uint[] primes = new uint[primeNum];
            uint k = 0;
            for (uint i = start; i <= end; i++)
            {
                if (temp[i] == 1) {
                    primes[k] = i;
                    k++;
                }
            }
            return primes;
        }

        private static void DisplayPrimes(uint start, uint end)
        {
            uint[] primes = GetPrimes(start, end);

            Console.WriteLine($"Prime number in range [{start}, {end}]:");
            for(int i = 0; i < primes.Length; i++)
            {
                Console.WriteLine(primes[i]);
            }
        }
        private static void MainLoop()
        {
            uint start;
            uint end;
            do
            {
                Console.WriteLine("--- SIEVE OF ERATOSTHENES ---");
                Console.WriteLine("Provide range:");
                start = ReadValues.GetUint("Range start= ");
                end = ReadValues.GetUint("Range end= ");
                if (start > 1 && (start < end)) break;
                Console.WriteLine("Wrong input. Try again");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            } while (true);
            
            DisplayPrimes(start, end);
        }
        static void Main(string[] args)
        {
            MainLoop();
        }
    }
}
