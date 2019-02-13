using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {

        static void PrintSpaces(int level)
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write(" ");
            }
        }

        static void Task(DirectoryInfo directory, int level)
        {
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] dirs = directory.GetDirectories();

            foreach (FileInfo file in files)
            {
                PrintSpaces(level);
                Console.WriteLine(file.Name);
            }

            foreach (DirectoryInfo dir in dirs) { 
                    PrintSpaces(level);
                    Console.WriteLine(dir.Name);
                    Task(dir, level + 1);
                }
            }


            static void Main(string[] args)
            {
                DirectoryInfo dir = new DirectoryInfo("C:/Users/albin/Desktop/PP1");
                Task(dir, 1);
                Console.ReadKey();
            }
        }
    }

