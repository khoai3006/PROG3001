using System;

class Project3
{
    static void Main()
    {
        Console.WriteLine("Please enter a character:");
        string input = Console.ReadLine();

        if (input.Length == 1) 
        {
            char character = input[0];
            int asciiCode = (int)character;
            Console.WriteLine($"The character you entered is '{character}', its ASCII code is {asciiCode}");
        }
        else
        {
            Console.WriteLine("You must enter a single character");
        }
    }
}