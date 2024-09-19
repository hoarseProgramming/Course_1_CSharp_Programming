//Struct and Enum

Position position = new Position(0, 0);

Console.WriteLine($"Player is at position {position.X}, {position.Y}");


Color myColor = Color.Red;

Console.WriteLine($"myColor = {myColor} ({(int)myColor})");
Console.WriteLine($"(Color)3 = {(Color)3}");

struct Position
{
    public int X;
    public int Y;

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}
enum Color { Red, Green, Blue, Yellow, Purple };

