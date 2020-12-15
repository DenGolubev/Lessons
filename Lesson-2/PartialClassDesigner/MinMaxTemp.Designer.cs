using System;

namespace Lesson_2
{
    partial class MinMaxTemp
    {
        private string MinTemp { get; set; }
        private string MaxTemp { get; set; }
        private bool Cheking { get; set; }

        private bool CheckConsoleEnter(string a, string b)
        {
            Cheking = true;
            char[] variable_a = a.ToCharArray();
            char[] variable_b = b.ToCharArray();
            if (a.Length < 1 || b.Length < 1)
            {
                Console.WriteLine("Вы допустили ошибку ввода и просто нажали Enter. Попробуйте еще раз:\n");
                Cheking = false;
            }
            else
            {
                foreach (char i in variable_a)
                {
                    foreach(char y in variable_b)
                    if (char.IsLetter(i) || char.IsLetter(y))
                    {
                        Console.WriteLine("Вы допустили ошибку ввода и ввели букву. Попробуйте еще раз:\n");
                        Cheking = false;
                    }

                }
            }
            return Cheking;
        }

        private double AverTemp(string a, string b)
        {
            return (Convert.ToDouble(a) + Convert.ToDouble(b)) / 2;
        }

    }
}
