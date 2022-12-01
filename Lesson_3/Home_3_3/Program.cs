//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

    Console.WriteLine("Введите число");
float n = int.Parse(Console.ReadLine()!);

    for (int i = 2; i <= n; i++)
    {
    Console.WriteLine($"{i} в кубе = {Math.Pow(i, 3)}");
    }
