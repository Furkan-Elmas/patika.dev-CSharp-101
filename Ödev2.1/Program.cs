using System;
using System.Collections;
using System.Collections.Generic;

class PrimeNumbers
{
    static void Main()
    {
        int[] numbers = new int[20];

        Console.WriteLine("Toplam 20 adet pozitif tamsayı girin: ");

        for (int i = 0; i < 20; i++)
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

        GetPrimes(numbers);

    }

    static void GetPrimes(int[] numbers)
    {
        List<int> primes = new List<int>();
        List<int> nonPrimes = new List<int>();

        foreach (int number in numbers)
        {
            if (number == 1)
            {
                nonPrimes.Add(number);
                continue;
            }
            if (number == 2)
            {
                primes.Add(number);
                continue;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    nonPrimes.Add(number);
                    break;
                }
                primes.Add(number);
                break;
            }
        }

        nonPrimes.Sort();
        nonPrimes.Reverse();
        primes.Sort();
        primes.Reverse();

        Console.WriteLine("\n*************** ASAL OLMAYAN SAYILAR ***************");
        foreach (int number in nonPrimes)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine("\nToplam Sayı: " + nonPrimes.Count);
        Console.WriteLine("Ortalama: " + Convert.ToDecimal(nonPrimes.Sum()) / nonPrimes.Count);

        Console.WriteLine("\n*************** ASAL SAYILAR ***************");
        foreach (int number in primes)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine("\nToplam Sayı: " + primes.Count);
        Console.WriteLine("Ortalama: " + Convert.ToDecimal(primes.Sum()) / primes.Count);
        Console.ReadLine();
    }
}
