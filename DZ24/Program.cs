//Задача 58: Задайте две матрицы. Напишите метод, который будет находить произведение двух матриц.
Console.WriteLine("Введите колличество строк первой матрицы ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите кооличество столбцов первой матрицы");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите колличество строк второй матрицы ");
bool isParsedP = int.TryParse(Console.ReadLine(), out int p);
Console.WriteLine("Введите кооличество столбцов вторрой матрицы");
bool isParsedS = int.TryParse(Console.ReadLine(), out int s);

if (!isParsedN || !isParsedP)
{
    Console.WriteLine("Ошибка! Умножение матриц невозможно!");
    return;
}

int[,] array = CreateRandom2DArray(m,n);
Print2DArray(array);
int [,] array1 = CreateRandom2DArray(p,s);
Print2DArray(array1);
int[,] array3=ProductArray(array,array1);
Print2DArray(array3);

int [,] ProductArray(int[,] array, int[,] array1)
{
    int [,] result=new int[array.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(0); k++)
            {
                result[i,j]=array[i,k]*array1[k,j]+result[i,j];
            }
        }
    }
    return result;
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