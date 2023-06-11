// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int Number()
{
    int m = int.Parse(Console.ReadLine());
    return m;
    Console.WriteLine();
}

void BackwardPrintedRow(int num)
{
    if (num == 1)
    {
        return;
    }
    num = num - 1;
    System.Console.Write($"{num} ");
    BackwardPrintedRow(num);
    System.Console.WriteLine();
}

System.Console.Write("Введите число: ");
int num = Number();
BackwardPrintedRow(num);
