using System;

namespace ToDo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите задачу:");
            string title = Console.ReadLine();
            bool status = false;
            ToDo list = new ToDo(title, status);
            list.EnterTask();
           
        }
    }
}
