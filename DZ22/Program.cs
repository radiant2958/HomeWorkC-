// Задача 54: Задайте двумерный массив. Напишите метод, 
//который упорядочит по убыванию элементы каждой строки двумерного массива. И продемонстрируйте его работу.
Console.WriteLine("Введите m - ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите n - ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] array = CreateRandom2DArray(m,n);
Print2DArray(array);
int[,] array2=OrderElementsArray(array);
Print2DArray(array2);

int [,] OrderElementsArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(1)-1; n++)
            {
                if(array[i,n]<array[i,n+1])
                {
                    int tmp=0;
                    tmp=array[i,n];
                    array[i,n]=array[i,n+1];
                    array[i,n+1]=tmp;
                }
            }
        }
    }
    return array;
}


int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1, 10);
        }
    }

    return array;
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}