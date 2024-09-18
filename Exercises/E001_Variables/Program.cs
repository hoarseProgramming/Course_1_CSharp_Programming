//Övningar Variables

//e1();
//e2();
//e3();
//e4();
//e5();
//e6();
e7();

static void e1() 
{
    Console.WriteLine("Skriv in ditt namn!");
    string name = Console.ReadLine();
    Console.WriteLine($"Hej {name}!");
}

static void e2()
{
    Console.WriteLine("Skriv in två heltal, ett i taget!");
    int numberOne = Int32.Parse(Console.ReadLine());
    int numberTwo = Int32.Parse(Console.ReadLine());
    Console.WriteLine(numberOne * numberTwo);
}
static void e3()
{
    Console.WriteLine("Enter Password");
    string passWord = "abc123";
    string input = Console.ReadLine();

    if (input == passWord)
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine("Incorrect");
    }
}
static void e4()
{
    Console.WriteLine("Give me a number!");
    int number = Int32.Parse(Console.ReadLine());

    if (number == 100)
    {
        Console.WriteLine("You number is 100.");
    }
    if (number < 100)
    {
        Console.WriteLine("You number is less than 100.");
    }
    if (number > 100)
    {
        Console.WriteLine("You number is higher than 100.");
    }
}
static void e5()
{
    Console.WriteLine("Give me a number!");
    double number = Double.Parse(Console.ReadLine());

    Console.WriteLine($"Your number: {number} becomes {number * 2} when doubled");
    Console.WriteLine($"Your number: {number} becomes {number / 2} when halved");
}
static void e6()
{
    Console.WriteLine("Welcome to the calculator\nLet's start with a number");
    double x = Double.Parse(Console.ReadLine());
    Console.WriteLine("What do you want to do with it? (+, -, /");
    string choiceOfOperand = Console.ReadLine();
    Console.WriteLine("Great, gotcha!\nLet's go for one more number");
    double y = Double.Parse(Console.ReadLine());

    switch (choiceOfOperand)
    {
        case "+":
            Console.WriteLine(x + y);
            break;
        case "-":
            Console.WriteLine(x - y);
            break;
        case "/":
            Console.WriteLine(x /
                y);
            break;
    }


}
static void e7()
{
    double number;
    double sum = 0;
    double numberOfNumbers = 0; 
    bool isNumber = true;

    Console.WriteLine("Let´s sum it up! Enter numbers and sum them up!");
    Console.WriteLine("Escape the loop by entering anything else than a number. Then get a surprise.");
    while (isNumber)
    {
        isNumber = Double.TryParse(Console.ReadLine(), out number);
        if (isNumber)
        {
            sum += number;
            numberOfNumbers++;
            Console.WriteLine(sum);
        }
        else
        {
            if (numberOfNumbers > 0)
            {
                Console.WriteLine($"Average value = {sum / numberOfNumbers}");
            }
            else
            {
                Console.WriteLine($"You didn't make it. Try again.");
            }
        }
    } 
}