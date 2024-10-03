using L018_Library;
//LINQ

//LINQ gives us the ability to do the things we do with loops, without doing the loops.
//More of a declarative approach to programming


List<object> objectList = new List<object>();

objectList.Add("Hello");
objectList.Add("World");
objectList.Add(5);
objectList.Add("Hej");
objectList.Add(true);
objectList.Add(3.4);
objectList.Add("Bye");

foreach (object item in objectList)
{
    Console.WriteLine(item);
}
//Using foreach to separate strings from list

List<string> stringList = new List<string>();

foreach (object item in objectList)
{
	if (item is string s)
	{
		stringList.Add(s);
	}
}

//Using LINQ to separate strings from list

List<string> stringList2 = objectList.OfType<string>().ToList();

Console.WriteLine("\n*** Link methods example ***\n");

Console.WriteLine("stringList2 content:");
Console.WriteLine(string.Join('\n', stringList2));

Console.WriteLine($"{"stringList2.Any(s => s.Length == 5)",-50} {stringList2.Any(s => s.Length == 5)}");
Console.WriteLine($"{"stringList2.All(s => s.Length <= 10)",-50} {stringList2.All(s => s.Length <= 10)}");
Console.WriteLine($"{"stringList2.Any(s => s == \"Hej\")",-50} {stringList2.Any(s => s == "Hej")}");
Console.WriteLine($"{"stringList2.Any(s => s.Contains(\"ye\"))",-50} {stringList2.Any(s => s.Contains("ye"))}");
Console.WriteLine($"{"stringList2.Any(s => s.ToLower() == \"hej\")",-50} {stringList2.Any(s => s.ToLower() == "hej")}");
Console.WriteLine($"{"stringList2.Any(s => s.Split(' ').Length == 3)",-50} {stringList2.Any(s => s.Split(' ').Length == 3)}");
Console.WriteLine($"{"stringList2.All(s => s.StartsWith('B'))",-50} {stringList2.All(s => s.StartsWith('B'))}");

//Where
//Filter collection
Console.WriteLine("\n*** Where ***\n");

Console.WriteLine("var stringList3 = stringList2.Where(s => s.Length == 5).ToList();");
var stringList3 = stringList2.Where(s => s.Length == 5).ToList();

Console.WriteLine("stringList3 content:");
Console.WriteLine(string.Join('\n', stringList3));

//Select
//Transfrom objects
Console.WriteLine("\n*** Select ***\n");

var people = new[] {
    new {LastName = "Björnsson", FirstName = "Björn", Age = 39},
    new {LastName = "Rafaelsson", FirstName = "Rafael", Age = 40},
    new {LastName = "Pellesson", FirstName = "Pelle", Age = 39}
}.ToList();

//Makes a new list with selected properties
//Overload, (object, position in list)
Console.WriteLine("var people2 = people.Select(p => new { Name = $\"{p.FirstName} {p.LastName}\", Age = p.Age, Email = $\"{p.FirstName.Title()}.{p.LastName.ToLower()}.gmail.com\" }).ToList();");
var people2 = people.Select((p, i) => new { Number = i, Name = $"{p.FirstName} {p.LastName}", Age = p.Age, Email = $"{p.FirstName.Title()}.{p.LastName.ToLower()}.gmail.com" }).ToList();

Console.WriteLine(string.Join("\n", people2));

Console.WriteLine();

//Linq method chaining
Console.WriteLine("\n*** Where ***\n");

var people3 = people
    .Where(p => p.Age >= 40)
    .Select((p, i) => new 
    { Number = i, 
      Name = $"{p.FirstName} {p.LastName}", 
      Email = $"{p.FirstName.Title()}.{p.LastName.ToLower()}.gmail.com" })
    .Where(p => p.Number >= 0)
    .ToList();


people3.ForEach(p => Console.WriteLine($"The email for {p.Name} = {p.Email}"));

//Query Syntax
Console.WriteLine("\n*** Query syntax ***");

//from (iterator) in (collection) (selection) where (projection) select 

//Query operations doesn't execute until forced by example ToList method.
var query = from p in people where p.Age >= 40 select p.Age;


// var methodSyntax = people.Where(p => p.Age >= 40).Select(p => p.FirstName);

foreach (var age in query)
{
    Console.WriteLine(age);
}

Console.WriteLine("\nAdd person to people\n");
people.Add(new { LastName = "Björnsson", FirstName = "Björn", Age = 45 });

foreach (var age in query)
{
    Console.WriteLine(age);
}
