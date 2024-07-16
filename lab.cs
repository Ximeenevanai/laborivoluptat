using System;

class Program
{
    static void Main()
    {
        string input = "[key]";
        // Simulating a regular expression match
        var match = System.Text.RegularExpressions.Regex.Match(input, @"\[(.*?)\]");
        
        if (match.Success)
        {
            string key = match.Value.TrimStart('[').TrimEnd(']');
            Console.WriteLine("Extracted key: " + key); // Output: Extracted key: key
        }
    }
}
