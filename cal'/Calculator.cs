namespace kt7;

public class Calculator
{
    public static double Add(double x, double y)
    {
        return x + y;
    }

    public static double Subtract(double x, double y)
    {
        return x - y;
    }

    public static double Multiply(double x, double y)
    {
        return x * y;
    }

    public static double Divide(double x, double y)
    {
        if (y == 0)
        {
            throw new ArgumentException("Division by zero is not allowed.");
        }
        return x / y;
    }

    public static double PerformOperation(double x, double y, Func<double, double, double> operation)
    {
        return operation(x, y);
    }

    public static void Main()
    {
        double num1 = 10.0;
        double num2 = 5.0;

        Func<double, double, double> addOperation = Calculator.Add;
        Func<double, double, double> subtractOperation = Calculator.Subtract;
        Func<double, double, double> multiplyOperation = Calculator.Multiply;
        Func<double, double, double> divideOperation = Calculator.Divide;

        double resultAdd = PerformOperation(num1, num2, addOperation);
        double resultSubtract = PerformOperation(num1, num2, subtractOperation);
        double resultMultiply = PerformOperation(num1, num2, multiplyOperation);
        double resultDivide = PerformOperation(num1, num2, divideOperation);

        Console.WriteLine($"Addition result: {resultAdd}");
        Console.WriteLine($"Subtraction result: {resultSubtract}");
        Console.WriteLine($"Multiplication result: {resultMultiply}");
        Console.WriteLine($"Division result: {resultDivide}");
    }
}