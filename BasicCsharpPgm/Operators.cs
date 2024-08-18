namespace CsharpOperators
{
    class Operators
    {
        // Function that performs an operation or comparison based on the given operator
        public string Operate(int a, int b, string op)
        {
            switch (op)
            {
                case "+":
                    return (a + b).ToString();
                case "-":
                    return (a - b).ToString();
                case "*":
                    return (a * b).ToString();
                case "/":
                    if (b != 0)
                        return (a / b).ToString();
                    else
                        throw new DivideByZeroException("Division by zero is not allowed.");
                case "<":
                    return (a < b).ToString();
                case ">":
                    return (a > b).ToString();
                case "<=":
                    return (a <= b).ToString();
                case ">=":
                    return (a >= b).ToString();
                case "==":
                    return (a == b).ToString();
                case "!=":
                    return (a != b).ToString();
                default:
                    throw new InvalidOperationException("Invalid operator");
            }
        }
    }
}