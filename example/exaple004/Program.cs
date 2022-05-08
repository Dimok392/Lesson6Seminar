﻿// Задача 44: используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
double Fibonacci(int n)
{
    if (n==1 | n==2) return 1;
    else return Fibonacci(n-1)+Fibonacci(n-2);
   
}
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n; i++)
{
   
    Console.Write( Fibonacci(i) +" ");
}
