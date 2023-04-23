Console.Write("Введите число = ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2; // cчетчик четных чисел до введенного


while (count <= N)
{
    if (count < N-1)
   {Console.Write($"{count},"); }
   else {Console.Write(count);}
        count = count+2;
    }