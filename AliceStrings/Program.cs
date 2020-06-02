using System;

namespace AliceStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            
            Console.WriteLine("Enter a word to search for: ");

            string word = Console.ReadLine();

            int results = sentence.IndexOf(word, StringComparison.CurrentCultureIgnoreCase);

            if (results == -1)
            {
                Console.WriteLine("Word not found.");
            }
            else
            {
                Console.WriteLine(word + " found at index: " + results + "\nIt is " + word.Length + " characters long");

                string newSentence = sentence.Remove(results, word.Length);
                Console.WriteLine(newSentence);
            }

        }
    }
}
