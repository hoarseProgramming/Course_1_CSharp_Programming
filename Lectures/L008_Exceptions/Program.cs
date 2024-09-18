// Try, Catch, Finally blocks.
//Ex_1_TryCatchFinally();
//Ex_2_NestedTry();
Exercise();
static void Ex_1_TryCatchFinally()
{
    static void MyFunction()
    {
        int[] myArray = new int[] { 1, 2, 3, 4 };
        myArray[4] = 0;
    }

    try
    {
        //DividedByZeroException
        int x = 0;
        int y = 1 / x;

        //IndexOutOfrngeException
        MyFunction();

        //FormatException
        Int32.Parse("Hej");

        Console.WriteLine("Det gick bra");
    }
    //Runs if IndexOutOfRangeException is thrown by the try block
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine($"Wrong index: {ex.Message}");
        Console.WriteLine(ex.StackTrace);
    }
    //Runs if FormatException is thrown by the try block
    catch (FormatException ex)
    {
        Console.WriteLine($"Wrong format: {ex.Message}");
        Console.WriteLine(ex.StackTrace);
    }
    //Runs if Exception, other than those above, is thrown by the try block
    catch (Exception ex)
    {
        Console.WriteLine("Unexpected Error");
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.StackTrace);
    }
    //Always runs
    finally
    {
        Console.WriteLine("End of application");
    }

}

static void Ex_2_NestedTry()
{
    //Nested try-blocks
    static void MyFunctionTwo()
    {
        try
        {
            int[] myArray = new int[] { 1, 2, 3, 4 };
            myArray[4] = 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error in MyFunctionTwo: {ex.Message}");
            //Trows exception again
            throw;
        }
    
    }

    //Will handle two exceptions
    try
    {
        try
        {
        
            MyFunctionTwo();
            Int32.Parse("Hej");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"IndexOutOfRangeException: {ex.Message}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unexpected error: {ex.Message}");
    }
    //Throws chosen exception type
    throw new FileNotFoundException();

}

static void Exercise()
{
    static int CalculateDiffFromNow(int futureYear)
    {
        //DateTime dateTime = DateTime.Now;
        int currentYear = DateTime.Now.Year;

        if (futureYear > currentYear)
        {
            return futureYear - currentYear;
        }
        else
        {
            throw  new ArgumentOutOfRangeException();
        }
    
    }

    bool isCorrectInput = false;

    while (!isCorrectInput)
    {
        try
        {
            Console.WriteLine("Input Future year!");

            int futureYear = Int32.Parse(Console.ReadLine());
            int years = CalculateDiffFromNow(futureYear);
        
            isCorrectInput = true;

            Console.WriteLine($"The year {futureYear} is {years} years from now");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Wrong: Try a future year!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Something went wrong: {ex.Message}");
        }
    }

}
