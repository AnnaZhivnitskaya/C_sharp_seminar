// 2. Задайте двумерный массив. Найдите элементы,
//    у которых обе позиции чётные, и замените эти элементы на их квадраты.

int[,] FillArray(int row, int colomn, int from, int to)
{
    int[,] arr = new int[row, colomn];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < colomn; j++)
        
            arr[i, j] = new Random().Next(from, to);
            return arr;
}

void Quatro(int[,] array)
{
    int rowSize = array.GetLength(0);
    int colomnSize = array.GetLength(1);
    for (int i = 1; i < array.GetLength(0); i+=2)
        for (int j = 1; j < array.GetLength(1); j+=2)
        {
          array[i, j] *= array[i, j];
        }
}

void Print(int[,] arr) // функция, выводящая на печать
{
    int row_size = arr.GetLength(0);
    int colomn_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < colomn_size; j++)
            Console.Write($"{arr[i, j],4}|"); //числом указывается ширина столбцов
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
Quatro(arr_1);
Console.WriteLine();
Print(arr_1);
