// Задача 56: Задайте двумерный массив. 
//Напишите метод, который будет находить строку с наименьшей суммой элементов.
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
//int[] sumRowArray= MinSumRowArray(array);
//OutPut(sumRowArray);
int tmp=RowMinSumArray(array);
Console.WriteLine(tmp);

int RowMinSumArray(int[,] array)
{
    
    
    int[] result = new int [array.GetLength(0)];
    result = MinSumRowsArray(array);
    int minsum=result[0];
    
    for (int i = 1; i < result.Length; i++)
    {
        
        if(result[i]<=minsum)
        {
            minsum=i;
            
            

        }
    }
    return minsum;
}


int[] MinSumRowsArray(int[,] array)
{
  
    int[] result= new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+=array[i,j];

        }
        result[i]=sum;

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

/*void OutPut(int[] array1)
{
    for(int i = 0; i<array1.Length;i++)
    {
        Console.Write($"{array1[i]} " );

    }
    
}*/
 
 
