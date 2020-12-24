
namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFile file = new MyFile();
            AddData addTime = new AddData();
            MyBinFile binFile = new MyBinFile();
            //file.WriteFile();
            //addTime.AppendFile();
            binFile.BinFile();
        }
    }
}
