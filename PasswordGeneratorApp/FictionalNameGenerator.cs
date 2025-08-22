using System;

namespace PasswordGeneratorApp
{
    public static class FictionalNameGenerator
    {
        private static readonly string[] NamePrefixes =
        {
            "Ar", "El", "Fen", "Gal", "Is", "Ka", "Lun", "Mor", "Ny", "Syl", "Tar", "Vel", "Tryl", "Tryll", "Zell", "Balla", "Cyl", "Dra", "Kyl", "Thal", "Xel", "Zy"
        };

        private static readonly string[] NameSuffixes =
        {
            "an", "ion", "ith", "or", "as", "wyn", "riel", "eth", "ar", "en", "iel", "us", "br", "il", "en"
, "ynn", "xn", "alla", "ndra", "lerra", "gella" , "deffe"       };

        public static string GenerateName()
        {
            Random random = new Random();
            string prefix = NamePrefixes[random.Next(NamePrefixes.Length)];
            string suffix = NameSuffixes[random.Next(NameSuffixes.Length)];
            return $"{prefix}{suffix}";
        }
    }
}
