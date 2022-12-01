// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int pali = int.Parse(Console.ReadLine()!);

int s1 = pali / 10000;
int s2 = pali / 1000 % 10;
int s4 = pali / 10 % 10;
int s5 = pali % 10;

if (pali > 99999 || pali < 10000)
{
    Console.WriteLine("Число введено неверно");
}

else if(s1 == s5 & s2 == s4)
    Console.WriteLine("палиндром");

else
    Console.WriteLine("не палиндром");

