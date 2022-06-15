using System;

namespace Telefon_Rehberi_Uygulaması
{
    public class Persons
    {
        string name;
        string surname;
        string phoneNumber;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public Persons(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }
        public Persons()
        {

        }
    }
}
