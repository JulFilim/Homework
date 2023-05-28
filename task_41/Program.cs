 string InputMass()
{
    Console.Write("Введенный массив вещественных чисел:  ");
    string mass = Console.ReadLine();
    return mass;
    Console.WriteLine();
}

void CreateArray(string[] mass1,double[] mass2)
{
    for(int i=0; i<mass1.Length; i++)
    {   mass2[i] = Double.Parse(mass1[i]);    
        //Console.Write($"{mass2[i]} ");
    }
    Console.WriteLine();
}
void PrintArray (double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
        { Console.Write(arr[i]+" ");}
    Console.WriteLine();
}

int Count (double []arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) count++;
    }
    //Console.WriteLine(count); проверка корректности выполнения логики
    return count;
    System.Console.WriteLine();
}
string mass = InputMass();
string []splitMass =mass.Split(' ');
double [] newMass = new double[splitMass.Length];
CreateArray(splitMass,newMass);
Console.WriteLine($"Количество чисел больше 0: {Count (newMass)}");
System.Console.WriteLine();
