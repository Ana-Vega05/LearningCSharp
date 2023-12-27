// Write an algorithm that receives a word and counts the times each letter appears in said word.
// In the end it must show the information for each of the letters as follows:
// Letter1 - repetitions
// Letter2 - repetitions

Console.WriteLine("Write a random word");
string Word = Console.ReadLine();
var counter = 0;
string CountedLetters = "";
CountLetters(Word);

void CountLetters(string Word)
{
    for (int i = 0; i < Word.Length; i++)
    {
        if(CountedLetters.Contains(Word[i]))
            continue;
        
        for (int j = 0; j < Word.Length; j++)
        {
            if (Word[i] == Word[j])
            {
                counter = counter + 1;
            }
            
        }
        Console.WriteLine(Word[i] + "-" + counter);
        counter = 0;
        CountedLetters = CountedLetters + Word[i];
    }
    
}