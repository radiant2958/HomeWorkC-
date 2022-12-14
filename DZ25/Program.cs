// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите метод, который будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine("Введите m - ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите n - ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите k - ");
bool isParsedK = int.TryParse(Console.ReadLine(), out int k);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,,] array = CreateRandom3DArray(m, n, k);
Print3DArray(array);

int[,,] CreateRandom3DArray(int m, int n, int k)
{
    int[,,] array = new int[m, n, k];
    int[] values = new int[100];
    Random random = new Random();
    int b=0;
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = b++;
        
    }
    for (int i = 0; i < values.Length; i++)
    {
        
        int randomIndex=random.Next(10,100);
        values[i]=values[randomIndex];

    }
    int index = 0;


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int p = 0; p < array.GetLength(2); p++)
            {
                array[i,j,p] = values[index++];
                      
            }

            
        }

    }   
    return array;   
}


void Print3DArray(int[,,] array)
{
    for (var p = 0; p < array.GetLength(2); p++)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, p]} {(i, j, p)} ");
            }
            Console.WriteLine();
        }

    }
}
