using System;
using PasswordGeneratorApp.Models;


namespace PasswordGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Ultimate Generator App!");

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Generate a password");
                Console.WriteLine("2. Test an existing password");
                Console.WriteLine("3. Generate a fictional character name");
                Console.WriteLine("4. Generate a geographical name");
                Console.WriteLine("5. Generate a story plot");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice (1-6): ");
                string choice = Console.ReadLine();

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
                PasswordGenerator generator = new PasswordGenerator
                {
                    Length = length,
                    UpperCaseCount = upperCaseCount,
                    NumberCount = numberCount,
                    SpecialCharCount = specialCharCount
                };

                string password = generator.Generate();
                Console.WriteLine($"\nGenerated Password: {password}");

                Console.Write("Would you like to save this password? (yes/no): ");
                string saveChoice = Console.ReadLine().Trim().ToLower();

                if (saveChoice == "yes")
                {
                    DataManager.SavePassword(password);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static void TestPasswordFlow()
        {
            Console.Write("Enter the password you want to test: ");
            string password = Console.ReadLine();

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
                Console.WriteLine(FictionalNameGenerator.GenerateName());
            }
        }

       private static void GenerateGeographicalNameFlow()
{
    Console.Write("How many geographical names would you like to generate? ");
    int count = int.Parse(Console.ReadLine());

    Console.WriteLine("\nGenerated Geographical Names:");
    for (int i = 0; i < count; i++)
    {
        string name = GeoNameGenerator.GenerateName();
        Console.WriteLine(name);

        Console.Write("Would you like to save this geographical name? (yes/no): ");
        string saveChoice = Console.ReadLine().Trim().ToLower();

        if (saveChoice == "yes")
        {
            var entry = new GeoName
            {
                Name = name,
                CreatedAt = DateTime.Now
            };
            SaveGeoName(entry); 
        }
    }
}

            private const string GeoNameFile = "saved_geo_names.txt";

        public static void SaveGeoName(GeoName entry)
        {
            File.AppendAllText(GeoNameFile, $"{entry.CreatedAt:u} | {entry.Name}{Environment.NewLine}");
            Console.WriteLine("Geographical name saved successfully.");
        }

        public static void LoadGeoNames()
        {
            if (File.Exists(GeoNameFile))
            {
                Console.WriteLine("Saved Geographical Names:");
                foreach (var line in File.ReadAllLines(GeoNameFile))
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("No saved geographical names found.");
            }

        }

        private static void GenerateStoryPlotFlow()
        {
            Console.Write("How many story plots would you like to generate? ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("\nGenerated Story Plots:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"- {StoryPlotGenerator.GeneratePlot()}");
            }
        }
    }
}


