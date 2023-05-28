 Console.Write("введите значения b1, k1, b2 и k2:  ");
    string mass = Console.ReadLine();
    string []splitMass =mass.Split(' ');
    double [] newMass = new double[splitMass.Length];
    for(int i=0; i<splitMass.Length; i++)
    {newMass[i] = Double.Parse(splitMass[i]);    } 

double b1=newMass[0];
double k1=newMass[1];
double b2=newMass[2];
double k2=newMass[3];
System.Console.WriteLine();

void CrossDot (double b1,double k1, double b2,double k2)
{
double x = (b2 - b1) / (k1 - k2); 
double y = k1 * x + b1;
System.Console.WriteLine($"точка пересечения: ({x}; {y})");
}

CrossDot(b1,k1,b2,k2);
System.Console.WriteLine();