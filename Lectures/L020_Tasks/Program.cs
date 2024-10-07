////Tasks

//Run() creates and starts task

//Task myTask = Task.Run(Task1);

//for (int i = 0; i < 600; i++)
//{
//    Console.WriteLine($"Main thread: {i}");
//}

//Console.WriteLine("The end!");

//Waits for task to complete, but locks the thread in waiting. Synchronous wait.
//This ususally isn't what you want to do.
//myTask.Wait();

//static void Task1()
//{
//    for (int i = 0; i < 1000; i++)
//    {
//        Console.WriteLine($"Task 1: {i}");
//    }
//}

//Lambda way + how to create a task, and later running it.
//Task<TResult>
Task<int> task1 = new Task<int>(() =>
{
    int sum = 0;
    for (int i = 0; i < 100; i++)
    {
        sum += i;
        Console.WriteLine($"Counting. Sum: {sum}");
    }
    return sum;
});

//Status property, returning status of task.
Console.WriteLine($"task1 is {task1.Status}");

//Starts task
task1.Start();

Task task2 = Task.Run(() =>
{
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine(i);
    }
});


//Creates a new task that will start running when the task is finished: In the example
// task 1 will finish counting then the codeblock will run.
task1.ContinueWith(task =>
{
    Console.WriteLine($"Result of task1: {task.Result}");
});


Console.WriteLine($"task1 is {task1.Status}");

Console.WriteLine("The end");

Console.ReadKey();

//Result also blocks the thread.
//task1.Result();

