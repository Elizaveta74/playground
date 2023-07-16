// Constant declaration
// This value cannot be changed after the first assignment
const int constantIntValue = 120;

// Variable declaration
// This value CAN be changed after the first assignment
int variableIntValue = 700;

// Array declaration
// It is only declaration, memory for this array is not allocated yet.
int[] integerArray;

// Array declaration + memory allocation
// The following declaration declares an int array and allocates memory for 3 elements of this int array
// These elements will have indexes: 0, 1 and 2
// At the moment of declaration and allocation, all int elements of this array will be equal to 0
int[] anotherIntegerArray = new int[3];

// Array declaration
// This is array declaration + memory allocation + initial assignment
// The following line of code declares an int array with 4 elements and assigns a value to each element
int[] integerArrayLiteral = { -10, 20, -30, 40 };


// Plain and simple condition
int a = 10;
int b = 30;

if (a > b)
{
    // do something if a > b
}
else
{
    // do something if a is not > b (i.e a <= b)
}

// for-loop example
for (int i = 0; i < 10; i++)
{
    // this loop does 10 iterations, for i = 0, 1, 2, 3, 4, 5, 6, 7, 8, 9

    // "int i = 0" - is initial loop state
    // "i < 10" - if this condition is true, loop continues
    // i++ - increases i to 1, equal to expression: i = i + 1

}

// while loop example
int someValue = 3;
while (someValue > 0)
{
    someValue--; // this expression means: someValue = someValue - 1

    // this loop does 3 iterations for someValue = 3, 2, 1
}

// do-while loop example
int someNumber = 2;
do
{
    someNumber++;
    // this loop will make 3 iterations for someNumber = 3, 4 and 5
    // please note even someNumber = 5 the loop does the iteration
    // because we check the confition "someNumber < 5" at the end of every iteration

} while (someNumber < 5);


// the following line of code prints "Hello there :) Press Enter please" on the screen
Console.WriteLine("Hello there :) Press Enter please");

// the following line of code waits until user presses Enter
Console.ReadLine();

// the following lines of code, print text "Please type some text and press Enter: "
// and then retrieve the input as a text value from the keyboard and store it in the string variable
Console.Write("Please type some text and press Enter: ");
string someStringValue = Console.ReadLine();

// the following line of code prints value, stored to someStringValue
Console.WriteLine(someStringValue);

// string interpolation
// you can include variables inside strings using the following approach
string partOfString = "value is"; // arbitrary text here
int someValueForInterpolatedString = 40; // arbitrary value here
string resultString = $"According to calculations {partOfString} {someValueForInterpolatedString}";

// the following line of code prints interpolated string to the screen (console)
Console.WriteLine(resultString);