using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekdaysEnumExample
{
    enum Weekdays
    {
        MON = 1,
        TUE,
        WED,
        THU = 111,
        FRI,
        SAT,
        SUN = 0
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);

            // iterate through all names in Weekdays enum
            foreach (string weekday in Enum.GetNames(typeof(Weekdays)))
            {
                Console.WriteLine($"weekday= {weekday} int= {(int)Enum.Parse(typeof(Weekdays), weekday)}");

            }

            // itereate through all values in Weekdays enum
            foreach (int value in Enum.GetValues(typeof(Weekdays)))
            {
                Console.WriteLine($"weekeday= {Enum.GetName(typeof(Weekdays), value)} int= {value}");
            }
        }
    }
}
