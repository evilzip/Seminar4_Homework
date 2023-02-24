// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int InputInt32(string msg)
{
    System.Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());

}  

int[] FillArray(int size, int MinElementLimit, int MaxElementLimit)
{
    int[] FilledArray = new int[size];
    for (int i = 0; i < FilledArray.Length; i++)
    {
        FilledArray[i] = new Random().Next(MinElementLimit, MaxElementLimit);
    }
    return FilledArray;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Threading.Thread.Sleep(100);
        System.Console.Write($" {array[i]} ");
    }
    System.Console.Write("]");
}

int size = InputInt32("Enter size of desired array");
int MinLimit = InputInt32("Enter minimal element");
int MaxLimit = InputInt32("Enter maximum element");
int[] GeneratedArray = FillArray(size, MinLimit, MaxLimit);
PrintArray(GeneratedArray);