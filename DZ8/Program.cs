// Задача 19

int[] MetodArray(int number)
{
    int[] array = new int[5];
    
        for (int i = 0; i<array.Length;i++)
        {
           int k= number%10;
           array[i]=k;
           number=number/10; 
        }
    return array;

}
       


void VerificationNumber(int number)
{
    int[] array1 = MetodArray(number);
    bool a;
    if (array1[0]==array1[4] | array1[1]==array1[3])
    {
       a=true;
    }
    else
    {
       a=false;

    }
    Console.WriteLine(a);
}
  
VerificationNumber(12321);
