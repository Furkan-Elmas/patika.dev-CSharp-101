
class MainClass
{
    static void Main()
    {
        string sentence = String.Empty;
        string[] words;

        while (true)
        {
            try
            {

                Console.WriteLine("Lütfen bir cümle girin");
                sentence = Console.ReadLine().Trim();
                words = sentence.Split(' ');
                break;
            }

            catch
            {
                Console.WriteLine("Yanlış değer girdiniz!");
            }
        }

        int wordCount = words.Length;
        int letterCount = 0;

        for (int i = 0; i < sentence.Length; i++)
        {
            if ((char.ToLower(sentence[i]) >= 'a' && char.ToLower(sentence[i]) <= 'z') || char.ToLower(sentence[i]) == 'ç' || char.ToLower(sentence[i]) == 'ğ' || sentence[i] == 'ı' || sentence[i] == 'İ' || char.ToLower(sentence[i]) == 'ö' || char.ToLower(sentence[i]) == 'ü' || char.ToLower(sentence[i]) == 'ş')
            {
                letterCount++;
            }
        }
        Console.WriteLine("Toplam kelime: " + wordCount);
        Console.WriteLine("Toplam harf: " + letterCount);
    }
}
