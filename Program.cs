// Console.Write("Введите строку: ");
// string text = Console.ReadLine() ?? "";

// //№3
// int CountCharacter(string text, char target)
// {
//     int count = 0;

//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             count++;
//         }
//     }

//     return count;
// }

// //№4
// int CountDigits(string text)
// {
//     int count = 0;

//     foreach (char symbol in text)
//     {
//         if (char.IsDigit(symbol))
//         {
//             count++;
//         }
//     }

//     return count;
// }

// int CountLetters(string text)
// {
//     int count = 0;
//     foreach (char symbol in text)
//     {
//         if (char.IsLetter(symbol))
//         {
//             count++;
//         }
//     }
//     return count;
// }
// //№5
// int FindCharacterIndex(string text, char target)
// {
//     int index = -1;

//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             return i;
//         }
//     }

//     return index;
// }
// //№7
// int CountWords(string text)
// {
//     string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     return words.Length;
// }
// //№8
// // Console.WriteLine(">>> Анализ строки <<<");
// // Console.WriteLine();
// // Console.WriteLine($"Исходная строка: [{text}]");
// // Console.WriteLine($"Длина: {text.Length}");
// // Console.WriteLine($"Букв: {CountLetters(text)}");
// // Console.WriteLine($"Цифр: {CountDigits(text)}");
// // Console.WriteLine($"Пробелов: {CountCharacter(text, ' ')}");
// // Console.WriteLine($"Слов: {CountWords(text)}");
// // Console.WriteLine($"Без пробелов по краям: [{text.Trim()}]");
// // Console.WriteLine($"Верхний регистр: [{text.ToUpper()}]");
// // Console.WriteLine($"Замена пробелов: [{text.Replace(' ', '_')}]");

// // Console.Write("Введите один символ для поиска: ");
// // char target = Convert.ToChar(Console.ReadLine());
// // int res = FindCharacterIndex(text, target);
// // if (res == -1)
// // {
// //     Console.WriteLine("Символ не найден");
// // }
// // else
// // {
// //     Console.WriteLine($"Первый индекс: {res}");
// // }



// // Console.WriteLine(CountLetters("Ёж и C#"));
// // Console.WriteLine(CountDigits("A0Б9!"));
// // Console.WriteLine(CountCharacter("aAa", 'a'));
// // Console.WriteLine(FindCharacterIndex("тест", 'т'));
// // Console.WriteLine(FindCharacterIndex("", 'т'));
// // Console.WriteLine(CountWords("  одно   два  "));




// //Самостоятельное задание
// //№1
// int FindLastCharacterIndex(string text, char target)
// {
//     int index = -1;
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             index = i;
//         }
//     }
//     return index;
// }
// Console.WriteLine(FindLastCharacterIndex("", 'z'));

// //№3
int CountVowels(string text)
{
    int count = 0;
    foreach (char c in text)
    {
        char lower = char.ToLowerInvariant(c);
        if (lower == 'а'|| lower == 'е' || lower == 'ё' || lower == 'и' || lower == 'о' || lower == 'у' || lower == 'ы' || lower == 'э' || lower == 'ю' || lower == 'я')
        {
            count++;
        } 
    }
    return count;
}

Console.WriteLine(CountVowels("ритм"));