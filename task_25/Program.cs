Console.Write("Введите число A= ");
double A= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B= ");
double B = Convert.ToDouble(Console.ReadLine());

double Extent (double X, double Y)
{
    double result = Math.Pow(X,Y);
        return result;
}
double result = Extent (A,B);
Console.WriteLine(result);