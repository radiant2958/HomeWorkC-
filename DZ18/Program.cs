//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите k1");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
float k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
float b2 = Convert.ToInt32(Console.ReadLine());
float[] crossLines = CrossPointLine(k1, k2, b1, b2);
Console.WriteLine($"x={crossLines[0]}, y= {crossLines[1]}");

float[] CrossPointLine(float k1, float k2, float b1, float b2)
{
    float[] cross = new float[2];
    cross[0] = (b2 - b1) / (k1 - k2);

    cross[1] = k1 * cross[0] + b1;

    return cross;
}




