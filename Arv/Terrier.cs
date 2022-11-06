using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    internal class Terrier : Hund
    {
        public string hair;

        public Terrier(string name, int age, string sound, string environment, string food, int weigth, string hair)
        {
            this.name = name;
            this.age = age;
            this.sound = sound;
            this.environment = environment;
            this.food = food;
            this.weigth = weigth;
            this.hair = hair;
            
        }
        public Terrier() : this("No name", 0, "No sound", "No environment", "No food", 0, "No data")
        {

        }
        public void HairType()
        {
            Console.WriteLine("Hunden har {0} hår", hair);
        }

    }
}
