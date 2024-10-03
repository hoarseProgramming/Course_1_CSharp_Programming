//Lambda expressions


//One way of writing methods, and using delegates

Func<int, int> square = Square;
Console.WriteLine(square(5));
static int Square(int a)
{
    return a * a;
}

//Lambda way
//ex 1
Console.WriteLine("*** Ex 1***");
Func<int, int> lambdaSquare = x => x * x;
Console.WriteLine(lambdaSquare(5));

Action<int> printInt = x => Console.WriteLine(x);
printInt(lambdaSquare(5));

//ex 2
Console.WriteLine("*** Ex 2***");
Person person = new Person() { Age = 15 };

Func<Person, int, bool> checkLegalAge = (Person, legalAge) => Person.Age >= legalAge;

Console.WriteLine(checkLegalAge(person, 18));

//ex 3
Console.WriteLine("*** Ex 3***");
PrintResult(x => x * 10, 5);
PrintResult(MultiplyByTen, 5);

static int MultiplyByTen(int x)
{
    return x * 10;
}
static void PrintResult(Func<int, int> func, int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i}: {func(i)}");
    }
    
}

class Person
{
    public int Age { get; set; }
}