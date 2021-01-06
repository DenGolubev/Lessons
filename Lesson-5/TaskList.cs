using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lesson_5
{
    class TaskList
    {
        FileMethod fileMethod = new FileMethod();
        BinaryFormatter binfile = new BinaryFormatter();
        private string PathFile { get; set; } = AppContext.BaseDirectory;
        private string NameFile { get; set; } = "TaskList.bin";
        private string FullPath { get; set; }
        public string PathName()
        {
            FullPath = fileMethod.GetFullPath(PathFile, NameFile);
            return FullPath;
        }

        public bool CreateFile(string fullpath)
        {
            bool check = false;
            if (!File.Exists(FullPath)) fileMethod.CreateFile(NameFile, FullPath);
            else check = true;
            return check;
            
         }

        public string LoadMyList(string fullpath)
        {
            string newList = null;
            try
            {
                if (CreateFile(fullpath))
                {
                    using (FileStream fileStream = File.Open(fullpath, FileMode.Open))
                    {
                        newList = (string)binfile.Deserialize(fileStream);
                        fileStream.Close();
                        fileStream.Dispose();
                    }
                        
                    
                }
            }
            catch
            {
                Console.WriteLine("Пустой файл данных");
                Console.ReadKey();
            }
           
            return newList;
        }

        public void Serbinfile(string mysms)
        {
            PathName();
            using (FileStream fileStream = File.Open(FullPath, FileMode.Append))
            {
                binfile.Serialize(fileStream, mysms);
                fileStream.Close();
                fileStream.Dispose();
            }
                
            
        }
        public string Deserbinfile()
        {
            using (FileStream fileStream = File.Open(FullPath, FileMode.Open))
            {
                string newList = (string)binfile.Deserialize(fileStream);
                fileStream.Close();
                fileStream.Dispose();
                return newList;
            }
                
            
         }
    }
}
