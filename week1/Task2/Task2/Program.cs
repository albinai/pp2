using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student //создаем новый класс
        {
        public string name;
        public string id;
        public int year = 1;

        public Student(string name, string id) //присваиваем значения 
        {
            this.name = name;
            this.id = id;
        }

        public void Print() //выводим на экран
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
