using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    internal class Katt : Djur
    {
        public string gender;

        public Katt(string name, int age, string sound, string environment, string food, string gender)
        {
            this.name = name;
            this.age = age;
            this.sound = sound;
            this.environment = environment;
            this.food = food;
            this.gender = gender;
        }
        public Katt() : this("No name", 0, "No sound", "No environment", "No food","No gender")
        {

        }

        public void CheckGender()
        {
            Console.WriteLine("Kattens kön är: {0}", gender);
        }
    }
}
