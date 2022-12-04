// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

//Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве:
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

double Distance(float x1, float y1, float t1, float x2, float y2, float t2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(t2 - t1, 2));    
}

Console.WriteLine(Distance(3, 6, -9, 0, 2, 1));
