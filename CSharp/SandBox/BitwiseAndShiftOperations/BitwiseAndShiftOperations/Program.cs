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

string ConvertByteToBinaryString(byte intValue)
{
    return Convert.ToString(intValue, 2).PadLeft(8, '0');
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

Console.WriteLine("\n");

/**
    Bitwise operations are sometimes used to wrap a group of logical flags (bits) into a single value. 
    The presence of bit 1 means true and the presence of bit 0 means false. And 8 logical flags (bits) 
    can be packed into one byte in this way.
 */

// all 8 flags are set to false: 00000000
// bit positions are counting from right to left
byte allFlags = 0;

// setting the second, third forth bits to 1
// it is a bit-mask to be used for this task
const byte bitMaskForSecondThirdAndForthBits = 0b00001110;
string bitMaskForSecondThirdAndForthBitsBinaryRepresentationString = ConvertIntToBinaryString(bitMaskForSecondThirdAndForthBits);

Console.WriteLine($"Setting bit mask: '{bitMaskForSecondThirdAndForthBitsBinaryRepresentationString}' ({bitMaskForSecondThirdAndForthBits}) to 00000000 (allFlags)");

allFlags |= bitMaskForSecondThirdAndForthBits;

string allFlagsBinaryRepresentationString = ConvertIntToBinaryString(allFlags);
Console.WriteLine($"bit-mask has set, allFlags = {allFlags},\tbinary representation: {allFlagsBinaryRepresentationString}");

Console.WriteLine("\n");

Console.WriteLine($"Clearing second bit for {allFlags},\t\tbinary representation: {allFlagsBinaryRepresentationString}");

// clearing second bit in allFlags byte value
const byte bitMaskToClearSecondBit = 0b11111101;

allFlags &= bitMaskToClearSecondBit;

allFlagsBinaryRepresentationString = ConvertIntToBinaryString(allFlags);
Console.WriteLine($"Second bit cleared, allFlags = {allFlags},\tbinary representation: {allFlagsBinaryRepresentationString}");

Console.WriteLine("\n");

Console.WriteLine($"Checking third bit is set or not for allFlags = {allFlags},\tbinary representation: {allFlagsBinaryRepresentationString}");

// checking third bit set or not
byte maskToCheckThirdBitSet = 0b00000100;

if ((allFlags & maskToCheckThirdBitSet) != 0)
{
    Console.WriteLine($"allFlags has 3-rd bit set.\t\t\t\tbinary representation: {allFlagsBinaryRepresentationString}");
}
else
{
    Console.WriteLine($"allFlags has 3-rd bit NOT set\t\t\t\tbinary representation: {allFlagsBinaryRepresentationString}");
}

Console.WriteLine("\n");

// checking a group of set bits at once (we'll check first, second and fifth bits are set to 1)
byte eightFlags = 0b01010111; // the place where we'll check bits
byte maskToApplyToEightFlagsVariable = 0b00010011;

Console.WriteLine($"eightFlags:\t\t\t{ConvertByteToBinaryString(eightFlags)}");
Console.WriteLine($"The mask to be used:\t\t{ConvertByteToBinaryString(maskToApplyToEightFlagsVariable)}");

// applying mask to the flags variable
if ( (eightFlags & maskToApplyToEightFlagsVariable) == maskToApplyToEightFlagsVariable)
{
    Console.WriteLine("CHECK RESULT: first, second and fifth bits are set to 1 together");
}
else
{
    Console.WriteLine("CHECK RESULT: first, second and fifth bits are NOT set to 1 together");
}

