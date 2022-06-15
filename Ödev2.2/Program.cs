using System;
using System.Collections;
using System.Collections.Generic;

class Max3Min3Numbers
{
    static void Main()
    {
        int[] numbers = new int[5];

        Console.WriteLine("Toplam 20 adet pozitif tamsayı girin: ");

        for (int i = 0; i < 5; i++)
        {
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                while (input < 0)
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                numbers[i] = input;
            }
            catch (Exception)
            {
                Console.WriteLine("Yanlış karakter girdiniz. Numerik bir değer girin.");
                i--;
                continue;
            }
        }

        Array.Sort(numbers);

        TakeAvarage(numbers);
    }
    static void TakeAvarage(int[] numbers)
    {
        int[] maxNumbers = new int[3] {numbers[numbers.Length-1], numbers[numbers.Length - 2], numbers[numbers.Length - 3] };
        int[] minNumbers = new int[3] {numbers[0], numbers[1], numbers[2]};

        decimal maxNumbersAvarage = Convert.ToDecimal(maxNumbers.Sum()) / 3;
        decimal minNumbersAvarage = Convert.ToDecimal(minNumbers.Sum()) / 3;

        Console.WriteLine("\nEn büyük 3 sayının ortalaması: ");
        Console.WriteLine(maxNumbersAvarage);
        Console.WriteLine("\nEn küçük 3 sayının ortalaması: ");
        Console.WriteLine(minNumbersAvarage);
        Console.WriteLine("\nOrtalamalarının toplamları: ");
        Console.WriteLine(maxNumbersAvarage + minNumbersAvarage);
        Console.ReadLine();
    }
}