using System;
using System.Text;

namespace PasswordGeneratorApp
{
    public class PasswordGenerator
    {
        public int Length { get; set; }
        public int UpperCaseCount { get; set; }
        public int NumberCount { get; set; }
        public int SpecialCharCount { get; set; }

        private static readonly string UpperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string Numbers = "0123456789";
        private static readonly string SpecialChars = "!@#$%^&*()";
        private static readonly string LowerCaseChars = "abcdefghijklmnopqrstuvwxyz";

        public string Generate()
        {
            if (UpperCaseCount + NumberCount + SpecialCharCount > Length)
            {
                throw new ArgumentException("Sum of character type counts exceeds total length.");
            }

            StringBuilder password = new StringBuilder();
            Random random = new Random();

            // Add required uppercase letters
            for (int i = 0; i < UpperCaseCount; i++)
                password.Append(UpperCaseChars[random.Next(UpperCaseChars.Length)]);

            // Add required numbers
            for (int i = 0; i < NumberCount; i++)
                password.Append(Numbers[random.Next(Numbers.Length)]);

            // Add required special characters
            for (int i = 0; i < SpecialCharCount; i++)
                password.Append(SpecialChars[random.Next(SpecialChars.Length)]);

            // Fill the rest with lowercase letters
            int remaining = Length - password.Length;
            for (int i = 0; i < remaining; i++)
                password.Append(LowerCaseChars[random.Next(LowerCaseChars.Length)]);

            // Shuffle the password
            return Shuffle(password.ToString());
        }

        private string Shuffle(string input)
        {
            char[] array = input.ToCharArray();
            Random random = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (array[i], array[j]) = (array[j], array[i]);
            }
            return new string(array);
        }
    }
}
