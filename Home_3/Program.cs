// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()!);

int ost = (num % 2);

if (ost > 0)
    Console.WriteLine("нечетное");
else
    Console.WriteLine("четное");
