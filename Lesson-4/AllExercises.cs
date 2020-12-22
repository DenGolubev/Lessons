
namespace Lesson_4
{
    class AllExercises
    {
        
        public void MyMenu(int selex)
        {
            switch (selex) 
            {
                case 1:
                    GetFullName fullName = new GetFullName();
                    fullName.PrintUser();
                    break;
                case 2:
                    StringNumber stringNumber = new StringNumber();
                    stringNumber.InputNumber();
                    break;
                case 3:
                    Seasons seasons = new Seasons();
                    seasons.InputNumber();
                    break;
                case 4:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.EnterNumber();
                    break;
            }


        }
        

        


    }
}
