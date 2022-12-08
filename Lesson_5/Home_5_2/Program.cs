// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int[] Array(int num, int from, int to)
{
    int[] mass = new int[num];
    for (int i = 0; i < num; i++)
    {
        mass[i] = new Random().Next(from, to);
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

void SumNechet(int[] arr)
{
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
                sum += arr[i];
        }
        Console.WriteLine(sum);
    }
}
int[] summNechet = Array(int.Parse(Console.ReadLine()!),
                      int.Parse(Console.ReadLine()!),
                      int.Parse(Console.ReadLine()!));

Print(summNechet);
SumNechet(summNechet);