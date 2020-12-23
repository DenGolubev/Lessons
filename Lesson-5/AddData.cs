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
            
            string FullPath = fileMethod.GetFullPath(PathFile, NameFile);
            fileMethod.CreateFile(FullPath);
            fileMethod.AddTimeFile(FullPath);
            string mytext = fileMethod.InputFile();
            fileMethod.AddinFile(FullPath, " - " + mytext + Environment.NewLine) ;

        }
    }
}
