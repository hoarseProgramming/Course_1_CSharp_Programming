using System.Collections;

//yield return keeps track of where it was after each time it´s called upon.

foreach (var number in GetNumbers())
{
    Console.WriteLine(number);
}

IEnumerable GetNumbers()
{
    yield return 1;
    yield return 5;
    yield return 3;
}