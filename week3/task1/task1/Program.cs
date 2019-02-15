using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Manager
    {
        public int index;
        public string path;
        public int s;
        DirectoryInfo dir;
        FileSystemInfo cur;
        bool close;

        public Manager()
        {
            index = 0;
        }

        public Manager(string path)
        {
            this.path = path;
            index = 0;
            dir = new DirectoryInfo(path);
            s = dir.GetFileSystemInfos().Length;
            close = true;
        }

        public void Color(FileSystemInfo infos, int index2)  //метод для цветов консоли, текста, и курсора
        {
            if (index == index2)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                cur = infos;
            }
            else if (infos.GetType() == typeof(DirectoryInfo)) //если это папка - желтый
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void Interface() 
        {
            Console.BackgroundColor = ConsoleColor.Black;
            string str = "Go back : Backspace // Delete: Del // Rename: F2 // Enter: Enter"; //подсказки для удобства
            foreach (char c in str) 
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine();
            Console.WriteLine(str);
            
            Console.Clear();
            dir = new DirectoryInfo(path);
            FileSystemInfo[] infos = dir.GetFileSystemInfos();
            for (int i = 0, k = 0; i < infos.Length; i++)
            {
                if (close == false && infos[0].Name == ".")
                {
                    continue;
                }
                Color(infos[i], k);
                Console.WriteLine(infos[i].Name);
                k++;
            }
           
        }

        public void C()
        {
            dir = new DirectoryInfo(path);
            FileSystemInfo[] infos = dir.GetFileSystemInfos();
            s = infos.Length;
            if (close == false)
                for (int i = 0; i < infos.Length; i++)
                    if (infos[i].Name[0] == '.')
                        s--;

        }

      
       

        public void Start()
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            while (consoleKey.Key != ConsoleKey.Escape)
            {
                C();
                Interface();
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow)
                                        {
                                            index--;
                                            if (index < 0)
                                            {
                                                index = --s;
                                            }
                                        }
                if (consoleKey.Key == ConsoleKey.DownArrow)
                                    {
                                        index++;
                                        if (index == s)
                                        {
                                            index = 0;
                                        }
                                    }
                if (consoleKey.Key == ConsoleKey.Enter)
                {
                                    if (cur.GetType() == typeof(DirectoryInfo))
                                    {
                                        index = 0;
                                        path = cur.FullName;
                                    }
                                    else
                                    {
                                        StreamReader sr = new StreamReader(cur.FullName);
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Clear();
                                        Console.WriteLine(sr.ReadToEnd());
                                        Console.ReadKey();
                                    }
                }
                if (consoleKey.Key == ConsoleKey.Backspace)
                                    {
                                        if (dir.Parent.FullName != @"С:\")
                                        {
                                            index = 0;
                                            path = dir.Parent.FullName;
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                        }
                                    }
                if (consoleKey.Key == ConsoleKey.Delete)
                                    {
                                        if (cur.GetType() == typeof(DirectoryInfo))
                                        {
                                            index = 0;
                                            Directory.Delete(cur.FullName);
                                        }
                                        else
                                        {
                                            index = 0;
                                            File.Delete(cur.FullName);
                                        }
                                    }
                if (consoleKey.Key == ConsoleKey.F2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter new name:");
                                    string newname = Console.ReadLine();
                                    Console.Clear();
                                    string newpath = Path.Combine(dir.FullName, newname);
                                    if (cur.GetType() == typeof(DirectoryInfo))
                                    {
                                        Directory.Move(cur.FullName, newpath);
                                    }
                                    else
                                    {
                                        File.Move(cur.FullName, newpath);
                                    }
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\albin\Desktop\pp2\week3\tests";
            Manager farManager = new Manager(path);
            farManager.Start();
        }
    }
}
