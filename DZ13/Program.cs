// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Задание должно быть выполнено в методах.

int[] GenerateArr ()
{
    int[] array = new int[8];
    Random random = new Random();
    for( int i= 0; i<array.Length;i++)
    {
        array[i]= random.Next(0,99);


    }
    return array;
}

int[] array = GenerateArr();

void OutPut(int[] array1)
{
    for(int i = 0; i<array1.Length;i++)
    {
        Console.Write($"{array1[i]} " );

    }
    
}
 
 OutPut(GenerateArr());
