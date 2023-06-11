// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Number()
{
    int m = int.Parse(Console.ReadLine());
    return m;
    Console.WriteLine();
}
int Ack(int a, int b)
{
    if (a == 0) return (b + 1);
    else if (a > 0 && b == 0) return Ack(a - 1, 1);
    else  return Ack(a - 1, Ack(a, b - 1));
}


System.Console.Write("Введите число M: ");
int m = Number();
System.Console.Write("Введите число N: ");
int n = Number();

System.Console.WriteLine(Ack(m, n));