using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Pal(string word)
        {
            int cnt = 0; //счетчик одинаковых букв
            bool ch = true;
            for (int i = 0; i < word.Length; i++) {
                if (word[i] == word[word.Length - i - 1]) //если первый символ совпадает с последним и последующие тоже - увеличиваем счетчик
                {
                    cnt++;
                }
             }

            if (word.Length == cnt) ch = true; // если число одинаковых букв совпадаем с их количеством - то слово палиндром
            else ch = false;

            return ch;
        }

        static void Main(string[] args)
        {
            string word = File.ReadAllText(@"C:\Users\albin\Desktop\pp2\week2\word.txt"); //считываем слово из файла
     
            if (Pal(word) == true)
            {
                Console.WriteLine("Yes"); //выводим если слово - палиндром
            }
            else Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}
