using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            int a = int.Parse(s1);
            int b = int.Parse(s2);
            Console.WriteLine(a + b);
            Console.ReadKey();
        }
    }
}
