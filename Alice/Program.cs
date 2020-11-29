using System;

namespace Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string lowerAlice = alice.ToLower();
            Console.WriteLine("What word would you like to search for?");
            string word = Console.ReadLine();
            string lowerWord = word.ToLower();
            bool search = lowerAlice.Contains(lowerWord);
            Console.WriteLine($"It is {search} that your word, {word}, was in the passage.");
            int indexOfWord = alice.IndexOf(word, 0);
            Console.WriteLine($"Your word can be found at index {indexOfWord}.");
            Console.WriteLine($"The length of the word is {word.Length}.");
            string newAlice = alice.Remove(indexOfWord, word.Length);
            Console.WriteLine(newAlice);


        }
    }
}
