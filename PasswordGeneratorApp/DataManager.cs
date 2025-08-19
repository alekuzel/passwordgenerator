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
    }
}
