//E1_LetterByLetter();
//E2_LetterByLetterNewLine();
//E3_LetterByLetterStarred();
//E4_LetterByLetterGreenAndRed();
//E5_LetterByLetterGreenDoubles();
//E6_LetterByLetterGreenSubstring();
//E9_LetterPyramid();
//E10_WordPyramid();
//E11_WordPyramidTwo();
//E12_RedWords();
//E13_RedLetters();
//E14_RedLetters2();
E15_RedLetters3();

static void E1_LetterByLetter()
{
    string greeting = "Hello World";

	foreach (char c in greeting)
	{
		if (!(c == ' '))
		{
            Console.Write(c);
		}
		else
		{
			break;
		}
	}
}
static void E2_LetterByLetterNewLine()
{
	string text = "This is just some other text";

	foreach (char c in text)
	{
		if (c == ' ')
		{
            Console.WriteLine();
		}
		else
		{
			Console.Write(c);
		}
	}
}
static void E4_LetterByLetterGreenAndRed()
{
	string greeting = "Hello World";

	foreach (char c in greeting)
	{
		switch (c)
		{
			case 'o':
				Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(c);
				break;
            case 'l':
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(c);
                break;
			default:
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(c);
				break;

        }
	}
}
static void E5_LetterByLetterGreenDoubles()
{
	string greeting = "OO1OO1OOO1OOOO1OOOO1OOOO1OOO1OOO";
	bool isDoubleLetter = false;

	for (int i = 0; i < greeting.Length; i++)
	{

        if (i == greeting.Length - 1)
        {
            if (isDoubleLetter)
            {
                isDoubleLetter = false;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(greeting[i]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(greeting[i]);
            }
        }
        else if (greeting[i] == greeting[i + 1])
		{
			isDoubleLetter = true;
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write(greeting[i]);
		}
		else
		{
			if (isDoubleLetter)
			{
				isDoubleLetter = false;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(greeting[i]);
            }
			else
			{
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.Write(greeting[i]);
			}
		}
	}
}
static void E6_LetterByLetterGreenSubstring()
{
	string rhyme = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
	string greenString = Console.ReadLine();
	int nextIndex; 

	for (int i = 0; i < rhyme.Length; i++)
	{
		nextIndex = rhyme.IndexOf(greenString, i);

        if (i == nextIndex)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			for (int j = 0; j < greenString.Length; j++)
			{
                Console.Write(rhyme[i + j]);
            }
            rhyme = rhyme.Remove(i, greenString.Length - 1);

        }
		else
		{
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write(rhyme[i]);
		}
	}
}
static void E9_LetterPyramid()
{
	string greeting = "Hello World!";

	for (int i = 0; i < greeting.Length; i++)
	{
		for (int j = 0; j <= i; j++)
		{
			Console.Write(greeting[i]);
		}
		Console.WriteLine();
	}
}
static void E10_WordPyramid()
{
    string rhyme = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
	int numberOfWords = 0;
	int startOfWord = 0;
	int endOfWord = 0;

	for (int i = 0; i < rhyme.Length; i++)
	{
		if (Char.IsWhiteSpace(rhyme[i]) || Char.IsPunctuation(rhyme[i]))
		{
			numberOfWords++;
		}
	}

	for (int i = 0; i < numberOfWords; i++)
	{
		for (int j = 0; j <= i; j++)
		{
			for (int k = startOfWord; k < rhyme.Length; k++)
			{
				if (Char.IsWhiteSpace(rhyme[k]) || Char.IsPunctuation(rhyme[k]))
				{
					Console.Write(' ');
					endOfWord = k + 1;
					break;
				}
				else
				{
					Console.Write(rhyme[k]);
				}
			}
		}
		startOfWord = endOfWord;
        Console.WriteLine();
	}
    
}
static void E11_WordPyramidTwo()
{
	int numberOfWords = 0;
	int startOfIndex = 0;
	int endOfIndex = 0;
    string rhyme = "How much. wood would a woodchuck! chuck if a woodchuck could chuck wood?";

	for (int i = 0; i < rhyme.Length; i++)
	{
		if (Char.IsWhiteSpace(rhyme[i]) || Char.IsPunctuation(rhyme[i]))
		{
			numberOfWords++;
		}
	}

	for (int i = 0; i < numberOfWords; i++)
	{
		for (int j = startOfIndex; j < rhyme.Length; j++)
		{
			if (Char.IsWhiteSpace(rhyme[j]) || Char.IsPunctuation(rhyme[j]))
			{
				endOfIndex = j;
				break;
			}

		}
        for (int k = 0; k < endOfIndex; k++)
        {
            if (Char.IsPunctuation(rhyme[k + 1]))
            {
                Console.Write($"{rhyme[k]}{rhyme[k + 1]}");
            }
			else
			{
				if (!Char.IsPunctuation(rhyme[k]))
				{
					Console.Write(rhyme[k]);
				}

			}
			startOfIndex = endOfIndex + 1;
            
        }
        Console.WriteLine();
    }	
}  
static void E12_RedWords()
{
    string sentenceToMakeRed = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
    int numberOfWords = FindNumberOfWords(sentenceToMakeRed);
	int startingIndex = 0;

	for (int i = 0; i < numberOfWords; i++)
	{
		int length = FindNextRedWord(startingIndex, sentenceToMakeRed);
		WriteSentence(length, startingIndex, sentenceToMakeRed);
		startingIndex = length + 1;
        Console.WriteLine();
    }

	static void WriteSentence(int length, int startingIndex, string sentence)
	{
		for (int i = 0; i < sentence.Length; i++)
		{
			if (i >= startingIndex && i < length)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(sentence[i]);
			}
			else
			{
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(sentence[i]);
            }
		}
	}
	static int FindNextRedWord(int startingIndex, string sentence)
	{
		int length = 0;
		
		for (int i = startingIndex; i < sentence.Length; i++)
		{
			if (Char.IsWhiteSpace(sentence[i]) || Char.IsPunctuation(sentence[i]))
			{
				length = i;
				break;
			}
		}
        return length;
    }
	static int FindNumberOfWords(string sentence)
	{
        int numberOfWords = 0;
        for (int i = 0; i < sentence.Length; i++)
        {
			
            if (Char.IsWhiteSpace(sentence[i]) || Char.IsPunctuation(sentence[i]))
            {
                numberOfWords++;
            }
			
        }
        return numberOfWords;
    }
    
}
static void E13_RedLetters()
{
	string letters = "abcdefghijklmnopqrstuvwxyz";
	int startingIndex = 0;

	for (int i = 0; i < letters.Length - 4; i++)
	{
		for (int j = 0; j < letters.Length; j++)
		{
			if (j >= startingIndex && j < startingIndex + 5)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(letters[j]);
			}
			else
			{
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(letters[j]);
            }
		}
		startingIndex++;
        Console.WriteLine();
	}
}
static void E14_RedLetters2()
{
	string sentence = Console.ReadLine();
	int endOfRedIndex = NextIndexOfFirstChar(sentence);

	for (int i = 0; i < sentence.Length; i++)
	{
		if (i <= endOfRedIndex)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(sentence[i]);
		}
		else
		{
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(sentence[i]);
        }
	}
	
	static int NextIndexOfFirstChar(string sentence)
	{
		int nextIndex = 0;
		for (int i = 1; i < sentence.Length; i++)
		{
			if (sentence[i] == sentence[0])
			{
				nextIndex = i;
				break;
			}
		}
		return nextIndex;
	}
}
static void E15_RedLetters3()
{
    string sentence = Console.ReadLine();
	int startOfRedIndex = 0;
    
    for (int i = 0; i < sentence.Length; i++)
    {
        int endOfRedIndex = NextIndexOfFirstChar(sentence, startOfRedIndex);

        for (int j = 0; j < sentence.Length; j++)
		{
            if (j >= startOfRedIndex && j <= endOfRedIndex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(sentence[j]);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(sentence[j]);
            }
        }
		startOfRedIndex++;
        Console.WriteLine();
    }

    static int NextIndexOfFirstChar(string sentence, int start)
    {
        int nextIndex = 0;

        for (int i = start + 1; i < sentence.Length; i++)
        {
            if (sentence[i] == sentence[start])
            {
                nextIndex = i;
                break;
            }
        }
        return nextIndex;
    }
}

