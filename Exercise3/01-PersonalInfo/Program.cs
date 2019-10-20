using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_PersonalInfo
{
    class Program
    {

        private static string GetString(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string firstName = GetString("Provide first name: ");
            string lastName = GetString("Provide last name: ");
            Console.WriteLine("Address details:");
            string street = GetString("Street: ");
            string buildingNumber = GetString("Builing number: ");
            string aptNumber = GetString("Apartement: ");
            string zipCode = GetString("Zip code: ");
            string city = GetString("City: ");

            Console.WriteLine();
            Console.WriteLine($"{firstName} {lastName}\n{street} {buildingNumber}/{aptNumber}\n{zipCode} {city}");

        }
    }
}
