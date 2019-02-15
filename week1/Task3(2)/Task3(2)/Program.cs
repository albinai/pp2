using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //количество элементов в массиве

            string s = Console.ReadLine();

            string[] arr = s.Split(); //массив из строк

            int[] m = new int[n]; //новый массив

            for (int i = 0; i < n; i++)
            {
                m[i] = int.Parse(arr[i]); //заполняем массив

            }

            Doubl(m, n); //вызываем функцию

        }

        public static void Doubl(int[] m, int n)
        {
            List<int> list = new List<int>(); //заводим список

            for (int i = 0; i < n; i++)
            {

                list.Add(m[i]); //добавляем элемент массива в список дважды
                list.Add(m[i]);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " "); //выводим на экран
            }

            Console.ReadKey();

        }
    }
}
