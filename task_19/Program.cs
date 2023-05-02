
Console.Write("Введите число x= ");
double x = Convert.ToDouble(Console.ReadLine());
double Razryad (double x,double y)
    {
    double result1 = Math.Floor(x/y)-(Math.Floor(x/(y*10)))*10;
    return (result1);
    }
double ed = Razryad  (x,1);         //Console.WriteLine ($"{ed}");
double des = Razryad  (x,10);       //Console.WriteLine ($"{des}");
double sot = Razryad  (x,100);      //Console.WriteLine ($"{sot}");
double tys = Razryad  (x,1000);     //Console.WriteLine ($"{tys}");
double destys = Razryad  (x,10000); //Console.WriteLine ($"{destys}");

if (ed==destys && des==tys)
{    Console.WriteLine ($"число явлется палиндромом");}
else Console.WriteLine ($"число НЕ явлется палиндромом");


