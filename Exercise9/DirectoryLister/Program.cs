using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryLister
{
    class Program
    {
        private static DirectoryInfo _path;
        private static int _depth;
        private static char _dirSep;
        private static char _indent = ' ';

        private static int CountCharInString(string str, char ch)
        {
            int count = 0;
            foreach(char s in str)
            {
                if (s.Equals(ch)) count++;
            }
            return count;
        }

        private static string GetIndent(int count)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < count; i++)
            {
                sb.Append(_indent);
            }
            return sb.ToString();
        }

        private static void SetDir(string input)
        {
            DirectoryInfo di = new DirectoryInfo(input);
            if (di.Exists) { 
                _path = di;
                // TODO: Add also Linux directory separator
                _dirSep = '\\';
                _depth = CountCharInString(di.FullName, _dirSep);
            }
            else throw new ArgumentException("Wrong path");
        }

        private static void ListSubDirs(DirectoryInfo di)
        {
            int level = CountCharInString(di.FullName, _dirSep) - _depth;
            string indent = GetIndent(level);
            Console.WriteLine(indent + di.Name);
            ListFiles(di, indent);
            foreach (DirectoryInfo d in di.GetDirectories())
            {
                ListSubDirs(d);
            }
        }

        private static void ListFiles(DirectoryInfo di, string indent)
        {
            foreach (FileInfo f in di.GetFiles())
            {
                Console.WriteLine(indent + f.Name + "\t" + f.Length + "\t" + f.CreationTime + "\t" + f.Attributes);
            }
        }
        private static void MainLoop(string[] args)
        {
            try
            {
                SetDir(args.Length > 0 ? args[0] : @".");
                Console.WriteLine($"Listing {_path.FullName}");
                ListSubDirs(_path);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            MainLoop(args);
        }
    }
}
