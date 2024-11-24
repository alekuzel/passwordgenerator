using System;

namespace PasswordGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Password Generator!");

            Console.Write("Enter the desired password length: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of uppercase letters: ");
            int upperCaseCount = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of digits: ");
            int numberCount = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of special characters: ");
            int specialCharCount = int.Parse(Console.ReadLine());

            try
            {
                PasswordGenerator generator = new PasswordGenerator
                {
                    Length = length,
                    UpperCaseCount = upperCaseCount,
                    NumberCount = numberCount,
                    SpecialCharCount = specialCharCount
                };

                string password;
                bool isSatisfied = false;

                do
                {
                    password = generator.Generate();
                    Console.WriteLine($"Generated Password: {password}");

                    Console.Write("Are you satisfied with this password? (yes/no): ");
                    isSatisfied = Console.ReadLine().Trim().ToLower() == "yes";
                } while (!isSatisfied);

                Console.WriteLine("Thank you for using the Password Generator!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
