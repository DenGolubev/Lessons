using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lesson_5
{
    
    class MyBinFile
    {
        private string PathFile { get; set; } = AppContext.BaseDirectory;
        private string NameFile { get; set; } = "Number.bin";
        FileMethod fileMethod = new FileMethod();
        BinaryFormatter binfile = new BinaryFormatter();
        Number number = new Number(123456789, 987654321);

        public void BinFile()
        {
            string FullPath = fileMethod.GetFullPath(PathFile, NameFile);
            fileMethod.CreateFile(NameFile, FullPath);
            Serbinfile(FullPath);
            Deserbinfile(FullPath);
         }
        public void Serbinfile(string fullpath)
        {
            using (FileStream fileStream = new FileStream(fullpath, FileMode.OpenOrCreate))
            {
                binfile.Serialize(fileStream, number);
            }
                            
        }
        public void Deserbinfile(string fullpath)
        {
            using (FileStream fileStream = new FileStream(fullpath, FileMode.OpenOrCreate))
            {
                Number newNumber = (Number)binfile.Deserialize(fileStream);
                Console.WriteLine($"Первое число равно: {newNumber.MyNumber1} / Второе число равно: {newNumber.MyNumber2}");
            }
            Console.ReadKey();
        }

        [Serializable]
        class Number
        {
            public int MyNumber1 { get; set; }
            public int MyNumber2 { get; set; }

            public Number(int num1, int num2)
            {
                MyNumber1 = num1;
                MyNumber2 = num2;
            }
        }

    }
}
