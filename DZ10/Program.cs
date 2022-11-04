// Задача 21

double DistancePoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double rezult = Math.Sqrt((x2-x1)+(y2-y1)+(z2-z1));
    return rezult;
}

Console.WriteLine("Введите координаты первой точки А");
bool inputX1 = int.TryParse(Console.ReadLine(),out int xA);
bool inputY1 = int.TryParse(Console.ReadLine(),out int yA);
bool inputZ1 = int.TryParse(Console.ReadLine(),out int zA);

Console.WriteLine("Введите координаты второй точки В");
bool inputX2 = int.TryParse(Console.ReadLine(),out int xB);
bool inputY2 = int.TryParse(Console.ReadLine(),out int yB);
bool inputZ2 = int.TryParse(Console.ReadLine(),out int zB);

double n=DistancePoints(xA,yA,zA,xB,yB,zB);
Console.WriteLine(n);