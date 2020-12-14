using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 1\n");
            Min_Max_Temp aver_Temp = new Min_Max_Temp();
            aver_Temp.average_Temp();
            double c = aver_Temp.aver_Temp();
            Console.WriteLine("\nСреднесуточная температура: " + c + " градусов цельсия");
            Console.WriteLine(new string('-', 50));
            //
            //-----------------------------------------------------------------------------------
            //
            Console.WriteLine("\nУпражнение 2\n");
            SerialNumberMonth month = new SerialNumberMonth();
            string m = month.Number_of_month();
            Console.WriteLine("\nВы выбрали: " + m);
            Console.WriteLine(new string('-', 50));
            //
            //-----------------------------------------------------------------------------------
            //
            Console.WriteLine("\nУпражнение 3\n");
            Even_number number = new Even_number();
            if (number.even_number() == true) Console.WriteLine("Вы ввели четное число");
            else Console.WriteLine("Вы ввели нечетное число");
            Console.WriteLine(new string('-', 50));
            //
            //-----------------------------------------------------------------------------------
            //
            Console.WriteLine("\nУпражнение 4\n");
            if ((m == "Декабрь" || m == "Январь" || m == "Февраль") && c > 0) Console.WriteLine("Дождливая зима");
            else Console.WriteLine("С зимой все впорядке");

            Console.ReadKey();

        }
    }
}
