﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public static class ReadValues
    {
        public static readonly string DefaultErrorMessageDouble = "Not a double. Try again!";
        public static readonly string DefaultErrorMessageInt = "Not an integer. Try again!";
        public static readonly string DefaultErrorMessageChar = "Not a character. Try again!";
        public static readonly string DefaultErrorMessateUint = "Not an unsigned integer.Try again!";

        public static readonly double DefaultValueDouble = -1.0;
        public static readonly int DefaultValueInt = -1;
        public static readonly char DefaultValueChar = 'x';
        public static readonly uint DefaultValueUint = 0;

        // double
        public static double GetDouble(string msg)
        {
            return GetDouble(msg, DefaultErrorMessageDouble);
        }
        
        public static double GetDouble(string msg, string err)
        {
            double result = 0;
            while (true)
            {
                Console.Write(msg);
                if (double.TryParse(Console.ReadLine(), out result)) break;
                Console.WriteLine(err);
            }
            return result;
        }

        public static double GetDouble(string msg, int attempts)
        {
            return GetDouble(msg, DefaultErrorMessageDouble, attempts, DefaultValueDouble);
        }
        public static double GetDouble(string msg, string err, int attempts, double def)
        {
            int i = 0;
            double result;
            do
            {
                i++;
                Console.Write(msg);
                if (double.TryParse(Console.ReadLine(), out result)) return result;
                Console.WriteLine(err);
                Console.WriteLine($"Attempts left: {attempts - i}");
            }
            while (i < attempts);
            Console.WriteLine("Returning default value");
            return def;
        }

        // character
        public static char GetCharacter(string msg)
        {
            return GetCharacter(msg, DefaultErrorMessageChar);
        }
        
        public static char GetCharacter(string msg, string err)
        {
            char result;
            while (true)
            {
                Console.Write(msg);
                if (char.TryParse(Console.ReadLine(), out result)) break;
                Console.WriteLine(err);
            }
            return result;
        }

        public static char GetCharacter(string msg, int attempts)
        {
            return GetCharacter(msg, DefaultErrorMessageChar, attempts, DefaultValueChar);
        }

        public static char GetCharacter(string msg, string err, int attempts, char def)
        {
            int i = 0;
            char result;
            do
            {
                i++;
                Console.Write(msg);
                if (char.TryParse(Console.ReadLine(), out result)) return result;
                Console.WriteLine(err);
                Console.WriteLine($"Attempts left: {attempts - i}");
            }
            while (i < attempts);
            Console.WriteLine("Returning default value");
            return def;
        }

        // int
        public static int GetInt(string msg)
        {
            return GetInt(msg, DefaultErrorMessageInt);
        }

        public static int GetInt(string msg, string err)
        {
            int result = 0;
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out result)) break;
                Console.WriteLine(err);
            }
            return result;
        }

        public static int GetInt(string msg, int attempts)
        {
            return GetInt(msg, DefaultErrorMessageInt, attempts, DefaultValueInt);
        }

        public static int GetInt(string msg, string err, int attempts, int def)
        {
            int i = 0;
            int result;
            do
            {
                i++;
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out result)) return result;
                Console.WriteLine(err);
                Console.WriteLine($"Attempts left: {attempts - i}");
            }
            while (i < attempts);
            Console.WriteLine("Returning default value");
            return def;
        }

        public static int GetInt(string msg, int begin, int end, int attempts)
        {
            int i = 0;
            int result;
            do
            {
                i++;
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out result) && result >= begin && result <= end) return result;
                Console.WriteLine($"Wrong intput - provide integer in range [{begin}, {end}]");
                Console.WriteLine($"Attempts left: {attempts - i}");
            }
            while (i < attempts);
            Console.WriteLine("Returning default value");
            return (begin + end)/2;
        }

        // uint
        public static uint GetUint(string msg)
        {
            return GetUint(msg, DefaultErrorMessateUint);
        }

        public static uint GetUint(string msg, string err)
        {
            uint result = 0;
            while (true)
            {
                Console.Write(msg);
                if (uint.TryParse(Console.ReadLine(), out result)) break;
                Console.WriteLine(err);
            }
            return result;
        }

        public static uint GetUint(string msg, int attempts)
        {
            return GetUint(msg, DefaultErrorMessateUint, attempts, DefaultValueUint);
        }

        public static uint GetUint(string msg, string err, int attempts, uint def)
        {
            int i = 0;
            uint result;
            do
            {
                i++;
                Console.Write(msg);
                if (uint.TryParse(Console.ReadLine(), out result)) return result;
                Console.WriteLine(err);
                Console.WriteLine($"Attempts left: {attempts - i}");
            }
            while (i < attempts);
            Console.WriteLine("Returning default value");
            return def;
        }

        //string
        public static string GetString(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
    }
}