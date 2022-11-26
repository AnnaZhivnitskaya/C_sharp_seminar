// Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int DelFir(int num)
{
    int first = num / 100;
    return first;
}

int DelThi(int num)
{
    int third = num % 10;
    return  third;
}
Console.Write(DelFir(num));
Console.WriteLine(DelThi(num));