//OOP - Constructor, Properties

//Static classes and members

// Static member or class. It's not a member of an instance of cat. But instead
// a member of the class.

// Objects can read static methods or members. Static members can't read objects.

Cat myCat = new Cat() { name = "Blixten" };

Cat.staticName = "Static name";
myCat.Greet();
Cat.Hello();
Cat.PrintNumberOfLives();

class Cat
{
    public static int numberOfLives = 9;
    public string name;
    public static string staticName;
    public void Greet()
    {
        Console.WriteLine($"Hi! My name is {name} and i have {numberOfLives} lives!");
    }
    public static void Hello()
    {
        Console.WriteLine($"Hello! I'm {staticName}");
    }
    public static void PrintNumberOfLives()
    {
        Console.WriteLine($"Every cat has {numberOfLives} lives");
    }
}
