using System;

namespace PasswordGeneratorApp
{
    public static class FictionalNameGenerator
    {
        private static readonly string[] NamePrefixes =
        {
            "Ar", "El", "Fen", "Gal", "Is", "Ka", "Lun", "Mor", "Ny", "Syl", "Tar", "Vel"
        };

        private static readonly string[] NameSuffixes =
        {
            "an", "ion", "ith", "or", "as", "wyn", "riel", "eth", "ar", "en", "iel", "us"
        };

        public static string GenerateName()
        {
            Random random = new Random();
            string prefix = NamePrefixes[random.Next(NamePrefixes.Length)];
            string suffix = NameSuffixes[random.Next(NameSuffixes.Length)];
            return $"{prefix}{suffix}";
        }
    }
}
