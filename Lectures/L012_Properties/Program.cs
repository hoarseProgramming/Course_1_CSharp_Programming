//Properties vs fields

Otter myOtter = new();

//Field Syntax
//myOtter.SetName("Rafael");
//Console.WriteLine(myOtter.GetName());

//Property syntax
myOtter.Name = "Kalle";
Console.WriteLine(myOtter.Name);
Console.WriteLine(myOtter.Age);

class Otter
{
    
    //Private field that's used as a property starts with underscore
    //Short form = propfull + tab
    private string _name = "Otto";
    //First uppercase letter in properties
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    //Auto property, the same as creating a basic set get property.
    //Short form = prop + tab
    public int NumberOfLegs { get; set; }
    //Read-only property
    private int _age;
    public int Age
    {
        get
        {
            return 9;
        }
    }
    //Syntax for working with a private field
    //public void SetName(string name)
    //{
    //    this._name = name;
    //}
    //public string GetName()
    //{
    //    return _name;
    //}
}