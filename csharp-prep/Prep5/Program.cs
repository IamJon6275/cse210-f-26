using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int userBirth = PromptUserBirth();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber, userBirth);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    static int PromptUserBirth()
    {
        Console.Write("Please enter the year you were born: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string userName, int square, int userBirth)
    {
        int currentYear = DateTime.Now.Year;
        Console.WriteLine($"{userName}, the square of your number is {square}\n{userName}, you will turn {currentYear - userBirth + 1} this year.");
    }
}