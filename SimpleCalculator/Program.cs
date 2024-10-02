namespace SimpleCalculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enkel Kalkylator");
        char operation = GetOperation("Ange vilken operation du vill utföra\n( + - * /)");
        double num1 = GetNumber("\nAnge första talet: ");
        double num2 = GetNumber("\nAnge andra talet: ");

        double result = 0;
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Ogiltig operation.");
                break;
        }
        Console.WriteLine($"Resultat: {result}");
        Console.ReadLine();
    }

    //Tar emot val av operation
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
    public static double GetNumber(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            double userInput = Convert.ToDouble(Console.ReadLine());
            return userInput;
        }
    }
}

