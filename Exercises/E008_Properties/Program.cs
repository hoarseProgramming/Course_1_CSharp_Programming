//Exercises - Properties

//1 Add property firstName
Person hampus = new Person();

hampus.Firstname = "Hampus";
Console.WriteLine(hampus.Firstname);

//2 Add autoproperty LastName
hampus.LastName = "Eiderström Swahn";
Console.WriteLine(hampus.LastName);

//3 Add Read-only property FullName
Console.WriteLine(hampus.FullName);

//4 Create StepCounter class
StepCounter myStepCounter = new();

for (int i = 0; i < 1000; i++)
{
    myStepCounter.Step();
}

Console.WriteLine(myStepCounter.Steps);
myStepCounter.Reset();
Console.WriteLine(myStepCounter.Steps);

//5 Create Car Class
Car mazda = new Car("Mazda", 20000, "Red");
Console.WriteLine($"");

class Person
{
    private string _firstName;
    public string Firstname
    {
        get
        {
            return _firstName;
        }
        set
        {
            _firstName = value;
        }
    }
    public string LastName { get; set; }

    public string FullName
    {
        get
        {
            return $"{this.Firstname} {this.LastName}";
        }
    }
}

class StepCounter
{
    private int _steps = 0;
    public int Steps
    {
        get
        {
            return _steps;
        }
    }
    public void Step()
    {
        _steps++;
    }
    public void Reset()
    {
        _steps = 0;
    }
}

class Car
{
    private string _model;

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }
    private int _price;

    public int Price
    {
        get { return _price; }
        set { _price = value; }
    }
    private string _colour;

    public string Coloir
    {
        get { return _colour; }
        set { _colour = value; }
    }

    public Car()
    {
    }
    public Car(string model, int price, string colour)
    {
        _model = model;
        _price = price;
        _colour = colour;
    }


}