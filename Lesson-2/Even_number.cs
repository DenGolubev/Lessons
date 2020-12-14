using System;

namespace Lesson_2
{
    class Even_number
    {
        private int Number { get; set; }
        public bool Even_parity { get; private set; }

        public bool even_number()
        {
            Console.WriteLine("Введите любое число:\n");
            Number = Convert.ToInt32(Console.ReadLine());
            if (Number == 0) 
            {
                Console.WriteLine("Вы ввели ноль\n");
                even_number();
            } 
            else if (Number % 2 == 0) Even_parity = true;
            return Even_parity;
        }


    }
}
