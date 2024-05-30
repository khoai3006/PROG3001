using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter real number:");
        string input = Console.ReadLine();
        
        if (double.TryParse(input, out double number))
        {
            int int_number = (int)number;
            long long_number = (long)number;
            Console.WriteLine($"The number you entered is {number}, as an int is {int_number} and as a long is {long_number}");
        }
        else
        {
            Console.WriteLine("That's not a real number.");
        }
    }
}