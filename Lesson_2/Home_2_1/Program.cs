// Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число от 100 до 999");

int num = int.Parse(Console.ReadLine()!);

int CheckMiddle(int num)
{
    int first = (num % 100) / 10;
    return first;
}
Console.WriteLine(CheckMiddle(num));