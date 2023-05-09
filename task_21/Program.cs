Console.Write("Введите х координату 1й точки = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите у координату 1й точки = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z координату 1й точки = ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите х координату 2й точки = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите у координату 2й точки = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z координату 2й точки = ");
double z2 = Convert.ToDouble(Console.ReadLine());
double s= Math.Round((Math.Sqrt(((Math.Pow((x2-x1),2))+(Math.Pow((y2-y1),2))+(Math.Pow((z2-z1),2))))),2);
Console.WriteLine($"расстояние между заданными точками=  {s}");

