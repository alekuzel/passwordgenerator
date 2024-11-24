using System;
using System.IO;

namespace PasswordGeneratorApp
{
    public static class PasswordManager
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
    }
}
