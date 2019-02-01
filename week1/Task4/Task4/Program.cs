using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //вводим переменную - количество строк

            for (int i=0; i<n; i++) //настраиваем количество строк
            {
                for (int j=0; j<i+1; j++) //количество столбцов
                {
                    Console.Write("[*]" + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
