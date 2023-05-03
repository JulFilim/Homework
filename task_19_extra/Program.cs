
Console.Write("Введите число x= ");
double x = Convert.ToDouble(Console.ReadLine());
double Size (double x)
    {
    double i =0;
    while (x>1)
    { x = x/10; i++;}
    return(i);
    }
int size = Convert.ToInt32(Size(x));

//double[] arr = new double[size];
double[] rra = new double[size];

for (int j = 0; j <=size-1; j++)
{
    double y = Math.Pow(10,j);
    rra[j] = Math.Floor(x/y)-(Math.Floor(x/(y*10)))*10;
    //Console.Write(rra[j]+" ");
}
bool match=true;
for (int j = 0; j <size; j++)
{
    if (rra[j]==rra[size-1])
        { match=true; size--;}
        //Console.WriteLine ("квведенное число = полиндром");
    else 
        {match=false; break;}
}
    //Console.WriteLine ("квведенное число = НЕ полиндром");

if (match) Console.WriteLine ("введенное число = полиндром");
else 
Console.WriteLine ("введенное число = НЕ полиндром");





