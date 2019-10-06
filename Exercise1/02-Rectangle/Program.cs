using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 10;
            float b = 12.128174798627384568716587162354876132765784362567826478526356862785632123f;

            float area = a * b;
            Console.WriteLine("Area of the rectangle= " + area);
            Console.WriteLine("Area of the rectangle= {0}", area);
            Console.WriteLine("Area of the rectangle= {0:c}", area);
            Console.WriteLine("Area of the rectangle= {0:e}", area);
            Console.WriteLine("Area of the rectangle= {0:f}", area);
            Console.WriteLine("Area of the rectangle= {0:g}", area);
            Console.WriteLine("Area of the rectangle= {0:n}", area);
            Console.WriteLine("Area of the rectangle= {0:n20}", area);
            Console.WriteLine("Area of the rectangle= {0:0.000000}", area);

        }
    }
}
