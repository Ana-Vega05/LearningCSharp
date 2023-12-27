// Write a algorithm that receive a number for console and identify if number is prime or not


Console.WriteLine("Write a number");
var Number = int.Parse(Console.ReadLine()!);
// bool DivisionBetweenOne = Number % 1 == 0;
// bool DivisionBetweenNumber = Number % Number == 0;
// bool DivisionBetweenTwo = Number % 2 == 0;
// if (DivisionBetweenOne && DivisionBetweenNumber && !DivisionBetweenTwo) 
// {
//     Console.WriteLine("Is prime");
// }
// else
// {
//     Console.WriteLine("Isn't prime");
// }

bool IsPrimeNumber = true;
for (int i = 2; i < Number; i++)
{
    if(Number % i == 0)
    {
        IsPrimeNumber = false;
    }
}

if (IsPrimeNumber == false)
{
    Console.WriteLine("Isn't prime");
}
else
{
    Console.WriteLine("Is prime");
}