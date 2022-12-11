// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



double[] Array(int sum, int from, int to)
{
    double[] arr = new double[sum];

    for (int i = 0; i < sum; i++)
    {
        arr[i] = new Random().NextDouble() * (to - from) + from;
    }
    return arr;
}

void Print(double[] count)
{
    int begin = count.Length;
    for (int i = 0; i < begin; i++)
    {
        Console.Write($"{count[i]} ");
    }
    Console.WriteLine();
}

void Razz(double[] arr)

    {
    double min = arr[0];
    double max = arr[0];
    
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }

        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    double diff = max - min;

    Console.WriteLine($"{max} - {min} = {diff}");

}
   

double[] razn = Array(int.Parse(Console.ReadLine()!),
                      int.Parse(Console.ReadLine()!),
                      int.Parse(Console.ReadLine()!));

Print(razn);
Razz(razn);