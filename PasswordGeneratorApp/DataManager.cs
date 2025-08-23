using System;
using System.IO;
using PasswordGeneratorApp.Models;

namespace PasswordGeneratorApp
{
    // A static class which is used to save and load different types of data by the app
    public static class DataManager
    {
        // Path to the file where passwords will be stored
        private const string FilePath = "saved_passwords.txt";

        // Save a new password by appending it to the password file
        public static void SavePassword(string password)
        {
            File.AppendAllText(FilePath, password + Environment.NewLine);
            Console.WriteLine("Password saved successfully.");
        }

        // Load and display all saved passwords if the file exists
        public static void LoadPasswords()
        {
            if (File.Exists(FilePath))
            {
                string[] passwords = File.ReadAllLines(FilePath);
                Console.WriteLine("Saved Passwords:");
                foreach (string password in passwords)
                {
                    Console.WriteLine(password);
                }
            }
            else
            {
                Console.WriteLine("No saved passwords found.");
            }
        }

        // Path to the file where fictional names are be stored
        private const string FictionalNameFile = "saved_fictional_names.txt";

        // Save a fictional name entry with time when ot was created
        public static void SaveFictionalName(FictionalName entry)
        {
            File.AppendAllText(FictionalNameFile, $"{entry.CreatedAt:u} | {entry.Name}{Environment.NewLine}");
            Console.WriteLine("Fictional name saved successfully.");
        }

        // Path to the file with geographical 
        private const string GeoNameFile = "saved_geo_names.txt";

        // Save a geographical name 
        public static void SaveGeoName(GeoName entry)
        {
            File.AppendAllText(GeoNameFile, $"{entry.CreatedAt:u} | {entry.Name}{Environment.NewLine}");
            Console.WriteLine("Geographical name saved successfully.");
        }

        // Load and show all saved geographical names 
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

        // Load and display  saved fictional names 
        public static void LoadFictionalNames()
        {
            if (File.Exists(FictionalNameFile))
            {
                Console.WriteLine("Saved Fictional Names:");
                foreach (var line in File.ReadAllLines(FictionalNameFile))
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("No saved fictional names found.");
            }
        }

        private const string StoryPlotFile = "saved_story_plots.txt";

        // Save a story plot 
        public static void SaveStoryPlot(StoryPlot entry)
        {
            // Append a new line to the file with the date and time 
            File.AppendAllText(StoryPlotFile, $"{entry.CreatedAt:u} | {entry.Plot}{Environment.NewLine}");
            Console.WriteLine("Story plot saved successfully.");
        }

        // Load  saved story plots
        public static void LoadStoryPlots()
        {
            if (File.Exists(StoryPlotFile))
            {
                Console.WriteLine("Saved Story Plots:");
                foreach (var line in File.ReadAllLines(StoryPlotFile))
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("No saved story plots found.");
            }
        }
    }
}
