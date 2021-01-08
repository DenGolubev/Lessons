using System;
using System.Collections.Generic;


namespace ToDo
{
    class MyArrayList
    {
        List<string> ArrayList = new List<string>();
        ConsoleKeyInfo keyInfo;
        public void AddArrayList(string task, bool taskstatus)
        {
            try
            {
                while (task != "" || keyInfo.Key == ConsoleKey.Escape)
                {
                    ArrayList.Add(taskstatus + " " + task);
                    task = "";
                }
                AddArrayList(task, taskstatus);
            }
            catch
            {
                Console.WriteLine("Вы ввели максимальное число записей");
                ReadArrayList();
            }
            
         }

        //public void DelArrayList()
        //{
        //    for (int i = 0; i < ArrayList.Length; i++)
        //    {
        //        ArrayList[i] = null;
        //    }
        //}

        public void ReadArrayList()
        {
            foreach (var item in ArrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
