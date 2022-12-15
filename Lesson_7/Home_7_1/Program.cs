// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] FillArray(int row, int colomn, int from, int to)
{
    double[,] arr = new double[row, colomn];
    Random n_new = new Random(); //обязательно!!!
    
    for (int i = 0; i < row; i++)
        for (int j = 0; j < colomn; j++)
            arr[i, j] = Math.Round(n_new.NextDouble() * (to - from), 2);
    return arr;
}

void Print(double[,] array)
{
    int rowNum = array.GetLength(0);
    int columnNum = array.GetLength(1);

    for (int i = 0; i < rowNum; i++)
    {
        for (int j = 0; j < columnNum; j++)
            Console.Write($" {Math.Round(array[i, j], 2),6}");
            Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Задайте количество строк массива");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте количество столбцов массива");
int column = int.Parse(Console.ReadLine()!);

double[,] matrix = FillArray(row, column,
                    int.Parse(Console.ReadLine()!),
                    int.Parse(Console.ReadLine()!));

Print(matrix);






