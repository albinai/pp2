using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {

        public static void Delete(string from)
        {
            if (File.Exists(from))
            {
                File.Delete(from);//если файл существует - удаляем его
            }
        }

        static void Main(string[] args)
        {
            string path = @"C:\Users\albin\Desktop\pp2\week2\Task4\path"; //оригинальная папка
            string Newfile = "NEWF"; //имя файла

            string from = Path.Combine(path, Newfile); //объединяем две строки в путь к файлу

            FileStream fs = File.Create(from); //создаем файл в потоке 
            fs.Close();

            string path1 = @"C:\Users\albin\Desktop\pp2\week2\Task4\path1"; //вторая папка
            string to = Path.Combine(path1, Newfile); //создаем путь во второй папке

            if (File.Exists(to)) //если файл уже существует - удаляем его т.к. программа не может копировать в существующий файл
            {
                Delete(to);
            }

            File.Copy(from, to); //копируем файл из оригинального во второй

            Delete(from); //вызываю функцию, чтобы удалить файл

        }
    }
}
