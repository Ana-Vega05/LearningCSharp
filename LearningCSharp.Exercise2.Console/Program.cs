// Write a Program that receive a number and print all primes number less than 

Console.WriteLine("Write a number");
var Number = int.Parse(Console.ReadLine());

for (int i = 2; i < Number; i++)
{
    bool IsPrimeNumber = ValidateIsPrimeNumber(i);
    if (IsPrimeNumber)
    {
        Console.WriteLine(i);
    }
}

bool ValidateIsPrimeNumber(int number)
{
    bool IsPrimeNumber = true;
    for (int j = 2; j < number; j++)
    {
        if(number % j == 0)
        {
            IsPrimeNumber = false;
        }
    }
    
    return IsPrimeNumber;
}

