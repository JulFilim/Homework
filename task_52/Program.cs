// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Number()
{
int m =int.Parse(Console.ReadLine());
return m;
Console.WriteLine();
}

void NewRandomArray (double [,] arr)
{
    for (int i = 0; i <arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j]= new Random().Next(10,100);
        }
         System.Console.WriteLine();
    }
}
void  ColumnAverage (double [,] arr)
{         
       for (int j = 0; j < arr.GetLength(1); j++)
    { 
        double sum=0;
        double count=0; 
        for (int i = 0; i < arr.GetLength(0); i++)
        {
           sum=sum+arr[i,j]; count++;
        }
        double sum1=Math.Round(sum/count,2);
        System.Console.WriteLine($"среднее арифметическое {j}го столбца= {sum1}  ");
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
ColumnAverage(array);
System.Console.WriteLine();
System.Console.WriteLine();
