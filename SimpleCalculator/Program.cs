
namespace SimpleCalculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enkel Kalkylator");
        char operation = GetOperation("Ange vilken operation du vill utföra\n( + - * / )");
        double num1 = GetNumber("\nAnge första talet: ", operation);
        double num2 = GetNumber("\nAnge andra talet: ", operation);

        double result = 0;
        switch (operation)
        {
            case '+':
                result = Add(num1, num2);
                break;
            case '-':
                result = Subtract(num1, num2);
                break;
            case '*':
                result = Multiply(num1, num2);
                break;
            case '/':
                result = Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Ogiltig operation.");
                break;
        }
        DisplayResult(num1, num2, result, operation);
        Console.ReadLine();
    }

    //Tar emot val av operation
    public static char GetOperation(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            char operation = Console.ReadKey().KeyChar;
            //kontrollera att inmatad operation är giltig ( + - * /)
            switch (operation)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                    return operation;
                default:
                    Console.Clear();
                    Console.WriteLine("Ogiltig operation, väl mellan: ( + - * / )\nTryck ENTER för att fortsätta...");
                    Console.ReadLine();
                    break;
            }
        }
    }

    //Tar emot användaren inmating, validerar och returnerar om giltig inmatning
    public static double GetNumber(string prompt, char operation)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(prompt);
            //Kontrollerar så att input är ett numreriskt värde
            if (double.TryParse(Console.ReadLine(), out double userInput))
            {
                //Kontrollerar ifall operation är division '/' och om user input är 0, om sant meddelar användare
                //att detta är ogiltigt
                if (operation == '/' && userInput == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Vid division får täljaren inte vara 0. Försök igen.\nTryck ENTER för att fortsätta...");
                    Console.ReadLine();
                    continue;
                }
                return userInput;
            }
            Console.WriteLine("Du måste ange ett numreriskt värde.");
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

