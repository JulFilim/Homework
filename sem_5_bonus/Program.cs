
// Задача бонусная: Задайте массив вещественных чисел. Найдите дубликаты элементов массива.

string InputMass()
{
    Console.Write("задайте массив вещественных чисел:  ");
    string mass = Console.ReadLine();
    return mass;
    Console.WriteLine();
}

void CreateArray(string[] mass1,double[] mass2)
{
    for(int i=0; i<mass1.Length; i++)
    {   mass2[i] = Double.Parse(mass1[i]);    
        Console.Write($"{mass2[i]} ");
    }
    Console.WriteLine();
}
void PrintArray (double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
        { Console.Write(arr[i]+" ");}
    Console.WriteLine();
}


void NonZeroCount(double [] arr)
{
    int NonZero=0;
    double temp=0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i]!=0) 
        {NonZero++; }
        Console.WriteLine();
    Console.Write( $"количество НЕнулевых чисел: {NonZero}\t");
    Console.WriteLine();    
}

void ExcludeDuplicate(double []arr)
{
    double zero=true;
      for (int i = 0; i < arr.Length; i++) // замена дублей на "0"
    {
        for (int j = i+1; j < arr.Length; j++)
        {
            if (arr[i]!)
            {
                  if (arr[i]==arr[j]) arr[j]=0;  
            }
            else continue;            
        }
        //Console.Write($"{arr[i]} ");  //   проверка, что замена состоялась        
    }    
Console.WriteLine();
    int sizeArr=0; // определение размера введенного массива 
    int NonZero=0; //определение размера количества уникальных элементов
    for (int i = 0; i < arr.Length; i++)
        { if (arr[i]!=0) 
        {sizeArr++; NonZero++; }
    else sizeArr++;
        }
Console.WriteLine();
   

double [] substitDupli =new double [sizeArr];
for (int i = 0,j=0; i < arr.Length; i++,j++)
{   if (arr[i]!=0) 
    {   substitDupli[j]=arr[i];}
    else {j--;  }              
//Console.Write($"{substitDupli[i]}"); // ..исходный массив: 5 1 5 5 2, выводит: 51000 ( должно быть 51200)                                                               
}
Console.WriteLine("Массив, где дубликаты заменены на 0: ");
Console.WriteLine();
PrintArray (substitDupli);
     
double [] noDupli=new double [NonZero]; // создание нового массива для уникальных элементов
    for (int i = 0,j=0; i< NonZero; j++,i++)
        {                                                   
            if (substitDupli[i]!=0) 
            {   noDupli[j]=substitDupli[i];}  
            else break;
        }
Console.WriteLine();
Console.WriteLine("Массив без дубликатов: ");
Console.WriteLine();
PrintArray(noDupli);
}      


string mass = InputMass();
string []splitMass =mass.Split(' ');
double [] newMass = new double[splitMass.Length];
CreateArray(splitMass,newMass);

ExcludeDuplicate (newMass);



