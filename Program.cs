using System;
using System.Text;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 0, value2 = 0;     //user entered values for arithmetic operation
            //decimal result;
            string operation = null;
            bool contd;                     //continue

            Calculator myCalculator = new Calculator();

            do
            {
                try
                {
                    Console.Write("Enter your first number : ");
                    value1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter your second number : ");
                    value2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter an arthimatic operation \n[Add(+), Subtract(-), Multiply(*) or Divide(/)] : ");
                    operation = (Console.ReadLine()).ToLower();

                    // myCalculator.userInput(value1, value2, operation);  //cannot get this working, won't takes the user input values instead keeps reading the initial during the initialization
                }
                catch (FormatException Ex) 
                {
                    Console.WriteLine("Invalid user Input. Please, enter a valid integer.");
                }

                try
                {
                    myCalculator.calculate(value1, value2, operation);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Division by Zero cannot be performed.");
                }

                Console.WriteLine("\nWould you like to perform another calculation?");
                Console.Write("press \"Y\" for yes and \"N\" for no : ");

                string next = (Console.ReadLine()).Trim().ToUpper();
                contd = myCalculator.doContinue(next);
            }
            while (contd);
        }
    }
}
