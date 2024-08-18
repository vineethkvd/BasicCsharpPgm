using System;
namespace DesicionMakingSt
{
    class DesicionMaking
    {

        public void IfElseExample(int number)
        {
            if (number > 10)
            {
                Console.WriteLine("The number is greater than 10.");
            }
            else if (number == 10)
            {
                Console.WriteLine("The number is exactly 10.");
            }
            else
            {
                Console.WriteLine("The number is less than 10.");
            }
        }

        public void SwitchExample(int day)
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }

        public void TernaryExample(int number)
        {
            string result = (number > 5) ? "Greater than 5" : "Less than or equal to 5";
            Console.WriteLine(result);
        }

    }
}