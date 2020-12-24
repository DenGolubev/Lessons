using System;

namespace Lesson_5
{
    class MyFile
    {
        private string PathFile { get; set; } = AppContext.BaseDirectory;
        private string NameFile { get; set; } = "Test.txt";
        FileMethod fileMethod = new FileMethod();
        public void WriteFile()
        {
            Console.WriteLine("Введите текст:");
            string mytext = Console.ReadLine();
            string FullPath = fileMethod.GetFullPath(PathFile, NameFile);
            fileMethod.CreateFile(NameFile, FullPath);
            fileMethod.WriteFile(FullPath, mytext);
            Console.WriteLine(fileMethod.ReadFile(FullPath));
            Console.ReadKey();
         }

    }
}




 