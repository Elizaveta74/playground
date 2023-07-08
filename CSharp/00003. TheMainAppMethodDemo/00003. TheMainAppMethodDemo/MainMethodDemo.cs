// This lesson demonstrates ways in which you can declare the main application method

namespace MainAppMethodDemo
{
    public class MainMethodDemo
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("This method returns nothing. The operating system assumes that it always returns 0.");
        //    Console.WriteLine("Check the output window, there's text: 'TheMainAppMethodDemo.exe exited with code 0.'");
        //    Console.WriteLine("if you get a 'Process finished with exit code 0' message, that means that the code ran correctly.");
        //}

        public static int Main(string[] args)
        {
            Console.WriteLine("This method returns an int value indicating whether the process was successful or failed.");
            Console.WriteLine("If the process finished ok it should return 0, " +
                              "if an error occurred the process returns an int value associated with the error " +
                              "to let the calling process determine what's gone wrong.");
            Console.WriteLine("In most cases, it is sufficient to return a -1 on error to let the parent process know that the child process has failed.");


            return -1;
        }
    }
}


