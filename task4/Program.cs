// Задача 4: Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int lenList = Convert.ToInt32(Console.ReadLine());
int num = 1;

while (num <= lenList)
{
    if (num % 2 == 0)
    {
        Console.WriteLine(num);
    }
    num++;
}
