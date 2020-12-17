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
                Console.Write("Имя {0} / Телефон {1}", NameBook[y], NumberBook[y]);
                Console.ReadKey();
                break;
            }     
            
        }

        public void OutUser()
        {

        }
    }
}
