// Напишите программу, которая выводит третью цифру
//заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое число");
int num = int.Parse(Console.ReadLine()!);

if (num < 100)

    Console.WriteLine("третьего числа нет");

else
{
int ShowTh(int num)
{
while (num >= 1000)
{
    int num2 = num / 10;
    num = num2;
}
int num3 = num % 10;
return num3;
}
Console.WriteLine(ShowTh(num));
}

