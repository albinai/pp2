using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {

        public static bool Prime(int c)
        {
            bool ch = true;
            if (c == 1) ch = false;

            for (int i = 2; i < c; i++) 
            {
                if (c % i == 0)
                {
                    ch = false;
                }

            }
            return ch;
        }

        static void Main(string[] args)
        {
            string s = File.ReadAllText(@"C:\Users\albin\Desktop\pp2\week2\nums.txt"); //считываем текст из файла
            string[] nums = s.Split(); //разбиваем строку на элементы массива
            string output = ""; 

            for (int i=0; i<nums.Length-1; i++)
            {
                int c = int.Parse(nums[i]); //преобразуем элемент массива в число
                if (Prime(c) == true)
                {
                    output += c.ToString() + " "; 
                }
                File.WriteAllText(@"C:\Users\albin\Desktop\pp2\week2\output.txt", contents: output); //создаем текстовый файл и выводим простые числа
            }
            Console.ReadKey();
        }
    }
}
