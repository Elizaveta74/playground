// This lesson demonstrates the declaration and use of functions with and without parameters, returning and not returning a value.

// ===================== HERE WE DECLARE ALL FUNCTIONS THAT WE NEED ============================

// this function does not take any parameters (arguments)
// and returns an integer value
int GetSomeIntValue()
{
    const int someValue = 42;
    return someValue;
}


// this function takes two integer parameters (arguments) and returns an integer value containing their sum
int Sum(int a, int b)
{
    int result = a + b;
    return result;
}


// this function takes two integer parameters (arguments) and returns an integer value
// containing the results of subtracting the second parameter from the first.
int Subtract(int a, int b)
{
    int result = a - b;
    return result;
}


// this function (method) does not take any parameters (arguments) and does not return a value.
// all calculations are being done inside of this function and result is displayed on the screen.
void CalculateAnDisplayResults()
{
    int d = 10;
    int e = 20;
    int f = Sum(d, e);

    int g = 40;
    int h = Subtract(f, g);

    Console.WriteLine($"sum result f = {f}");
    Console.WriteLine($"subtraction result h = {h}");
}


// this function returns tuple (readonly array) with 2 variables
// one (someNumber) contains an int number
// another (text) contains text
// this function takes one parameter, initialText
(int someNumber, string text) GetIntValueAlongWithTextValue(string initialText)
{
    // calling function, declared before (check line #7)
    int someIntNumber = GetSomeIntValue();

    string processedText = $"AAAAAAAAA__{initialText}";

    return (someIntNumber, processedText);
}

// ==============================================================================================

// ==================== AND BELOW, WE'RE CALLING THE FUNCTIONS DECLARED ABOVE ====================

Console.WriteLine("Hello!");
Console.WriteLine("This lesson will show you how to declare and call functions");

Console.WriteLine("============= Getting a random integer number =============");

int randomIntValue = GetSomeIntValue();

Console.WriteLine($"Random integer value = {randomIntValue}");
Console.WriteLine("===========================================================");

Console.WriteLine("================= Summing two numbers =====================");

int firstArgumentForSum = 11;
int secondArgumentForSum = 28;
int sumResult = Sum(firstArgumentForSum, secondArgumentForSum);

Console.WriteLine($"First argument: {firstArgumentForSum}");
Console.WriteLine($"Second argument: {secondArgumentForSum}");
Console.WriteLine($"Sum result: {sumResult}");
Console.WriteLine("===========================================================");

Console.WriteLine("=============== Subtracting two numbers ===================");

int firstArgumentForSubtraction = 15;
int secondArgumentForSubtraction = 23;
int subtractionResult = Subtract(firstArgumentForSubtraction, secondArgumentForSubtraction);

Console.WriteLine($"First argument: {firstArgumentForSubtraction}");
Console.WriteLine($"Second argument: {secondArgumentForSubtraction}");
Console.WriteLine($"Sum result: {subtractionResult}");
Console.WriteLine("===========================================================");

Console.WriteLine("======== Calling void function without arguments ============");

CalculateAnDisplayResults();

Console.WriteLine("===========================================================");

Console.WriteLine("======== Calling function with one argument and returns tuple ============");

string someInitialText = "BBBBBBBBBBB";
Console.WriteLine($"We're passing this text as parameter: {someInitialText}");

(int someIntValue, string processedText) = GetIntValueAlongWithTextValue(someInitialText);

Console.WriteLine($"someInitialText = {someInitialText}");
Console.WriteLine($"An integer value returned by function: {someIntValue}");
Console.WriteLine($"String value returned by function: {processedText}");

Console.WriteLine("==========================================================================");
