using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace Lesson_5
{
    class MyList
    {
        FileMethod fileMethod = new FileMethod();
        TaskList taskList = new TaskList();
        private bool Status { get; set; } = false;
        private bool check { get; set; } = false;
        private int counter { get; set; } = 0;
        private string FullPath { get; set; } = null;
        private string DoSMS { get; set; } = null;
        string[,] MyArrayList = new string[5, 2];
        
        public void MyListToDo()
        {
            Console.Clear();
            Console.WriteLine("Добавить в список дел - 1\nУдалить из списка дел - 2\nПосмотреть список дел - 3\nОчистить файл данных - 4\nЗакончить работу с программой - 5\n");
            Console.WriteLine("\nВыберите задачу:");
            int i = 0;
            try
            {
                i = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Выберите правильный пункт меню");
                Console.ReadKey();
            }
            switch (i)
            {
                case 1:
                    AddinMyList();
                    break;
                case 2:
                    DelfromMyList();
                    break;
                case 3:
                    ArrayList();
                    break;
                case 4:
                    DelfromMyList();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Не правильный выбор, попробуйте еще раз");
                    MyListToDo();
                    break;
            }
        }

        private void AddinMyList()
        {
            Console.Clear();
            FullPath = fileMethod.GetFullPath(AppContext.BaseDirectory, "TaskList.bin");
            Console.WriteLine($"Добавить задачу:\nВсего задач - {(MyArrayList.GetLength(0) + counter) - MyArrayList.GetLength(0)} / {MyArrayList.GetLength(0)}");
            DoSMS = Console.ReadLine();
            ConsoleKeyInfo inputKey = Console.ReadKey(true);
            try
            {
                while (inputKey.Key != ConsoleKey.Escape)
                {
                    MyArrayList[counter, 0] = DoSMS;
                    taskList.Serbinfile(MyArrayList, FullPath);
                    counter++;
                    AddinMyList();
                }
            }
            catch
            {
                Console.WriteLine($"Вы ввели  {(MyArrayList.GetLength(0) + counter) - MyArrayList.GetLength(0)} / {MyArrayList.GetLength(0)} задач");
                Console.ReadKey();
            }
            MyListToDo();
        }
        

        


        private void DelfromMyList()
        {
            FullPath = fileMethod.GetFullPath(AppContext.BaseDirectory, "TaskList.bin");
            taskList.ClearMyTaskList(FullPath);
            Console.ReadKey();
            MyListToDo();
        }

        public void ArrayList()
        {
            FullPath = fileMethod.GetFullPath(AppContext.BaseDirectory, "TaskList.bin");
            Console.Clear();
            Console.WriteLine(taskList.Deserbinfile(FullPath));
            Console.ReadKey();
            MyListToDo();
         }
    }
}
