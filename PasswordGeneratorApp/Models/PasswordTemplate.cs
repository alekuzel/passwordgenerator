namespace PasswordGeneratorApp.Models
{
    public class PasswordTemplate
    {
        public int Length { get; set; }
        public int UpperCaseCount { get; set; }
        public int NumberCount { get; set; }
        public int SpecialCharCount { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}: Length={Length}, UpperCase={UpperCaseCount}, Numbers={NumberCount}, Specials={SpecialCharCount}";
        }
    }
}
