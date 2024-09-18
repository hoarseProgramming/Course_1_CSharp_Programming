//Constructor 
//The constructor of the class. Constructor method.
//Default constructor.

//Keyword new calls upon the constructor of a class,
//which creates an object and returns a reference to the object.

//Different ways to create object
Cat myCat = Cat.CreateObject();
var myOtherCat = new Cat("Gugge");
Cat myThirdCat = new("Gugge", 6);

Console.WriteLine($"Hi my name is {myCat.name} and I'm {myCat.age} years old.");
Console.WriteLine($"Hi my name is {myOtherCat.name} and I'm {myOtherCat.age} years old.");
Console.WriteLine($"Hi my name is {myThirdCat.name} and I'm {myThirdCat.age} years old.");
Console.WriteLine(Cat.numberOfCats);
class Cat
{
    public string name = "Default name";

    public int age = 0;
    //Constructors can work with private fields.
    private bool isHungry;

    public static int numberOfCats = 0;

    public static Cat CreateObject()
    {
        return new Cat();
    }

    //Constructor, called the same as the class.
    //If you make your own constructor, it will replace the default constructor
    private Cat()
    {
        //private constructor, must be called upon from static method
        //Some logic can only(?) be accomplished by using private constructor
        numberOfCats++;
        this.name = "Mimmi";
        this.age = 5;
    }
    //You can method overload constructors.
    public Cat(string name)
    {
        this.name = name;
        this.isHungry = false;
    }
    public Cat(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}