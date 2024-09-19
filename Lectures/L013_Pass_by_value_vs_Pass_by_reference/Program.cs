//Types, Passing parameters

//Value type: b is not changed by the new value of a, since b copies value from a.
int a = 5;
int b = a;
a = 3;
Console.WriteLine($"a = {a}, b = {b}");

//Reference type: catB name is changed by the new value of catA name, since catB
//is pointing to the same reference as catA.
Cat catA = new Cat() { name = "Miaow" };
Cat catB = catA;
catA.name = "Moo";
Console.WriteLine($"catA.name = {catA.name}, catB.name = {catB.name}");

//Pass by value, Pass by reference
//Pass by reference: keyword ref and out(must change value of parameter)

Console.WriteLine("***Passing***");
PassValueTypeByValue(a);
Console.WriteLine($"After PassValueTypeByValue(a), a = {a}");

PassValueTypeByReference(ref a);
Console.WriteLine($"After PassValueTypeByReference(a), a = {a}");

PassReferenceTypeByValue(catA);
Console.WriteLine($"After PassReferenceTypeByValue(catA), catA.name = {catA.name}");

PassReferenceTypeByReference(ref catA);
Console.WriteLine($"After PassReferenceTypeByReference(catA), catA.name = {catA.name}");


//Can't change value of value type
static void PassValueTypeByValue(int i)
{
    i = 0;
    
}
//Can change value of value type
static void PassValueTypeByReference(ref int i)
{
    i = 0;
}
//Can change members of Reference type
static void PassReferenceTypeByValue(Cat cat)
{
    //This works: cat.name = "Miaow";
    cat = new Cat() { name = "Miaow" };
}
//Can change the object reference of reference type
static void PassReferenceTypeByReference(ref Cat cat)
{
    cat = new Cat() { name = "Miaow" };
}
class Cat
{
    public string name;
}