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
            string stringVar = "Hello, World!";
            Console.WriteLine("String: " + stringVar);

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