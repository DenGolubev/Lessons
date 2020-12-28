using System;

using System.IO;


namespace Lesson_5
{
    
    class SerialBin
    {
        FileMethod fileMethod = new FileMethod();
        
        public void BinFile()
        {
            string mytext = fileMethod.InputFile();
        }
    }
}
