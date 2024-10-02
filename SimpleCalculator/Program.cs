using System.ComponentModel;

namespace SimpleCalculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enkel Kalkylator");
        char operation = GetOperation("Ange vilken operation du vill utföra\n( + - * / )");
        double num1 = GetNumber("\nAnge första talet: ");
        double num2 = GetNumber("\nAnge andra talet: ");

        double result = 0;
        switch (operation)
        {
            case '+':
                result = Add(num1, num2);
                break;
            case '-':
                result = Subtract(num1,num2);
                break;
            case '*':
                result = Multiply(num1,num2);
                break;
            case '/':
                result = Divide(num1,num2);
                break;
            default:
                Console.WriteLine("Ogiltig operation.");
                break;
        }
        DisplayResult(num1, num2, result, operation);
        Console.ReadLine();
    }

    //Tar emot val av operation
    //TODO: fixa felhantering så att användaren inte kan mata annat än giltiga operationer
    public static char GetOperation(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            char operation = Console.ReadKey().KeyChar;
            return operation;
        }
    }
    //Tar emot användaren tal
    //TODO: fixa felhantering så att användaren inte kan mata annat än numreriska värden
    //TODO: fixa så att om användaren kan mata in ',' som decimal
    //TODO: fixa så att användaren inte kan mata in 0 som täljare vid division
    public static double GetNumber(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            double userInput = Convert.ToDouble(Console.ReadLine());
            return userInput;
        }
    }
    //Skriver ut resultatet i konsol
    public static void DisplayResult(double a, double b, double result, char operation)
    {
        Console.Clear();
        Console.WriteLine($"Resultat:\n{a} {operation} {b} = {result}");
    }

    //Hanterar addition
    public static double Add(double a, double b)
    {
        return a + b;
    }
    //Hanterar subraktion
    public static double Subtract(double a, double b)
    {
        return a - b;
    }
    //Hanterar multiplikation
    public static double Multiply(double a, double b)
    {
        return a * b;
    }
    //Hanterar division
    public static double Divide(double a, double b)
    {
        return a / b;
    }

}

