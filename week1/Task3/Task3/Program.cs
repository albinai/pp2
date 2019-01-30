using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //вводим число n - количество элементов в массиве
            string s = Console.ReadLine(); // вводим строку s
            string[] arr = s.Split(); //разделяем строку на элементы массива
            for (int i = 0; i < n; i++)
            {
               Console.Write(arr[i] + " " + arr[i] + " "); //выводим каждый элемент дважды
            }
            Console.ReadKey(); // консоль выключится после нажатия любой кнопки
        }
    }
}
