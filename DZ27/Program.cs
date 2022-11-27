// Задача 66: Задайте значения M и N. 
//Напишите метод, который найдёт сумму натуральных элементов в промежутке от M до N. Через рекурсию!

int SumNumber(int a, int b)
{
    int sum=0;
    if(b==0) return a;
    else if(a<=b)
    {
        sum=a+SumNumber(a+1,b);
    }
    return sum;
}

Console.WriteLine(SumNumber(2,5));