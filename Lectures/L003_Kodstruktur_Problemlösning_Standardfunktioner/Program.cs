// Föreläsning 3 = Grundläggande C#

//Code Snippets

// cw = Console.WriteLine();
// for = forloop

//If-else-statements
int x = 0;

if (x > 1) //true eller false. Om true körs kodblocket.
{
    Console.WriteLine("Hello World!");
}
else if (x < 1) //Om inte första if är sant, men detta är sant så körs kodblocket.
{
    Console.WriteLine("Hello Zoomer.");
}
else // Om if-statement, eller else-if-statement är false körs else
{
    Console.WriteLine("Hello Boomer");
}
Console.WriteLine();

// Kan köra ett enkelt statement utan måsvingar.
if (true) Console.WriteLine("Hello World!");

Console.WriteLine();

//Ternary operator

Console.WriteLine(true ? "Japp!" : "Nope!"); //Gör det ena eller andra, förminskad if-sats.

x = 5;
int y = x < 10 ? 5 : 8; // Är x mindre än tio så blir y 5, annars blir y 8.

Console.WriteLine(y); // Utslag = 5

int numberOfPeople = 1;
Console.WriteLine($"{numberOfPeople} person{(numberOfPeople == 1 ? "" : "er")}");