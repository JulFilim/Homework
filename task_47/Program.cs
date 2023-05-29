int Number()
{
int m =int.Parse(Console.ReadLine());
return m;
Console.WriteLine();
}

void NewRandomArray (double [,] arr)
{
    Random rnd = new Random();
        for (int i = 0; i <arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j]= Math.Round((rnd.NextDouble()),2);
        }
         System.Console.WriteLine();
    }
}
void PrintArray (double [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           Console.Write($" {arr[i,j]} "); 
           //System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}
System.Console.Write("введите число строк m:   ");
int rows= Number();
System.Console.Write("введите число столбцов n:   ");
int col= Number();
double[,] array=new double[rows,col];
NewRandomArray(array);
PrintArray(array);
System.Console.WriteLine();