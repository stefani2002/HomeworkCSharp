using System;

namespace HomeworkExercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region Exercise6

            Console.WriteLine("Insert two numbers: ");
            int numberOne;
            int numberTwo;
            bool ifCorrect = int.TryParse(Console.ReadLine(), out numberOne);
            bool ifCorrectTwo = int.TryParse(Console.ReadLine(), out numberTwo);

            if(ifCorrect && ifCorrectTwo)
            {

                if( numberOne>numberTwo)
                {
                    Console.WriteLine(numberOne + " is larger!");
                }
                else if (numberOne<numberTwo)
                {
                    Console.WriteLine(numberTwo + " is larger!");
                }
                else
                {
                    Console.WriteLine("They are even!");
                }


                if (numberOne % 2 == 0)
                {
                    Console.WriteLine(numberOne+" is even!");
                }
                else
                {
                    Console.WriteLine(numberOne+" is odd!");
                }

                if (numberTwo % 2 == 0)
                {
                    Console.WriteLine(numberTwo+" is even!");
                }
                else
                {
                    Console.WriteLine( numberTwo+" is odd!");
                }

            }
            else
            {
                Console.WriteLine("Wrong Input!");
            }

            #endregion

            Console.ReadLine();
        }
    }
}
