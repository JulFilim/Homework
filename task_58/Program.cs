// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int Number()
{
    int m = int.Parse(Console.ReadLine());
    return m;
    Console.WriteLine();
}

void NewRandomArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 9);
        }
        System.Console.WriteLine();
    }
}


void MatrixMultiplication(double[,] arr1, double[,] arr2)
{
    int row = arr2.GetLength(0);
    int col = arr1.GetLength(1);
    double[,] arr3 = new double[row, col];
    bool x = false;
    if (row==col)    {x=true;}
 if(x)
 {
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            for (int k = 0; k < col; k++)
            {
                arr3[i, j] = arr3[i, j] + arr1[i, k] * arr2[k, j];
            }
            System.Console.Write($" {arr3[i, j]} ");
        }
        Console.WriteLine();
    }
}
else {Console.WriteLine($" Кол-во строк матрицы 1 не равно кол-ву столбцов другой матрицы - матрицы перемножить невозможно");}
}


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


System.Console.Write("введите число строк матрицы 1:   ");
int rows1 = Number();
System.Console.Write("введите число столбцов матрицы 1:   ");
int col1 = Number();
double[,] matrix1 = new double[rows1, col1];
System.Console.Write("введите число строк матрицы 2:   ");
int rows2 = Number();
System.Console.Write("введите число столбцов матрицы 2:   ");
int col2 = Number();
double[,] matrix2 = new double[rows2, col2];
//double[,] array3 = new double[rows1, col2];
NewRandomArray(matrix1);
PrintArray(matrix1);
System.Console.WriteLine();
NewRandomArray(matrix2);
PrintArray(matrix2);
System.Console.WriteLine();
MatrixMultiplication(matrix1, matrix2);
System.Console.WriteLine();


