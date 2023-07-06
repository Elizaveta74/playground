namespace CommandLineArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Total app parameters: {args.Length}");

            Console.WriteLine($"First app parameter: {args[0]}");

            if ( args.Length > 1 ) 
            {
                Console.WriteLine($"Second app parameter: {args[1]}");
            }

            if (args.Length > 2)
            {
                Console.WriteLine($"Second app parameter: {args[2]}");
            }
        }
    }
}