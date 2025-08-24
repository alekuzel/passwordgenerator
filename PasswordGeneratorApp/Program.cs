using System;
using PasswordGeneratorApp.Models;

namespace PasswordGeneratorApp
{
 
    class Program
    {
        static void Main(string[] args)
        {
            // menu to be shown in the terminal
            Console.WriteLine("Welcome to the Generator App!");
  
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Generate a password");
                Console.WriteLine("2. Test an existing password");
                Console.WriteLine("3. Generate a fictional character name");
                Console.WriteLine("4. Generate a geographical name");
                Console.WriteLine("5. Generate a story plot");
                Console.WriteLine("6. Show saved passwords");   
                Console.WriteLine("7. Show saved fictional names");
                Console.WriteLine("8. Show saved geographical names");
                Console.WriteLine("9. Show saved story plots");
                Console.WriteLine("10. Exit");

                // Ask user to make an option
                Console.Write("Enter your choice (1-10): ");
                string choice = Console.ReadLine();
          
                // Process user selection using switch statement
                switch (choice)
                {
                    case "1":
                        GeneratePasswordFlow(); 
                        break;

                    case "2":
                        TestPasswordFlow();   
                        break;

                    case "3":
                        GenerateFictionalNameFlow();  
                        break;

                    case "4":
                        GenerateGeographicalNameFlow();  
                        break;

                    case "5":
                        GenerateStoryPlotFlow();  
                        break;
                    case "6":
                        DataManager.LoadPasswords();
                        break;
                    case "7":
                        DataManager.LoadFictionalNames();  
                        break;

                    case "8":
                        DataManager.LoadGeoNames(); 
                        break;

                    case "9":
                        DataManager.LoadStoryPlots();
                        break;

                    case "10":
                        Console.WriteLine("See you!");  
                        return;  
                        

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");  
                        break;
                }
            }
        }

        private static void GeneratePasswordFlow()
        {
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
                // Create a password  with  parameters given by a user
                PasswordGenerator generator = new PasswordGenerator
                {
                    Length = length,
                    UpperCaseCount = upperCaseCount,
                    NumberCount = numberCount,
                    SpecialCharCount = specialCharCount
                };

                string password = generator.Generate();
                Console.WriteLine($"\nGenerated Password: {password}");

                // Ask user if they want to save the password
                Console.Write("Would you like to save this password? (yes/no): ");
                string saveChoice = Console.ReadLine().Trim().ToLower();

                // Save password if the answer was "yes"
                if (saveChoice == "yes")
                {
                    DataManager.SavePassword(password);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors during password generation
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        private static void TestPasswordFlow()
        {
            Console.Write("Enter the password you want to test: ");
            string password = Console.ReadLine();

            // Evaluate password strength using validator
            string strength = PasswordValidator.EvaluateStrength(password);
            Console.WriteLine($"Password Strength: {strength}");
        }


     
        private static void GenerateFictionalNameFlow()
        {
            Console.Write("How many names would you like to generate? ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("\nGenerated Names:");
            for (int i = 0; i < count; i++)
            {
                // Generate a fictional name using the name generator
                string name = FictionalNameGenerator.GenerateName();
                Console.WriteLine($"- {name}");

                // Prompt user to save each individual name
                Console.Write("Would you like to save this name? (yes/no): ");
                string saveChoice = Console.ReadLine().Trim().ToLower();

                if (saveChoice == "yes")
                {
                    // Save the name with timestamp using DataManager
                    DataManager.SaveFictionalName(new FictionalName
                    {
                        Name = name,
                        CreatedAt = DateTime.Now
                    });
                }
            }
        }


        private static void GenerateGeographicalNameFlow()
        {
            Console.Write("How many geographical names would you like to generate? ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("\nGenerated Geographical Names:");
            for (int i = 0; i < count; i++)
            {
                // Generate geographical name using geo name generator
                string name = GeoNameGenerator.GenerateName();
                Console.WriteLine(name);

                // Prompt user to save each geographical name
                Console.Write("Would you like to save this geographical name? (yes/no): ");
                string saveChoice = Console.ReadLine().Trim().ToLower();

                if (saveChoice == "yes")
                {
                    // Save geographical name with timestamp
                    DataManager.SaveGeoName(new GeoName
                    {
                        Name = name,
                        CreatedAt = DateTime.Now
                    });
                }
            }
        }

        private static void GenerateStoryPlotFlow()
        {
            Console.WriteLine("\nGenerated Story Plot:");
            
            // Generate a complete story plot using plot generator
            string plot = StoryPlotGenerator.GeneratePlot();
            Console.WriteLine($"- {plot}");

            // Prompt user to save the generated plot
            Console.Write("Would you like to save this plot? (yes/no): ");
            string saveChoice = Console.ReadLine().Trim().ToLower();

            if (saveChoice == "yes")
            {
                // Save story plot with timestamp
                DataManager.SaveStoryPlot(new StoryPlot
                {
                    Plot = plot,
                    CreatedAt = DateTime.Now
                });
            }
        }
    }
}