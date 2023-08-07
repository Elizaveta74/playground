// ===============================================
//              Function Declaration
// ===============================================
bool IsNumberEven(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool IsNumerEvenOptimizedWay(int number)
{
    return number % 2 == 0;
}

bool IsNumerEvenMoreOptimizedWay(int number)
{
    // checking if the first bit at the right side is set to 1
    // if it is not set, then the number is even, otherwise it is odd
    return (number & 1) == 0;
}

void PrintIsNumberEvenOrNot(int number)
{
    PrintLineSeparator();

    bool isNumberEvenGenericWay = IsNumberEven(number);
    bool isNumberEvenOptimizedWay = IsNumerEvenOptimizedWay(number);
    bool isNumberEvenMoreOptimizedWay = IsNumerEvenMoreOptimizedWay(number);

    Console.WriteLine($"Is number {number} even (generic way)? {isNumberEvenGenericWay}");
    Console.WriteLine($"Is number {number} even (optimized way)? {isNumberEvenOptimizedWay}");
    Console.WriteLine($"Is number {number} even (more optimized way)? {isNumberEvenMoreOptimizedWay}");

    PrintLineSeparator();
}

void PrintLineSeparator()
{
    Console.WriteLine();
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine();
}

// ==============================================


Console.WriteLine("Using int variable as a logical (boolean) flag");

int isDoorOpen = 0; // change "int isDoorOpen = 0;" to "int isDoorOpen = 1;" and relaunch app

if (isDoorOpen == 1)
{
    Console.WriteLine("We're inside!");
}
else
{
    Console.WriteLine("We're outside, because door is closed");
}

PrintIsNumberEvenOrNot(12);
PrintIsNumberEvenOrNot(13);
PrintIsNumberEvenOrNot(7);
PrintIsNumberEvenOrNot(8);

int someNumber = 20;
bool someFlag = IsNumberEven(someNumber);

// generic check
if (someFlag == true)
{
    Console.WriteLine($"[Generic if] Number {someNumber} checked and it is even");
}
else
{
    Console.WriteLine($"[Generic if] Number {someNumber} is odd");
}

// optimized check
if (someFlag)
{
    Console.WriteLine($"[Optimized if] Number {someNumber} checked and it is even");
}
else
{
    Console.WriteLine($"[Optimized if] Number {someNumber} is odd");
}

// =============================== 
PrintLineSeparator();
PrintLineSeparator();

Console.WriteLine("Checking even number presence in the someArray");

int[] someArray = { 9, 8, 7, 5, 4, 3 };
bool isEvenNumberPresentInArray = false; // it is on init stage

for (int i = 0; i < someArray.Length; i++)
{
    if (someArray[i] % 2 == 0)
    {
        isEvenNumberPresentInArray = true;
        break; // breaking the loop
    }
}

// generic if 
if (isEvenNumberPresentInArray == true)
{
    Console.WriteLine("[Generic if]  Even number present in someArray");
}
else
{
    Console.WriteLine("[Generic if] Even number is not present in someArray");
}

// optimized if 
if (isEvenNumberPresentInArray)
{
    Console.WriteLine("[Optimized if] Even number present in someArray");
}
else
{
    Console.WriteLine("[Optimized if] Even number is not present in someArray");
}

// ================================================

PrintLineSeparator();
PrintLineSeparator();

Console.WriteLine("Checking anotherArray contains only odd numbers");

int[] anotherArray = { 4, 8, 12, 6, 5, 10 };
bool doesArrayContainOnlyOddNumbers = true; // init stage

for (int i = 0; i < anotherArray.Length; i++)
{
    if (someArray[i] % 2 == 0)
    {
        doesArrayContainOnlyOddNumbers = false;
        break; // breaking the loop
    }
}

// generic if
if (doesArrayContainOnlyOddNumbers == true)
{
    Console.WriteLine("[Generic if] anotherArray contains only odd numbers");
}
else
{
    Console.WriteLine("[Generic if] anotherArray contains also even numbers too");
}

// optimized if
if (doesArrayContainOnlyOddNumbers)
{
    Console.WriteLine("[Optimized if] anotherArray contains only odd numbers");
}
else
{
    Console.WriteLine("[Optimized if] contains also even numbers too");
}