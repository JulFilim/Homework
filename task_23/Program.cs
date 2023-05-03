
Console.Write("Введите число N = ");
double N = Convert.ToDouble(Console.ReadLine());
int i=1;
for (i=1;i<=N;i++)
{
   double y = Math.Pow(i,3);
   Console.Write(y+" ");
}