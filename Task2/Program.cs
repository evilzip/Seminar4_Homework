// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


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

int NumberDigitSum(int UserValue)
{
    if (UserValue > 0)
    {
        int DigitSum = 0;
        while (UserValue>0)
        {
            int CurrentDigit = UserValue%10;
            DigitSum = DigitSum + CurrentDigit;
            UserValue/=10;            
        }      
        return DigitSum;    
    }
    System.Console.WriteLine("Error! Your number should be Natural");
    Environment.Exit(-2);
    return 0;
}

int UserValue = InputInt32("Enetr your number");

int result = NumberDigitSum(UserValue);


System.Console.WriteLine($"Total Sum of all digits in Your value = {result}");