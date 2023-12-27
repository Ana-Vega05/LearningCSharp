// Write a program than receive a word and return it inverted

Console.WriteLine("Write a random word");
var word = Console.ReadLine();
InvestWord(word);

void InvestWord(string word)
{
    var invertedWord = "";
    for (var i = word.Length - 1; i >= 0; i--)
    {
        invertedWord += word[i];
    }
    Console.WriteLine(invertedWord);
}
