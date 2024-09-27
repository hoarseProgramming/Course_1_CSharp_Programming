

var cat = new Cat() { Name = "Mister Cat"};

cat.Run();
cat.Mew();
cat.Walk();

Console.WriteLine();

var dog = new Dog() { Name = "Missus Dog"};

dog.Run();
dog.Bark();
dog.Walk();

Console.WriteLine();

//Since both cats and dogs are animala, an animal reference can refer to both cats and dogs.
Animal catAsAnimal = new Cat() { Name = "Rugged" };

Animal[] animals = new Animal[]
{
    new Cat() {Name = "1" },
    new Dog() { Name = "2" },
    catAsAnimal
};
Console.WriteLine("*** foreach loop ***");
//This is only possible because the run and walk method is abstract/virtual. All animals
//will be able to run/walk, but, in this case, will do things differently.

//is + as keyword and how to use it
//Using the nullReference operator with as keyword
foreach (Animal animal in animals)
{
    animal.Run();
    animal.Walk();
    (animal as Dog)?.Bark();

    if (animal is Dog)
    {
        Dog doggy = (Dog)animal;
        doggy.Bark();
    }
    if (animal is Cat catty)
    {
        catty.Mew();
    }
    Console.WriteLine();
}

Console.WriteLine("*** Cast ***");

//Cast
Char myChar = 'A';
Console.WriteLine((int)myChar);

Animal myAnimal = new Cat() { Name = "Rolf" };
Cat myCat = (Cat)myAnimal;
myCat.Mew();



//Abstract classes can't have instances of it.
abstract class Animal
{
    //required = The required member must be declared when instanced.
    required public string Name { get; set; }
    //Abstract methods can't have a implementation of method in the class. They MUST be 
    //implemented in sub classes.
    public abstract void Run();
    //Virtual makes method overrideable.
    public virtual void Walk()
    {
        Console.WriteLine($"{Name} is walking.");
    }
}

class Cat : Animal
{

    public void Mew()
    {
        Console.WriteLine($"{Name}: Meow!");
    }
    //override = Make a implementation of abstract, virtual or overrided method
    public override void Run()
    {
        Console.WriteLine($"The cat {Name} is running!");
    }
    public override void Walk()
    {
        Console.WriteLine($"{Name} is walking like a cat.");
        base.Walk();
    }
}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name}: Woof!");
    }
    public override void Run()
    {
        Console.WriteLine($"The dog {Name} is running!");
    }
}
