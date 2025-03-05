using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Cow : Animal
    {
        public Cow(string name) : base(name) { }
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Moo!");
        }
    }
    internal class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Meow!");
        }
    }
    internal class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Bark!");
        }
    }
    internal class Animal
    {
        private readonly string _name;
        public Animal(string name)
        {
            _name = name;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{_name} says...");
        }
    }
}
