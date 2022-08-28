using System;
namespace Exercises
{
    class Calculator
    {
       static void Calci()
            {
            while (true)
            {
                var value1 = inputDouble("Enter the first value");
                var value2 = inputDouble("Enter the second value");
                var choice = inputString("Enter the choice as +, - X or /");

                switch (choice)
                {
                    case "+":
                        Console.WriteLine($"The added value is {value1 + value2}");
                        break;

                    case "-":
                        Console.WriteLine($"The Subtracted value is {value1 - value2}");
                        break;
                    case "X":
                        Console.WriteLine($"The Multiplied value is {value1 * value2}");
                        break;
                    case "/":
                        Console.WriteLine($"The Divided value is {value1 / value2}");
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
           
            }
            static double inputDouble(string question)
            {
                Console.WriteLine(question);
                return double.Parse(Console.ReadLine());
            }
            static string inputString(string question)
            {
                Console.WriteLine(question);
                return Console.ReadLine();
            }


            static void Main(string[] args)
            {
               
                Calci();
            }
        
    }
}
