//LINQ vs PLINQ

//LINQ
//var list = Enumerable
//    .Range(0, 50)
//    .Select(i => CostlyOperation(i))
//    .ToList();

//Console.WriteLine("\nProcessiong complete! Here is the processed data:\n");
//list.ForEach(i => Console.WriteLine(i));

//static int CostlyOperation(int n)
//{
//    for (int i = 0; i < 1000_000_000; i++) ;
//    Console.WriteLine($"Processing element {n}.");
//    return n;
//}

//PLINQ
var parallelList = Enumerable
    .Range(0, 50)
    //Makes it multithread
    .AsParallel()
    .Where(i => i > 25)
    .Select(i => CostlyOperation1(i))
    .ToList();

Console.WriteLine("\nProcessiong complete! Here is the processed data:\n");
parallelList.ForEach(i => Console.WriteLine(i));

static int CostlyOperation1(int n)
{
    for (int i = 0; i < 1000_000_000; i++) ;
    Console.WriteLine($"Processing element {n}.");
    return n;
}