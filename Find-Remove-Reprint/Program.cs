using System;

namespace Find_Remove_Reprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchTerm;

            string firstSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister was reading, " +
                "but it had no pictures or conversations in it, 'and what is the use of a book,' " +
                "thought Alice 'without pictures or conversation?'\n";

            Console.WriteLine(firstSentence);
            
            Console.WriteLine("What term would you like to search for?");

            searchTerm = Console.ReadLine();

            //bool contains = firstSentence.Contains(searchTerm, StringComparison.OrdinalIgnoreCase);

            //string str = "He is driving a red car.";

            Console.WriteLine(firstSentence.Replace(searchTerm, " "));

        }
    }
}
