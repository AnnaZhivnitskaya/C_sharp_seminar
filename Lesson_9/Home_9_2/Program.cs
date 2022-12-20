// Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

int Sum(int M, int N)
{
    if (M > N) return 0;
    return M + Sum(M + 1, N);

}
Console.WriteLine(Sum(2, 5));
