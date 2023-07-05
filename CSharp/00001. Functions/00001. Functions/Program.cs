// This lesson demonstrates the declaration and use of functions with and without parameters, returning and not returning a value.


Console.WriteLine("Hello!");
Console.WriteLine("This lesson will show you how to declare and call functions");

Console.WriteLine("============= Getting a random integer number =============");

int randomIntValue = getRandomInt();

Console.WriteLine($"Random integer value = {randomIntValue}");
Console.WriteLine("===========================================================");

// this function does not take any parameters (arguments)
// and returns random number
int getRandomInt()
{
    Random randomNumberGenerator = new();
    int randomNumber = randomNumberGenerator.Next();

    return randomNumber;
}

Console.WriteLine("================= Summing two numbers =====================");

int firstArgumentForSum = 11;
int secondArgumentForSum = 28;
int sumResult = sum(firstArgumentForSum, secondArgumentForSum);

Console.WriteLine($"First argument: {firstArgumentForSum}");
Console.WriteLine($"Second argument: {secondArgumentForSum}");
Console.WriteLine($"Sum result: {sumResult}");
Console.WriteLine("===========================================================");

// this function takes two integer parameters (arguments) and returns an integer value containing their sum
int sum(int a, int b)
{
    int result = a + b;
    return result;
}

Console.WriteLine("=============== Subtracting two numbers ===================");

int firstArgumentForSubtraction = 15;
int secondArgumentForSubtraction = 23;
int subtractionResult = subtract(firstArgumentForSubtraction, secondArgumentForSubtraction);

Console.WriteLine($"First argument: {firstArgumentForSubtraction}");
Console.WriteLine($"Second argument: {secondArgumentForSubtraction}");
Console.WriteLine($"Sum result: {subtractionResult}");
Console.WriteLine("===========================================================");

// this function takes two integer parameters (arguments) and returns an integer value
// containing the results of subtracting the second parameter from the first.
int subtract(int a, int b)
{
    int result = a - b;
    return result;
}

Console.WriteLine("======== Calling void method without arguments ============");

calculateAnDisplayResults();

Console.WriteLine("===========================================================");

// this function (method) does not take any parameters (arguments) and does not return a value.
// all calculations are being done inside of this function and result is displayed on the screen.
void calculateAnDisplayResults()
{
    int d = 10;
    int e = 20;
    int f = sum(d, e);

    int g = 40;
    int h = subtract(f, g);

    Console.WriteLine($"sum result f = {f}");
    Console.WriteLine($"subtraction result h = {h}");
}