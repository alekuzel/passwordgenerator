using System;

namespace PasswordGeneratorApp
{
    public static class GeoNameGenerator
    {
        // Array of location prefixes
        private static readonly string[] LocationPrefixes =
        {
            "Red", "Silent", "Golden", "Crystal", "Silver", "Shadow", "Misty", "Windy", "Azure", "Green"
        };
        // Array of location suffixes
        private static readonly string[] LocationSuffixes =
        {
            "Valley", "Ridge", "Forest", "Lake", "Haven", "Cliff", "Shore", "Peak", "Fjord", "Plains"
        };

        public static string GenerateName()
        {
            Random random = new Random();
            // Select a random prefix and suffix and combine them
            string prefix = LocationPrefixes[random.Next(LocationPrefixes.Length)];
            string suffix = LocationSuffixes[random.Next(LocationSuffixes.Length)];
            return $"{prefix} {suffix}";
        }
    }
}
