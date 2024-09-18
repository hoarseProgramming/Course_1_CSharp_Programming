char myChar = 'x';
char newLine = '\n';
char unicode = '\u0041';

Console.WriteLine($"{myChar} {newLine} {unicode} {(uint)unicode} {(char)66} ");

for (int i = 65; i < 65 + 26; i++)
{
    Console.Write((char)i);
}