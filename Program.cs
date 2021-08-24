using System;
using System.Text;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1, value2;     //user entered values for arithmetic operation
            bool contd;             //continue
            do
            {
                Console.Write("Enter your first number : ");
                value1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your second number : ");
                value2 = Convert.ToInt32(Console.ReadLine());

                string operation;
                string result = "";

                Console.Write("Enter an arthimatic operation \n[Add(+), Subtract(-), Multiply(*) or Divide(/)] : ");
                operation = (Console.ReadLine()).ToLower();

                try
                {
                    switch (operation)
                    {
                        case "+":
                        case "add":
                            result = (value1 + value2).ToString();
                            operation = "+";
                            break;

                        case "-":
                        case "subtract":
                            result = (value1 - value2).ToString();
                            operation = "-";
                            break;

                        case "*":
                        case "multiply":
                            result = (value1 * value2).ToString();
                            operation = "*";
                            break;

                        case "/":
                        case "divide":
                            result = $"{((decimal)value1 / value2):F4}";   //formats to four decimal values; interger division can produce decimal results
                            operation = "/";
                            break;
                    }
                    Console.WriteLine($"\n{value1} {operation} {value2} = {result}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Division by Zero cannot be performed.");
                }
                Console.WriteLine("\nWould you like to perform another calculation?");
                Console.Write("press \"Y\" for yes and \"N\" for no : ");

                string next = (Console.ReadLine()).ToUpper();
                //coudn't get the trimmer to work here, not sure why?
                //string next = (Console.ReadLine()).Trim().ToUpper();
                //Console.WriteLine(next);

                contd = (next == "Y" || next == "YES") ? true : false;  //checks if user wants to continue

               /* if (next == "Y" || next == "YES")
                    contd = true;
                else
                    contd = false;*/
            }
            while (contd);
        }
    }
}
