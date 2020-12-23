using System;
using System.IO;    

namespace Lesson_5
{
    class MyFile
    {
        private string FullPath { get; set; }

        private void CreateFile()
        {
            string PathFile = @"C:\Users\Denis\OneDrive\Desktop\";
            string NameFile = "Test.txt";
            FullPath = Path.Combine(PathFile, NameFile);
            FileStream file = new FileStream(FullPath, (FileMode)FileAccess.ReadWrite);
            if (!File.Exists(Path.Combine(PathFile, NameFile)))
            {
                file = File.Create(FullPath);
                file.Close();
            }
            else Console.WriteLine("Файл {0} уже создан");
        }
                public void InputLineFile()
        {
            CreateFile();
            Console.WriteLine("Введите строку для записи в файл:");
            string InFile = Console.ReadLine();
            RecFile(FullPath, InFile);
         }

        private void RecFile(string fullpath, string inputdata)
        {
            File.WriteAllText(fullpath, inputdata);
        }

    }
}
