//Iterationer, Loopar

//while
int x = 1;

while (x <= 10)
{
    Console.WriteLine(x++);
}

Console.WriteLine();

//do-while
x = 10;

do
{
    Console.WriteLine(x++);
} while (x <= 10);

Console.WriteLine();

//for-loop
//continue: stanna nuvarande iteration i loopen, kör nästa iteration.
//break: Avbryt loopen, hoppa ur loopen och fortsätt neråt.

for (int i = 1; i <= 10; i++)
{
    if (i == 5) continue;
    Console.WriteLine(i);
}

Console.WriteLine();

for (int i = 1; i <= 10; i++)
{
    if (i == 5) break;
    Console.WriteLine(i);
}

//Nästlad for-loop

for (int i = 0; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}