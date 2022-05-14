
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

        Console.Write("Girdiğiniz çift sayılar: ");

        foreach (int i in list)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }
    }
}
