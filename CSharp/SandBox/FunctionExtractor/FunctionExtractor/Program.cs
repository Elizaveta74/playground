// Simplify the code below via extracting repeating parts to functions

Console.WriteLine("================= BEGIN OF DATA BLOCK =================");
Console.WriteLine("Apple");
Console.WriteLine("================== END OF DATA BLOCK ==================");
Console.WriteLine("================= BEGIN OF DATA BLOCK =================");
Console.WriteLine("Pear");
Console.WriteLine("================== END OF DATA BLOCK ==================");
Console.WriteLine("================= BEGIN OF DATA BLOCK =================");
Console.WriteLine("Mango");
Console.WriteLine("================== END OF DATA BLOCK ==================");
Console.WriteLine("================= BEGIN OF DATA BLOCK =================");
Console.WriteLine("Mulberry");
Console.WriteLine("================== END OF DATA BLOCK ==================");
Console.WriteLine("================= BEGIN OF DATA BLOCK =================");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("================== END OF DATA BLOCK ==================");
Console.WriteLine("================= BEGIN OF DATA BLOCK =================");
for (int i = 0; i < 13; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("================== END OF DATA BLOCK ==================");

int sum = 0;
Console.WriteLine("================= BEGIN OF DATA BLOCK =================");
for (int i = 0; i < 15; i++)
{
    sum = sum + i;
}
Console.WriteLine($"sum = {sum}");
Console.WriteLine("================== END OF DATA BLOCK ==================");

sum = 0;
Console.WriteLine("================= BEGIN OF DATA BLOCK =================");
for (int i = 0; i < 278; i++)
{
    sum = sum + i;
}
Console.WriteLine($"sum = {sum}");
Console.WriteLine("================== END OF DATA BLOCK ==================");