﻿// This lesson demonstrates command line argument handling

namespace CommandLineArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"App parameters count = {args.Length}");

            // if there's at least one parameter present
            if (args.Length > 0)
            { 
                Console.WriteLine($"First app parameter: {args[0]}");
            }

            // if there're at least two parameters present
            if ( args.Length > 1 ) 
            {
                Console.WriteLine($"Second app parameter: {args[1]}");
            }

            // if there are three parameters present
            if (args.Length > 2)
            {
                Console.WriteLine($"Third app parameter: {args[2]}");
            }
        }
    }
}