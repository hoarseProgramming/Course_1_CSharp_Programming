//E1 WriteNames
Console.WriteLine("***E1***");
Person firstPerson = new Person() { firstName = "Hampus", lastName = "Es" };
Person secondPerson = new Person() { firstName = "Julki", lastName = "Schabb" };

Console.WriteLine($"{firstPerson.firstName} {firstPerson.lastName}");
Console.WriteLine($"{secondPerson.firstName} {secondPerson.lastName}");

//E2 Add method
Console.WriteLine("***E2***");
Console.WriteLine(firstPerson.GetFullName());
Console.WriteLine(secondPerson.GetFullName());

//E3 Add method name backwards
Console.WriteLine("***E3***");
Console.WriteLine(firstPerson.GetFullNameReversed());

//E4 Add method overload with title
Console.WriteLine("***E4***");
Console.WriteLine(firstPerson.GetFullName("Mr"));

//E5+E6 Add parents
Console.WriteLine("***E5***");
Person johan = new Person() { firstName = "Johan", lastName = "Swahn" };
Person eva = new Person() { firstName = "Eva", lastName = "Eiderström" };
Person myself = new Person() { firstName = "Hampus", lastName = "Eiderström Swahn", father = johan};
Console.WriteLine(myself.GetFullName());
Console.WriteLine(myself.father.GetFullName());

//E7 Add parents
Console.WriteLine("***E7***");
Console.WriteLine(myself.GetSelfAndParent());

//E8 Add private length
Console.WriteLine("***E8***");
myself.SetLength(1.84);
Console.WriteLine(myself.GetLength());

//E9 Add private length
Console.WriteLine("***E9***");
myself.SetWeight(80.5);
Console.WriteLine(myself.GetWeight());
Console.WriteLine(myself.GetBMI());

class Person
{
    public string firstName;
    public string lastName;

    private double length;
    private double weight;

    public Person mother;
    public Person father;

    public string GetFullName()
    {
        return $"{firstName} {lastName}";
    }
    public string GetFullName(string title)
    {
        return $"{title}.{firstName} {lastName}";
    }
    public string GetFullNameReversed()
    {
        char[] charName = GetFullName().ToCharArray();
        Array.Reverse(charName);

        string fullNameReversed = new string (charName);
   
        return fullNameReversed;
    }
    public string GetSelfAndParent()
    {
        string mothersName = string.Empty;
        string fathersName = string.Empty;

        if(this.mother == null)
        {
            mothersName = "okänd";
        }
        else
        {
            mothersName = this.mother.GetFullName();
        }
        if (this.father == null)
        {
            fathersName = "okänd";
        }
        else
        {
            fathersName = this.father.GetFullName();
        }

        return $"{this.GetFullName()} - Mamma: {mothersName} - Pappa: {fathersName}";
    }
    public void SetLength(double length)
    {
        this.length = length;
    }
    public double GetLength()
    {
        return length;
    }
    public void SetWeight(double weight)
    {
        this.weight = weight;
    }
    public double GetWeight()
    {
        return weight;
    }
    public double GetBMI()
    {
        return weight / (length * length);
    }
}