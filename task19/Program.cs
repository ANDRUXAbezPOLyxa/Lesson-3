// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("введите пятизначное число");
int n = int.Parse(Console.ReadLine());
if (n<10000)
{
    Console.WriteLine("Пятизначное!");
}
int m =n%10;
int n2 = n%10000;
int m2 = n%100;
int n1 = n/10000;
if (n1 == m || n2 == m2)
{
    Console.WriteLine(n + "=>" + "полиндром");
}
else
{
    Console.WriteLine(n + "=>" + "не полиндром");
}