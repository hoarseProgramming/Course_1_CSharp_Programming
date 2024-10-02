//Anonymous types

var data = new { FirstName = "Hejkon", LastName = "Bejkon", Age = 33 };

Console.WriteLine(data);

var data2 = new { Integer = 1, Float = 2.0f, Double = 3.0, Decimal = 4.0M, Long = 5L, Boolean = true };

Console.WriteLine(data2);

//List example
Console.WriteLine("*** Anonymous list ***");
var people = new[] {
    new {LastName = "Björnsson", FirstName = "Björn", Age = 39},
    new {LastName = "Pellesson", FirstName = "Pelle", Age = 39}
};

foreach (var person in people)
{
    Console.WriteLine(person);
}

//Nested anonymous types
Console.WriteLine("*** Nested anonymous types ***");

var anonymousPerson = new
{
    name = "Anders Eriksson",
    age = 45,
    contactInfo = new { email = "anders@gmail.com", phone = 07384902}
};

Console.WriteLine(anonymousPerson);