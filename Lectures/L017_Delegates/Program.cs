
//Different ways to declare delegate variables
DemoDelegate charCounter = new DemoDelegate(CharCounter);
DemoDelegate wordCunter = WordCounter;
DemoDelegate myDelegateTwo = null;
static int CharCounter(string text)
{
    return text.Length;
}
static int WordCounter(string text)
{
    return text.Split(' ').Length;
}

//Func
Func<string, int> demoDelegate = WordCounter;

//Different ways to run delegate methods.
//Invoke = calls the method in delegate.
Console.WriteLine(charCounter.Invoke("Hello World!"));

//Why using invoke can be a good idea.
//This way will crash if null.
Console.WriteLine(wordCunter("Hello World!"));
//This won't crash if null.
Console.WriteLine(myDelegateTwo?.Invoke("Hello World!"));


//Example where you want to have a delegate.
//Can be used as parameter in method.
string[] countries = new string[] { "Sweden", "Norway", "Denmark", "Faroe Islands" };

ProcessStrings(countries, charCounter);

//Since the parameter in ProcessStrings is a delegate, you can just send a method that
//fits the delegate as argument.
ProcessStrings(countries, WordCounter);

//Using Func instead
ProcessStringsFunc(countries, demoDelegate);


static void ProcessStrings(string[] strings, DemoDelegate demoDelegate)
{
    foreach (string s in strings)
    {
        Console.WriteLine(demoDelegate?.Invoke(s));
    }
}
static void ProcessStringsFunc(string[] strings, Func<string, int> genericDelegate)
{
    foreach (string s in strings)
    {
        Console.WriteLine(genericDelegate?.Invoke(s));
    }
}


Console.WriteLine("*** Multi Cast ***");
//Multicast delegates

static void FuncA()
{
    Console.WriteLine("Func A");
}
static void FuncB()
{
    Console.WriteLine("Func B");
}
static void FuncC()
{
    Console.WriteLine("Func C");
}

Action action = FuncA;
action += FuncB;
action += FuncC;
action += FuncB;
action += FuncA;

action.Invoke();



Console.WriteLine("*** Exercise 1 ***");
//Lecture exercises

//1
Action<int, int> addition = Addition;
addition(1, 1);

static void Addition(int numberOne, int numberTwo)
{
    Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
}

//2
Console.WriteLine("*** Exercise 2 ***");

Func<char, int, string> multiplyCharacter = MultiplyChar;

Console.WriteLine(multiplyCharacter('#', 5));

static string MultiplyChar(char c, int number)
{
    string multipliedCharacter = string.Empty;

    for (int i = 0; i < number; i++)
    {
        multipliedCharacter += c;
    }
    return multipliedCharacter;
}


//3
Console.WriteLine("*** Exercise 3 ***");


Action<int, int> printMultipliedNumbers = PrintMultipliedNumbers;

myFunction(3, printMultipliedNumbers);
myFunction(3, addition);

static void PrintMultipliedNumbers(int numberOne, int numberTwo)
{
    Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");
}

static void myFunction(int number, Action<int, int> myAction)
{
    for (int i = 1; i <= 10; i++)
    {
        myAction(number, i);
    }
}


public delegate int DemoDelegate(string s);
