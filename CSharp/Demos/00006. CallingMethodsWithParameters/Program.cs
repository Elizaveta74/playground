// In this application we'll assume that static void Main(string[] args) represents an operating system.
// And method SomeProcessMain(string[] args) represents the Main method of some application. And we'll call
// this SomeProcessMain method like operating systems call Main method and pass parameters to it.

namespace CallingMethodsWithParameters
{
    internal class Program
    {
        // Suppose this method works as Operating System
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("Calling program without command line arguments");
            Console.WriteLine("**********************************************");

            string[] noApplicationArguments = { }; // empty array declaration
            SomeProcessMain(noApplicationArguments);

            Console.WriteLine("**********************************************");

            Console.WriteLine();

            Console.WriteLine("**********************************************");
            Console.WriteLine("Calling program with single argument: help");
            Console.WriteLine("**********************************************");

            string[] singleApplicationArgumentToDisplayDocs = { "help" };
            SomeProcessMain(singleApplicationArgumentToDisplayDocs);

            Console.WriteLine("**********************************************");

            Console.WriteLine();

            Console.WriteLine("**********************************************");
            Console.WriteLine("Calling program with single argument: products");
            Console.WriteLine("**********************************************");

            string[] singleApplicationArgumentPrintAllProducts = { "products" };
            SomeProcessMain(singleApplicationArgumentPrintAllProducts);

            Console.WriteLine("**********************************************");

            Console.WriteLine();

            Console.WriteLine("**********************************************");
            Console.WriteLine("Calling program with two arguments: apples jam");
            Console.WriteLine("**********************************************");

            string[] twoApplicationArgumentsToMakeAppleJam = { "apples", "jam" };
            PerformLogicWhenTwoArgumentsPassed(twoApplicationArgumentsToMakeAppleJam);

            Console.WriteLine("**********************************************");

            Console.WriteLine();

            Console.WriteLine("**********************************************");
            Console.WriteLine("Calling program with two arguments: oranges juice");
            Console.WriteLine("**********************************************");

            string[] twoApplicationArgumentsToMakeOrangeJuice = { "oranges", "juice" };
            PerformLogicWhenTwoArgumentsPassed(twoApplicationArgumentsToMakeOrangeJuice);

            Console.WriteLine("**********************************************");

            Console.WriteLine();

            Console.WriteLine("**********************************************");
            Console.WriteLine("Calling program with two arguments: apples juice");
            Console.WriteLine("**********************************************");

            string[] twoApplicationArgumentsToMakeAppleJuice = { "apples", "juice" };
            PerformLogicWhenTwoArgumentsPassed(twoApplicationArgumentsToMakeAppleJuice);

            Console.WriteLine("**********************************************");

            Console.WriteLine();

            Console.WriteLine("**********************************************");
            Console.WriteLine("Calling program with two arguments: oranges jam");
            Console.WriteLine("**********************************************");

            string[] twoApplicationArgumentsToMakeOrangeJam = { "oranges", "jam" };
            PerformLogicWhenTwoArgumentsPassed(twoApplicationArgumentsToMakeOrangeJam);

            Console.WriteLine("**********************************************");
        }


        /**
         * Suppose this method is a Main(string[] args) method of an application. 
         * We'll call this method like the operating system calls the 
         * Main method and pass parameters to it.
         */
        static void SomeProcessMain(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments passed to app. Performing logic for case, when no arguments passed");
                PerformLogicWhenNoArgsPassed();
                return;
            }

            if (args.Length == 1)
            {
                Console.WriteLine("Single argument passed to app. Performing logic for case, when only single argument passed");
                string passedSingleArgument = args[0]; // first element of array

                PerformLogicWhenSingleArgumentPassed(passedSingleArgument);
            }

        }

        static void PerformLogicWhenTwoArgumentsPassed(string[] arguments)
        {
            string firstArgument = arguments[0];
            string secondArgument = arguments[1];
            
            Console.WriteLine($"Processing first argument: {firstArgument}");
            Console.WriteLine($"Processing second argument: {secondArgument}");

            Console.WriteLine($"We assume the first argument: '{firstArgument}' contains product name, and the second argument contains the action '{secondArgument}'");

            Console.WriteLine($"Preparing: {secondArgument} using {firstArgument} ....");
        }

        static void PerformLogicWhenSingleArgumentPassed(string singleArgument)
        {
            Console.WriteLine($"Processing single argument: {singleArgument}");
            
            if (singleArgument == "help")
            {
                Console.WriteLine($"Help requested, printing documentation");
                Console.WriteLine($"This application makes jam and juice from apples and oranges.");
                return;
            }

            if (singleArgument == "products")
            {
                Console.WriteLine($"Products list requested. Printing list of products");
                Console.WriteLine($"Products: apples, oranges");
                return;
            }

            // if parameter is not equal to 'help' nor 'products', then we ignore this parameter and do nothing
        }

        static void PerformLogicWhenNoArgsPassed()
        {
            // an arbitrary logic, when no parameters passed.
            // doing some calculation and displaying the result

            int x = 10;
            int y = 20;
            int z = x + y;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = {z}");
        }
    }
}