//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[4];
FillArray(array);
PrintArray(array);
int result = SumPositiveElementsArray(array);
Console.WriteLine(result);
int SumPositiveElementsArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        {
            sum++;
        }
    }
    return sum;
}



void PrintArray(int[] array)
{
    Console.WriteLine();
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
}