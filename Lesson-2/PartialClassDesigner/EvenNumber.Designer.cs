using System;


namespace Lesson_2
{
    partial class EvenNumber
    {
        private string Number { get; set; }
        private bool Cheking { get; set; }
        public bool CheckConsoleEnter(string a)
        {
            Cheking = true;
            char[] variable = a.ToCharArray();
            if (a.Length < 1)
            {
                Console.WriteLine("Вы допустили ошибку ввода, попробуйте еще раз:\n");
                Cheking = false;
            }
            else
            {
                foreach (char c in variable)
                {
                    if (c == 48 || char.IsLetter(c)) //Ноль в UniCode = 48
                    {
                        Console.WriteLine("Вы ввели НОЛЬ или букву, попробуйте еще раз:\n");
                        Cheking = false;
                    }
                }
            }
            
            return Cheking;
        }


        public bool EnterNumberCheck(string a)
        {
            if(Cheking == true)
            {
                int y = Convert.ToInt32(a);
                if (y % 2 == 0)
                {
                    Cheking = true;
                    Console.WriteLine("Четное число");
                }
                else
                {
                    Cheking = false;
                    Console.WriteLine("Нечетное число");
                }
            }
            return Cheking;
        }
    }
}
