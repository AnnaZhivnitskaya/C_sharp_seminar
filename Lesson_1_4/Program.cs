// написать программу вычисления модуля числа

Console.WriteLine("Задайте число ");
int num = int.Parse(Console.ReadLine()!);
int mod;
if (num > 0)
    mod = num;
else
    mod = (0 + (-num));

Console.WriteLine (mod);
