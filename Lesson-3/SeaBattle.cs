using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class SeaBattle
    {
        private string[,] Area = new string[10, 10];
        int count { get; set; }

        public void MyMenu()
        {
            Console.WriteLine("Морской бой\n");
            Console.WriteLine("Выберите пункт меню и нажмите Enter:\n");
            Console.WriteLine("Добавить однопалубные корабли  - 1\nДобавить двупалубные корабли - 2\nДобавить трехпалубные корабли - 3\nДобавить четырехпалубный корабль -4\n");
            int i = int.Parse(Console.ReadLine());
            InputArea();
            switch (i)
            {
                case 1:
                    Console.Clear();
                    SetUp_1();
                    break;
                case 2:
                    Console.Clear();
                    //OutUser();
                    break;
                case 3:
                    //Environment.Exit(3);
                    break;
                default:
                    Console.WriteLine("Вы ввели не правильную цифру");
                    MyMenu();
                    break;
            }
        }
        public void InputArea()
        {
            for (int y = 0; y < Area.GetLength(0); y++)
            {
                for (int x = 0; x < Area.GetLength(1); x++)
                {
                    //Console.Write(" Y: " + y + " X: " + x);
                    Area[y, x] = " .";
                    Console.Write(Area[y, x]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public void SetUp_1()
        {
            Console.Clear();
            Console.WriteLine("Введите координату X:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y:");
            int y1 = int.Parse(Console.ReadLine());
            //Console.Write(" Y: " + y1 + " X: " + x1);

            for (int y = 0; y < Area.GetLength(0); y++)
            {
                for (int x = 0; x < Area.GetLength(1); x++)
                {
                    if (Area[y1, x1] == " .")
                    {
                        Area[y1, x1] = " O";
                        count++;
                    }
                    Console.Write(Area[y, x]);
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Вы установили {0} кораблей\n", count);
            if(count == 4)
            {
                MyMenu();
            }
            Console.ReadKey();
            SetUp_1();
            
            

        }
        
    }
}
