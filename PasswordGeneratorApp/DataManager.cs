using System;
using System.IO;
using PasswordGeneratorApp.Models;


namespace PasswordGeneratorApp
{
    public static class DataManager
    {
        private const string FilePath = "saved_passwords.txt";

        public static void SavePassword(string password)
        {
            File.AppendAllText(FilePath, password + Environment.NewLine);
            Console.WriteLine("Password saved successfully.");
        }

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


        //path to file
        private const string FictionalNameFile = "saved_fictional_names.txt";

        public static void SaveFictionalName(FictionalName entry)
        {
            File.AppendAllText(FictionalNameFile, $"{entry.CreatedAt:u} | {entry.Name}{Environment.NewLine}");
            Console.WriteLine("Fictional name saved successfully.");
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

        // Path to the file where story plots will be saved
        private const string StoryPlotFile = "saved_story_plots.txt";

        public static void SaveStoryPlot(StoryPlot entry)
        {
            // Append a new line to the file with the date/time and the plot text
            File.AppendAllText(StoryPlotFile, $"{entry.CreatedAt:u} | {entry.Plot}{Environment.NewLine}");

            Console.WriteLine("Story plot saved successfully.");
        }

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
