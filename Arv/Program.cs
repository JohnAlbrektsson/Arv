using System;
using System.Runtime.CompilerServices;

namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objects
            Ko ko = new Ko("Nils", 2, "muuu","bondgård","gräs","brun");
            Hund hund = new Hund("Bosse", 5, "woof", "bondgård","kött", 4);
            Katt katt = new Katt("Jack", 1, "Mjau", "Lägenhet", "fisk", "hane");
            Chihuahua chi = new Chihuahua("Bella", 1, "woof", "Lägenhet", "Kyckling", 1, "liten");
            Terrier terrier = new Terrier("Bonita", 7, "woof", "Hus", "Kött", 3, "kort");

            //Calls all Ko methods
            ko.CheckAge();
            ko.CheckColor();
            ko.CheckEnv();
            ko.MakeSound();

            Console.WriteLine("----------");
            //Calls all Katt methods
            katt.CheckAge();
            katt.CheckGender();
            katt.CheckEnv();
            katt.MakeSound();

            Console.WriteLine("----------");
            //Calls all Hund methods
            hund.CheckAge();
            hund.CheckWeight();
            hund.CheckEnv();
            hund.MakeSound();

            Console.WriteLine("----------");
            //Calls all Chihuahua methods
            chi.CheckAge();
            chi.CheckWeight();
            chi.CheckEnv();
            chi.MakeSound();
            chi.CheckSize();

            Console.WriteLine("----------");
            //Calls all Terrier methods
            terrier.CheckAge();
            terrier.CheckWeight();
            terrier.CheckEnv();
            terrier.MakeSound();
            terrier.HairType();
        }
    }
}
