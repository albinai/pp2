﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; //создаем переменную
            n = int.Parse(Console.ReadLine()); //вводим n
            string s = Console.ReadLine();
            string[] arr = s.Split(); //создаем массив и разбиваем строку s на элементы массива
            int cnt = 0; //создаем переменную для подсчета простых чисел
            for (int i = 0; i < n; i++)
            {
                int c = int.Parse(arr[i]); //преобразовываем элемент массива в число
                if (Prime(c) == true) // проверяем число
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt); //выводим сnt

            for (int i = 0; i < n; i++)
            {
                int c = int.Parse(arr[i]);
                if (Prime(c) == true)
                {
                    Console.Write(c + " "); //выводим на экран простые числа через пробел в строке
                }
            }

            Console.ReadKey();

        }

        public static bool Prime(int a) //создаем функцию для проверки числа на prime
        {
            bool ch = true;
            if (a == 1) ch = false;

            for (int i = 2; i < a; i++) //чтоб убедится простое число или нет достаточно проверить не делитсья ли число на числа до него
            {
                if (a % i == 0)
                {
                    ch = false;
                }

            }
            return ch;

        }
    }
}
