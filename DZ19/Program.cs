// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
//Сделать отдельный метод который генерирует двумерный массив и отдельный метод который выводит его на экран.
//m и n вводит пользователь в консоль
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
//Console.Write("{0,6:F2}",array[i,j]);-форматирование вещественных чисел
Console.WriteLine("Введите m - ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите n - ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

double[,] array = CreateRandom2DArray(m,n);
Print2DArray(array);

double[,] CreateRandom2DArray(int m, int n)
{
    double[,] array = new double[m, n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.NextDouble()*100;
        }
    }

    return array;
}

void Print2DArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}",array[i,j]);
        }
        Console.WriteLine();
    }
}
