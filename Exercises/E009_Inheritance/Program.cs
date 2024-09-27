Console.WriteLine("*** 1+2 - Make vehicle class + override ToString() ***");

Console.WriteLine(new Vehicle(Brand.Volvo, Color.Black));
Console.WriteLine();

Console.WriteLine("*** 3 - Make Car sub class ***");

Console.WriteLine(new Car(Brand.Volvo, "XC90", Color.Black));
Console.WriteLine();

Console.WriteLine("*** 4 + 5 - Create struct, update Vehicle constructor ***");

Console.WriteLine(new Car(Brand.Volvo, "XC90", Color.Black));
Console.WriteLine();

Console.WriteLine("*** 6 - Create Circle class, that inherits from Shape class ***");
var circle = new Circle(5);
Console.WriteLine(circle);
Console.WriteLine($"Area: {circle.Area:f}");
Console.WriteLine($"Circumference: {circle.Circumference:f}");
Console.WriteLine();

Console.WriteLine("*** 7 - Create Square class, that inherits from Shape class ***");
var square = new Square(5);
Console.WriteLine(square);
Console.WriteLine($"Area: {square.Area:f}");
Console.WriteLine($"Circumference: {square.Circumference:f2}");
Console.WriteLine();

Console.WriteLine("*** 8 - Add Print() in Shape class ***");
var squareOne = new Square(3.2);
squareOne.Print();

var circleOne = new Circle(4.5);
circleOne.Print();
Console.WriteLine();

Console.WriteLine("*** 9 - Create shape array ***");
Shape[] shapes = new Shape[10];

for (int i = 0; i < 10; i++)
{
    Random r = new Random();
    if (r.Next(2) == 0)
    {
        shapes[i] = new Square(Math.Round((double)r.Next(10) + r.NextDouble(), 1), (ConsoleColor)r.Next(1, 16));
    }
    else
    {
        shapes[i] = new Circle(Math.Round((double)r.Next(10) + r.NextDouble(), 1), (ConsoleColor)r.Next(1, 16));
    }
}
Console.WriteLine();

Console.WriteLine("*** 10 - Create Static print methods in Shape class ***");
Shape.PrintAll(shapes);
Console.WriteLine();
Shape.PrintCircles(shapes);


struct Size
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public Size(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

}
enum Brand { Volvo, Sedan, Volkswagen, Ferrari, Toyota }
enum Color { Red, Green, Black, White, Yellow }

class Vehicle
{
    public Size Size { get; set; }

    private Color _color;
    public Color Color
    {
        get
        {
            return _color;
        }
        set
        {
            _color = value;
        }
    }

    private Brand _brand;
    public Brand Brand
    {
        get
        {
            return _brand;
        }
        set
        {
            _brand = value;
        }
    }

    public Vehicle(Brand brand)
    {
        Brand = brand;
        Color = Color.Black;
    }
    public Vehicle(Brand brand, Color color)
    {
        Random r = new Random();
        Brand = brand;
        Color = color;

        //Min lösning
        //double length = Math.Round((double)r.Next(3, 4) + r.NextDouble(), 1);
        //double width = Math.Round((double)r.Next(4, 6) + r.NextDouble(), 1);
        //double height = Math.Round((double)r.Next(2, 3) + r.NextDouble(), 1);
        Size size = new Size();

        //Så man brukar göra det
        //RandomDouble * Range + Offset
        size.Length = r.NextDouble() * 2 + 3.5;
        size.Width = r.NextDouble() * 0.7 + 1.5;
        size.Height = r.NextDouble() * 2 + 1;

        Size = size;

    }
    public override string ToString()
    {
        return $"A {this.Color} {this.Brand}";
    }
}
class Car : Vehicle
{
    public string Model { get; set; }

    public Car(Brand brand, string model, Color color) : base(brand, color)
    {
        Model = model;
    }
    public override string ToString()
    {
        return $"A {this.Color} {this.Size.Length} meters long {this.Model} from {this.Brand}";
    }
}
public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }
    protected ConsoleColor color;

    public void Print()
    {
        Console.WriteLine(this);
    }
    public static void PrintAll(Shape[] shapes)
    {
        foreach (Shape shape in shapes)
        {
            Console.ForegroundColor = shape.color;
            shape.Print();
        }
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    public static void PrintCircles(Shape[] shapes)
    {
        foreach (Shape shape in shapes)
        {
            (shape as Circle)?.Print();
        }
    }
}
public class Circle : Shape
{
    public override double Area { get; }
    public override double Circumference { get; }
    public double Radius { get; set; }

    public override string ToString()
    {
        return $"A circle with radius {Radius} has an area of {Area:f} and a circumference of {Circumference:f}.";
    }
    public Circle(double radius)
    {
        Radius = radius;
        Area = Math.Pow(Radius, 2) * Math.PI;
        Circumference = 2 * Math.PI * Radius;
    }
    public Circle(double radius, ConsoleColor color) : this(radius)
    {      
        this.color = color;
    }
}
public class Square : Shape
{
    public override double Area { get; }
    public override double Circumference { get; }
    public double Side { get; set; }

    public override string ToString()
    {
        return $"A square with side {Side} has an area of {Area:f} and a circumference of {Circumference:f}.";
    }
    public Square(double side)
    {
        Side = side;
        Area = Math.Pow(side, 2);
        Circumference = side * 4;
    }
    public Square(double side, ConsoleColor color) : this(side)
    {
        this.color = color;
    }

}