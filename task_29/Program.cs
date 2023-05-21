
void RandomArray (int[] arr, int minRand,int maxRand)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]= new Random().Next(minRand,maxRand+1);
    }
}
void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
System.Console.Write("Введите длину массива= \t");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Введите начало диапазона случайных чисел= \t");
int start = int.Parse(Console.ReadLine());
System.Console.WriteLine();
System.Console.Write("Введите конец диапазона случайных чисел= \t");
int end = int.Parse(Console.ReadLine());
System.Console.WriteLine();
int[] array = new int[size];
RandomArray(array,start,end);
PrintArray(array);




