using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    internal class Ko : Djur
    {
        public string color;

        public Ko(string name, int age, string sound, string environment, string food, string color)
        {
            this.name = name;
            this.age = age;
            this.sound = sound;
            this.environment = environment;
            this.food = food;
            this.color = color;
        }
        public Ko() : this("No name", 0, "No sound", "No environment", "No food", "No color")
        {

        }
        public void CheckColor()
        {
            Console.WriteLine("Färgen på kon är {0}", color);
        }
    }
}
