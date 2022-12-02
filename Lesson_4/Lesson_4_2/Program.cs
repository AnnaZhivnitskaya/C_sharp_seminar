// 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);

int SumNum(int n)
{
    int sum = 0;
    while(n > 0) //пока введенное число больше 0
    {
        n = n/=10;//делим его на 10
        Console.WriteLine(n);
        sum = sum + 1; //каждый раз одно действие деления приравниваем 
                        //к 1 и суммируем в переменной
    }
    return sum;
}

Console.WriteLine(SumNum(n));

