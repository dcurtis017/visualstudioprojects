using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean keepGoing = true;
            while(keepGoing)
            {
                int firstNumber = promptForNumber();
                string operation = promptForOperation();
                if(operation == null || operation.Length > 1)
                {
                    Console.WriteLine("Something is wrong with the operation you entered");
                    Console.WriteLine("Press CTRL+Z to exit or start over.");
                    continue;
                }
                int secondNumber = promptForNumber();
                completeOperation(firstNumber, secondNumber, operation);
            }
        }

        static int promptForNumber()
        {
            Console.Write("Please enter a number: ");
            return int.Parse(Console.ReadLine());
        }

        static string promptForOperation()
        {
            Console.Write("Please enter an operation (+-*/: ");
            return Console.ReadLine();
        }

        static void completeOperation(int int1, int int2, string operation)
        {
            int result = 0;
            if(operation == "+")
            {
                result = int1 + int2;
            }
            else if(operation == "-")
            {
                result = int1 - int2;
            }
            else if (operation == "*")
            {
                result = int1 * int2;
            }
            else if (operation == "/")
            {
                result = int1 / int2;
            }
            else
            {
                Console.WriteLine("You entered an invalid operation ("+operation+")");
                Console.WriteLine("Press CTRL+Z to exit or do another operation.");
                return;
            }
            Console.WriteLine("The result of " + int1 + operation + int2 + " is: " + result);
            Console.WriteLine("Press CTRL+Z to exit or do another operation.");
        }

        
    }
}
