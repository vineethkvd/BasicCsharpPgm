﻿using System;
using System.Collections;
using System.Collections.Generic;
namespace CsharpCollections
{
    class Collections
    {
        //array -->  Once an array is created, its size cannot be changed.
        // List --> The size of a list can change at runtime.
        // Example of List<T>
        // Example of Array
        public void ArrayExample()
        {
            Console.WriteLine("Array Example:");
            int[] numbers = { 1, 2, 3, 4, 5 }; // Array initialization

            // Modify an array element
            numbers[2] = 10; // Change the third element to 10

            // Display array elements
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        // Example of ArrayList
        //Add any type element
        public void ArrayListExample()
        {
            Console.WriteLine("\nArrayList Example:");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1); // Adding an integer
            arrayList.Add("Two"); // Adding a string
            arrayList.Add(3.0); // Adding a double

            // Modify an element
            arrayList[1] = "Modified";

            // Display elements
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Accessing an element with casting
            int firstElement = (int)arrayList[0];
            Console.WriteLine($"First element (after casting): {firstElement}");
        }
        public void ListExample()
        {
            Console.WriteLine("List<T> Example:");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Add(6); // Add an element
            numbers.Remove(3); // Remove an element

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        // Example of Dictionary<TKey, TValue>
        public void DictionaryExample()
        {
            Console.WriteLine("\nDictionary<TKey, TValue> Example:");
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "Alice", 30 },
                { "Bob", 25 }
            };

            ages["Charlie"] = 35; // Add a new key-value pair

            foreach (var kvp in ages)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        // Example of HashSet<T>
        public void HashSetExample()
        {
            Console.WriteLine("\nHashSet<T> Example:");
            HashSet<string> uniqueNames = new HashSet<string>
            {
                "Alice",
                "Bob",
                "Alice" // Duplicate, will be ignored
            };

            uniqueNames.Add("Charlie");

            foreach (string name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }

        // Example of Queue<T>
        public void QueueExample()
        {
            Console.WriteLine("\nQueue<T> Example:");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            Console.WriteLine(queue.Peek());

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }

        // Example of Stack<T>
        public void StackExample()
        {
            Console.WriteLine("\nStack<T> Example:");
            Stack<string> stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            //get the top value on the stack
            Console.WriteLine(stack.Peek());

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        // Example of LinkedList<T>
        public void LinkedListExample()
        {
            Console.WriteLine("\nLinkedList<T> Example:");
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("First");
            linkedList.AddLast("Second");
            linkedList.AddFirst("Zero");

            foreach (string item in linkedList)
            {
                Console.WriteLine(item);
            }
        }



        // Example of Hashtable
        public void HashtableExample()
        {
            Console.WriteLine("\nHashtable Example:");
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Alice", 30); // Adding key-value pairs
            hashtable.Add("Bob", 25);
            hashtable.Add("Charlie", 35);
            hashtable.Add(1, 35);

            // Modify a value
            hashtable["Alice"] = 31;

            // Display key-value pairs
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            // Accessing a value by key
            int aliceAge = (int)hashtable["Alice"];
            Console.WriteLine($"Alice's age: {aliceAge}");
        }
    }
}