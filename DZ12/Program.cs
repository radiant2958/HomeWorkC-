// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.

int GetLengtArray(int number)
{
    int count = 0;
    while(number>0)
    {
        number/= 10;
        count++;
    }
    return count;
}


int[] ArrayNumber(int number)
{
    int lengt = GetLengtArray(number);
    int[] array = new int[lengt];

        for (int i = 0; i < array.Length; i++)
        {
        int lastValue = number % 10;
        array[i] = lastValue;
        number = number / 10;
        }
    Array.Reverse(array);
    return array;
    
}

void SumNumbers(int number11)
{
    int sum = 0;
    int[] array1 = ArrayNumber(number11);
    
    for (int i = 0; i< array1.Length; i++)
    {
        sum =sum+array1[i];
    } 
    Console.WriteLine(sum);
    
    
}
SumNumbers(549);


