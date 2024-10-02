//Interface

Dog[] dogs =
{
    new Dog() { Name = "Dog4"},
    new Dog() { Name = "Dog3"},
    new Dog() { Name = "Dog2"},
    new Dog() { Name = "Dog1"}
};

int[] ints = { 5, 4, 3, 7, 8, 9 };

Array.Sort(ints);
Array.Sort(dogs);

List<Dog> doggies = new List<Dog> { new Dog() };



using (var dog = new Dog())
{
    Console.WriteLine("Dog!");
}

Console.WriteLine("The end!");


class Dog : IDisposable, IDog, IComparable<Dog>
{
    public string Name { get; set; }

    public int CompareTo(Dog? other)
    {
        return this.Name.CompareTo(other.Name);
    }

    public void Dispose()
    {
        Console.WriteLine("Disposed");
    }
    public override string ToString()
    {
        return Name;
    }
}

interface IDog
{
    public string Name { get; set; }
}




