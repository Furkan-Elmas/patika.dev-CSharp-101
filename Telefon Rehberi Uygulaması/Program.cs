using System;

namespace Telefon_Rehberi_Uygulaması
{
    public class PhoneBook
    {
        static List<Persons> phoneBookList = new(); // Kişilerin saklandığı liste

        static string continueOrExit = "continue"; // Çıkış yapılmadığı sürece seçenek ekranına dönüş sağlamak için

        static int choice; // Kulanıcıdan alınacak seçim

        public static void Main()
        {
            while (continueOrExit == "continue")
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("1.Telefon Numarası Kaydet");
                Console.WriteLine("2.Telefon Numarası Sil");
                Console.WriteLine("3.Telefon Numarası Güncelle");
                Console.WriteLine("4.Rehberi Listele");
                Console.WriteLine("5.Rehberde Arama Yap");

                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                MakeChoice(choice);
            }
        }

        static void MakeChoice(int choice)
        {
            switch (choice) // Kullanıcının yaptığı seçimin altındaki metod çalışacak
            {
                case 1:
                    SaveNumber();
                    break;
                case 2:
                    DeleteNumber();
                    break;
                case 3:
                    UpdateNumber();
                    break;
                case 4:
                    ShowPhoneBook();
                    break;
                case 5:
                    SearchInPhoneBook();
                    break;
            }
        }

        public static void SaveNumber()
        {
            Persons person = new(); //Kişilerin bilgilerini aldığımız sınıftan yeni bir kişi türetiliyor

            Console.WriteLine("Lütfen isim giriniz             :");
            person.Name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz          :");
            person.Surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            person.PhoneNumber = Console.ReadLine();

            phoneBookList.Add(person); // Bilgilerini aldığımız kişi listeye kaydediliyor
            Console.WriteLine("Kişi başarıyla eklendi!");
            Console.WriteLine();
        }

        public static void DeleteNumber()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");

            string nameOrSurname = string.Empty; // Kullanıcıdan alacağımız isim ya da soyisim değişkeni

            nameOrSurname = Console.ReadLine().Trim();


            foreach (var person in phoneBookList) // Listedeki kişiler foreach döngüsü ile çekilip kontrol ediliyor
            {
                if (person.Name == nameOrSurname || person.Surname == nameOrSurname) // Eğer istenilen kişinin adı ya da soyadı listede varsa bu bloğa girilecek
                {
                    Console.WriteLine(person.Name + " " + person.Surname + ": " + person.PhoneNumber);
                    Console.WriteLine("Bu kişi rehberden silinecek, emin misiniz? (e/h)");
                    if (Console.ReadLine() == "e")
                    {
                        Console.WriteLine("Kişi rehberden silindi.");
                        phoneBookList.Remove(person); // Kişi silindi
                        Console.WriteLine();
                        return; // Kişi bulunduğu için metod, return ile döndürülür
                    }
                }
            }
            // Kişi bulunamazsa, foreach döngüsü içerisindeki if bloğuna girilmez ve aşağıdaki blok çalışır
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız: ");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            if (Console.ReadLine() == "2")
            {
                MakeChoice(choice);
            }


        }
        public static void UpdateNumber()
        {
            Console.WriteLine("Lütfen güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");

            string nameOrSurname = string.Empty;


            nameOrSurname = Console.ReadLine().Trim();


            foreach (var person in phoneBookList)
            {
                if (person.Name == nameOrSurname || person.Surname == nameOrSurname) // Listede istenilen kişi varsa bu blok çalışır
                {
                    Console.WriteLine(person.Name + " " + person.Surname + ": " + person.PhoneNumber);
                    Console.WriteLine("\nKişinin bilgileri güncellenecek, verileri yeniden giriniz");

                    Console.WriteLine("Lütfen isim giriniz             :");
                    person.Name = Console.ReadLine();
                    Console.WriteLine("Lütfen soyisim giriniz          :");
                    person.Surname = Console.ReadLine();
                    Console.WriteLine("Lütfen telefon numarası giriniz :");
                    person.PhoneNumber = Console.ReadLine();
                    Console.WriteLine("\nKişinin bilgileri güncellendi!");
                    Console.WriteLine();
                    return; // Kişi bulunduğu için metod, return ile döndürülür.
                }
            }

            // Kişi bulunamazsa, foreach döngüsü içerisindeki if bloğuna girilmez ve aşağıdaki blok çalışır
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız: ");
            Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            if (Console.ReadLine() == "2")
            {
                MakeChoice(choice);
            }
        }
        public static void ShowPhoneBook()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");

            foreach (var person in phoneBookList) // Foreach döngüsü ile listedeki kişilerin bilgileri yazdırılır.
            {
                Console.WriteLine("İsim: " + person.Name);
                Console.WriteLine("Soyisim: " + person.Surname);
                Console.WriteLine("Telefon Numarası: " + person.PhoneNumber);
                Console.WriteLine("------------------------------------------------\n");
            }
        }
        public static void SearchInPhoneBook()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz: ");
            Console.WriteLine("**********************************************");

            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Lütfen görüntülemek istediğiniz kişinin adını ya da soyadını giriniz: ");

                string nameOrSurname = string.Empty;

                nameOrSurname = Console.ReadLine().Trim();

                foreach (var person in phoneBookList)
                {
                    if (person.Name == nameOrSurname || person.Surname == nameOrSurname)
                    {
                        Console.WriteLine("\nİsim: " + person.Name);
                        Console.WriteLine("Soyisim: " + person.Surname);
                        Console.WriteLine("Telefon Numarası: " + person.PhoneNumber);
                        Console.WriteLine("------------------------------------------------\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("Lütfen görüntülemek istediğiniz kişinin telefon numarasını giriniz: ");

                string phoneNumber = string.Empty;

                phoneNumber = Console.ReadLine().Trim();

                foreach (var person in phoneBookList)
                {
                    if (person.PhoneNumber == phoneNumber)
                    {
                        Console.WriteLine("\nİsim: " + person.Name);
                        Console.WriteLine("Soyisim: " + person.Surname);
                        Console.WriteLine("Telefon Numarası: " + person.PhoneNumber);
                        Console.WriteLine("------------------------------------------------\n");
                    }
                }
            }

        }
    }
}