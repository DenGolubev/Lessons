using System;
using System.Collections.Generic;

namespace Lesson_4
{
    class GetFullName
    {
        Dictionary<int, string> FIO = new Dictionary<int, string>(5);
        private int counter { get; set; } = 0;
        private (string F_Name, string L_Name, string M_Name) userName()
            
        {
            Console.WriteLine();
            Console.WriteLine("Пользователь № {0}", counter+1);
            Console.WriteLine(new string ('-', 50));
            Console.WriteLine();
            Console.WriteLine("Введите фамилию пользователя:");
            string lname = Console.ReadLine();
            Console.WriteLine("Введите имя пользователя:");
            string fname = Console.ReadLine();
            Console.WriteLine("Введите отчество пользователя:");
            string mname = Console.ReadLine();
            return (fname, lname, mname);
        }

        public void PrintUser()
        {
            string f_name;
            string l_name;
            string m_name;
            (f_name, l_name, m_name) = userName();
            FIO.Add(counter, l_name + " " + f_name + " " + m_name);
            counter++;
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Пользователь {0} {1} {2} - {3}", l_name, f_name, m_name, counter);
            Console.WriteLine(new string('-', 50));
            allUser();
            PrintUser();
        }
        public void allUser()
        {
            if (counter == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Список зарегистрированных пользователей:\n");
                foreach (var item in FIO)
                {
                    //Console.WriteLine(new string('-', 50));
                    Console.WriteLine(item.Value);
                    
                }
                Console.ReadKey();
                Environment.Exit(0);
            }
            
        }
    }
 
}
