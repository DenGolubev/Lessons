
namespace Lesson_5
{
    class AllExercises
    {
        
        public void MyMenu(int selex)
        {
            switch (selex) 
            {
                case 1:
                    MyFile file = new MyFile();
                    file.WriteFile();
                    break;
                case 2:
                    AddData addTime = new AddData();
                    addTime.AppendFile();
                    break;
                case 3:
                    MyBinFile binFile = new MyBinFile();
                    binFile.BinFile();
                    break;
                case 4:
                    DirectoryTree tree = new DirectoryTree();
                    tree.MyDir();
                    break;
                case 5:
                    ToDo mylist = new ToDo();
                    mylist.ToDoMyList();
                    break;
            }


        }
        

        


    }
}
