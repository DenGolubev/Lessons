using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 1\n");
            MinMaxTemp aver_Temp = new MinMaxTemp();
            aver_Temp.EnterTemp();
            aver_Temp.AveregeTemp();
            Console.WriteLine(new string('-', 50));
            //
            //-----------------------------------------------------------------------------------
            //
            Console.WriteLine("\nУпражнение 2\n");
            SerialNumberMonth month = new SerialNumberMonth();
            string m = month.NumberOfMonth();
            Console.WriteLine("\nВы выбрали: " + m);
            Console.WriteLine(new string('-', 50));
            ////
            ////-----------------------------------------------------------------------------------
            ////
            //Console.WriteLine("\nУпражнение 3\n");
            //Even_number number = new Even_number();
            //if (number.even_number() == true) Console.WriteLine("Вы ввели четное число");
            //else Console.WriteLine("Вы ввели нечетное число");
            //Console.WriteLine(new string('-', 50));
            ////
            ////-----------------------------------------------------------------------------------
            ////
            //Console.WriteLine("\nУпражнение 4\n");
            //if ((m == "Декабрь" || m == "Январь" || m == "Февраль") && c > 0) Console.WriteLine("Дождливая зима");
            //else Console.WriteLine("С зимой все впорядке");

            Console.ReadKey();

        }
    }
}
