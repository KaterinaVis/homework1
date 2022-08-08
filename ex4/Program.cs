// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberВ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int numberС = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if(numberA > max) max = numberA;
if(numberВ > max) max = numberВ;
if(numberС > max) max = numberС;
Console.Write("максимальное число " + max);
