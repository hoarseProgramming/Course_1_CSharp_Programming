using System.Xml.Serialization;
using System.Numerics;
//Lecture assignments
//F1_greeting();
//F2_greetingExtraParameter();
//F3_ProjectEuler8();
//Excersises
//E1_firstNamelastName();
//E2_returnFirstNamelastName();
//E3_isLongerThan();
//E4_celsiusToFahrenheitConverter();
//E5_addHyphenBetweenLetter();
//E6_myOwnStringJoin();
//E7_avgValue();
//E8_NumberToWords();
//E9_IntegerToText();
//E10_IndexesOf();
//E11_ThrowDice();
//E12_DrawABox();
//E13_AtGame();
E14_Worms();


static void F1_greeting()
{
    Greet("Hampus");

    static void Greet(string name)
    {
        Console.WriteLine($"Hi {name}!");
    }
}
static void F2_greetingExtraParameter()
{
    Greet("Hampus", 2);

    static void Greet(string name, int times = 1)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine($"Hi {name}!");
        }
        
    }
}
static void F3_ProjectEuler8()
{
    double largestProduct = 0;
    double sum = 1;
    string numberAsString = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
    for (int i = 0; i < 988; i++)
    {
        sum = 1;
        for (int j = 0; j < 13; j++)
        {
            sum *= char.GetNumericValue(numberAsString[i + j]);
            if (sum > largestProduct)
            {
                largestProduct = sum;
            }
        }
    }
    Console.WriteLine(largestProduct);


}
static void E1_firstNamelastName()
{
    PrintName("Hampus", "Eiderström Swahn");

    static void PrintName(string firstName, string lastName)
    {
        Console.WriteLine($"{firstName} {lastName}");
    }
}
static void E2_returnFirstNamelastName()
{
    Console.WriteLine(GetFullName("Hampus", "Eiderström Swahn"));

    static string GetFullName(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }
}
static void E3_isLongerThan()
{
    Console.WriteLine("Input sentence, then number to see if the sentence is longer than given number");

    bool result = IsLongerThan(Console.ReadLine(), Int32.Parse(Console.ReadLine()));
    Console.WriteLine(result);

    static bool IsLongerThan (string sentence, int length)
    {
        if (sentence.Length > length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
static void E4_celsiusToFahrenheitConverter()
{
    Console.WriteLine("Enter degrees Celsius, get back degrees Fahrenheit!");
    
    double fahrenheit = CelsiusToFahrenheit(Double.Parse(Console.ReadLine()));
    Console.WriteLine(fahrenheit);

    static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = celsius * 1.8 + 32;
        return fahrenheit;
    }
}
static void E5_addHyphenBetweenLetter()
{
    Console.WriteLine("Let's hyphe it up! Enter sentence!");

    string hyphenedString = AddHyphenBetweenLetter(Console.ReadLine());

    Console.WriteLine(hyphenedString);

    static string AddHyphenBetweenLetter(string sentence)
    {
        string hyphens = "";

        for (int i = 0; i < sentence.Length; i++)
        {
            if (i == sentence.Length - 1)
            {
                hyphens += sentence[i];
            }
            else
            {
                hyphens += $"{sentence[i]}-";
            }      
        }
        return hyphens;
    }

}
static void E6_myOwnStringJoin()
{
    Console.WriteLine(MyOwnStringJoin("=>", "Sverige", "Norge", "Finland"));

    static string MyOwnStringJoin(string joiner, params string[] strings)
    {
        string joinedStrings = "";

        for (int i = 0; i < strings.Length; i++)
        {
            if (i == 0)
            {
                joinedStrings += strings[i];
            }
            else
            {
                joinedStrings += joiner + strings[i];
            }
        }
        return joinedStrings;
    }
}
static void E7_avgValue()
{
    int[] numbers = new int[] { 9, 1, 0 };

    Console.WriteLine(AvgValue(numbers));

    static double AvgValue(int[] numbers)
    {
        double sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Length;
    }
}
static void E8_NumberToWords()
{
    foreach (string number in NumberToWords(76584119))
    {
        Console.WriteLine(number);
    }

    static string[] NumberToWords(int number)
    {
        
        string numberAsString = number.ToString();
        string[] numberAsWords = new string[numberAsString.Length];

        for (int i = 0; i < numberAsWords.Length; i++)
        {
            if (numberAsString[i] == '0')
            {
                numberAsWords[i] = "Zero";
            }
            else if (numberAsString[i] == '1')
            {
                numberAsWords[i] = "One";
            }
            else if (numberAsString[i] == '2')
            {
                numberAsWords[i] = "Two";
            }
            else if (numberAsString[i] == '3')
            {
                numberAsWords[i] = "Three";
            }
            else if (numberAsString[i] == '4')
            {
                numberAsWords[i] = "Four";
            }
            else if (numberAsString[i] == '5')
            {
                numberAsWords[i] = "Five";
            }
            else if (numberAsString[i] == '6')
            {
                numberAsWords[i] = "Six";
            }
            else if (numberAsString[i] == '7')
            {
                numberAsWords[i] = "Seven";
            }
            else if (numberAsString[i] == '8')
            {
                numberAsWords[i] = "Eight";
            }
            else if (numberAsString[i] == '9')
            {
                numberAsWords[i] = "Nine";
            }
            
        }
        return numberAsWords;
    }
}
static void E9_IntegerToText()
{
    Console.WriteLine("Input number to textify!");
    Console.WriteLine(IntegerToText(UInt16.Parse(Console.ReadLine())));
    
    static string IntegerToText(ushort number)
    {

        string numberAsString = number.ToString();

        string numberAsWords = "";
        
        if (numberAsString.Length == 5)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    numberAsWords += $"{TenToNinety(numberAsString[i], numberAsString[i + 1])} {OneToNine(numberAsString[i + 1], numberAsString[i])} Thousand "; 
                }
                else if (i == 2)
                {
                    if (numberAsString[i] != '0')
                    {
                        numberAsWords += $"{OneToNine(numberAsString[i])} Hundred ";
                    }                     
                }
                else if (i == 3)
                {
                    numberAsWords += $"{TenToNinety(numberAsString[i], numberAsString[i + 1])} {OneToNine(numberAsString[i + 1], numberAsString[i])}";
                }
            }
        }
        else if (numberAsString.Length == 4)
        {
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    numberAsWords += $"{OneToNine(numberAsString[i])} Thousand ";
                }
                else if (i == 1)
                {
                    if (numberAsString[i] != '0')
                    {
                        numberAsWords += $"{OneToNine(numberAsString[i])} Hundred ";
                    }
                }
                else if (i == 2)
                {
                    numberAsWords += $"{TenToNinety(numberAsString[i], numberAsString[i + 1])} {OneToNine(numberAsString[i + 1], numberAsString[i])}";
                }
            }
        }
        else if (numberAsString.Length == 3)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    numberAsWords += $"{OneToNine(numberAsString[i])} Hundred ";
                }
                else if (i == 1)
                {
                    numberAsWords += $"{TenToNinety(numberAsString[i], numberAsString[i + 1])} {OneToNine(numberAsString[i + 1], numberAsString[i])}";
                }
            }
        }
        else if (numberAsString.Length == 2)
        {
            
            numberAsWords += $"{TenToNinety(numberAsString[0], numberAsString[1])} {OneToNine(numberAsString[1], numberAsString[0])}";
          
        }
        else
        {
            numberAsWords += OneToNine(numberAsString[0]);
        }
        return numberAsWords;
  
    }
    static string TenToNinety(char tens, char ones)
    {
        if (tens == '0')
        {
            return "";
        }
        else if (tens == '1')
        {
            if (ones == '0')
            {
                return "Ten";
            }
            else if (ones == '1')
            {
                return "Eleven";
            }
            else if (ones == '2')
            {
                return "Twelve";
            }
            else if (ones == '3')
            {
                return "Thirteen";
            }
            else if (ones == '4')
            {
                return "Fourteen";
            }
            else if (ones == '5')
            {
                return "Fifteen";
            }
            else if (ones == '6')
            {
                return "Sixteen";
            }
            else if (ones == '7')
            {
                return "Seventeen";
            }
            else if (ones == '8')
            {
                return "Eighteen";
            }
            else if (ones == '9')
            {
                return "Nineteen";
            }
        }
        else if (tens == '2')
        {
            return "Twenty";
        }
        else if (tens == '3')
        {
            return "Thirty";
        }
        else if (tens == '4')
        {
            return "Fourty";
        }
        else if (tens == '5')
        {
            return "Fifty";
        }
        else if (tens == '6')
        {
            return "Sixty";
        }
        else if (tens == '7')
        {
            return "Seventy";
        }
        else if (tens == '8')
        {
            return "Eighty";
        }
        else if (tens == '9')
        {
            return "Ninety";
        }
        return "Invalid input";
    }
    static string OneToNine(char ones, char tens = 'x')
    {
        if (tens == '1' || tens == '0' && ones == '0')
        {
            return "";
        }
        else if (ones == '0')
        {
            if (tens == 'x')
            {
                return "Zero";
            }
            else
            {
                return "";
            }
        }
        else if (ones == '1')
        {
            return "One";
        }
        else if (ones == '2')
        {
            return "Two";
        }
        else if (ones == '3')
        {
            return "Three";
        }
        else if (ones == '4')
        {
            return "Four";
        }
        else if (ones == '5')
        {
            return "Five";
        }
        else if (ones == '6')
        {
            return "Six";
        }
        else if (ones == '7')
        {
            return "Seven";
        }
        else if (ones == '8')
        {
            return "Eight";
        }
        else if (ones == '9')
        {
            return "Nine";
        }
        return "Invalid input";
    }

}
static void E10_IndexesOf()
{
    int[] indexesCorrespondingToInput = IndexesOf("Hello World", 'W');
    
    foreach (int index in indexesCorrespondingToInput)
    {
        Console.WriteLine(index);
    }

    static int[] IndexesOf(string text, char c)
    {
        int neededIndexes = 0;
        int currentIndex = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == c)
            {
                neededIndexes++;
            }
        }

        int[] indexes = new int[neededIndexes];

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == c)
            {
                indexes[currentIndex] = i;
                currentIndex++;
            }
        }

        return indexes;
    }
}
static void E11_ThrowDice()
{

    Console.WriteLine(ThrowMultipleDice(10, 100)); 

    static int ThrowDice(int sides = 6)
    {
        Random r = new Random();
        return r.Next(1, sides + 1);
    }
    static int ThrowMultipleDice(int n, int sides)
    {
        int result = 0;
        
        for (int i = 0; i < n; i++)
        {
            int roll = ThrowDice(sides);
            Console.WriteLine($"Roll {i + 1}: {roll}");
            result += roll;
        }

        return result;
    }

}
static void E12_DrawABox()
{
    //Console.BufferHeight = 100;
    //Console.BufferWidth = 200;
    Random r = new Random();

    Console.WriteLine("Press button to start.");
    Console.ReadKey();

    for (int i = 0; i < 20; i++)
    {
        DrawABox(r.Next(3, 10), r.Next(4, 8), r.Next(1, 100), r.Next(1, 10));
        Thread.Sleep(500);
    }
    Console.ReadKey();
    static void DrawABox(int width, int height, int left = 0, int top = 0)
    {
        
        for (int i = 0; i < height; i++)
        {
            Console.SetCursorPosition(left, top++);

            for (int j = 0; j < width; j++)
            {
                if (i == 0 || i == height - 1)
                {
                    Console.Write('#');
                }
                else if (j == 0 || j == width - 1)
                {
                    Console.Write('#');
                }
                else
                {
                    Console.Write('-');
                }
            }
            Console.WriteLine();
        }
    }
}
static void E13_AtGame()
{
    ConsoleKeyInfo cki;

    int[] playerXYPositions = new int[2] {6, 6};

    do
    {
        Console.WriteLine("Move your @!\nUse Arrows!\nEsc to escape");
        playerXYPositions = DrawABox(12, 12, playerXYPositions);

        cki = Console.ReadKey();

        if (cki.Key == ConsoleKey.UpArrow)
        {
            if (playerXYPositions[1] != 0)
            {
                playerXYPositions[1] = playerXYPositions[1] - 1;
            }
        }
        else if (cki.Key == ConsoleKey.DownArrow)
        {
            if (playerXYPositions[1] != 11)
            {
                playerXYPositions[1] = playerXYPositions[1] + 1;
            }
        }
        else if (cki.Key == ConsoleKey.LeftArrow)
        {
            if (playerXYPositions[0] != 0)
            {
                playerXYPositions[0] = playerXYPositions[0] - 1;
            }
        }
        else if (cki.Key == ConsoleKey.RightArrow)
        {
            if (playerXYPositions[0] != 11)
            {
                playerXYPositions[0] = playerXYPositions[0] + 1;
            }
        }

        Console.Clear();

    } while (cki.Key != ConsoleKey.Escape);

    static int[] DrawABox(int width, int height, int[] XY)
    {

        for (int i = 0; i < height; i++)
        {
            
            for (int j = 0; j < width; j++)
            {
                if (i == XY[1] && j == XY[0])
                {
                    Console.Write('@');
                }
                else if (i == 0 || i == height - 1)
                {
                    Console.Write('#');
                }
                else if (j == 0 || j == width - 1)
                {
                    Console.Write('#');
                }
                else
                {
                    Console.Write('-');
                }
            }
            Console.WriteLine();
        }
        return XY;
    }
}
static void E14_Worms()
{
    //Snake - hoarseProgramming

    //Todo
    //Fancier start screen
    //Save highscore in file, inbetween sessions   
    Console.CursorVisible = false;
    int highscore = 0;
    while (true)
    {
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Play Snake!");
        Console.WriteLine("Press SPACE to start");
        Console.WriteLine("Press ESC to quit");
        Console.WriteLine($"Highscore {highscore}");
        ConsoleKeyInfo cki;
        cki = Console.ReadKey(true);
        if (cki.Key == ConsoleKey.Spacebar)
        {
            Console.Clear();
            highscore = playGame(highscore);
        }
        else if (cki.Key == ConsoleKey.Escape)
        {
            break;
        }
        Console.Clear();
    }
    Console.WriteLine("See ya!");

    //Functions
    static int playGame(int highscore)
    {
        //Setup variables
        ConsoleKey lastPressedKey = ConsoleKey.None;
        Random r = new Random();
        int score = 0;

        //Playingfield
        int playingFieldWidth = 15;
        int playingFieldHeight = 10;
        char[,] playingField = new char[playingFieldWidth, playingFieldHeight];

        //Player
        bool playerIsAlive = true;
        string[] playerPositionXY = new string[playingFieldHeight * playingFieldWidth - (playingFieldHeight - 2) * 2 - playingFieldWidth * 2];
        int playerPositionX = r.Next(1, playingFieldWidth - 1);
        int playerPositionY = r.Next(1, playingFieldHeight - 1);
        playerPositionXY[0] = $"{playerPositionX} {playerPositionY}";
        int[] playerVelocityXY = new int[2];
        int playerLength = 1;
        int playerSpeed = 1;

        //Food
        string foodPositionXY = String.Empty;
        foodPositionXY = MakeFood(foodPositionXY, playerPositionXY, playerLength, playingFieldWidth, playingFieldHeight);
        bool needFood = false;
        

        //Game Loop
        while (playerIsAlive)
        {
            //Movement input
            if (Console.KeyAvailable)
            {  
                ConsoleKeyInfo cki;
                cki = Console.ReadKey(true);
                lastPressedKey = cki.Key;
                playerVelocityXY = MovePlayer(lastPressedKey, playerVelocityXY[0], playerVelocityXY[1]);
            }
            playerPositionX += playerVelocityXY[0];
            playerPositionY += playerVelocityXY[1];
            needFood = FoundFood(foodPositionXY, playerPositionXY);
            if (needFood)
            {
                foodPositionXY = MakeFood(foodPositionXY, playerPositionXY, playerLength, playingFieldWidth, playingFieldHeight);
                needFood = false;
                playerLength++;
                score++;
                Console.Beep(440, 50);
                if ((playerLength - 1) % 5 == 0)
                {
                    playerSpeed++;
                }
            }
            playerPositionXY = GetPlayerPosition(playerPositionXY, playerLength, playerPositionX, playerPositionY);
            playerIsAlive = Crashed(playerPositionXY, playerLength, playingFieldWidth, playingFieldHeight);

            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Score {score} Speed {playerSpeed}");
            PrintPlayingField(GetPlayingField(playingFieldWidth, playingFieldHeight, playerPositionXY, playerLength, foodPositionXY), foodPositionXY);
            Thread.Sleep(400 - playerSpeed * 40);
        }
        
        //Death screen
        Console.Clear();
        Console.WriteLine($"Score {score} Speed {playerSpeed}");
        PrintPlayingField(GetPlayingField(playingFieldWidth, playingFieldHeight, playerPositionXY, playerLength, foodPositionXY), foodPositionXY);
        Console.WriteLine("You crashed!");        
        Thread.Sleep(3500);
        Console.Clear();
        if (score > highscore)
        {
            highscore = score;
        }
        return highscore;

    }  
    static bool Crashed(string[] playerArrayXY, int playerLength, int playingFieldWidth, int playingFieldHeight)
    {
        //Check wall collision
        string[] playerHeadXY = playerArrayXY[0].Split(" ");
        if (Int32.Parse(playerHeadXY[0]) == 0 || Int32.Parse(playerHeadXY[0]) == playingFieldWidth - 1 || Int32.Parse(playerHeadXY[1]) == 0 || Int32.Parse(playerHeadXY[1]) == playingFieldHeight - 1)
        {
            Console.Beep(200, 150);
            Console.Beep(200, 150);
            Console.Beep(200, 150);
            Console.Beep(140, 200);
            return false;
        }
        //Check player collision
        for (int i = 1; i < playerLength; i++)
        {
            if (playerArrayXY[0] == playerArrayXY[i])
            {
                Console.Beep(200, 150);
                Console.Beep(200, 150);
                Console.Beep(200, 150);
                Console.Beep(140, 200);
                return false;
            }
        }
        return true;
    }
    static bool FoundFood(string foodPositionXY, string[] playerArrayXY)
    {
        bool foundFood = false;

        if (playerArrayXY[0] == foodPositionXY)
        {
            foundFood = true;
        }
        return foundFood;
 
    }
    static int[] MovePlayer(ConsoleKey direction, int velocityX, int velocityY)
    {  
        if (direction == ConsoleKey.UpArrow)
        {
            if (!(velocityY == 1))
            {
                velocityY = -1;
                velocityX = 0;
            }   
        }
        else if (direction == ConsoleKey.DownArrow)
        {
            if (!(velocityY == -1))
            {
                velocityY = 1;
                velocityX = 0;
            }
        }
        else if (direction == ConsoleKey.RightArrow)
        {
            if (!(velocityX == -1))
            {
                velocityX = 1;
                velocityY = 0;
            }
                
        }
        else if (direction == ConsoleKey.LeftArrow)
        {
            if (!(velocityX == 1))
            {
                velocityX = -1;
                velocityY = 0;
            }
        }
        int[] xYVelocity = new int[] {velocityX, velocityY};
        return xYVelocity;
    }
    static string[] GetPlayerPosition(string[] playerArray, int playerLength, int playerX, int playerY)
    {
        for (int i = playerLength - 1; i >= 0; i--)
        {
            if (i > 0)
            {
                playerArray[i] = playerArray[i - 1];
            }
            else
            {
                playerArray[i] = $"{playerX} {playerY}";
            }         
        }
        return playerArray;
    }
    static string MakeFood(string foodPosition, string[] playerArray, int playerLength, int playingFieldWidth, int playingFieldHeight)
    {
        Random r = new Random();
        bool foundSpotForFood = false;

        while (!foundSpotForFood)
        {
            foodPosition = $"{r.Next(1, playingFieldWidth - 1)} {r.Next(1, playingFieldHeight - 1)}";

            for (int i = 0; i < playerLength; i++)
            {
                if (!(foodPosition == playerArray[i]))
                {
                    foundSpotForFood = true;
                }
                else
                {
                    foundSpotForFood = false;
                    break;
                }
            }
            
        }

        return foodPosition;
    }
    static char[,] GetPlayingField(int width, int height, string[] playerPositionXY, int playerLength, string foodPositionXY)
    {
        Random r = new Random();
        char[,] playingField = new char[width, height];

        //Add background    
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {   
                if (y == 0 || y == height - 1 || x == 0 || x == width - 1)
                {
                    playingField[x, y] = '#';
                }
                //Commented out unnecessary code, but could be used for using different characters for top and bottom frame
                //else if (x == 0 || x == width - 1)
                //{
                //    playingField[x, y] = '#';
                //}
                else
                {
                    playingField[x, y] = ' ';
                }
            }
        }
        //Add player
        for (int i = playerLength - 1; i >= 0; i--)
        {
            string[] currentSnakePartXY = playerPositionXY[i].Split(' ');
            if (i == 0)
            {
                playingField[Int32.Parse(currentSnakePartXY[0]), Int32.Parse(currentSnakePartXY[1])] = '@';
            }
            else
            {
                playingField[Int32.Parse(currentSnakePartXY[0]), Int32.Parse(currentSnakePartXY[1])] = 'o';
            }
        }
        //Add Food
        string[] currentFoodPositionXY = foodPositionXY.Split(' ');
        if (playerPositionXY[0] == foodPositionXY)
        {
            playingField[Int32.Parse(currentFoodPositionXY[0]), Int32.Parse(currentFoodPositionXY[1])] = '@';
        }
        else
        {
            playingField[Int32.Parse(currentFoodPositionXY[0]), Int32.Parse(currentFoodPositionXY[1])] = '*';
        }
        
        
        
        return playingField;
    }
    static void PrintPlayingField(char[,] playingField, string foodPositionXY)
    {
        string[] foodXY = foodPositionXY.Split(" ");
        for (int y = 0; y < playingField.GetLength(1); y++)
        {
            for (int x = 0; x < playingField.GetLength(0); x++)
            {
                if (x == Int32.Parse(foodXY[0]) && y == Int32.Parse(foodXY[1]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(playingField[x, y]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(playingField[x, y]);
                }
            }
            Console.WriteLine();
        }
    }
}




