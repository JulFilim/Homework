
// Console.Write("Введите число x= ");
// double x = Convert.ToDouble(Console.ReadLine());
// double Size (double x)
//     {
//     double i =0;
//     double sum=0;
//     while (x>0)
//     { x = x/10; i++;sum=sum+x%10;}
//     return(sum);
//     }

Console.Write("Введите число x= ");
int x = Convert.ToInt32(Console.ReadLine());
int Size (int x)
    {
        int count=0;
    while (x>0)
    { x = x/10; count++;}
    return(count);
    }

int size = Convert.ToInt32(Size(x));
int sum=0;
for (int i = 0; i < size; i++)
{
    sum=sum+(x/Convert.ToInt32(Math.Pow(10,i)))%10;
}
Console.WriteLine(sum);