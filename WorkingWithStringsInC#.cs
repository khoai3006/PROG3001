using System;
using System.Linq;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();

            string reversedString = ReverseString(userInput);
            Console.WriteLine($"Reversed string: {reversedString}");

            Console.Write("Enter a search string: ");
            string searchString = Console.ReadLine();

            int occurrenceCount = CountOccurrences(userInput, searchString);
            Console.WriteLine($"Number of occurrences of '{searchString}': {occurrenceCount}");

            Console.Write("Enter the old substring: ");
            string oldSubstring = Console.ReadLine();
            Console.Write("Enter the new substring: ");
            string newSubstring = Console.ReadLine();

            string modifiedString = ReplaceSubstring(userInput, oldSubstring, newSubstring);
            Console.WriteLine($"Modified string: {modifiedString}");

            string stringWithoutWhitespace = RemoveWhitespace(userInput);
            Console.WriteLine($"String without whitespace: {stringWithoutWhitespace}");
        }

        static string ReverseString(string inputString)
        {
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static int CountOccurrences(string inputString, string searchString)
        {
            int count = 0;
            int index = 0;

            while ((index = inputString.IndexOf(searchString, index)) != -1)
            {
                count++;
                index += searchString.Length;
            }

            return count;
        }

        static string ReplaceSubstring(string inputString, string oldSubstring, string newSubstring)
        {
            return inputString.Replace(oldSubstring, newSubstring);
        }

        static string RemoveWhitespace(string inputString)
        {
            return string.Concat(inputString.Where(c => !char.IsWhiteSpace(c)));
        }
    }
}
