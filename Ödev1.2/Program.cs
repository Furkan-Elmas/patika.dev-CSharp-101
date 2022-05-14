
class MainClass
{
    static void Main()
    {
        int n = 0;
        int m = 0;

        while (true)
        {
            try
            {
                Console.WriteLine("Lütfen pozitif bir sayı girin(n): "); // Tam sayı olması gerektiğini kimse söylemedi :P
                n = Convert.ToInt32(Math.Round(Convert.ToDouble(Console.ReadLine()), 0));

                Console.WriteLine("Lütfen pozitif bir sayı girin(m): ");
                m = Convert.ToInt32(Math.Round(Convert.ToDouble(Console.ReadLine()), 0));

                if (n > 0 && m > 0)
                    break;
                else
                    Console.WriteLine("Negatif sayı giremezsiniz!");
            }
            catch
            {
                Console.WriteLine("Yanlış değer girdiniz!");
            }
        }

        double[] list = new double[n];

        while (true)
        {
            try
            {
                double value = 0;

                Console.WriteLine(n + " adet pozitif sayı girin");

                for (int i = 0; i < n; i++)
                {
                    value = Convert.ToDouble(Console.ReadLine());
                    if (value > 0)
                        list[i] = value;
                    else
                    {
                        Console.WriteLine("Yanlış değer girdiniz!");
                        i--;
                    }
                }
                break;
            }
            catch
            {
                Console.WriteLine("Yanlış değer girdiniz!");
            }
        }

        Console.Write("Girdiğiniz sayıların " + m + " sayısına tam bölünenleri: ");

        foreach (int i in list)
        {
            if (i % m == 0)
                Console.Write(i + " ");
        }
    }
}
