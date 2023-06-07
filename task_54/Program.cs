//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
            arr[i, j] = new Random().Next(10, 99);
        }
        System.Console.WriteLine();
    }
}
void SearchForMatch(double[,] arr)
{
    System.Console.Write("введите индекс i: ");
    int a = Number();
    int rowsize = arr.GetLength(0);
    System.Console.Write("введите индекс j: ");
    int b = Number();
    int colsize = arr.GetLength(1);
    System.Console.WriteLine();

    if ((a > rowsize) || (b > colsize) || (b > rowsize) || (a > colsize) || (a < 0) || (b < 0))
    { System.Console.WriteLine($"такого элемента нет  "); }
    else
    {

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if ((i == a) && (j == b))
                {
                    Console.WriteLine($" {arr[i, j]} ");
                }
            }
            //System.Console.WriteLine();
        }
    }
}

void DescendingRowsElements(double[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k + 1] > arr[i, k])
                {
                    (arr[i, k], arr[i, k + 1]) = (arr[i, k + 1], arr[i, k]);
                }
            }

        }
    }
}


void CheckCorrectness(double[,] arr)
{
    int count = 0;
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    int size = row * col;
    System.Console.WriteLine($"количество элементов массива: {size}");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        bool x = false;
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            if (arr[i, j] > arr[i, j + 1]) ;
            { x = true; count++; }
        } 
    }       
        //System.Console.WriteLine();    }
    //System.Console.WriteLine($"количество отсортированных элементов массива{count}");
    int elemQuantity = 0;
    if (row != col)
    {
        elemQuantity = count + row;
    }
    else { elemQuantity = count + row; }
    Console.WriteLine ($"количество отсортированных элементов массива {elemQuantity}");
    if ((elemQuantity) == size)
    {
        Console.WriteLine();
    Console.WriteLine($"кол-во элементов={elemQuantity} совпадает с кол-вом отсортированных элементов={size}:Сортировка по убыванию выполнена верно ");
    }
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


System.Console.Write("введите число строк m:   ");
int rows = Number();
System.Console.Write("введите число столбцов n:   ");
int col = Number();
double[,] array = new double[rows, col];
NewRandomArray(array);
PrintArray(array);
System.Console.WriteLine();
DescendingRowsElements(array);

PrintArray(array);
System.Console.WriteLine();
//CheckCorrectness(array);
System.Console.WriteLine(); ;

