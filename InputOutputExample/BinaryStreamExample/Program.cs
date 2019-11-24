using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryStreamExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo outputFile = new FileInfo(@"C:\testDir\textFile.dat");


            // Write a binary file
            string hello = "Hello World";
            char[] chars = hello.ToCharArray();
            try 
            {
                using (BinaryWriter bw = new BinaryWriter(outputFile.Open(FileMode.OpenOrCreate, FileAccess.Write), Encoding.UTF8))
                {
                    foreach(char ch in chars)
                    {
                        bw.Write(ch);
                    }
                    
                }
             } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            // Read binary file and display the content in console
            byte temp;
            try
            {
                using (BinaryReader br = new BinaryReader(outputFile.Open(FileMode.Open, FileAccess.Read)))
                {
                    while ((temp = br.ReadByte()) != null)
                    {
                        Console.WriteLine(temp);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
