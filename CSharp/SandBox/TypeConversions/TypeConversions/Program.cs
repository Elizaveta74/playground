string someStringValue = "45";

// this approach will crash the application if someStringValue cannot be converted to int
// You can try it by replacing someStringValue with a non-numeric value and running the program.
int someStringValueConvertedToInt = int.Parse(someStringValue);

// adding 4 to converted value and displaying the result
int summedValues = someStringValueConvertedToInt + 4;
Console.WriteLine($"Increased the converted value by 4 and get: {summedValues}");

// int.Parse() is ok in cases where the data you are processing is 100% correct
// in cases where you are processing user input, or input from external files, and additional verification is required
// then use int.TryParse()

string anotherStringValue = "abc";
int anotherStringValueConvertedToInt;

// below it is not necessary to compare TryParse return value with true
// because it already returns a boolean value (true or false)
// you can use:
// if (int.TryParse(anotherStringValue, out anotherStringValueConvertedToInt))
if (int.TryParse(anotherStringValue, out anotherStringValueConvertedToInt) == true)
{
    Console.WriteLine($"Conversion succeed. Adding 1 to converted value, and the sum is {anotherStringValueConvertedToInt + 1}");
}
else
{
    Console.WriteLine($"Conversion failed, value you provided cannot be convered to int number: {anotherStringValue}");
}
