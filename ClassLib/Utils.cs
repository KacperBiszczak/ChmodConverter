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
                string result = "-";

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

                            string symbolicPerm = "";
                            switch (num)
                            {
                                case 1:
                                    symbolicPerm = "--x";
                                    break;

                                case 2:
                                    symbolicPerm = "-w-";
                                    break;

                                case 3:
                                    symbolicPerm = "-wx";
                                    break;

                                case 4:
                                    symbolicPerm = "r--";
                                    break;

                                case 5:
                                    symbolicPerm = "r-x";
                                    break;

                                case 6:
                                    symbolicPerm = "rw-";
                                    break;

                                case 7:
                                    symbolicPerm = "rwx";
                                    break;

                                default:
                                    symbolicPerm = "---";
                                    break;

                            }

                            result += symbolicPerm;
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
