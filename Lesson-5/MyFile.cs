﻿using System;
using System.IO;

namespace Lesson_5
{
    class MyFile
    {
        private string PathFile { get; set; } = AppContext.BaseDirectory;
        private string NameFile { get; set; } = "Test.txt";
        FileMethod fileMethod = new FileMethod();
        public void WriteFile()
        {
            string FullPath = fileMethod.GetFullPath(PathFile, NameFile);
            fileMethod.CreateFile(FullPath);
            string mytext = fileMethod.InputFile();
            fileMethod.RecFile(FullPath, mytext);
             
        }

    }
}




 