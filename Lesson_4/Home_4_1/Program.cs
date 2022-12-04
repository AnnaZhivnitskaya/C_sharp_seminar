// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B. Без модуля Math, используем цикл for.

Console.WriteLine("Введите число A");
int numA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B");
int numB = int.Parse(Console.ReadLine()!);

int result= 0;

for(int n = 1; n <= numB; n++)

result = (numA * numA) * n;

Console.WriteLine(result);
