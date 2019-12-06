using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptainsLog
{

    class Program
    {
        private static string _path = @".\";
        private static FileInfo log;
        private static TextWriter tr;
        private static string _startLog = "startLog";
        private static string _stopLog = "stopLog";

        private static bool _isStarted = false;
        private static bool _exit = false;

        private static void StartLog()
        {
            Console.WriteLine();
            Console.WriteLine("Type 'startLog' to start logging.");
            if (_startLog.Equals(Console.ReadLine()))
            {
                _isStarted = true;
                Console.WriteLine("Logging started! Type 'stopLog to stop");
                DateTime timestamp = DateTime.Now;
                string format = "yyyyMMdd_hhmm";
                log = new FileInfo(_path + timestamp.ToString(format) + ".log");
                tr = log.AppendText();
                tr.WriteLine("Captain's log. Stardate: " + timestamp.ToString(format));
            }
        }

        private static void StopLog() {
            string input = Console.ReadLine();
            if(_stopLog.Equals(input))
            {
                tr.WriteLine("Jean-Luc Pircard");
                Console.WriteLine("Writing log file");
                tr.Close();
                _exit = true;
            } else
            {
                tr.WriteLine(input);
            }
        }

        private static void MainLoop()
        {
            try
            {
                while (!_exit)
                {
                    if (!_isStarted)
                    {
                        StartLog();
                    }
                    else
                    {
                        StopLog();
                    }
                }
            } 
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public static void Main(string[] args)
        {
            MainLoop();
        }
    }
}
