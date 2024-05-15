namespace ChmodConverter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Utils.NumericToSymbolic("773") );
            Console.WriteLine( Utils.SymbolicToNumeric("-rwxrw-r-x") );
        }
    }
}
