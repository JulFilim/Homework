// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет



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
void  SearchForMatch (double [,] arr)
{
    System.Console.Write("введите индекс i: ");
    int a=Number(); 
    int rowsize=arr.GetLength(0);
    System.Console.Write("введите индекс j: ");
    int b=Number();
    int colsize=arr.GetLength(1);
    System.Console.WriteLine();
        
    if ((a > rowsize) || (b>colsize) || (b > rowsize) || (a>colsize)) 
    {System.Console.WriteLine($"такого элемента нет  ");}
     else {
        
       for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           if ((i==a)&&(j==b)) 
           {
            Console.WriteLine($" {arr[i,j]} ");
           }
        }
        //System.Console.WriteLine();
    }
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
SearchForMatch (array);
System.Console.WriteLine();
