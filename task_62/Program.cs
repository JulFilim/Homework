// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int Number()
{
    int m = int.Parse(Console.ReadLine());
    return m;
    Console.WriteLine();
}


void SpiralArray(double[,] arr)
{
    int rowsize = arr.GetLength(0);
    int colsize = arr.GetLength(1);
    double[,] arr1=new double[rowsize,colsize];
    
       double a= arr[(rowsize-rowsize),(colsize-colsize)];
        System.Console.WriteLine($" a = {a}");
        
        for (int j = 0; j < colsize; j++)
            {
            int i=(rowsize-rowsize);
            arr[i, j] = a+(j+1);                                    
            }

        System.Console.WriteLine();

    double x= arr[(rowsize-rowsize),(colsize-1)]; // последний элемент 1ой строки arr[0,colsize-1]= 4
    System.Console.WriteLine($" x = {x}");
            
        for (int i = 1; i < rowsize; i++) // по последнему столбцу : 4 5 6 7 
        {
            int j = colsize-1;
            arr[i, j] = x+i;
        }
    
    double y= arr[rowsize-1,colsize-1];
     System.Console.WriteLine($" y = {y}");// последний элемент последнего столбца arr[rowsize-1,(colsize-1)] = 7
            
        for (int j = colsize-1; j >= 0; j--) //  7 8 9 10 - в обратную сторону ход
        {
             int i = rowsize-1;
            arr[i, j] = y+((colsize-1)-j);
        }

    double z= arr[rowsize-1,(colsize-colsize)]; // последний элемент последней строки 1го столбца arr[rowsize-1,(colsize-colsize)] = 10 в обратную сторону ход
     System.Console.WriteLine($" z = {z}");
    
    for (int i = rowsize-1; i >0; i--)
            {
                int j = colsize-colsize;
                arr[i, j] = z+((rowsize-1)-i);
            }
           double k= arr[rowsize-3,(colsize-colsize)]; // последний элемент 1го столбца  2ой строки arr[rowsize-3,(colsize-colsize)]= 12 !!КОНЕЦ ВИТКА
        System.Console.WriteLine($" k = {k}");
          
        for (int j = 1; j < colsize-1; j++) // по строке движение
            {
              int i = rowsize-3;  
              arr[i, j] = k+j;                                    
            }
        
        double l= arr[rowsize-3,(colsize-2)];
            System.Console.WriteLine($" l = {l}");
            
        for (int i = 2; i < rowsize-1; i++) // по  столбцу : 15
        {   int j = colsize-2;
             arr[i, j] = l+(rowsize-1-i);
        }
        
        double m= arr[rowsize-2,(colsize-2)];
         System.Console.WriteLine($" m = {m}");
         System.Console.WriteLine();
    
    for (int j = colsize-3; j >=1; j--) //  7 8 9 10
        {
             int i = rowsize-2;
            arr[i, j] = m+1;
        }
    }
    
System.Console.WriteLine();


void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"  {arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}


System.Console.Write("введите число строк m:   ");
int rows = Number();
System.Console.Write("введите число столбцов n:   ");
int col = Number();
double[,] array = new double[rows, col];
SpiralArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(); ;

