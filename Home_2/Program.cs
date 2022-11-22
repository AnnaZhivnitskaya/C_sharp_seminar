// Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число ");
int fst = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число ");
int sec = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число ");
int thd = int.Parse(Console.ReadLine()!);

int max = fst;

if (sec > max)
    max = sec;

if (thd > max)
    max = thd;

Console.WriteLine(max);

