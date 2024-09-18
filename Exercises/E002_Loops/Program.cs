// Exercises 2 - Loops
//e1();
//e2();
//e3();
//e4();
//e5();
//e6();
//e7();
//e8();
//e9();
//e10();
//e11();
//e12();
//e13();
//e14secretNumbersGame();
//e15rockPaperScissors();

static void e1()
{
	for (int i = 20; i <= 30; i++)
	{
        Console.WriteLine(i);
	}
}
static void e2()
{
	for (int i = 0; i <= 30; i += 2)
	{
        Console.WriteLine(i);
	}
}
static void e3()
{
	for (int i = 0; i <= 30; i++)
	{
		if ( i % 3 == 0)
		{
            Console.WriteLine("Hej");
		}
		else
		{
            Console.WriteLine(i);
		}
	}
}
static void e4()
{
    Console.WriteLine("Svårt att hålla koll på gångertabellen? Mata in ett tal och träna!");
	int number = Int32.Parse(Console.ReadLine());

	for (int i = 1; i <= 10; i++)
	{
        Console.WriteLine(number * i);
	}
}
static void e5()
{
	int sum = 0;
	for (int i = 1; i <= 1000; i++)
	{
		sum += i;
	}
    Console.WriteLine(sum);
}
static void e6()
{
	
	for (int i = 0; i < 64; i++)
	{
        Console.WriteLine($"Box {i + 1}: {Math.Pow(2, i)}");
	}
}
static void e7()
{
    Console.WriteLine("Make a box! Choose width and height, one number at a time");
    Console.WriteLine("Enter width:");
	int width = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Enter height:");
    int heigth = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Behold, the box.");

	for (int i = 0; i < heigth; i++)
	{
		for (int j = 0; j < width; j++)
		{
			Console.Write("X");
        }
        Console.WriteLine();
	}
}
static void e8()
{
    Console.WriteLine("Make a box! Choose width and height, one number at a time");
    Console.WriteLine("Enter width:");
    int width = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Enter height:");
    int heigth = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Behold, the box.");

    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
			if (j % 2 == 0) Console.Write("X");
			else Console.Write("O");
        }
        Console.WriteLine();
    }
}
static void e9()
{
    Console.WriteLine("Make a box! Choose width and height, one number at a time");
    Console.WriteLine("Enter width:");
    int width = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Enter height:");
    int heigth = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Behold, the box.");

    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (i % 2 == 0)
            {
                if (j % 2 == 0) Console.Write("X");
                else Console.Write("O");
            }
            else 
            {
                if (j % 2 == 0) Console.Write("O");
                else Console.Write("X");
            }
        }
        Console.WriteLine();
    }
}
static void e10()
{
    Console.WriteLine("Make a box! Choose width and height, one number at a time");
    Console.WriteLine("Enter width:");
    int width = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Enter height:");
    int heigth = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Behold, the box.");

    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (i == 0 || i == heigth - 1 || j == 0 || j == width - 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
static void e11()
{
    for (int i = 1; i < 10; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write(j + 1);
        }
        Console.WriteLine();
    }
}
static void e12()
{
    for (int i = 2; i < 11; i++)
    {
        for (int j = 1; j < i; j++)
        {
            for (int k = 0; k < j; k++)
            {
                Console.Write(k + 1);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
static void e13()
{
    int numberOfPrimes = 0;

    for (int i = 2; i < 10000000; i++)
        {
        if (numberOfPrimes < 20)
        {
            for (int j = 2; j < 200; j++)
            {
                if (i == j)
                {
                    Console.WriteLine(i);
                    numberOfPrimes++;
                    break;
                } 
                else if (i % j == 0)
                {
                    break;
                }
            }
        }
    }
}
static void e14secretNumbersGame()
{
    Random r = new Random();

    int secretNumber = r.Next(1, 101);
    int numberOfGuesses = 0;
    bool correctAnswer = false;
    //Human
    //Console.WriteLine("Welcome to the secret numbers game. Try to guess the number (1-100) in as few tries as possible! Good luck!");
    //while (!correctAnswer)
    //{
    //    int guess = Int32.Parse(Console.ReadLine());
    //    numberOfGuesses++;

    //    if (guess == secretNumber)
    //    {
    //        Console.WriteLine($"You got it! Number of tries: {numberOfGuesses}");
    //        correctAnswer = true;
    //    }
    //    else if (guess < secretNumber)
    //    {
    //        Console.WriteLine("A bit low!");
    //    }
    //    else
    //    {
    //        Console.WriteLine("A bit high!");
    //    }

    //}

    //////CPU
    int cpuMinGuess = 1;
    int cpuMaxGuess = 101;
    Console.WriteLine("I welcome myself to the secret numbers game ");
    Console.WriteLine("I'm gonna try to guess the number (1-100) in as few tries as possible! I wish myself good luck!");

    while (!correctAnswer)
    {
        int cpuGuess = r.Next(cpuMinGuess, cpuMaxGuess);
        Console.WriteLine($"\"Hmm, let's see... {cpuGuess} seems about right\"");
        numberOfGuesses++;

        if (cpuGuess == secretNumber)
        {
            Console.WriteLine($"I got it! Number of tries: {numberOfGuesses}");
            correctAnswer = true;
        }
        else if (cpuGuess < secretNumber)
        {
            Console.WriteLine("A bit low!");
            cpuMinGuess = cpuGuess + 1;
        }
        else
        {
            Console.WriteLine("A bit high!");
            cpuMaxGuess = cpuGuess - 1;
        }

    }

}
static void e15rockPaperScissors()
{
    Random r = new Random();
    int humanScore = 0;
    int cpuScore = 0;

    
    while (true)
    {
        Console.WriteLine("Let's play some rock, paper, scissors! Exit game by sending empty input.");
        Console.WriteLine("Input \"Rock\", \"Paper\" or \"Scissors\"");
        string[] choices = new string[] { "Rock", "Paper", "Scissors" };
        string humanChoice = Console.ReadLine();

        Console.Clear();

        Console.WriteLine("***************************************************");
        Console.WriteLine(humanChoice);
        string cpuChoice = choices[r.Next(0, 3)];

        if (humanChoice == "")
        {
            if (humanScore < cpuScore)
            {
                Console.WriteLine("************************Game Over************************");
                Console.WriteLine($"Human score: {humanScore}\nCPU Score: {cpuScore}");
                Console.WriteLine("CPU wins!");
            }
            else if (humanScore == cpuScore)
            {
                Console.WriteLine("************************Game Over************************");
                Console.WriteLine($"Human score: {humanScore}\nCPU Score: {cpuScore}");
                Console.WriteLine("It´s a draw!");
            }
            else
            {
                Console.WriteLine("************************Game Over************************");
                Console.WriteLine($"Human score: {humanScore}\nCPU Score: {cpuScore}");
                Console.WriteLine("Human wins!");
            }
            break;
        }
        else if (humanChoice != "Rock" && humanChoice != "Paper" && humanChoice != "Scissors")
        {
            Console.WriteLine("Oof, gotten a typo have we? ;)");
        }
        else if (humanChoice == "Rock" && cpuChoice == "Paper" || humanChoice == "Paper" && cpuChoice == "Scissors" || humanChoice == "Scissors" && cpuChoice == "Rock")
        {
            cpuScore++;
            Console.WriteLine($"I choose: {cpuChoice}");
            Console.WriteLine("Gotcha!");
            Console.WriteLine($"Human score: {humanScore}\nCPU Score: {cpuScore}");
        }
        else if (cpuChoice == "Rock" && humanChoice == "Paper" || cpuChoice == "Paper" && humanChoice == "Scissors" || cpuChoice == "Scissors" && humanChoice == "Rock")
        {
            humanScore++;
            Console.WriteLine($"I choose: {cpuChoice}");
            Console.WriteLine("Oof, I´ll get you next time!");
            Console.WriteLine($"Human score: {humanScore}\nCPU Score: {cpuScore}");
        }
        else
        {
            Console.WriteLine($"I choose: {cpuChoice}");
            Console.WriteLine("Throwing the same on never ceases to amaze!");
            Console.WriteLine($"Human score: {humanScore}\nCPU Score: {cpuScore}");
        }
        Console.WriteLine("***************************************************");
    }

}
