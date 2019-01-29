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
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] arr = s.Split();
            for (int i = 0; i < n; i++)
            {
               Console.Write(arr[i] + " " + arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
