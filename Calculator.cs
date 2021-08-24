using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
   public class Calculator
    {
       public int value1, value2;     //user entered values for arithmetic operation
       public  string operation;

        //Calculator constructor 
       public Calculator(int val1, int val2, string op)
        {
            value1 = val1;
            value2 = val2;
            operation = op;
        }
        public void userInput()
        {
            Console.Write("Enter your first number : ");
            value1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number : ");
            value2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter an arthimatic operation \n[Add(+), Subtract(-), Multiply(*) or Divide(/)] : ");
            operation = (Console.ReadLine()).ToLower();

        }
        public void calculate()
        {
            decimal result = 0;
            switch (operation)
            {
                case "+":
                case "add":
                    result = value1 + value2;
                    break;

                case "-":
                case "subtract":
                    result = value1 - value2;
                    break;

                case "*":
                case "multiply":
                    result = value1 * value2;
                    break;

                case "/":
                case "divide":
                    result = (decimal)value1 / value2;
                    break;
            }
            Console.WriteLine($"{value1} {operation} {value2} = {result}");
        }

        public bool doContinue(string next)
        {
            return ((next == "Y" || next == "YES") ? true : false); 
        }

        /*public string calculate()
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
