
void RandomArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]= new Random().Next(0,3);
    }
}
void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
RandomArray(array);
PrintArray(array);




