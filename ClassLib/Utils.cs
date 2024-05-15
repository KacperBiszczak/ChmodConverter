namespace ClassLib
{
    public static class Utils
    {
        public static string SymbolicToNumeric(string symbolic)
        {
            throw new NotImplementedException();
        }

        public static string NumericToSymbolic(string numeric)
        {
            // Check if argument is null
            if(ReferenceEquals(numeric, null))
            {
                throw new ArgumentNullException("Argument can't be a null.");
            }
            
            // Validate format
            if(numeric.Trim().Length == 3)
            {
                numeric = numeric.Trim();
                string result = "";

                foreach(char c in numeric)
                {
                    // Check if char is a numeric
                    if(int.TryParse(c.ToString(), out int num))
                    {
                        // Check if char is in range
                        if(num < 0 || num > 7)
                        {
                            throw new ArgumentException("Char must be between 0 and 7.");
                        }
                        else
                        {
                            result += num;
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Char is not a number.");
                    }
                }

                return result;
            }
            else
            {
                throw new ArgumentException("Invalid format.");
            }
        }
    }
}
