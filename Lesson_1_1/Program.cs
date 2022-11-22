// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли первое число квадратом второго

Console.WriteLine("Введите первое число ");
int first = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число ");
int second = int.Parse(Console.ReadLine()!);

if (first == second * second)
Console.WriteLine("True");
else
Console.WriteLine("False");
