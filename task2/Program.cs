// Задача 2: Напишите программу, которая 
// принимает на вход три числа и выдаёт 
// максимальное из этих чисел.

Console.WriteLine("Узнаем максимальное число из " +
                  "трёх чисел.\nВведите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num_temp = Convert.ToInt32(Console.ReadLine());

if (num < num_temp)
{
    num = num_temp;
}
Console.WriteLine("Введите трутье число: ");
num_temp = Convert.ToInt32(Console.ReadLine());

if (num < num_temp)
{
    num = num_temp;
}
Console.WriteLine("Максимальное число: " + num);
