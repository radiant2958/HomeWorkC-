// Задача 68: Напишите метод вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
Console.WriteLine("Введите m");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FunctionAckerman(m,n));

int FunctionAckerman(int m,int n)
{
    int fun=0;
    if(m==0)
    {
        fun= n+1;
    }
    else if(m>0 & n==0)
    {
        fun = FunctionAckerman(m-1,n);
    }
    else if(m>0&n>0)
    {
        fun=FunctionAckerman(m-1,FunctionAckerman(m,n-1));
    }
    return fun;

}
