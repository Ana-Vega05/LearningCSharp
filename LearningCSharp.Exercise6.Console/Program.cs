// Write a program than receive a word and say if the word is palindrome 

// Understand the problem 
// what is the palindrome word

// Think about the logic 
// 1. receive the word 
// 2. iterate the word from the last letter to the first one
// 3. create a variable for save the inverted word
// 4. compare the word receive and the inverted word

Console.WriteLine("Write a random word");
var word = Console.ReadLine();

void IdentifyPalindromeWord(string word)
{
    var invertedWord = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        invertedWord += word[i];
    }

    if (word == invertedWord)
    {
        Console.WriteLine("The word is palindrome");
    }
    else
    {
        Console.WriteLine("The word isn't palindrome");
    }
}


IdentifyPalindromeWord(word);