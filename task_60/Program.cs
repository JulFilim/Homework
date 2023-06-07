// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int Number()
{
    int m = int.Parse(Console.ReadLine());
    return m;
    Console.WriteLine();
}

bool SizeTypeCheck(int a, int b)
{
    int x; int y;
    if (a == b)
    {
        Console.WriteLine("Вы ввели квадратную матрицу,нужна прямоугольная");
        return false;
    }
    else { System.Console.WriteLine("все верно: матрица прямоугольная"); return true; }
}
void NewRandomArray(double[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = new Random().Next(10*(i+1), 99-5*(i+1));
            }
        }
        System.Console.WriteLine();
    }
}


void PrintArrayTriDimen(double[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine($" page # {i + 1} ");
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                {
                    Console.Write($" [{i} {j} {k}] = {arr[i, j,k]}  ");
                }
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}


System.Console.Write("ввод глубины массива z:   ");
int depth = Number();
System.Console.Write("введите число строк x:   ");
int row = Number();
System.Console.Write("введите число столбцов y:   ");
int col = Number();
//bool validity=SizeTypeCheck (rows,col);
//System.Console.WriteLine(validity);
// if (validity)
// {   

double[,,] array = new double[depth, row, col];
NewRandomArray(array);
PrintArrayTriDimen(array);
System.Console.WriteLine();


