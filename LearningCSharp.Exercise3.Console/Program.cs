// Write a Program that receive a number and print all pars number less than 

Console.WriteLine("Write a number");
var Number = int.Parse(Console.ReadLine());

for (int i = 1; i < Number; i++)
{
    bool IsParsNumber = ValidateIsParsNumber(i);
    if (IsParsNumber)
    {
        Console.WriteLine(i);
    }
}

bool ValidateIsParsNumber(int number)
{
    bool IsParsNumber = false;
    for (int j = 1; j < number; j++)
    {
        if(number % 2 == 0)
        {
            IsParsNumber = true;
        }
    }
    
    return IsParsNumber;
}