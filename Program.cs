

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] operators = { '+', '-', '*', '/' };
            int operatorIndex = -10;
            char operation = '\0';

            Console.WriteLine("Usage: <10-2 or 10 - 2>\n::>");

            string userInput = Console.ReadLine();

            while (userInput != "exit")
            {
                userInput = userInput.Replace(" ", "");

                foreach (char op in operators)
                {
                    operatorIndex = userInput.IndexOf(op);
                    if (operatorIndex != -1)
                    {
                        operation = op;
                        break;
                    }
                }

                if (operatorIndex == -1)
                {
                    Console.WriteLine("Invalid input. Usage: <10-2 or 10 - 2>\n::> ");
                    userInput = Console.ReadLine();
                    continue;
                }

                double num1 = double.Parse(userInput.Substring(0, operatorIndex));
                double num2 = double.Parse(userInput.Substring(operatorIndex + 1));

                switch (operation)
                {
                    case '+':
                        Console.WriteLine($"Result: {num1 + num2}");
                        break;
                    case '-':
                        Console.WriteLine($"Result: {num1 - num2}");
                        break;
                    case '*':
                        Console.WriteLine($"Result: {num1 * num2}");
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero!");
                            break;
                        }
                        Console.WriteLine($"Result: {num1 / num2}");
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }
                Console.WriteLine("Usage: <10-2 or 10 - 2>\n::>");
                userInput = Console.ReadLine();
            }
        }
    }
}