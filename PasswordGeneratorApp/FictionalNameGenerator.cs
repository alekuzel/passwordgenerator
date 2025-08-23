using System;

namespace PasswordGeneratorApp
{
    public static class FictionalNameGenerator
    {
        // Prefixes for fictional names
        private static readonly string[] NamePrefixes =
        {
            "Ar", "El", "Fen", "Gal", "Is", "Ka", "Lun", "Mor", "Ny", "Syl", "Tar", "Vel", 
            "Tryl", "Tryll", "Zell", "Balla", "Cyl", "Dra", "Kyl", "Thal", "Xel", "Zy"
        };

        // Suffixes
        private static readonly string[] NameSuffixes =
        {
            "an", "ion", "ith", "or", "as", "wyn", "riel", "eth", "ar", "en", "iel", "us", 
            "br", "il", "en", "ynn", "xn", "alla", "ndra", "lerra", "gella", "deffe"
        };

        private static readonly Random random = new Random();
     
        // Generate a new fictional name by randomly combining a prefix and suffix
      
        public static string GenerateName()
        {
            // Randomly select one prefix...
            string prefix = NamePrefixes[random.Next(NamePrefixes.Length)];
            
            // ...and one suffix
            string suffix = NameSuffixes[random.Next(NameSuffixes.Length)];
            
            // Combine prefix and suffix here
            return $"{prefix}{suffix}";
        }
    }
}