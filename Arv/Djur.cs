using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    internal class Djur
    {
        public string sound;
        public string environment;
        public int age;
        public string food;
        public string name;
        public void MakeSound()
        {
            Console.WriteLine(sound);
        }
        public void CheckAge()
        {
            Console.WriteLine("{0} är {1} år gammal",name,age);
        }
        public void CheckEnv()
        {
            Console.WriteLine("{0} bor i/på en {1}",name,environment);
        }
    }
}
