using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputExample
{
    class Program
    {


        private static string GetFileDetails(FileInfo f)
        {
            string fileName = f.Name.Substring(0, f.Name.IndexOf(f.Extension));
            return $"{fileName}\t{f.Extension}\t{f.Length}\t{f.Attributes}";

            
        }

        private static void ClearDirecotry(DirectoryInfo d)
        {
            int dirNum = 0;
            int fileNum = 0;
            try
            {
                foreach (FileInfo f in d.GetFiles())
                {
                    f.Delete();
                    fileNum++;
                }
                foreach (DirectoryInfo sd in d.GetDirectories())
                {
                    sd.Delete();
                    dirNum++;
                }
            } catch(IOException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine($"Deleted {fileNum} files and {dirNum} directories.");
            }

        }
        static void Main(string[] args)
        {
            // Direcotry Info
            DirectoryInfo di = new DirectoryInfo(@".\");
            // Get full path
            Console.WriteLine(di.FullName);
            // Get attributes (in this case it's only 'Directory'
            Console.WriteLine(di.Attributes);
            Console.WriteLine($"All directories in {di.FullName} - only one level down");
            foreach(DirectoryInfo d in di.GetDirectories())
                Console.WriteLine(d.FullName);
            // List all file in the direcotry
            Console.WriteLine($"\nAll files in {di.Name}");
            foreach (FileInfo f in di.GetFiles())
                Console.WriteLine(f.FullName);

            // FileInfo
            di = new DirectoryInfo(@"C:\TestDir");
            di.Create();
            DirectoryInfo subDir = di;
            try
            {
                subDir = di.CreateSubdirectory("TEST");
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            // Clear directory
            ClearDirecotry(subDir);

            // Create 4 files
            for(int i = 0; i < 4; i++)
            {
                FileInfo f = new FileInfo(subDir.FullName + @"\testFile" + i + ".txt");
                               
                try
                {
                    using (f.Create())
                    {
                        Console.WriteLine("File created: " + f.FullName);
                        if (i % 2 == 0) f.Attributes = FileAttributes.Hidden;
                        else f.Attributes = FileAttributes.Normal;
                    }
                    
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Could not create file" + f.FullName);
                }
                
            }

            // List file attributes
            Console.WriteLine($"All files in {subDir} with attributes: ");
            foreach(FileInfo f in subDir.GetFiles())
            {
                Console.WriteLine(f.FullName);
                Console.WriteLine(f.Name);
                Console.WriteLine(f.Attributes);
            }

            // Rename all 'Normal' files
            string path;
            foreach(FileInfo f in subDir.GetFiles())
            {
                try
                {
                    if (f.Attributes == FileAttributes.Normal)
                    {
                        path = subDir + @"\renamed" + f.Name;
                        Console.WriteLine(path);
                        f.MoveTo(path);
                    }
                        
                } catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }

            // List again all files
            Console.WriteLine($"All files in {subDir} with attributes: ");
            foreach (FileInfo f in subDir.GetFiles())
            {
                Console.WriteLine(GetFileDetails(f));
            }

        }
    }
}
