//OOP Intro

//Make object (new instance of Cat), myCat = reference to a object.
Cat myCat = new Cat();
Cat myOtherCat = new Cat();
//Reference to the object of myCat
Cat myThirdCat = myCat;

//Define object field "name"
myCat.name = "Hampi";
myOtherCat.name = "Julki";
//Will change name of myCat, since myThirdCat is pointing to the same refrence.
myThirdCat.name = "Gugge";

//Define age
myCat.age = 5;
myOtherCat.age = 10;

//More convenient way of doing it
Cat myFourthCat = new Cat() { name = "Papi", age = 5 };


Console.WriteLine($"{myCat.name} is {myCat.age} years old.");
Console.WriteLine($"{myOtherCat.name} is {myOtherCat.age} years old.");
Console.WriteLine(myThirdCat.name);
Console.WriteLine($"{myFourthCat.name} is {myFourthCat.age} years old.");

//Array of cat references
Cat[] cats = new Cat[] { myCat, myOtherCat, myThirdCat, myFourthCat };

foreach (Cat cat in cats)
{
    Console.WriteLine($"{cat.name} is {cat.age} years old");
}

Console.WriteLine("*******************************");

//Call for methods of cat object 
foreach (Cat cat in cats)
{
    cat.Greet();
}

myCat.Greet();
myCat.Greet("Hampus");
myCat.Greet(myOtherCat);

Console.WriteLine(myCat.GetDoubleAge());

//Miniexcersise
/* Make array with 100 cats 
 * Name "Katt1", "Katt2 osv
 * Age: "1 år gammal", "2 år gammal" osv
 */
Cat[] hundredCats = new Cat[100];

for (int i = 0; i < hundredCats.Length; i++)
{
    hundredCats[i] = new Cat { name = $"Katt {i}", age = i };
}
 
//Define class
class Cat
{
    public int age = 0;

    public string name = "Default name";

    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {name}!");
    }
    //Method overloading
    public void Greet(string name)
    {
        //This keyword - reference to the current object
        Console.WriteLine($"Hello {name}, my name is {this.name}!!!");
    }
    public void Greet(Cat cat)
    {
        Console.WriteLine($"Hello {cat.name}, my name is {this.name}!!!");
    }

    public int GetDoubleAge()
    {
        return age * 2;
    }
}


