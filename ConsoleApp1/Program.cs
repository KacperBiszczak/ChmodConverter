using U = ClassLib.Utils;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( U.NumericToSymbolic("773") );
            Console.WriteLine( U.SymbolicToNumeric("-rwxrw-r-x") );
        }
    }
}
