using System;

namespace OopsExample
{
    public class Oops
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        private int curAge = 14;

        // Default constructor
        public Oops()
        {
            Console.WriteLine("Default constructor");
        }

        // Constructor with parameters (overloaded)
        public Oops(string name, int age)
        {
            Console.WriteLine("Constructor with parameters");
            this.Name = name;
            this.Age = age;
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        // Setter for curAge
        public void setCurrentAge(int age)
        {
            this.curAge = age;
        }

        // Getter for curAge
        public int getCurrentAge()
        {
            return this.curAge;
        }

        // Property for curAge with getter and setter
        public int CurAge
        {
            get { return curAge; }
            set { curAge = value; }
        }
    }
}
