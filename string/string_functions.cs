using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        // Convert the sentence to uppercase and lowercase
        string upperCase = sentence.ToUpper();
        string lowerCase = sentence.ToLower();

        // Count the number of characters
        int characterCount = sentence.Length;

        // Reverse the sentence
        char[] characters = sentence.ToCharArray();
        Array.Reverse(characters);
        string reversedSentence = new string(characters);

        // Display the results
        Console.WriteLine("\nUppercase: " + upperCase);
        Console.WriteLine("Lowercase: " + lowerCase);
        Console.WriteLine("Number of characters: " + characterCount);
        Console.WriteLine("Reversed: " + reversedSentence);
    }
}
