using L018_Library;

Cat myCat = new() { Name = "Misse" };
Cat myOtherCat = new() { Name = "Kisse" };
CatMethods.Drink(myCat);

//Extension methods
myCat.Drink();
myCat.Hug(myOtherCat);
Console.WriteLine(myCat.CompareCats(myOtherCat));

//Lecture Exercise

Console.WriteLine("Hello World".Encapsulate("!@!"));
Console.WriteLine("Hello World".Encapsulate("<<", ">>"));

static class CatMethods
{
    public static void Drink(Cat cat)
    {
        Console.WriteLine($"{cat.Name} is drinking.");
    }
}

static class CatExtensions
{
    public static void Drink(this Cat cat)
    {
        Console.WriteLine($"{cat.Name} is drinking.");
    }
    public static void Hug(this Cat c1, Cat c2)
    {
        Console.WriteLine($"{c1.Name} hugs {c2.Name}");
    }
    public static string CompareCats(this Cat c1, Cat c2)
    {
        if (c1.Name[0] == c2.Name[0])
        {
            return $"{c1.Name} and {c2.Name}s names begins with the same letter!";
        }
        else
        {
            return $"{c1.Name} and {c2.Name}s names don't begin with the same letter!";
        }
    }
}
/* Put this code in L018_Library to demonstrate class library project
static class StringExtensions
{
    public static string Encapsulate(this string stringToEncapsulate, string encapsulation)
    {
        return $"{encapsulation}{stringToEncapsulate}{encapsulation}";
    }
}
*/
class Cat
{
    public string Name { get; set; }
}