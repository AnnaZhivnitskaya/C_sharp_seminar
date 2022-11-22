// Напишите программу, котора на вход принимает одно число N, а на выходе показывает 
//все целые числа от N до -N

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!);

int antinumber = 0 - number;

while (antinumber <= number)
{
  Console.WriteLine(antinumber);
  antinumber = (antinumber + 1);  
}