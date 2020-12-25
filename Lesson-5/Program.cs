
namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFile file = new MyFile();
            AddData addTime = new AddData();
            MyBinFile binFile = new MyBinFile();
            DirectoryTree tree = new DirectoryTree();
            //file.WriteFile();
            //addTime.AppendFile();
            //binFile.BinFile();
            
            tree.MyDir();
        }
    }
}
