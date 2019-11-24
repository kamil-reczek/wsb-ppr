using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace TextStreamExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get text data from file and display it on the console
            FileInfo inputFile = new FileInfo(@"C:\TestDir\textFile.txt");
            string temp;
            try
            {
                using (TextReader tr = inputFile.OpenText())
                {
                    while ((temp = tr.ReadLine()) != null)
                    {
                        Console.WriteLine(temp);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Create new file and append data (current time in unit timestamp)
            FileInfo outputFile = new FileInfo(@"C:\TestDir\output.txt");
            try
            {
                using (TextWriter tw = outputFile.CreateText())
                {
                    for (int i = 0; i < 10; i++)
                    {
                        tw.WriteLine(DateTimeOffset.Now.ToUnixTimeMilliseconds());
                        Thread.Sleep(500);
                    }
                }
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Append new data to existing file
            try
            {
                using(TextWriter tw = outputFile.AppendText())
                {
                    tw.WriteLine();
                    tw.WriteLine("Author: Krzysztof Jarzyna ze Szczecina");
                }
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
                
        }
    }
}
