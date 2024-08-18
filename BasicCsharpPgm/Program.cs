using Methods;
using CsharpOperators;
namespace BasicCsharpPgm
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of the DataTpes class
            //DataType.DataTpes dataTpes = new DataType.DataTpes();

            // Call the DisplayDataTypes method to show different data types
            //dataTpes.DisplayDataTypes();
            //dataTpes.DisplayStringMethods();
            //Console.Write("Enter the first number: ");
            //string input1 = Console.ReadLine();
            //int num1;
            //while (!int.TryParse(input1, out num1))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    input1 = Console.ReadLine();
            //}

            // Prompt the user to enter the second number
            //Console.Write("Enter the second number: ");
            //string input2 = Console.ReadLine();
            //int num2;
            //while (!int.TryParse(input2, out num2))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    input2 = Console.ReadLine();
            //}

            // Call the DisplayResult method to calculate the sum and display it as a string
            //string result = dataTpes.DisplayResult(num1, num2);

            // Output the result
            //Console.WriteLine($"The sum of {num1} and {num2} is: {result}");
            CsharpMethods obj= new CsharpMethods();
            CsharpMethods.ShowMessage();

            // Call Add method with just one required parameter
            int result1 = obj.ChkSum(5); // b and c will take the default values 0

            // Call Add method with two parameters
            int result2 = obj.Add(5, 10); // c will take the default value 0

            // Call Add method with all three parameters
            int result3 = obj.ChkSum(5, 10, 15);

            // Display the results
            Console.WriteLine($"Result1: {result1}"); // Output: 5
            Console.WriteLine($"Result2: {result2}"); // Output: 15
            Console.WriteLine($"Result3: {result3}"); // Output: 30


            // Perform operations and comparisons using different operators

            Operators obj2 = new Operators();
            string resultAdd = obj2.Operate(10, 5, "+"); // 10 + 5 = 15
            string resultGreaterThan = obj2.Operate(10, 5, ">"); // 10 > 5 = true
            string resultEqualTo = obj2.Operate(10, 10, "=="); // 10 == 10 = true
            string resultNotEqual = obj2.Operate(10, 5, "!="); // 10 != 5 = true

            // Display the results
            Console.WriteLine($"Addition: {resultAdd}");
            Console.WriteLine($"Greater Than: {resultGreaterThan}");
            Console.WriteLine($"Equal To: {resultEqualTo}");
            Console.WriteLine($"Not Equal: {resultNotEqual}");
        }
    }
}