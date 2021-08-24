using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Calculator
    {
        public void userInput(int val1, int val2, string op)
        {
            Console.Write("Enter your first number : ");
            val1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number : ");
            val2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter an arthimatic operation \n[Add(+), Subtract(-), Multiply(*) or Divide(/)] : ");
            op = (Console.ReadLine()).ToLower();
        }
        public void calculate(int val1, int val2, String op)
        {
            decimal result = 0;
            switch (op)
            {
                case "+":
                case "add":
                    result = val1 + val2;
                    break;

                case "-":
                case "subtract":
                    result = val1 - val2;
                    break;

                case "*":
                case "multiply":
                    result = val1 * val2;
                    break;

                case "/":
                case "divide":
                    result = (decimal)val1 / val2;
                    break;
            }
            Console.WriteLine($"{val1} {op} {val2} = {result}");
        }

        public bool doContinue(string next)
        {
            return ((next == "Y" || next == "YES") ? true : false); 
        }

        /*public string Calculate(string operation, int value1, int value2)
        {
            string result = "";
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
            return result;
        }*/
    }

    
}
