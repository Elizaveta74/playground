// using namespace with necessary functionality
using System.Text;

// iterating over string characters

string someString = "Hello there, it is a some string value";

// A string can be considered as an array of characters and can be processed like an array

Console.WriteLine("******* START OF THE STRING ************");
for(int i = 0; i < someString.Length; i++)
{
    char currentProcessingCharacter = someString[i];
    Console.WriteLine(currentProcessingCharacter);
}
Console.WriteLine("********* END OF THE STRING **************");

// *********** getting substring from a string ***********

// this call gets "Hello" substring from someString value
string substring = someString.Substring(startIndex: 0, length: 5);
Console.WriteLine($"(Using 'Substring()' method): Getting substring from index = 0 with length = 5, result = '{substring}'");

string substringUsingRangeOperator = someString[..5];
Console.WriteLine($"(Using range operator): Getting substring from index = 0 with length = 5, result = '{substringUsingRangeOperator}'");

// ==== concatenate strings ======
string part1 = "this is the first part";
string part2 = "this is the second part";

// plain simple way
string composedString1 = part1 + ", " + part2;

Console.WriteLine($"composed string #1 = '{composedString1}'");

Console.WriteLine("--------------------------------------------------------------");

// interpolated string
string composedString2 = $"{part1}, {part2}";

Console.WriteLine($"composed string #2 = '{composedString2}'");

Console.WriteLine("--------------------------------------------------------------");

// Using StringBuilder (use it when you build string in a loop)
StringBuilder sb = new();

string allSymbols = "*Apples,*Oranges,*Kiwis,*Peas,*Mangos";
char symbolToSkip = '*';
for(int i = 0; i < allSymbols.Length; i++)
{
    // skipping the * symbol
    if (allSymbols[i] != symbolToSkip)
    {
        sb.Append(allSymbols[i]);
    }
}

string composedString3 = sb.ToString();

Console.WriteLine($"Removed the symbol `{symbolToSkip}` from the string `{allSymbols}`, result is `{composedString3}`");

Console.WriteLine("--------------------------------------------------------------");

// *********** getting index of the substring in a string ***********
string sampleString = "Hello, it is a sample string, la-la-laaaaa!!!!";

int sampleSubstringIndex = sampleString.IndexOf("sample");

if (sampleSubstringIndex == -1)
{
    // if substring not found, index will be = -1
    // should not happen :)
    Console.WriteLine($"Substring 'sample' not found in the string '{sampleString}'");
}
else
{
    // if substring found
    Console.WriteLine($"Index of 'sample' substring in the string `{sampleString}` is {sampleSubstringIndex}");

    // get substring from the found index to the end of the string
    string substringToTheEndOfString = sampleString.Substring(sampleSubstringIndex);
    Console.WriteLine($"Substring from found index to the end of the string: '{substringToTheEndOfString}'");

    // get substring from the found index with 4 symbols length
    string substringWithFourSymbolsLength = sampleString.Substring(sampleSubstringIndex, 4);
    Console.WriteLine($"Substring from found index with 4 symbols length: '{substringWithFourSymbolsLength}'");
}

Console.WriteLine("--------------------------------------------------------------");

// to check if string is empty or contains only whitespace symbols, use string.IsNullOrWhiteSpace()
string anotherString = "      ";
if (string.IsNullOrWhiteSpace(anotherString))
{
    Console.WriteLine("anotherString is empty or contains only whitespace symbols");
}
else
{
    Console.WriteLine("anotherString is NOT empty");
}

Console.WriteLine("--------------------------------------------------------------");

// More info on string operations: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/