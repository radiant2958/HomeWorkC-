// Задача 23
int[] FunctionCub(int n)
{
    int[] array = new int[n];
    int j=1;
    for(int i=0; i<array.Length; i++)
    {
        
        array[i]=j*j*j;
        j++;
    }
    return array;
}

void OutPut(int[] array1)
{
    for(int i= 0; i<array1.Length;i++)
    {
        Console.Write($"{array1[i]} ");

    }
}
OutPut(FunctionCub(5));
