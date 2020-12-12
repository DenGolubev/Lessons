using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Serial_number_month
    {
        private int number_month { get; set; }

        private string Month(int n)
        {
            n = number_month;
            string month_name = null;
            switch (n)
            {
                case 1:
                    month_name = "Январь";
                    break;
                case 2:
                    month_name = "Февраль";
                    break;
                case 3:
                    month_name = "Март";
                    break;
                case 4:
                    month_name = "Апрель";
                    break;
                case 5:
                    month_name = "Май";
                    break;
                case 6:
                    month_name = "Июнь";
                    break;
                case 7:
                    month_name = "Июль";
                    break;
                case 8:
                    month_name = "Август";
                    break;
                case 9:
                    month_name = "Сентябрь";
                    break;
                case 10:
                    month_name = "Октябрь";
                    break;
                case 11:
                    month_name = "Ноябрь";
                    break;
                case 12:
                    month_name = "Декабрь";
                    break;
                default:
                    Console.WriteLine("Вы выбрали не существующий месяц");
                    break;
            }
            return month_name;
        }

        public string Number_of_month()
        {
            Console.WriteLine("Введите порядковый номер месяца от 1 до 12 :");
            number_month = Convert.ToInt32(Console.ReadLine());
            return Month(number_month);
        }
    }
}
