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
Car mazda = new Car("Mazda", 19999, "Red");
Console.WriteLine($"Model = {mazda.Model}, Price = {mazda.Price}, Colour = {mazda.Colour}");
mazda.HalfPrice();
Console.WriteLine(mazda.Price);

//6 Create GlassOfWater class
GlassOfWater glass = new();
glass.BreakGlass();
glass.EmptyGlass();
glass.FillGlass();

//7 Blue & Red
BlueAndRed myBlueAndRed = new();
myBlueAndRed.Red = 20.2314;
Console.WriteLine($"myBlueAndRed.Blue = {myBlueAndRed.Blue}, myBlueAndRed.Red = {myBlueAndRed.Red}");

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

    private double _price;
    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }

    private string _colour;
    public string Colour
    {
        get { return _colour; }
        set { _colour = value; }
    }

    public void HalfPrice()
    {
        this.Price /= 2;
    }

    public Car()
    {
    }
    public Car(string model, double price, string colour)
    {
        _model = model;
        _price = price;
        _colour = colour;
    }


}
class GlassOfWater
{
    private bool glassIsFull = false;
    private bool glassIsWhole = true;

    public void FillGlass()
    {
        if (glassIsWhole)
        {
            if (glassIsFull)
            {
                Console.WriteLine("The glass is already full.");
            }
            else
            {
                glassIsFull = true;
                Console.WriteLine("Filling the glass with water!");
            }
        }
        else
        {  
            Console.WriteLine("Your water is smudged upon the shards of the broken glass");      
        }      
    }
    public void EmptyGlass()
    {
        if (glassIsWhole)
        {
            if (glassIsFull)
            {
                glassIsFull = false;
                Console.WriteLine("Emptying glass.");
            }
            else
            {
                Console.WriteLine("The glass is already empty!");
            }
        }
        else
        {
            Console.WriteLine("You cut your hand as you try emptying a broken glass");
        }
    }
    public void BreakGlass()
    {
        if (!glassIsWhole)
        {
            Console.WriteLine("You can't break what is already broken.");
        }
        else
        {
            glassIsWhole = false;
            if (glassIsFull)
            {
                Console.WriteLine("The water splashes as you break the glass.");
            }
            else
            {
                Console.WriteLine("You break the glass.");
            }
        }
    }
}
class BlueAndRed
{
    private double _blue;
    public double Blue
    {
        get
        {
            return _blue;
        }
        set
        {
            if (value < 0)
            {
                _blue = 0;
                _red = 100 - _blue;
            }
            else if (value > 100)
            {
                _blue = 100;
                _red = 100 - _blue;
            }
            else
            {
                _blue = value;
                _red = 100 - _blue;
            }
        }
    }
    private double _red;
    public double Red
    {
        get
        {
            return _red;
        }
        set
        {
            if (value < 0)
            {
                _red = 0;
                _blue = 100 - _red;
            }
            else if (value > 100)
            {
                _red = 100;
                _blue = 100 - _red;
            }
            else
            {
                _red = value;
                _blue = 100 - _red;
            }
        }
    }

}