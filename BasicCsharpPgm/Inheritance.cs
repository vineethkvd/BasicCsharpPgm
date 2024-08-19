using System;

namespace InheritanceExample
{
    public class Animal
    {
        // Property
        public string Name { get; set; }

        // Constructor
        public Animal(string name)
        {
            Name = name;
        }

        // Method
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        // Virtual method (can be overridden in derived classes)
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }


    public class Dog : Animal
    {
        // Constructor
        public Dog(string name) : base(name)
        {
        }

        // Override the virtual method from the base class
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} barks.");
        }

        // Additional method specific to Dog
        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching a ball.");
        }
    }
}
