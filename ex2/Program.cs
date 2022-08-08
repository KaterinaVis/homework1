//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberВ = Convert.ToInt32(Console.ReadLine());
if(numberA >= numberВ)
{
   Console.WriteLine(numberA + " больше " ); 
}
else
{
     Console.WriteLine(numberВ + " больше " );
}