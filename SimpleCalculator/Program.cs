namespace SimpleCalculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enkel Kalkylator");
        char operation = GetOperation("Ange vilken operation du vill utföra\n( + - * /)");
        Console.WriteLine("\nAnge första talet: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nAnge andra talet: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

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

}

