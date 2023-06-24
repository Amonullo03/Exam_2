public class Calculator
{
    private double firstNumber;
    private double secondNumber;

    public Calculator(double firstNumber, double secondNumber)
    {
        this.firstNumber = firstNumber;
        this.secondNumber = secondNumber;
    }

    public double Sum()
    {
        return firstNumber + secondNumber;
    }

    public double Subtract()
    {
        return firstNumber - secondNumber;
    }

    public double Multiplication()
    {
        return firstNumber * secondNumber;
    }

    public double Division()
    {
        if (secondNumber == 0)
        {}
        return firstNumber / secondNumber;
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Введите первое число: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.Write("Введите операцию (+, -, *, /): ");
            char operation = char.Parse(Console.ReadLine());

            Calculator calculator = new Calculator(firstNumber, secondNumber);
            double result = 0;

            if (operation == '+')
            {
                result = calculator.Sum();
            }
            else if (operation == '-')
            {
                result = calculator.Subtract();
            }
            else if (operation == '*')
            {
                result = calculator.Multiplication();
            }
            else if (operation == '/')
            {
                result = calculator.Division();
            }
            else
            {
                Console.WriteLine("Неверная операция");
            }

            Console.WriteLine("Результат: {0}", result);
        }
    }
}