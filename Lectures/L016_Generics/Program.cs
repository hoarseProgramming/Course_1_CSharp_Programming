//Generics

//Generic collections

//List
List<string> countries = new List<string>() { "france", "spain", "italy"};
//Clears list

countries.Clear();
//Add object to list
countries.Add("brazil");
countries.Add("sweden");
countries.Add("norway");
countries.Add("denmark");
countries.Add("norway");

//Removes first occurence of value = lowest index
countries.Remove("norway");
//Remove at index position
countries.RemoveAt(0);
//Remove desired span, starting from indexposition
countries.RemoveRange(0, 2);

foreach (var country in countries)
{
    Console.WriteLine(country);
}

string myCountry = "norway";
//Returns true if the list contains chosen parameter.
Console.WriteLine(countries.Contains(myCountry));

//Save list as array
string[] myCountries = countries.ToArray();
//Resize array method
Array.Resize(ref myCountries, 5);

//List uses an array that is resized any time the lsit runs out of space.

List<int> numbers = new List<int>();
for (int i = 0; i < 40; i++)
{
    numbers.Add(i);
    Console.WriteLine($"numbers.Count: {numbers.Count}, numbers.Capacity: {numbers.Capacity}");
}
for (int i = 0; i < 40; i++)
{
    numbers.Remove(i);
    Console.WriteLine($"numbers.Count: {numbers.Count}, numbers.Capacity: {numbers.Capacity}");
}

Console.WriteLine("*** Dictionary  ***");
//Dictionary 
//Works in pairs, the key can be seen as a index, dict[Key] returns Value
//The keys must be unique

//Declaring and initializing Dictionary
Dictionary<string, string> myDictionary = new Dictionary<string, string>();

myDictionary.Add("boy", "pojke");
myDictionary.Add("girl", "flicka");
myDictionary.Add("boy2", "pojke");
myDictionary.Add("man", "man");
myDictionary.Add("woman", "kvinna");

string input;

do
{
    input = Console.ReadLine();

    if(myDictionary.ContainsKey(input))
    {
        Console.WriteLine(myDictionary[input]);
    }
    else
    {
        Console.WriteLine("No corresponding key");
    }

} while (input != "");

//Returns true if Dictionary contains the value
Console.WriteLine(myDictionary.ContainsValue("pojke"));


myDictionary.TryGetValue("boy", out string value);
Console.WriteLine(value);

//Properties
//Key property used for iterating through kyes
foreach (var key in myDictionary.Keys)
{
    Console.WriteLine(key);
}
//Value property used for iterating through values
foreach (var value1 in myDictionary.Values)
{
    Console.WriteLine(value1);
}
//KeyValuePair struct used for iterating through both keys and values
foreach (var keyValuePair in myDictionary)
{
    Console.WriteLine($"Key: {keyValuePair.Key} Value: {keyValuePair.Value}");
}

Console.WriteLine("*** Stack ***");
//Stack - LIFO(Last In First Out)
//Can be used for searching through dirs

//Declare and initialize Stack
Stack<int> myStack = new Stack<int>();

//Push - Adds to stack
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);

//Pop - Removes and returns object from stack
int myInt1 = myStack.Pop();
int myInt2 = myStack.Pop();

//Peek, returns top of the stack without removing it from the stack
Console.WriteLine(myStack.Peek());
Console.WriteLine(myInt1);  //Output: 3
Console.WriteLine(myInt2);  //Output: 2


//Queue FIFO - First In First Out

//Common use for server, queue requests before handling them
Queue<string> myQueue = new Queue<string>();

//Adds object to queue
myQueue.Enqueue("Hej");
myQueue.Enqueue("Då");

//Returns and removes the top object from queue
myQueue.Dequeue();





//Generic class

Cage<double> myDoubleCage = new Cage<double>();
Cage<string> myStringCase = new Cage<string>();
Cage<bool> myBooolCage = new Cage<bool>();

myDoubleCage.MyProperty = 5.23;

var v = myDoubleCage.MyProperty;

Console.WriteLine(v);

class Cage<T>
{
    public T MyProperty { get; set; }
}
