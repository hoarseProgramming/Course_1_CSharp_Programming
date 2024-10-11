//Race conditions

//Gives different results on different runs.
Console.WriteLine("***Bad count***");
for (int i = 0; i < 10; i++)
{
    BadCount();
}
Console.WriteLine("***Good count***");
for (int i = 0; i < 10; i++)
{
    GoodCount();
}
static void BadCount()
{
    int count = 0;

    Task task1 = Task.Run(() => DoCount());
    Task task2 = Task.Run(() => DoCount());

    Task.WaitAll(task1, task2);

    Console.WriteLine($"Count = {count}");

    void DoCount()
    {
        for (int i = 0; i < 10000; i++)
        {
            int temp = count; // Temp = 0;
            temp = temp + 1; // Temp = 1; <-- could jump out here, and the other task might run.
            count = temp; // obvious problems
        }
    }
}
static void GoodCount()
{
    object myLock = new object();

    int count = 0;

    Task task1 = Task.Run(() => DoCount());
    Task task2 = Task.Run(() => DoCount());

    Task.WaitAll(task1, task2);

    Console.WriteLine($"Count = {count}");

    void DoCount()
    {
        for (int i = 0; i < 10000; i++)
        {
            lock (myLock)
            {
                int temp = count; // Temp = 0;
                temp = temp + 1; // Temp = 1; <-- could jump out here, and the other task might run.
                count = temp; // obvious problems
            }         
        }
    }
}
