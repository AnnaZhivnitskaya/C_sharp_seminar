// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] Array(int num)
{
    int[] mass = new int[num];
    for (int i = 0; i < num; i++)
    {
        mass[i] = new Random().Next(100, 999);
    }
    return mass;
}

void Print(int[] count)
{
    int begin = count.Length;
    for (int i = 0; i < begin; i++)
    {
        Console.Write($"{count[i]} ");
    }
    Console.WriteLine();
}

void SumChet(int[] arr)
{
    {
        int chet = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
                chet = chet + 1;
        }
        Console.WriteLine(chet);
    }
}
int[] chetNum = Array(int.Parse(Console.ReadLine()!));

Print(chetNum);
SumChet(chetNum);
