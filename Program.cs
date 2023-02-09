using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {

            var numberOfCupsOfCoffee = 0;

            var fullName = "KM Musshafen";

            var today = DateTime.Now;

            Console.WriteLine($"{numberOfCupsOfCoffee} {fullName} {today}");

            Console.Write("What is your name? ");
            var userName = Console.ReadLine();

            Console.WriteLine($"It is a pleasure to meet you, {userName}!");

            Console.Write("What is your favorite number? ");
            var firstNumberAsString = Console.ReadLine();
            Console.Write("Perfect! What is your second favorite number? ");
            var secondNumberAsString = Console.ReadLine();


            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            Console.WriteLine($"{firstNumberAsString}+{secondNumberAsString}={sum}");

            Console.WriteLine($"{firstNumberAsString}-{secondNumberAsString}={difference}");

            Console.WriteLine($"{firstNumberAsString}x{secondNumberAsString}={product}");

            Console.WriteLine($"{firstNumberAsString}÷{secondNumberAsString}={quotient}");

            Console.WriteLine($"The remainder of {quotient} is {remainder}");

        }
    }
}