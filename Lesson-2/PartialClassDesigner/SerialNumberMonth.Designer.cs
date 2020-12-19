using System.Collections.Generic;

namespace Lesson_2
{
    partial class SerialNumberMonth
    {
        private int NumberMonth { get; set; }
        private Dictionary<int, string> MonthDictionary = new Dictionary<int, string>(12);
        
        private string SearchMonth(int i)
        {
            string MonthName = null;
            MonthDictionary.Add(1,"Январь");
            MonthDictionary.Add(2, "Февраль");
            MonthDictionary.Add(3, "Март");
            MonthDictionary.Add(4, "Апрель");
            MonthDictionary.Add(5, "Май");
            MonthDictionary.Add(6, "Июнь");
            MonthDictionary.Add(7, "Июль");
            MonthDictionary.Add(8, "Август");
            MonthDictionary.Add(9, "Сентябрь");
            MonthDictionary.Add(10, "Октябрь");
            MonthDictionary.Add(11, "Ноябрь");
            MonthDictionary.Add(12, "Декабрь");
            MonthName = MonthDictionary[i];
            return MonthName;
        }
        

    }
}
