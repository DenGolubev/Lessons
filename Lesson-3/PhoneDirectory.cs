using System;
using System.Collections;

namespace Lesson_3
{
    class PhoneDirectory
    {
        string[,] PhoneBook = new string[5, 2];
        string[] NameBook = new string[5];
        string[] NumberBook = new string[5];

        public void MyMenu()
        {
            Console.WriteLine("Выберите пункт меню:");
            Console.WriteLine("Добавить контакт - 1\nПосмотреть контакты - 2\nВыйти из приложения - 3");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    AddUser();
                    break;
                case 2:
                    OutUser();
                    break;
                case 3:
                    Environment.Exit(3);
                    break;
                default:
                    Console.WriteLine("Вы ввели не правильную цифру");
                    break;
            }
        }
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
