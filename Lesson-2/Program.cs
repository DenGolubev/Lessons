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
            Console.WriteLine(new string('-', 50));
            //////
            //////-----------------------------------------------------------------------------------
            //////
            Console.WriteLine("\nУпражнение 2\n");
            SerialNumberMonth month = new SerialNumberMonth();
            string m = month.NumberOfMonth();
            Console.WriteLine("\nВы выбрали: " + m);
            Console.WriteLine(new string('-', 50));
            //////
            //////-----------------------------------------------------------------------------------
            //////
            Console.WriteLine("\nУпражнение 3\n");
            EvenNumber CheckNumber = new EvenNumber();
            CheckNumber.EnterNumber();
            Console.WriteLine(new string('-', 50));
            ////
            ////-----------------------------------------------------------------------------------
            ////
            Console.WriteLine("\nУпражнение 4\n");
            if ((m == "Декабрь" || m == "Январь" || m == "Февраль") && aver_Temp.AveregeTemp() > 0) Console.WriteLine("Дождливая зима");
            else Console.WriteLine("С зимой все впорядке");

            Console.ReadKey();

        }
    }
}
