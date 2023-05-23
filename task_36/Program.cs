
void CreateArray (int[] arr, int minRand,int maxRand)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]= new Random().Next(minRand,maxRand+1);
    }
}

int Size (int startRand,int endRand)
{
int size=(endRand-startRand)+1;
return size;    
}


int Poisk_Sum(int []arr)
{
    int count=0;
    int sum=0;
for (int i = 0; i < arr.Length; i++)
{    
    if (i%2!=0) 
        {sum=sum+arr[i];count++; }
    else count++; 
}
return sum;
}

void PrintArray (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
        { Console.Write(arr[i]+"\t");}
}

Console.Write("укажите диапазон для выборки positive случайных чисел:  ");
string lim = Console.ReadLine();
string []limits =lim.Split(' ');
System.Console.WriteLine();

int startRand = int.Parse(limits[0]);
int endRand = int.Parse(limits[1]);

Console.Write("укажите размер массива чисел:  ");
int size = int.Parse(Console.ReadLine());
System.Console.WriteLine();
int [] triArray = new int[size];

CreateArray (triArray,startRand,endRand);
Console.Write("полученный массив: ");PrintArray (triArray);
System.Console.WriteLine();
int sum = Poisk_Sum(triArray);
System.Console.WriteLine();
Console.WriteLine($"сумма чисел на НЕчётных позициях в массиве =  {sum}");
System.Console.WriteLine();
