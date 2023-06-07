// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.



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
            arr[i, j] = new Random().Next(10, 100);
        }
        System.Console.WriteLine();
    }
}

void MinRowElementSum(double [,] arr)
{
double []arr1=new double[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        double sum=0;
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            sum=sum+arr[i,j]; 
        }
            arr1[i]=sum;
            Console.Write($" сумма эл-тов {i}й строки = {arr1[i]}"); //для проверки
            Console.WriteLine();
    }
double min=arr1[0];
int minRow=0;
    for (int k = 0; k < arr1.Length-1; k++)
         
        if (arr1[k+1] < min)
        {
            min=arr1[k+1]; minRow=k+1;
        }
         Console.WriteLine($"наименьшая сумма элеменов = {min} на {minRow}й строке");
}
bool SizeTypeCheck(int a,int b)
{int x; int y;
 if (a==b) {Console.WriteLine( "Вы ввели квадратную матрицу,нужна прямоугольная");
 return false;}
 else {System.Console.WriteLine("все верно: матрица прямоугольная"); return true;}
}

void PrintArrayTwoDimen(double[,] arr)
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

System.Console.Write("ввдите число cтрок m:   ");
int rows = Number();
System.Console.Write("введите число столбцов n:   ");
int col = Number();
bool validity=SizeTypeCheck (rows,col);

if (validity)
{  
double[,] array = new double[rows, col];
NewRandomArray(array);
PrintArrayTwoDimen(array);
MinRowElementSum(array);
System.Console.WriteLine();
}
else {System.Console.WriteLine("Задайте нужный тип матрицы");}

