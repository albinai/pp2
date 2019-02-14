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

        public static void F()
        {
            string path = @"C:\Users\albin\Desktop\pp2\week2\Task4\path"; //оригинальная папка
            string Newfile = "NEWF"; //имя файла

            path = Path.Combine(path, Newfile); //объединяем две строки в путь

            File.WriteAllText(path, "comms");

            string path1 = @"C:\Users\albin\Desktop\pp2\week2\Task4\path1"; //вторая папка
            string copyfile = Path.Combine(path1, Newfile); //создаем файл во второй папке

            File.Copy(path, copyfile, true); //копируем файл из оригинального во второй

            Delete(path); //вызываю функцию, чтобы удалить файл

        }

        public static void Delete(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);//если файл существует - удаляем его
            }
        }

        static void Main(string[] args)
        {
            F(); //вызываем функцию
        }
    }
}
