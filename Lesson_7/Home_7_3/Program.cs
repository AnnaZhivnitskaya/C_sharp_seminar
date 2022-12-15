// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Мария, извините, но у меня мозгов не хватило сделать через функции

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine()!);
int from = int.Parse(Console.ReadLine()!);
int to = int.Parse(Console.ReadLine()!);
double[,] arr = new double[row, column];
double[] sum = new double[column];

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        arr[i, j] = new Random().Next(from, to);

        Console.Write ($"{(arr[i, j]), 6}|");
        
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < column; i++)
{
    for (int j = 0; j < row; j++)
    {
        sum[i] += arr[j, i];
    }
}

for (int i = 0; i < column; i++)
{
    Console.Write($"{Math.Round((sum[i] / row), 2), 6}|"); 
}
Console.WriteLine();
