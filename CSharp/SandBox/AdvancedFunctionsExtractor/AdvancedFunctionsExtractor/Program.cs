string text = "Science is what we understand well enough to explain to a computer, Art is all the rest. -Donald Knuth.";
int symbolsCount = 0;
char symbolToFind = ' ';
for (int i = 0; i < text.Length; i++)
{
    if (text[i] == symbolToFind)
    {
        symbolsCount++;
    }
}

string report = $"Total number of symbols `{symbolToFind}` in the text: \n {text} \n equals to {symbolsCount}";

Console.WriteLine(report);

text = "Without experimentation, a willingness to ask questions and try new things, we shall surely become static, repetitive, and moribund. - Anthony Bourdain";

symbolsCount = 0;
symbolToFind = 'x';
for (int i = 0; i < text.Length; i++)
{
    if (text[i] == symbolToFind)
    {
        symbolsCount++;
    }
}

report = $"Total number of symbols `{symbolToFind}` in the text: \n {text} \n equals to {symbolsCount}";

Console.WriteLine(report);