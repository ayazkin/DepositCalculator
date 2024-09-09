using System.ComponentModel.DataAnnotations;

namespace DepositCalculator
{
    internal class Program
    {

        public static double Calculate(string userInput)
        {
            var numbers = userInput.Split(' ');

            double depositAmount = double.Parse(numbers[0]);
            double annualPercentage = double.Parse(numbers[1]);
            double numberOfMonths = double.Parse(numbers[2]);

            var result = depositAmount * Math.Pow((1 + (annualPercentage / 12.0) / 100), numberOfMonths);
            return result;
        }
        static void Main(string[] args)
        {

            var userInput = Console.ReadLine();
            Console.WriteLine(Calculate(userInput));
            
        }
    }
}
