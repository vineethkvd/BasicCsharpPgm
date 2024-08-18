using DataType;
namespace BasicCsharpPgm
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of the DataTpes class
            DataType.DataTpes dataTpes = new DataType.DataTpes();

            // Call the DisplayDataTypes method to show different data types
            dataTpes.DisplayDataTypes();

            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            int num1;
            while (!int.TryParse(input1, out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                input1 = Console.ReadLine();
            }

            // Prompt the user to enter the second number
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            int num2;
            while (!int.TryParse(input2, out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                input2 = Console.ReadLine();
            }

            // Call the DisplayResult method to calculate the sum and display it as a string
            string result = dataTpes.DisplayResult(num1, num2);

            // Output the result
            Console.WriteLine($"The sum of {num1} and {num2} is: {result}");

        }
    }
}