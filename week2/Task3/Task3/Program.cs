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
            FileInfo[] files = directory.GetFiles(); //создаем массив из файлов
            DirectoryInfo[] dirs = directory.GetDirectories(); //создаем массив из директорий

            foreach (FileInfo file in files)
            {
                PrintSpaces(level); //вызываем функцию, которая определяет уровень
                Console.WriteLine(file.Name); //выводим на экран файлы
            }

            foreach (DirectoryInfo dir in dirs) { 
                    PrintSpaces(level); //вызываем функцию
                    Console.WriteLine(dir.Name); //выводим на экран директории
                    Task(dir, level + 1); //рекурсивно повторяем действия и добавляем уровень
                }
            }


            static void Main(string[] args)
            {
                DirectoryInfo dir = new DirectoryInfo("C:/Users/albin/Desktop/PP1"); 
                Task(dir, 1); //вызываем функцию
                Console.ReadKey();
            }
        }
    }

