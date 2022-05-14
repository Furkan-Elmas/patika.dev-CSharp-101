
class MainClass
{
    static void Main()
    {
        int n = 0;

        while (true)
        {
            try
            {
                Console.WriteLine("Lütfen pozitif bir sayı girin(n): "); // Tam sayı olması gerektiğini kimse söylemedi :P
                n = Convert.ToInt32(Math.Round(Convert.ToDouble(Console.ReadLine()), 0));

                if (n > 0)
                    break;
                else
                    Console.WriteLine("Negatif sayı giremezsiniz!");
            }

            catch
            {
                Console.WriteLine("Yanlış değer girdiniz!");
            }
        }

        string[] words = new string[n];

        while (true)
        {
            try
            {

                Console.WriteLine(n + " adet kelime girin");
                words  = Console.ReadLine().Trim().Split(' ');

                if (words.Length == n)
                    break;
                else if (words.Length < n)
                    Console.WriteLine("Az kelime girdiniz!");
                else if (words.Length > n)
                    Console.WriteLine("Çok kelime girdiniz!");
            }

            catch
            {
                Console.WriteLine("Yanlış değer girdiniz!");
            }
        }
        Array.Reverse(words);
        string result = string.Join(" ", words);
        Console.WriteLine(result);
    }
}
