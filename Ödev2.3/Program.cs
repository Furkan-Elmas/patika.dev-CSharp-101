using System;
using System.Collections.Generic;

class VowelsInSentence
{
    static void Main()
    {
        char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        int vowelCount = 0;

        Console.WriteLine("Bir cümle girin: ");

        string sentence = Console.ReadLine();
        char[] vowelsInSentence = new char[sentence.Length];

        foreach (char letter in sentence)
        {
            if (vowels.Contains(letter))
            {
                vowelsInSentence[vowelCount] = letter;
                vowelCount++;
            }
        }

        Array.Sort(vowelsInSentence);

        Console.WriteLine("\nCümledeki sesli harfler: ");

        foreach (char letter in vowelsInSentence)
        {
            Console.Write(letter);
        }

        Console.ReadLine();
    }
}