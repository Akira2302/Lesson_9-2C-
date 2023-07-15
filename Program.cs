// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите начальное число M:");
int numM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число M:");
int numN = Convert.ToInt32(Console.ReadLine());


void SumNaturElement(int numM, int numN, int sum)
{
    if (numM > numN)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (numM++);
    SumNaturElement(numM, numN, sum);

    SumNaturElement(numM, numN, 0);
}