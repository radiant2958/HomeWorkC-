//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] array = new int[8];
FillArray(array);
PrintArray(array);
int n= DeductionMaxMinArray(array);
Console.WriteLine(n);


int DeductionMaxMinArray(int[] array)
{
    int result = MaxElArray(array) - MinElArray(array);
    return result;
}





int MinElArray (int [] array)
{
    int min=array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min)
        {
            min=array[i];
        }
    }
    return min;
}



int MaxElArray (int[] array)
{
    int maxel = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>maxel)
        {
            maxel=array[i];
        }

    }
    return maxel;
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
        array[i] = random.Next(0, 1000);
    }
}