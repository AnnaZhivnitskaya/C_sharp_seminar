// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число ");
int fst = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число ");
int sec = int.Parse(Console.ReadLine()!);

if (fst > sec)
{
    Console.Write("max=");
    Console.WriteLine(fst);
}
else
{
    Console.Write("max=");
    Console.WriteLine(sec);
}
