//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце. 
//Поиск среднее арифметического в отдельном методе. 
//Для создания массива и вывода можно воспользоваться методами из 47 задачи.
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
Console.WriteLine();
OutPut(MeanColumnsArray(array));

double[] MeanColumnsArray(double[,] array)
{
    double[] arrayMean=new double[array.GetLength(1)];
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum=0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum+=array[i,j];
        }
        arrayMean[j]=sum/array.GetLength(0);

    }
    return arrayMean;
}


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

void OutPut(double[] array)
{
    for(var i= 0; i<array.Length;i++)
    {
        Console.Write("{0,6:F2}",array[i]);

    }
}
