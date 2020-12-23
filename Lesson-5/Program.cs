
namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFile file = new MyFile();
            AddData addTime = new AddData();
            //file.WriteFile();
            addTime.AppendFile();
        }
    }
}
