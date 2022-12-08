// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

if(a + b > c && a + c > b && c + b > a)
Console.WriteLine("YES");
else
Console.WriteLine("NO");