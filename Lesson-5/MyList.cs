using System;
using System.Collections.Generic;



namespace Lesson_5
{
    class MyList
    {
        
        private bool Status { get; set; } = false;
        private bool check { get; set; } = false;
        private int counter { get; set; } = 0;
        
        string[,] MyArrayList = new string[5, 2];
        TaskList taskList = new TaskList();
        

        public void MyListToDo()
        {
            taskList.PathName();
            Console.Clear();
            Console.WriteLine("Добавить в список дел - 1\nУдалить из списка дел - 2\nПосмотреть список дел - 3\nЗакончить работу с программой - 4\n");
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
                    AddinMyList(check);
                    break;
                case 2:
                    DelfromMyList();
                    break;
                case 3:
                    ArrayList();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Не правильный выбор, попробуйте еще раз");
                    MyListToDo();
                    break;
            }
        }

        private void AddinMyList(bool check)
        {
            Console.Clear();
            Console.WriteLine($"Добавить задачу:\nВсего задач - {(MyArrayList.GetLength(0) + counter) - MyArrayList.GetLength(0)} / {MyArrayList.GetLength(0)}");
            string dosms = Console.ReadLine();
            try
            {
                if (dosms != "")
                {
                    MyArrayList[counter, 0] = dosms;
                    taskList.Serbinfile(MyArrayList[counter, 0]);
                    counter++;
                    Console.WriteLine("Задача добавлена");
                }
                else if (dosms == "")
                {
                    Console.WriteLine("Вы ввели пустою строку");
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели максимальное число задач");
            }
            
            Console.ReadKey();
            MyListToDo();
         }

        


        private void DelfromMyList()
        {
            //string FullPath = taskList.PathName();
            //Console.Clear();
            //Console.WriteLine($"Удалить задачу:\nВыберите номер из списка:");
            //MyArrayList();
            //Tasks.RemoveAt(int.Parse(Console.ReadLine()));
        }

        public void ArrayList()
        {
            Console.Clear();
            Console.WriteLine($"Ваш список дел:\n{taskList.Deserbinfile()}");
            Console.ReadKey();
            MyListToDo();
         }
    }
}
