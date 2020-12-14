using System;


namespace Lesson_2
{
    class Min_Max_Temp
    {
        private double min_Temp { get; set; }
        private double max_Temp { get; set; }
        public double aver_Temp()
        {
            return (min_Temp + max_Temp) / 2;
        }

        public void average_Temp()
        {
            Console.WriteLine("Введите минимальную суточную температуру :");
            string Temp1 = Console.ReadLine();
            foreach(char a in Temp1)
            {
                if(char.IsLetter(a))
                {
                    Console.WriteLine("Вы ввели буквы вместо цифр при вводе минимальной температуры, попробуйте еще раз\n");
                    Temp1 = Console.ReadLine();
                }
            }
            while (string.IsNullOrEmpty(Temp1))
            {
                Console.WriteLine("Вы ошиблись при вводе минимальной температуры, попробуйте еще раз\n");
                Temp1 = Console.ReadLine();
                
            }
            min_Temp = Convert.ToDouble(Temp1);

            Console.WriteLine("Введите максимальную суточную температуру:");
            string Temp2 = Console.ReadLine();
            foreach (char a in Temp2)
            {
                if (char.IsLetter(a))
                {
                    Console.WriteLine("Вы ввели буквы вместо цифр при вводе максимальной температуры, попробуйте еще раз\n");
                    Temp2 = Console.ReadLine();
                }
            }
            while (string.IsNullOrEmpty(Temp2))
            {
                Console.WriteLine("Вы ошиблись при вводе максимальной температуры, попробуйте еще раз\n");
                Temp2 = Console.ReadLine();
                
            }
            max_Temp = Convert.ToDouble(Temp2);

            
        }
    }
}
