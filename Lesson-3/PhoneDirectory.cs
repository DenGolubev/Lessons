using System;
using System.Collections;

namespace Lesson_3
{
    class PhoneDirectory
    {
        string[,] PhoneBook = new string[5, 2];
        string[] NameBook = new string[5];
        string[] NumberBook = new string[5];
        public void AddUser()
        {
            Console.WriteLine("Введите имя контакта:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите номер телефона:");
            string phone = Console.ReadLine();
            for (int y   = 0; y < PhoneBook.GetLength(0); y++)
            {
                NameBook[y] = name;
                NumberBook[y] = phone;
            }
            OutUser();
        }

        public void OutUser()
        {
            foreach (var name in NameBook)
            {
                foreach (var number in NumberBook)
                {
                    Console.Write("Имя {0} / Телефон {1}", name, number);
                    Console.ReadKey();
                }
            }
            
        }
    }
}
