using System;
using System.IO;

namespace Lesson_5
{
    class FileMethod
    {
        FileStream file;
         private string FullPath { get; set; }

        public string GetFullPath(string pathfile, string namefile)
        {
            FullPath = Path.Combine(pathfile, namefile);
            return FullPath;
        }
        public void CreateFile(string namefile, string fullpath)
        {
            if (!File.Exists(fullpath))
            {
                using (file = new FileStream(namefile, FileMode.CreateNew))
                {
                    Console.WriteLine($"Файл {namefile} создан по адресу: {fullpath}");
                }
            }
         }
        public void WriteFile(string fullpath, string inputstring)
        {
            using (file = new FileStream(fullpath, FileMode.Append))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(inputstring + "\r\n");
                file.Write(array, 0, array.Length);
            }
              
         }
        public string ReadFile(string fullpath)
        {
            string textinfile = null;
            using (file = File.OpenRead(fullpath))
            {
                byte[] array = new byte[file.Length];
                file.Read(array, 0, array.Length);
                textinfile = System.Text.Encoding.Default.GetString(array);
            }
            Console.Clear();
            return textinfile;
        }
        public void AddTimeFile(string fullpath)
        {
            DateTime timeDateAccess = File.GetLastAccessTime(fullpath);
            string a = timeDateAccess.ToShortTimeString();
            File.AppendAllText(fullpath, "\r\n" + a + " - ");
            Console.WriteLine();
        }
    }
}
