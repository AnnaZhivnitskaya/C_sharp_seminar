// Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели");
int num = int.Parse(Console.ReadLine()!);

if (num < 8)
{
if (num == 6 || num == 7)
    Console.WriteLine("выходной");

else
    Console.WriteLine("будний");
}
else
Console.WriteLine("Такого дня не существует");

