// This lesson demonstrates how to read user input from the console and print to the console.

Console.WriteLine("This text is printed and the cursor moves to the next line");

Console.Write("This text is printed and the cursor remains on the same line. ");
Console.Write("This text is printed on the same line as the previous text.");

// The following line of code does not print anything, it just moves the cursor to the next line.
Console.WriteLine();

Console.WriteLine("Press any key other than Shift, Alt or Control to continue ...");
Console.ReadKey();

Console.WriteLine();

Console.WriteLine("Press Enter to continue ...");
Console.ReadLine();

Console.WriteLine("Press Enter to clear the window...");
Console.ReadLine();
Console.Clear();

Console.Write("Enter any text and press Enter: ");
var enteredText = Console.ReadLine();
Console.WriteLine($"You have entered: {enteredText}");

Console.WriteLine("Type a letter and press Enter ...");
int letterCode = Console.Read();
Console.WriteLine($"You have typed a letter with a code: {letterCode}");
