
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76


double Min (double []arr)
{
    double min =arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<min)
        {
            min=arr[i];
        }
       
    }
    return min;
}

double Max (double []arr)
{
    double max =arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>max)
        {
            max=arr[i];
        }
       
    }
    return max;
}
double Result (double min, double max)
{    
    double result = max-min;
    return result;
    }

void PrintArray (double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
        { Console.Write(arr[i]+"\t");}
}


Console.Write("задайте массив вещественных чисел:  ");
string lim = Console.ReadLine();
string []limits =lim.Split(' ');
System.Console.WriteLine();


double [] doubleLimits = new double[limits.Length];
for(int i=0; i<limits.Length; i++)
{     doubleLimits[i] = Double.Parse(limits[i]);    } 


double min = Min(doubleLimits);
Console.WriteLine($"наименьший элемент в массиве =  {min}");
double max = Max(doubleLimits);
Console.WriteLine($"наибольший элемент в массиве =  {max}");
double result = Result (min,max);
Console.WriteLine($"разница между наибольшим и наименьшим элементом в массиве =  {result}");
Console.WriteLine();


