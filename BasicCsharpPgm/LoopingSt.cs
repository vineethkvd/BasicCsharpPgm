using System;
namespace LoopingSt
{
    class Loop
    {
        // Example of a for loop
        public void ForLoopExample()
        {
            Console.WriteLine("For Loop Example:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteration {i + 1}");
            }
        }

        // Example of a while loop
        public void WhileLoopExample()
        {
            Console.WriteLine("\nWhile Loop Example:");
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine($"Iteration {counter + 1}");
                counter++;
            }
        }

        // Example of a do-while loop
        public void DoWhileLoopExample()
        {
            Console.WriteLine("\nDo-While Loop Example:");
            int counter = 0;
            do
            {
                Console.WriteLine($"Iteration {counter + 1}");
                counter++;
            } while (counter < 5);
        }

        // Example of a foreach loop
        public void ForEachLoopExample()
        {
            Console.WriteLine("\nForeach Loop Example:");
            string[] colors = { "Red", "Green", "Blue", "Yellow", "Purple" };

            foreach (string color in colors)
            {
                Console.WriteLine($"Color: {color}");
            }
        }
    }
}
