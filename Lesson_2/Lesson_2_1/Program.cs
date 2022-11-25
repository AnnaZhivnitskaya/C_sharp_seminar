// 1. Напишите программу, которая принимает на вход трёхзначное число
//    и на выходе показывает последнюю цифру этого числа.
int num = new Random().Next(100, 1000);

Console.WriteLine(num);

int ShowLast(int num)
{
    int prelast = num % 100;
    int last = num % 10;
    return last;
}

Console.WriteLine (ShowLast(num));