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
            int n = int.Parse(Console.ReadLine());

            string s = Console.ReadLine();

            string[] arr = s.Split();

            int[] m = new int[n];

            for (int i = 0; i < n; i++)
            {
                m[i] = int.Parse(arr[i]);

            }

            Doubl(m, n);

        }

        public static void Doubl(int[] m, int n)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {

                list.Add(m[i]);
                list.Add(m[i]);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.ReadKey();

        }
    }
}
