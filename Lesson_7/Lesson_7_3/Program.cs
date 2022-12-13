// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.

int[,] FillArray(int row, int colomn, int from, int to)
{
    int[,] arr = new int[row, colomn];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < colomn; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    return arr;
}

int Summ(int[,] arr)
{
    int row1 = arr.GetLength(0);
    int colomn1 = arr.GetLength(1);

    int sumDiag = 0;

    for (int i = 0; i < row1; i++)
        for (int j = 0; j < colomn1; j++)
        {
            if (i == j)
                sumDiag += arr[i, j];
        }
    return sumDiag;
}

void Print(int[,] array)
{
    int row2 = array.GetLength(0);
    int colomn2 = array.GetLength(1);

    for (int i = 0; i < row2; i++)
    {
        for (int j = 0; j < colomn2; j++)
            Console.Write($"{array[i, j],4}|");
        Console.WriteLine();
    }
    Console.WriteLine();

}

Console.Write("Enter the number of rows: ");
int rowSize = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int colomnSize = int.Parse(Console.ReadLine()!);

int[,] arr_1 = FillArray(rowSize, colomnSize,
                        int.Parse(Console.ReadLine()!),
                        int.Parse(Console.ReadLine()!));

Print(arr_1);

Console.WriteLine(Summ(arr_1));