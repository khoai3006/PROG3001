using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter an integer
        Console.Write("Please enter an integer: ");

        // Read the integer input from the user
        string input = Console.ReadLine();
        int number;

        // Try to parse the input to an integer
        if (int.TryParse(input, out number))
        {
            // Cast the integer to a double
            double doubleNumber = (double)number;

            // Output the result
            Console.WriteLine($"The number you entered is {number} and as a double is {doubleNumber}");
        }
        else
        {
            // Handle invalid input
            Console.WriteLine("The input is not a valid integer.");
        }
    }
}
