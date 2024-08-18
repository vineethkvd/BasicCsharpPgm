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
        public void DisplayStringMethods()
        {
            string stringVar = "  Hello, Vineeth!  ";

            // 1. Length of the string
            Console.WriteLine($"Length of the string: {stringVar.Length}");
            // 2. ToUpper and ToLower
            Console.WriteLine($"ToUpper: {stringVar.ToUpper()}");
            Console.WriteLine($"ToLower: {stringVar.ToLower()}");

            // 3. Trim (removes leading and trailing white spaces)
            Console.WriteLine($"Trimmed: '{stringVar.Trim()}'");
            // 6. Contains (checks if a substring is present)
            Console.WriteLine($"Contains 'Vineeth': {stringVar.Contains("Vineeth")}");
            Console.WriteLine($"Contains 'World': {stringVar.Contains("World")}");

            // 7. IndexOf (finds the index of a substring)
            Console.WriteLine($"Index of 'Vineeth': {stringVar.IndexOf("Vineeth")}");

            // 8. StartsWith and EndsWith
            Console.WriteLine($"StartsWith 'Hello': {stringVar.StartsWith("Hello")}");
            Console.WriteLine($"EndsWith '!': {stringVar.EndsWith("!")}");
            // 9. Split (splits the string into an array based on a delimiter)
            string[] splitString = stringVar.Split(',');
            Console.WriteLine("Split by ',':");
            foreach (var part in splitString)
            {
                Console.WriteLine(part.Trim());
            }

        }
        public string DisplayResult(int num1,int num2)
        {
            int sum = num1 + num2;
            return sum.ToString();
        }

    }
}

