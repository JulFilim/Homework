// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Number()
{
    int m = int.Parse(Console.ReadLine());
    return m;
    Console.WriteLine();
}

int SumBetweenMandN (int a, int b)
{
    int sum=a;
   if (a>b) return 0;  
   if (a<=b)
   {
     a++;
   }
   //System.Console.WriteLine($"sum до рекурсии {sum}, т.е. sum = а , т.е.слагаемые будущей суммы"); // печатает значение sum = а
    sum=sum + SumBetweenMandN(a,b);
    //System.Console.WriteLine($"sum = sum+рекурсия( после рекурсии) {sum}"); // печатает накопленным итогом
     return sum;
  
}
    
System.Console.Write("Введите число M: ");
int m=Number();
System.Console.Write("Введите число N: ");
int n=Number();

   if (m>n)
    {
        (m,n)=(n,m);
    } 
int sum=SumBetweenMandN(m,n);
System.Console.WriteLine();
System.Console.WriteLine($" сумма элементов между M и N = {sum}");