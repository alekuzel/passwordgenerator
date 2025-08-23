using System.Text.RegularExpressions;

namespace PasswordGeneratorApp
{
    public static class PasswordValidator
    {
        public static string EvaluateStrength(string password)
        {
            if (string.IsNullOrEmpty(password))
                return "Weak (Empty password)";

            int score = 0;

            // Length scoring
            if (password.Length >= 12) score++;
            if (password.Length >= 16) score++;

            // Check if there are uppercase letters
            if (Regex.IsMatch(password, @"[A-Z]")) score++;

            // Check if there are lowercase letters
            if (Regex.IsMatch(password, @"[a-z]")) score++;

            // Check for digits
            if (Regex.IsMatch(password, @"\d")) score++;

            // Check for special characters
            if (Regex.IsMatch(password, @"[\W_]")) score++;

            // Score interpretation
            return score switch
            {
                <= 2 => "Weak",
                3 => "Moderate",
                4 => "Strong",
                5 => "Very Strong"
            };
        }
    }
}
