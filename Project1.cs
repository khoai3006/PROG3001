using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        string input = Console.ReadLine();
        int number;

        if (int.TryParse(input, out number))
        {
            double doubleNumber = (double)number;

            Console.WriteLine($"The number you entered is {number} and as a double is {doubleNumber}");
        }
        else
        {
            Console.WriteLine("The input is not a valid integer.");
        }
    }
}
