//  Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// y = k1 * x + b1 = k2 * x + b2; 
// k1 * x - k2 * x = b2 - b1

int b1 = int.Parse(Console.ReadLine()!);
int b2 = int.Parse(Console.ReadLine()!);
int k1 = int.Parse(Console.ReadLine()!);
int k2 = int.Parse(Console.ReadLine()!);


int x = (b2 - b1) / (k1 - k2);
int y = k1 * x + b1;

Console.WriteLine($"x = {x}; y = {y}");
