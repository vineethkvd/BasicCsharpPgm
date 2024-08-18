using System;
namespace DataType
{
    class DataTpes
    {
        public void DisplayDataTypes()
        {
            // Integer data type
            int intVar = 10;
            Console.WriteLine("Integer: " + intVar);
            Console.WriteLine("Type: " + intVar.GetType());
            // Floating-point data type
            float floatVar = 3.14f;
            Console.WriteLine("Float: " + floatVar);

            // Double data type
            double doubleVar = 3.14159;
            Console.WriteLine("Double: " + doubleVar);

            // Character data type
            char charVar = 'A';
            Console.WriteLine("Character: " + charVar);

            // String data type
            string stringVar = "Hello";
            string stringVar2 = "Vineeth";
            // 1. Concatenation using the + operator
            Console.WriteLine("Concatenation using + operator: " + stringVar + " " + stringVar2);

            // 2. Using String.Format
            Console.WriteLine(string.Format("Using String.Format: {0} {1}", stringVar, stringVar2));

            // 3. Using String Interpolation
            Console.WriteLine($"Using String Interpolation: {stringVar} {stringVar2}");

            // 4. Using Composite Formatting
            Console.WriteLine("Using Composite Formatting: {0} {1}", stringVar, stringVar2);


            // Boolean data type
            bool boolVar = true;
            Console.WriteLine("Boolean: " + boolVar);
        }
        public string DisplayResult(int num1,int num2)
        {
            int sum = num1 + num2;
            return sum.ToString();
        }

    }
}