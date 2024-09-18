//Exercises 3 - Index

//e1_oneLetterEachRow();
//e2_numbersToText();
//e3_backwards();
//e4_hideVowels();
//e5_palindrome();
//e6_calculator();
//e7_switchTheWordsUp();
e8_dragginItOut();
//e9_letterPyramid();
//e10_coloredLetters();
//e11_startAndStop();
//e12_changeColors();

static void e1_oneLetterEachRow()
{
    Console.WriteLine("Give me a string! I'll do something with it");
    string input = Console.ReadLine();

    foreach (var c in input)
    {
        Console.WriteLine(c);
    }
}
static void e2_numbersToText()
{
    string[] numbers = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    Console.WriteLine("Conver a number to it's text equivalent!");
    Console.WriteLine("Enter 0-9");
    Console.WriteLine(numbers[Int32.Parse(Console.ReadLine())]);
}
static void e3_backwards()
{
    Console.WriteLine("Give me some text to give back to you backwards!");
    string text = Console.ReadLine();

    for (int i = text.Length - 1; i >= 0; i--)
    {
        Console.Write(text[i]);
    }
}
static void e4_hideVowels()
{
    Console.WriteLine("Give me some text. I'll devowel it for you!");
    string text = Console.ReadLine();
    foreach (char c in text)
    {
        if ( c == 'a' || c == 'o' || c == 'u' || c == 'å' || c == 'e' || c == 'i' || c == 'y' || c == 'ä' || c == 'ö')
        {
            Console.Write('*');
        }
        else
        {
            Console.Write(c);
        }
    }
    Console.WriteLine();
    //Rövarspråket
    foreach (char c in text)
    {
        if (c == 'a' || c == 'o' || c == 'u' || c == 'å' || c == 'e' || c == 'i' || c == 'y' || c == 'ä' || c == 'ö')
        {
            Console.Write(c);
        }
        else
        {
            Console.Write($"{c}o{c}");
        }
    }

}
static void e5_palindrome()
{
    Console.WriteLine("Welcome to the palindrome check. Enter word:");
    string input = Console.ReadLine();
    string inputBackwards = "";

    for (int i = input.Length - 1; i >= 0; i--)
    {
        inputBackwards += input[i];
    }
    input = input.ToLower();
    inputBackwards = inputBackwards.ToLower();

    if (input == inputBackwards)
    {
        Console.WriteLine("Congrats, you entered a palindrome!");
    }
    else
    {
        Console.WriteLine("That's not a palindrome!");
    }
}
static void e6_calculator()
{
    string inputNumber1 = "";
    string inputNumber2 = "";
    char operand = ' ';
    bool isFirstNumber = true;
    decimal number1 = 0;
    decimal number2 = 0;
    
    Console.WriteLine("Welcome to the calculator. Input that which you wish to calcuate.");
    Console.WriteLine("2 numbers separated by operand type. Ex: \"1 + 1\"");

    string input = Console.ReadLine();

    foreach (char c in input)
    {
        if (c == ' ')
        {
            
        }
        if( c == '+' || c == '-' || c == '*' || c == '/' )
        {
            operand = c;
            isFirstNumber = false;
        }
        else if (isFirstNumber)
        {
            inputNumber1 += c;
        }
        else
        {
            inputNumber2 += c;
        }
    }

    //Convert strings to ints.
    number1 = Decimal.Parse(inputNumber1);
    number2 = Decimal.Parse(inputNumber2);

    if (operand == '+')
    {
        Console.WriteLine($"= {number1 + number2}");
    }
    else if (operand == '-')
    {
        Console.WriteLine($"= {number1 - number2}");
    }
    else if (operand == '/')
    {
        Console.WriteLine($"= {number1 / number2}");
    }
    else
    {
        Console.WriteLine($"= {number1 * number2}");
    }
}
static void e7_switchTheWordsUp()
{
    string[] sevenWords = new string[7];
    Console.WriteLine("Input seven words, one at a time, let's switch them up!");

    for (int i = 0; i < 7; i++)
    {
        sevenWords[i] = Console.ReadLine();
    }

    for (int i = 6; i >= 0; i--)
    {
        Console.WriteLine(sevenWords[i]);
    }
}
static void e8_dragginItOut()
{
    
    string[] words = new string[10];
    int numberOfWords = 0;

    Console.WriteLine("Enter words one at a time. After ten inputs I'll start showing your words.");
    for (int i = 0; i >= 0; i++)
    {
        for (int j = 0; j < words.Length; j++)
        {
            numberOfWords++;
            if (numberOfWords <= 10)
            {    
                words[j] = Console.ReadLine();
                if (numberOfWords < 10)
                {
                    Console.WriteLine("You haven't written 10 words yet.");
                }                
            }
            else
            {
                Console.WriteLine(words[j]);
                words[j] = Console.ReadLine();
            }

        }
    }

}
static void e9_letterPyramid()
{
    string hi = "Hello World";

    for (int i = 0; i < 11; i++)
    {
        for (int j = -1; j < i; j++)
        {
            Console.Write(hi[j + 1]);
        }
        Console.WriteLine();
    }

}
static void e10_coloredLetters()
{
    Console.WriteLine("Enter a sentence!");
    string sentence = Console.ReadLine();

    Console.WriteLine("Now enter a letter. I'll change the color of that letter in your sentence.");
    char letter = Char.Parse(Console.ReadLine());

    foreach (Char c in sentence)
    {
        if (c == letter || Char.ToLower(c) == letter || Char.ToUpper(c) == letter)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(c);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {    
            Console.Write(c);
        }
    }
    
}
static void e11_startAndStop()
{
    Console.WriteLine("Enter sentence");
    string text = Console.ReadLine();

    Console.WriteLine($"Enter index span to be redified. (Possible span to index = 0 - {text.Length - 1}");
    Console.WriteLine("Lower bounds:");
    int lowerBound = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Upper bounds:");
    int upperBound = Int32.Parse(Console.ReadLine());

    for (int i = 0; i < text.Length; i++)
    {
        if (i >= lowerBound && i <= upperBound)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text[i]);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            Console.Write(text[i]);
        }
        
    }
}
static void e12_changeColors()
{
    Console.WriteLine("Enter text.");
    string text = Console.ReadLine();
    Console.WriteLine("Enter redifiying letter");
    char redLetter = Char.Parse(Console.ReadLine());
    bool checkingForLetter = false;

    foreach (char c in text)
    {

        if (!checkingForLetter)
        {
            if (c == redLetter)
            {
                checkingForLetter = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(c);
            }
            else
            {
                Console.Write(c);
            }
        }
        else
        {
            if (c == redLetter)
            {
                checkingForLetter = false;
                Console.Write(c);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.Write(c);
            }
            
        }
    }

}
