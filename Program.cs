// string text = "Код 2026";

// Console.WriteLine(text.Length);
// Console.WriteLine(text[0]);
// Console.WriteLine(text[text.Length - 1]);

//№3
int CountCharacter(string text, char target)
{
    int count = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            count++;
        }
    }

    return count;
}

//№4
int CountDigits(string text)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (char.IsDigit(symbol))
        {
            count++;
        }
    }

    return count;
}

int CountLetters(string text)
{
    int count = 0;
    foreach (char symbol in text)
    {
        if (char.IsLetter(symbol))
        {
            count++;
        }
    }
    return count;
}
//№5
int FindCharacterIndex(string text, char target)
{
    int index = -1;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            return i;
        }
    }

    return index;
}

Console.WriteLine(FindCharacterIndex("banana", 'a'));
Console.WriteLine(FindCharacterIndex("banana", 'b'));
Console.WriteLine(FindCharacterIndex("banana", 'z'));
Console.WriteLine(FindCharacterIndex("", 'a'));