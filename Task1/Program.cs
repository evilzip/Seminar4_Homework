// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int InputInt32(string message)
{
    System.Console.Write(($"{message} "));
    int value;
    bool isCorrectInt32 = int.TryParse(Console.ReadLine(), out value);
    if (isCorrectInt32)
    {
        return value;
    }
    System.Console.WriteLine("You enetrd not a number");
    Environment.Exit(-1);
    return 0;
}

int NaturalPower(int BaseNumber, int PowerNumber)
{
    if (PowerNumber > 0)
    {
        int MultiplyResult =1;
        for (int i = 0; i < PowerNumber; i++)
        {
            MultiplyResult = MultiplyResult*BaseNumber;
        }      
        return MultiplyResult;    
    }
    System.Console.WriteLine("Error! power number must be a natural");
    Environment.Exit(-2);
    return 0;
}

int BasePower = InputInt32("Enetr base number A ");
int PowerNumber = InputInt32("Enter natural power number B");
int result = NaturalPower(BasePower, PowerNumber);


System.Console.WriteLine($"Result of number A rasied to the power B = {result}");

