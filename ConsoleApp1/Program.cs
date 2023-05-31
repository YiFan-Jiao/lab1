using System;

int n = 0;
while(n <= 0)
{
    Console.WriteLine("Please enter integer value greater than zero");
    n = Int32.Parse(Console.ReadLine());
}

string?[] words = new string[n];

for(int i =0; i < words.Length; i++)
{
    Console.WriteLine($"Enter words {i+1}");

    string newWord = Console.ReadLine();

    bool onlyLetter = true;

    foreach (char c in newWord)
    {
        if (!char.IsLetter(c))
        {
            onlyLetter = false;
            break;
        }
    }

    if (newWord.Length > 0 && onlyLetter) 
    {
        if(!newWord.Contains(" "))
        {
            words[i] = newWord;
        }
        else
        {
            Console.WriteLine("Sorry but your input cannot contain spaces");
            i--;
        }
    } 
    else 
    {
        Console.WriteLine("Sorry but you must enter at least one character " +
            "and can only contain characters");
        i--;
    }
}


char charToCount;
Console.WriteLine("Please enter a character to count.");
ConsoleKeyInfo keyInfo = Console.ReadKey();
charToCount = keyInfo.KeyChar;
bool isValid = false;

while (!isValid)
{
    if (Char.IsLetter(charToCount))
    {
        isValid = true;
    }
    else
    {
        isValid = false;
        Console.WriteLine("\nPlease enter a character to count.");
        keyInfo = Console.ReadKey();
        charToCount = keyInfo.KeyChar;
    }
}



//Console.WriteLine($"\ncharacter you enter {charToCount}");

int charCount = 0;
int charLength = 0;
foreach(string word in words)
{
    //Console.WriteLine($"{word}");
    char[] chars = word.ToCharArray();
    charLength = charLength + chars.Length;
    foreach (char c in chars)
    {
        if(c == charToCount)
        {
            charCount++;
        }
    }
}

double part = Convert.ToDouble(charCount);
double whole = Convert.ToDouble(charLength);
Console.WriteLine($"\nThe letter‘{charToCount}’" +
    $"appears {charCount} times in the array. This" +
    $" letter makes up more than {(part / whole) * 100}% " +
    $"of the total number of characters.");
