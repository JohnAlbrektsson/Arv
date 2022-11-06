using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    internal class Chihuahua : Hund
    {
        public string size;

        public Chihuahua(string name, int age, string sound, string environment, string food, int weigth, string size)
        {
            this.name = name;
            this.age = age;
            this.sound = sound;
            this.environment = environment;
            this.food = food;
            this.weigth = weigth;
            this.size = size;
        }
        public Chihuahua() : this("No name", 0, "No sound", "No environment", "No food", 0, "No data")
        {

        }
        public void CheckSize()
        {
            Console.WriteLine("hunden är {0}", size);
        }
    }
}
