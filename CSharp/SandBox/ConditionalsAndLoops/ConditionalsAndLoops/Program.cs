Console.WriteLine("============ Conditionals ====================");

int a = 1;
int b = 11;

Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");

if (a > b)
{
    Console.WriteLine("a is greater than b");
}
else
{
    Console.WriteLine("a is not greater than b");
}

int c = 100;
int d = 100;

Console.WriteLine($"c = {c}");
Console.WriteLine($"d = {d}");

if (c == d)
{
    Console.WriteLine("c is equal to d");
}
else
{
    Console.WriteLine("c is not equal to d");
}

bool ab = a == b;
Console.WriteLine($"a equals to b is {ab}");

bool cd = c == d;
Console.WriteLine($"c equals to d is {cd}");

Console.WriteLine("----------------------------");

Console.WriteLine("Example of ternary if");
string checkResult = c > 50 ? "c is greater than 50" : "c is NOT greater than 50";
Console.WriteLine($"c = {c}");
Console.WriteLine($"checkResult = {checkResult}");

Console.WriteLine("============ Loops ====================");

Console.WriteLine("for-loop for [1; 5]");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("---------------------------------");

Console.WriteLine("for-loop for [1; 7] but skipping 6");
for (int i = 1; i <= 7; i++)
{
    if (i == 6)
    {
        continue;
    }

    Console.WriteLine(i);
}

Console.WriteLine("---------------------------------");

Console.WriteLine("for-loop for [1; 9] but breaking the loop at i==4");
for (int i = 1; i <= 9; i++)
{
    if (i == 4)
    {
        break;
    }

    Console.WriteLine(i);
}

Console.WriteLine("---------------------------------");
Console.WriteLine("while-loop for [1; 5]");
int index = 1;
while (index <= 5)
{
    Console.WriteLine(index);
    index++; // it is the same as index = index + 1
}

Console.WriteLine("---------------------------------");
Console.WriteLine("while-loop for [1; 7] but skipping 6");
index = 1;
while (index <= 7)
{
    if (index == 6)
    {
        index++;
        continue; // it is the same as index = index + 1   
    }

    Console.WriteLine(index);
    index++; // it is the same as index = index + 1    
}

Console.WriteLine("---------------------------------");

Console.WriteLine("while loop for [1; 9] but breaking the loop at index==4");
index = 1;
while (index <= 9)
{
    if (index == 4)
    {
        break;
    }

    Console.WriteLine(index);
    index++; // it is the same as index = index + 1    
}

Console.WriteLine("---------------------------------");

Console.WriteLine("do-while-loop for [1; 5]");
index = 1;
do
{
    Console.WriteLine(index);
    index++; // it is the same as index = index + 1
} while (index <= 5);

Console.WriteLine("---------------------------------");

Console.WriteLine("do-while-loop for [1; 7] but skipping 6");
index = 1;
do
{
    if (index == 6)
    {
        index++;
        continue; // it is the same as index = index + 1   
    }

    Console.WriteLine(index);
    index++; // it is the same as index = index + 1    
} while (index <= 7);

Console.WriteLine("---------------------------------");

Console.WriteLine("do-while loop for [1; 9] but breaking the loop at index==4");
index = 1;
do
{
    if (index == 4)
    {
        break;
    }

    Console.WriteLine(index);
    index++; // it is the same as index = index + 1    

} while (index <= 9);

Console.WriteLine("---------------------------------");
