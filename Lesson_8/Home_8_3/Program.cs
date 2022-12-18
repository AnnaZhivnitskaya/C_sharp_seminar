// Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

// умножаем 1-ю строку I матрицы на 1 столбик II матрицы, 
//( 1 элемент 1-й строки на 1 элемент 1-го столбика +  1 эл 1 строки на 2 эл 1 столбика
//  2 элемент 1-й строки на 1 элемент 1-го столбика +  2 эл 1 строки на 2 эл 1 столбика)
// затем 2-ю строку I матр на 2-й столбик II матр
//( 1 элемент 2-й строки на 1 элемент 2-го столбика +  1 эл 2 строки на 2 эл 2 столбика
//  2 элемент 2-й строки на 1 элемент 2-го столбика +  2 эл 2 строки на 2 эл 2 столбика)

// A(ij) * B(jk) = C(ik)

int[,] ArrayA(int row1, int column1, int from, int to)
{
    int[,] arrayA = new int[row1, column1];

    for (int i = 0; i < row1; i++)
        for (int j = 0; j < column1; j++)
            arrayA[i, j] = new Random().Next(from, to);

    return arrayA;
}

int[,] ArrayB(int row2, int column2, int from, int to)
{
    int[,] arrayB = new int[row2, column2];

    for (int j = 0; j < row2; j++)
        for (int k = 0; k < column2; k++)
            arrayB[j, k] = new Random().Next(from, to);

    return arrayB;
}

int[,] ArrayC(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)]; // результирующая матр
    int rowA = arrayA.GetLength(0);
    int columnA = arrayA.GetLength(1);
    int rowB = columnA;
    int columnB = arrayB.GetLength(1);

    for (int i = 0; i < rowA; i++)
    {
        for (int j = 0; j < columnA; j++)
        {
            for (int k = 0; k < columnB; k++)
                arrayC[i, j] = 0;

            for (int k = 0; k < columnB; k++)
            {
                arrayC[i, k] += arrayA[i, j] * arrayB[j, k];
            }
        }
    }
    return arrayC;
}

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Enter the number of rows A: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns A: ");
int column1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of rows B: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns B: ");
int column2 = int.Parse(Console.ReadLine()!);

int[,] arr_1 = ArrayA(row1, column1,
                        int.Parse(Console.ReadLine()!),
                        int.Parse(Console.ReadLine()!));
int[,] arr_2 = ArrayB(row2, column2,
                        int.Parse(Console.ReadLine()!),
                        int.Parse(Console.ReadLine()!));
int[,] arr_3 = ArrayC(arr_1, arr_2);

Print(arr_1);
Console.WriteLine();
Print(arr_2);
Console.WriteLine();
Console.WriteLine($"Результат произведения двух матриц");
Print(arr_3);





