using System;

namespace Lesson_5
{
    class AddData
    {
        private string PathFile { get; set; } = AppContext.BaseDirectory;
        private string NameFile { get; set; } = "startup.txt";
        FileMethod fileMethod = new FileMethod();
        public void AppendFile()
        {
            Console.WriteLine("Введите текст:");
            string mytext = Console.ReadLine();
            string FullPath = fileMethod.GetFullPath(PathFile, NameFile);
            fileMethod.CreateFile(NameFile, FullPath);
            fileMethod.AddTimeFile(FullPath);
            fileMethod.WriteFile(FullPath, mytext) ;

        }
    }
}
