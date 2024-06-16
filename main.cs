using System;
namespace Perfect{

}
    class Program
    {
        public static void Main(string[] args)
        {
            int userInput=0; 
            bool isValidInput = false;
            while (!isValidInput)
            {
                Console.Write("Enter a number between 1 and 10,000: ");
                if (int.TryParse(Console.ReadLine(), out userInput) && userInput >= 1 && userInput <= 10000)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 10,000.");
                }
            }

            int sumOfDivisors =             CalculateSumOfProperDivisors(userInput);            if (sumOfDivisors == userInput)
            {
                Console.WriteLine($"{userInput} is a perfect number.");
            }
            else
            {
                Console.WriteLine($"{userInput} is not a perfect number.");
            }
        }
        private static int CalculateSumOfProperDivisors(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
