using System;
using System.IO;

namespace Lesson_5
{
    class FileMethod
    {
        private string FullPath { get; set; }
                
        /// <summary>
        /// Метод полного пути к файлу
        /// </summary>
        /// <param name="pathfile"></param>
        /// <param name="namefile"></param>
        /// <returns></returns>
        public string GetFullPath(string pathfile, string namefile)
        {
            FullPath = Path.Combine(pathfile, namefile);
            return FullPath;
        }
        /// <summary>
        /// Метод создания файла
        /// </summary>
        /// <param name="fullpath"></param>
        public void CreateFile(string fullpath)
        {
            if (!File.Exists(fullpath))
            {
                File.Create(fullpath).Close();
            }
            else Console.WriteLine("Файл уже создан");
        }

        /// <summary>
        /// Метод получения строки и присвоение к переменной
        /// </summary>
        /// <returns></returns>
        public string InputFile()
        {
            Console.WriteLine("Введите строку для записи в файл:");
            string InFile = Console.ReadLine();
            return InFile;
        }

        /// <summary>
        /// Метод записи в файл, каждый раз новый файл и новая запись
        /// </summary>
        /// <param name="fullpath"></param>
        /// <param name="inputdata"></param>
        public void RecFile(string fullpath, string inputdata)
        {
            File.WriteAllText(fullpath, inputdata);
        }

        /// <summary>
        /// Метод добавления записи в файл без перезаписи
        /// </summary>
        /// <param name="fullpath"></param>
        /// <param name="inputdata"></param>
        public void AddinFile(string fullpath, string inputdata)
        {
            File.AppendAllText(fullpath, inputdata);
            Console.WriteLine();
        }

        public void AddTimeFile(string fullpath)
        {
            DateTime timeDateAccess = File.GetLastAccessTime(fullpath);
            string a = timeDateAccess.ToShortTimeString();
            File.AppendAllText(fullpath, a + Environment.NewLine);
            Console.WriteLine();
        }
    }
}
