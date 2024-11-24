namespace PasswordGeneratorApp
{
    public static class PasswordValidator
    {
        public static bool IsStrong(string password)
        {
            // Basic strength validation: Length >= 8, contains upper, lower, digit, special char
            if (password.Length < 8) return false;

            bool hasUpper = false, hasLower = false, hasDigit = false, hasSpecial = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsLower(c)) hasLower = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else hasSpecial = true;

                if (hasUpper && hasLower && hasDigit && hasSpecial)
                    return true;
            }

            return false;
        }
    }
}
