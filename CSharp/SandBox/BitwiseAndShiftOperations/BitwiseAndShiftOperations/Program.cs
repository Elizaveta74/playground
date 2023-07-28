// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators

// ======================== FUNCTION DECLARATION BLOCK START =====================

void PrintDecimalAndBinaryValues(string prompt, uint numericValue)
{
    Console.WriteLine($"------ {prompt} ---------");
    Console.WriteLine($"decimal value: {numericValue}");

    string binaryRepresentation = ConvertIntToBinaryString(numericValue);
    Console.WriteLine($"the same value in binary representation: {binaryRepresentation}");
    Console.WriteLine($"---------------------------");
}

string ConvertIntToBinaryString(uint intValue)
{
    return Convert.ToString(intValue, 2);
}

// ======================== FUNCTION DECLARATION BLOCK END =========================

// ======================== CALLING DECLARED FUNCTIONS BELOW THIS POINT ============

uint myNumericVar = 5;

PrintDecimalAndBinaryValues("myNumericVar", myNumericVar);

uint valueShiftedLeft = myNumericVar << 1;

PrintDecimalAndBinaryValues("valueShiftedLeft", valueShiftedLeft);

uint valueShiftedRight = myNumericVar >> 1;

PrintDecimalAndBinaryValues("valueShiftedRight", valueShiftedRight);

Console.WriteLine("\n");

uint firstOperand = 11;
uint secondOperand = 12;

string firstOperandAsBinaryString = ConvertIntToBinaryString(firstOperand);
string secondOperandAsBinaryString = ConvertIntToBinaryString(secondOperand);

uint bitwiseAndResult = firstOperand & secondOperand;
string bitwiseAndResultAsBinaryString = ConvertIntToBinaryString(bitwiseAndResult);


Console.WriteLine($"firstOperand: {firstOperand},\tbinary representation: {firstOperandAsBinaryString}");
Console.WriteLine($"secondOperand: {secondOperand},\tbinary representation: {secondOperandAsBinaryString}");
Console.WriteLine($"bitwiseAndResult: {bitwiseAndResult},\tbinary representation: {bitwiseAndResultAsBinaryString}");

Console.WriteLine("\n");

uint bitwiseOrResult = firstOperand | secondOperand;
string bitwiseOrResultAsBinaryString = ConvertIntToBinaryString(bitwiseOrResult);

Console.WriteLine($"firstOperand: {firstOperand},\tbinary representation: {firstOperandAsBinaryString}");
Console.WriteLine($"secondOperand: {secondOperand},\tbinary representation: {secondOperandAsBinaryString}");
Console.WriteLine($"bitwiseOrResult: {bitwiseOrResult},\tbinary representation: {bitwiseOrResultAsBinaryString}");

Console.WriteLine("\n");

uint bitwiseXOrResult = firstOperand ^ secondOperand;
string bitwiseXOrResultAsBinaryString = ConvertIntToBinaryString(bitwiseXOrResult);

Console.WriteLine($"firstOperand: {firstOperand},\tbinary representation: {firstOperandAsBinaryString}");
Console.WriteLine($"secondOperand: {secondOperand},\tbinary representation: {secondOperandAsBinaryString}");
Console.WriteLine($"bitwiseXOrResult: {bitwiseXOrResult},\tbinary representation: {bitwiseXOrResultAsBinaryString}");

Console.WriteLine("\n");

uint bitwiseNotResult = ~firstOperand;
string bitwiseNotResultAsBinaryString = ConvertIntToBinaryString(bitwiseNotResult);
Console.WriteLine($"firstOperand: {firstOperand},\t\tbinary representation: {firstOperandAsBinaryString}");
Console.WriteLine($"bitwiseNotResult: {bitwiseNotResult},\tbinary representation: {bitwiseNotResultAsBinaryString}");