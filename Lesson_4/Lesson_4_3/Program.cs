// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

int Proiz(int num)
{
    int pro = 1;
    for(int i = 1; i <= num; i++)
    {
    pro = pro * i;
    Console.WriteLine(pro);
    }
    return pro;
}
Console.WriteLine(Proiz(num));