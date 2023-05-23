
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


int Poisk(int []arr)
{
    int count=0;
for (int i = 0; i < arr.Length; i++)
{    if (arr[i]%2==0) count++;} 
return count;
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
// System.Console.WriteLine(startRand);
// System.Console.WriteLine(endRand);
bool validate = true;
if ((startRand <100) || (startRand>=1000) || (endRand<100) || (endRand>=1000) || (startRand<0) || (endRand<0)) 
{validate=false;}
else validate=true;

if(validate)
{

Console.Write("укажите размер массива чисел:  ");
int size = int.Parse(Console.ReadLine());
//Console.WriteLine($"размер заданного массива =  {size}");
System.Console.WriteLine();
int [] triArray = new int[size];

CreateArray (triArray,startRand,endRand);
Console.Write("полученный массив: ");PrintArray (triArray);
System.Console.WriteLine();
int count = Poisk(triArray);
System.Console.WriteLine();
Console.WriteLine($"количество чётных чисел в массиве =  {count}");
}
else { System.Console.WriteLine("введен неверный диапазон");}
System.Console.WriteLine();
