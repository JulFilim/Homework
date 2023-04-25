Console.Write("Введите число x= ");
double x = Convert.ToDouble(Console.ReadLine());
//int count = 0; 
if (x<100) Console.WriteLine("третьей цифры у введенного числа нет");
else {
     while (100<=x)
     {
       x=x/10;
    }
    double result = Math.Floor((x-Math.Floor(x))*10);    
      Console.WriteLine($"третья цифра у введенного числа: {result}");
}