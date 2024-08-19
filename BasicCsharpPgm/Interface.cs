using System;

namespace InterfaceExample
{

    /* No Implementation: Interfaces do not contain implementation. They only declare methods and properties.
    Multiple Interfaces: A class can implement multiple interfaces.
    Polymorphism: Interfaces provide a way to use polymorphism in C#. */
    public interface IAnimal
    {
        // Property
        string Name { get; set; }

        // Method
        void Eat();

        // Method with no implementation
        void MakeSound();
    }



    public class Dog : IAnimal
    {
        // Implementing the property from the interface
        public string Name { get; set; }

        // Constructor
        public Dog(string name)
        {
            Name = name;
        }

        // Implementing the Eat method from the interface
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        // Implementing the MakeSound method from the interface
        public void MakeSound()
        {
            Console.WriteLine($"{Name} barks.");
        }
    }


    public class Cat : IAnimal
    {
        // Implementing the property from the interface
        public string Name { get; set; }

        // Constructor
        public Cat(string name)
        {
            Name = name;
        }

        // Implementing the Eat method from the interface
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        // Implementing the MakeSound method from the interface
        public void MakeSound()
        {
            Console.WriteLine($"{Name} meows.");
        }
    }
}
