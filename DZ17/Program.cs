//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите колличество чисел");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PositiveIntroducedNumber(NewArray(m)));

int PositiveIntroducedNumber(int[] array)
{
    int sum=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
        {
            sum++;
        }
    }
    return sum;
}


int[] NewArray(int m)
{
    int [] array=new int [m];
    for (int i=0; i<m; i++)
    {
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


