using System;

namespace PasswordGeneratorApp
{
    public static class GeoNameGenerator
    {
        private static readonly string[] LocationPrefixes =
        {
            "Red", "Silent", "Golden", "Crystal", "Silver", "Shadow", "Misty", "Windy", "Azure", "Green"
        };

        private static readonly string[] LocationSuffixes =
        {
            "Valley", "Ridge", "Forest", "Lake", "Haven", "Cliff", "Shore", "Peak", "Fjord", "Plains"
        };

        public static string GenerateName()
        {
            Random random = new Random();
            string prefix = LocationPrefixes[random.Next(LocationPrefixes.Length)];
            string suffix = LocationSuffixes[random.Next(LocationSuffixes.Length)];
            return $"{prefix} {suffix}";
        }
    }
}
