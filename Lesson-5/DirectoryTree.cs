using System;
using System.IO;


namespace Lesson_5
{
    class DirectoryTree
    {
        private string FileName { get; set; } = "MyTree.txt";
        private string Path { get; set; } = AppContext.BaseDirectory;
        FileMethod fileMethod = new FileMethod();


        public void AllDir()
        {
            string FullPath = fileMethod.GetFullPath(Path, FileName);
            string[] Dir = Directory.GetFileSystemEntries(FullPath, "*", SearchOption.AllDirectories);
            fileMethod.CreateFile(FileName, FullPath);
            foreach (var item in Dir)
            {
                fileMethod.WriteFile(FullPath, item);
            }
            
        }

        public void MyDir()
        {
            DirectoryInfo directory = new DirectoryInfo(Path);
            AllDirR(directory);
        }

        private void AllDirR(DirectoryInfo root)
        {
            FileInfo[] fileInfos = null;
            string FullPath = fileMethod.GetFullPath(Path, FileName);
            if (!File.Exists(FullPath))
            {
                fileMethod.CreateFile(FileName, FullPath);
            }
            try
            {
                fileInfos = root.GetFiles();
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            if (fileInfos != null)
            {
                foreach (FileInfo item in fileInfos)
                {
                    fileMethod.WriteFile(FullPath, Convert.ToString( item));
                    //Console.WriteLine(item);
                }
                DirectoryInfo[] Dir = root.GetDirectories();
                foreach (DirectoryInfo item in Dir)
                {
                    AllDirR(item);
                }
            }
           
        }
       
    }
}
