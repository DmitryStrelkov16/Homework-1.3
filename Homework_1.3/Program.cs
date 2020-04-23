using System;
using System.Diagnostics;

namespace Homework_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstVariable, secondVariable;
            string action;

            Console.WriteLine("Enter the number 1");
            firstVariable = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number 2");
            secondVariable = double.Parse(Console.ReadLine());

            Console.WriteLine("Select an available operation: '+' '-' '*' '/'");
            action = Console.ReadLine();
            
            switch (action)
            {
                case "+":
                    Console.WriteLine(firstVariable + secondVariable);
                    break;
                case "-":
                    Console.WriteLine(firstVariable - secondVariable);
                    break;
                case "*":
                    Console.WriteLine(firstVariable * secondVariable);
                    break;
                case "/":
                    if (secondVariable == 0)
                    {
                        Console.WriteLine("Error!!! Division by zero is not allowed!!!");
                    }
                    else
                    {
                        Console.WriteLine(firstVariable / secondVariable);
                    }                    
                    break;
                default:
                    Console.WriteLine("Error!!! This action is not provided by the program!");
                    break;
            }
          





        }
    }
}
