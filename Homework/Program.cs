using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            #region Task1
            int numberOne;
            int numberTwo;
            double result;

            Console.WriteLine("Insert two numbers: ");
           
            bool ifCorrect = int.TryParse(Console.ReadLine(), out numberOne);
            bool ifCorrectTwo = int.TryParse(Console.ReadLine(), out numberTwo);

            Console.WriteLine("Insert operator: ");
            string operator1 = Console.ReadLine();

            if (ifCorrect && ifCorrectTwo)
            {
                if(operator1 == "+")
                {
                    Console.WriteLine("The result is "+ numberOne + numberTwo);
                }
                else if (operator1 == "-")
                {
                    Console.WriteLine("The result is " + (numberOne - numberTwo));
                }
                else if (operator1 == "*")
                {
                    Console.WriteLine("The result is " + numberOne * numberTwo);
                }
                else if(operator1 == "/")
                {
                    result = (float)numberOne / numberTwo;
                    Console.WriteLine("The result is " + result);
                }
            }

            else
            {
                Console.WriteLine("Invalid input!");
            }
            #endregion
            Console.WriteLine("=======================");


            Console.WriteLine("Task 2:");
            #region Task2

            Console.WriteLine("Insert 4 numbers: ");

            int a;
            int b;
            int c;
            int d;

            bool ifCorrectThree = int.TryParse(Console.ReadLine(), out a);
            bool ifCorrectFour = int.TryParse(Console.ReadLine(), out b);
            bool ifCorrectFive = int.TryParse(Console.ReadLine(), out c);
            bool ifCorrectSix = int.TryParse(Console.ReadLine(), out d);

            if (ifCorrectThree && ifCorrectFour && ifCorrectFive && ifCorrectSix)
            {
                double average = (a+b+c+d) / 4;
                Console.WriteLine("The average of " + a + "," + b + "," + c + "," + d + " is " + average);
            }

            else
            {
                Console.WriteLine("Incorrect input!");
            }

            #endregion


            Console.WriteLine("=======================");
            Console.WriteLine("Task 3:");
            #region Task3
            int e;
            int f;

            Console.WriteLine("Input first number:");
            bool ifCorrectSeven = int.TryParse(Console.ReadLine(), out e);

            Console.WriteLine("Input second number:");
            bool ifCorrectEight = int.TryParse(Console.ReadLine(), out f);

            if (ifCorrectSeven && ifCorrectEight)
            {
                int temp;
                temp = e;
                e = f;
                f = temp;

                Console.WriteLine("After swapping:");
                Console.WriteLine("First number: " + e);
                Console.WriteLine("Second number: " + f);
            }
            else
                Console.WriteLine("Invalid input!");


            #endregion
            Console.ReadLine();

        }
    }
}
