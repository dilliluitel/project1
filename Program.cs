using System;
using System.Text;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 0, value2 = 0;     //user entered values for arithmetic operation
            string operation = null, next = null;

            Calculator myCalculator = new Calculator(value1, value2, operation);
            do
            {
                try
                {
                    myCalculator.userInput();
                }
                catch (FormatException Ex) 
                {
                    Console.WriteLine("Invalid user Input. Please, enter a valid integer.");
                }

                try
                {
                    myCalculator.calculate();
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Division by Zero cannot be performed.");
                }

                try
                {
                    Console.WriteLine("\nWould you like to perform another calculation?");
                    Console.Write("press \"Y\" for yes and \"N\" for no : ");

                    next = (Console.ReadLine()).Trim().ToUpper();
                }
                catch (FormatException e) 
                {
                    Console.WriteLine("Invalid input, expecting a string literal");
                }
            }
            while (myCalculator.doContinue(next));
        }
    }
}
