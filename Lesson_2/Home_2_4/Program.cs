// Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели");
int num = int.Parse(Console.ReadLine()!);

string Holyday(int num)
{
    if (num = 6 | 7)
    {
        return ("выходной");
    }
    else
    {
        return ("будний");
    }
}
Console.WriteLine(Holyday(num));