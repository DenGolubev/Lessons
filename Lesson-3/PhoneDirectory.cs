using System;
using System.Collections;

namespace Lesson_3
{
    class PhoneDirectory
    {
        readonly string[,] PhoneBook = new string[5, 2];
        
        public void MyMenu()
        {
            Console.WriteLine("Записная книжка\n");
            Console.WriteLine("Выберите пункт меню и нажмите Enter:\n");
            Console.WriteLine("Добавить контакт - 1\nПосмотреть контакты - 2\nВыйти из приложения - 3\n");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.Clear();
                    AddUser();
                    break;
                case 2:
                    Console.Clear();
                    OutUser();
                    break;
                case 3:
                    Environment.Exit(3);
                    break;
                default:
                    Console.WriteLine("Вы ввели не правильную цифру");
                    MyMenu();
                    break;
            }
        }
        public void AddUser()
        {            
            for (int y = 0; y < PhoneBook.GetLength(0); y++) //строки
            {
                for (int x = 0; x < PhoneBook.GetLength(1); x++) //столбцы
                {
                    Console.Write(" Y: " + y + " X: " + x);
                    if (x == 1)
                    {
                        Console.WriteLine("\nВведите номер телефона:");
                        PhoneBook[y, x] = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("\nВведите имя контакта:");
                        PhoneBook[y, x] = Console.ReadLine();
                    }
                    
                }
                Console.Clear();
                Console.WriteLine();
                MyMenu();
               
            }
            Console.ReadKey();
            OutUser();
        }

        public void OutUser()
        {

            for (int i = 0; i < PhoneBook.GetLength(0); i++)
            {
                for (int y = 0; y < PhoneBook.GetLength(1); y++)
                {
                    Console.Write(PhoneBook[i,y]+"\t");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            MyMenu();

        }
    }
}
