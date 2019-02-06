using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
        {
        public string name;
        public string id;
        public int year = 1;

        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public void Print()
        {
            year++;
            Console.WriteLine(name + " " + id + " " + year);
        }

        }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Albina", "18BD110909");
            s.Print();
            Console.ReadKey();
        }
    }
}
