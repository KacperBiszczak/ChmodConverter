using System;

namespace ClassLib
{
    public static class Utils
    {
        public static string SymbolicToNumeric(string symbolic)
        {
            // Check if argument is null
            if (ReferenceEquals(symbolic, null))
            {
                throw new ArgumentNullException("Argument can't be a null.");
            }

            symbolic = symbolic.Trim().ToLower();

            // Check format is like "-rwxrwxrwx" 
            if (symbolic[0] != '-' || symbolic.Length != 10)
                throw new ArgumentException("Invalid format.");

            string result = "";
            
            // Convert symbolic to numeric
            string[] symbolicPerm = new string[3];
            for (int i = 0; i < 3; i++)
            {
                symbolicPerm[i] = symbolic.Substring(1 + (3 * i), 3);
                int num;

                switch (symbolicPerm[i])
                {
                    case "---":
                        num = 0;
                        break;

                    case "--x":
                        num = 1;
                        break;

                    case "-w-":
                        num = 2;
                        break;

                    case "-wx":
                        num = 3;
                        break;

                    case "r--":
                        num = 4;
                        break;

                    case "r-x":
                        num = 5;
                        break;

                    case "rw-":
                        num = 6;
                        break;

                    case "rwx":
                        num = 7;
                        break;

                    default:
                        throw new ArgumentException("Invalid symbols or format.");
                }

                result += num;
            }

            return result;
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
                            // Convert numeric to symbolic
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
