using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Arv
{
    internal class Hund : Djur
    {
        public int weigth;

        public Hund(string name, int age, string sound, string environment, string food, int weigth)
        {
            this.name = name;
            this.age = age;
            this.sound = sound;
            this.environment = environment;
            this.food = food;
            this.weigth = weigth;
        }
        public Hund() : this("No name", 0, "No sound", "No environment", "No food", 0)
        {

        }
        public void CheckWeight()
        {
            Console.WriteLine("{0} väger {1} kg",name,weigth);
        }
    }
}
