// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

int Funck(int num)
{
    int sum = num % 10;
    num -= num % 10;

    while (num > 0)
    {
        num /= 10;
        sum = sum + (num % 10);
    }
    return sum;
}
Console.WriteLine(Funck(num));