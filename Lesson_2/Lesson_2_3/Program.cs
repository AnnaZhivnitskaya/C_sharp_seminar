// 4. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()!);

string Del(int num)
{
    if (num % 7 == 0 && num % 23 == 0) // && - оператор условного "И"
    //сравнивает два операнда, вычисляет второй, только если первый true
    return "кратно";
    else
    return "не кратно";
    }

Console.WriteLine (Del(num));