namespace SequenceExtractor;

/**
 * This sample application demonstrates the algorithm that extracts sequences from an int array based on provided delimiter int value.
 */ 

public class Program
{
    static void Main(string[] args)
    {
        int[] firstArray = { 10, 12, -1, 20, 30, 40, -1, 50, 60, 70, -1, 4, 11, 0, 2, -8, -3};
        int delimiterForFirstArray = -1;

        PrintArray("First array: ", firstArray);

        Console.WriteLine($"*** Sequences from first array delimited by {delimiterForFirstArray} ***");
        ExtractAndPrintSequences(firstArray, delimiterForFirstArray);
        Console.WriteLine("********************************************");

        Console.WriteLine("--------------------------------------------------");

        int[] secondArray = { 6, 8, 11, 0, -17, 12, 203, 0, 13, 45, 0, 80, 31, 110, 27, 0, 16, 10, 1 };
        int delimiterForSecondArray = 0;

        PrintArray("Second array: ", secondArray);

        Console.WriteLine($"*** Sequences from second array delimited by {delimiterForSecondArray} ***");
        ExtractAndPrintSequences(secondArray, delimiterForSecondArray);
        Console.WriteLine("**************************************************");

        Console.WriteLine("--------------------------------------------------");

        int[] thirdArray = { 65, 20, 91, 35, 123, 72, 20, 134, 35, 101};
        int delimiterForThirdArray = 20;

        PrintArray("Third array: ", thirdArray);

        Console.WriteLine($"*** Sequences from third array delimited by {delimiterForThirdArray} ***");
        ExtractAndPrintSequences(thirdArray, delimiterForThirdArray);
        Console.WriteLine("**************************************************");

    }

    static void PrintArray(string prompt, int[] array)
    {
        Console.Write($"{prompt}: ");
        for (int i = 0; i < array.Length; i++)
        {
            // if we have printed at least one element, printing comma with space
            if (i > 0)
            {
                Console.Write(", ");
            }

            Console.Write(array[i]);
        }

        Console.WriteLine();
    }

    static void ExtractAndPrintSequences(int[] array, int delimiter)
    {
        // as we did not print anything yet, putting the flag to false
        bool firstElementOfSequenceHasPrinted = false;

        // processing the array
        for (int i = 0; i < array.Length; i++)
        {
            // putting currently processing array element to separate variable for brewity
            int currentlyProcessingArrayElement = array[i];

            // checking whether currently processing element is a delimiter or not
            if (currentlyProcessingArrayElement != delimiter)
            {
                if (firstElementOfSequenceHasPrinted)
                {
                    // if the first element of sequence is already printed
                    // and we're printing the second (third, and so forth) element of the array
                    // we're printing a comma with space before the element, to delimit it from the
                    // previously printed element of the same sequence
                    Console.Write($", {currentlyProcessingArrayElement}");
                }
                else
                {
                    // if we're printing the first element in the sequence
                    // we just setting flag to true, and printing just the first element in the sequence 
                    firstElementOfSequenceHasPrinted = true;
                    Console.Write(currentlyProcessingArrayElement);
                }
            }
            else
            {
                // printing new line after printed sequence values
                Console.WriteLine();

                // new line started for the new sequence,
                // so, we're resetting firstElementOfSequenceHasPrinted flag
                // as there are no elements printed for the new sequence yet
                firstElementOfSequenceHasPrinted = false;
            }
        }

        // printing new line after all printed sequences, to move cursor to the new line
        Console.WriteLine();
    }
}